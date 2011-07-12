using System;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{

    public class TourGroups
    {

        protected QueryHelper query;


        public TourGroups(string sqlConnectionString)
        {
            this.query = new QueryHelper(sqlConnectionString);
        }


        public bool GetByTour(Entities.Tour tour)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));

                res = this.query.ExecuteReader("TourGroupsGetByTourId", MapGroupToObject, tour);
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


        protected void MapGroupToObject(SqlDataReader reader, object userData)
        {
            Entities.TourGroup group = new Entities.TourGroup();

            group.Id = Utils.GetSafeInt32(reader, "GroupId");
            group.SignUpType = DomainModel.SignUpTypes.GetById(
                Utils.GetSafeInt32(reader, "SignupTypeId"));
            group.Status = DomainModel.TourStates.GetById(
                Utils.GetSafeInt32(reader, "StateTypeId"));
            group.IsDirty = false;

            Entities.Tour tour = (Entities.Tour)userData;
            tour.Groups.Add(group);
        }


        public bool Insert(Entities.Tour tour, Entities.TourGroup group)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@SignupTypeId", group.SignUpType.Id));
                this.query.Parameters.Add(new SqlParameter("@StateTypeId", group.Status.Id));
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));

                int id;
                res = this.query.ExecuteInsertProc("TourGroupsAdd", out id);
                group.Id = id;
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


        public bool Update(Entities.Tour tour, Entities.TourGroup group)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@SignupTypeId", group.SignUpType.Id));
                this.query.Parameters.Add(new SqlParameter("@StateTypeId", group.Status.Id));
                this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));

                int affected;
                res = this.query.ExecuteUpdateProc("TourGroupstUpdateById", out affected);
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


        public bool Delete(Entities.TourGroup group)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("TourGroupDeleteById", out affected);
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


        internal bool Update(Entities.TourGroup group)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@SignupTypeId", group.SignUpType.Id));
                this.query.Parameters.Add(new SqlParameter("@StateTypeId", group.Status.Id));
                this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));
                this.query.Parameters.Add(new SqlParameter("@TourId", -1)); // if TourId < 0 it will be ignored

                int affected;
                res = this.query.ExecuteUpdateProc("TourGroupstUpdateById", out affected);
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
