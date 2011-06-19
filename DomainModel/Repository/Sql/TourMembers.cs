using System;
using System.Data.SqlClient;
using StatusController.Abstract;


namespace DomainModel.Repository.Sql
{

    public class TourMembers
    {

        protected QueryHelper query;


        public TourMembers(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        internal bool Insert(Entities.TourMember member)
        {
            bool res = false;

            try
            {
                if (member.Id >= 0)
                {
                    DomainModel.Application.Status.Update(
                        StatusTypes.Warning,
                        "stat_wrn_db_id_already_exists");
                    return true;
                }

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@TitleId", member.Title.Id));
                this.query.Parameters.Add(new SqlParameter("@FirstName", member.FirstName));
                this.query.Parameters.Add(new SqlParameter("@LastName", member.LastName));
                this.query.Parameters.Add(new SqlParameter("@MembershipType", member.MemberShip.Id));

                int id;
                res = this.query.ExecuteInsertProc("TourMemberAdd", out id);
                member.Id = id;
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }

            return res;
        }


        internal bool Update(Entities.TourMember member)
        {
            bool res = false;

            try
            {
                if (member.Id < 0)
                {
                    DomainModel.Application.Status.Update(
                        StatusTypes.Warning,
                        "stat_wrn_db_id_not_exists");
                    return true;
                }

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@MemberId", member.Id));
                this.query.Parameters.Add(new SqlParameter("@TitleId", member.Title.Id));
                this.query.Parameters.Add(new SqlParameter("@FirstName", member.FirstName));
                this.query.Parameters.Add(new SqlParameter("@LastName", member.LastName));
                this.query.Parameters.Add(new SqlParameter("@MembershipType", member.MemberShip.Id));

                res = this.query.ExecuteUpdateProc("TourMembertUpdateById");
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }

            return res;
        }


        internal bool GetByTour(Entities.Tour tour)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));

                res = this.query.ExecuteReader("TourMembersGetByTourId", MapMemberToObject, tour);
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "",
                        ex.Message);
                }
                catch { }
            }

            return res;
        }


        protected void MapMemberToObject(SqlDataReader reader, object userData)
        {
            Entities.TourMember member = new Entities.TourMember();

            member.Id = Utils.GetSafeInt32(reader, "MemberId");
            member.Title = DomainModel.PersonTitleTypes.GetById(
                Utils.GetSafeInt32(reader, "TitleId"));
            member.FirstName = Utils.GetSafeString(reader, "FirstName");
            member.LastName = Utils.GetSafeString(reader, "LastName");
            member.MemberShip = DomainModel.TourMembershipTypes.GetById(
                Utils.GetSafeInt32(reader, "MembershipType"));
            member.IsDirty = false;

            Entities.Tour tour = (Entities.Tour)userData;
            tour.Members.Add(member);
        }
    }
}
