using System;
using System.Data.SqlClient;
using StatusController.Abstract;


namespace DomainModel.Repository.Sql
{

    public class TourGroupMembers
    {

        protected QueryHelper query;


        public TourGroupMembers(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        internal bool Insert(Entities.TourMember member)
        {
            bool res = false;

            try
            {
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
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@MemberId", member.Id));
                this.query.Parameters.Add(new SqlParameter("@TitleId", member.Title.Id));
                this.query.Parameters.Add(new SqlParameter("@FirstName", member.FirstName));
                this.query.Parameters.Add(new SqlParameter("@LastName", member.LastName));
                this.query.Parameters.Add(new SqlParameter("@MembershipType", member.MemberShip == null ? -1 : member.MemberShip.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("TourMembertUpdateById", out affected);
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


        internal bool GetByGroup(Entities.TourGroup group)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));

                res = this.query.ExecuteReader("TourGroupMemberGetByGroupId", MapMemberToObject, group);
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

            Entities.TourGroup group = (Entities.TourGroup)userData;
            group.Members.Add(member);
        }


        internal bool Delete(Entities.TourMember member)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@MemberId", member.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("TourMemberDeleteById", out affected);
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
    }
}
