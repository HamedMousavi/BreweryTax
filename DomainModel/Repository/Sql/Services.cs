using System;
using System.Data.SqlClient;

namespace DomainModel.Repository.Sql
{

    public class Services
    {

        protected QueryHelper query;


        public Services(string sqlConnectionString)
        {
            this.query = new QueryHelper(sqlConnectionString);
        }


        internal bool Load(Entities.ServiceCollection services)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                res = this.query.ExecuteReader("ServicesGetAll", MapServiceToObject, services);
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
            Entities.Service service = new Entities.Service();

            service.Id = Utils.GetSafeInt32(reader, "ServiceId");
            service.ServiceType = DomainModel.ServiceTypes.GetById(
                Utils.GetSafeInt32(reader, "TypeId"));
            service.PricePerPerson.Value = Utils.GetSafeDecimal(reader, "PricePerPerson");
            service.PricePerPerson.Currency = DomainModel.Currencies.GetById(
                Utils.GetSafeInt32(reader, "PriceUnitId"));
            service.Name = Utils.GetSafeString(reader, "ServiceName");

            service.IsDirty = false;

            Entities.ServiceCollection services = 
                (Entities.ServiceCollection)userData;
            services.Add(service);
        }


        internal bool Insert(Entities.Service service)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@ServiceName", service.Name));
                this.query.Parameters.Add(new SqlParameter("@PricePerPerson", service.PricePerPerson.Value));
                this.query.Parameters.Add(new SqlParameter("@PriceUnitId", service.PricePerPerson.Currency.Id));
                this.query.Parameters.Add(new SqlParameter("@TypeId", service.ServiceType.Id));

                int id;
                res = this.query.ExecuteInsertProc("ServicesAdd", out id);
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


        internal bool Update(Entities.Service service)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@ServiceName", service.Name));
                this.query.Parameters.Add(new SqlParameter("@PricePerPerson", service.PricePerPerson.Value));
                this.query.Parameters.Add(new SqlParameter("@PriceUnitId", service.PricePerPerson.Currency.Id));
                this.query.Parameters.Add(new SqlParameter("@TypeId", service.ServiceType.Id));
                this.query.Parameters.Add(new SqlParameter("@ServiceId", service.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("ServicesUpdateById", out affected);
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


        internal bool Delete(Entities.Service service)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@ServiceId", service.Id));

                int affected;
                res = this.query.ExecuteUpdateProc("ServicesDeleteById", out affected);
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
