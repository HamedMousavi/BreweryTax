using System;
using System.Data.SqlClient;
using Entities.Abstract;


namespace DomainModel.Repository.Sql
{

    public class TourGroupServices
    {

        protected QueryHelper query;


        public TourGroupServices(string sqlConnectionString)
        {
            this.query = new QueryHelper(sqlConnectionString);
        }


        internal bool Insert(Entities.TourGroup group, Entities.TourServiceBase service)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));
                this.query.Parameters.Add(new SqlParameter("@ServiceId", service.Detail.Id));

                int id;
                res = this.query.ExecuteInsertProc("TourGroupServiceAdd", out id);
                service.Id = id;
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


        internal bool Update(/*Entities.TourGroup group, */Entities.TourServiceBase service)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                //this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));
                this.query.Parameters.Add(new SqlParameter("@ServiceId", service.Detail.Id));
                this.query.Parameters.Add(new SqlParameter("@GroupServiceId", service.Id));

                int affected;
                res = this.query.ExecuteUpdateProc("TourGroupServiceUpdateById", out affected);
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


        public bool Delete(ITourService service)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@GroupServiceId", service.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("TourGroupServiceDeleteById", out affected);
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


        internal bool Load(Entities.TourGroup group)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));

                res = this.query.ExecuteReader("TourGroupServicesGetByGroupId", MapServiceToObject, group);
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


        protected void MapServiceToObject(SqlDataReader reader, object userData)
        {
            Entities.TourServiceBase service = new Entities.TourServiceBase();

            service.Id = Utils.GetSafeInt32(reader, "GroupServiceId");
            service.Detail = DomainModel.Services.GetById(Utils.GetSafeInt32(reader, "ServiceId"));

            service.IsDirty = false;

            Entities.TourGroup group = (Entities.TourGroup)userData;
            group.Services.Add(service);
        }
    }
}
