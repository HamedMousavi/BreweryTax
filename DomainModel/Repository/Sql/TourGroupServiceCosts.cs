using System;
using System.Data.SqlClient;
using Entities.Abstract;


namespace DomainModel.Repository.Sql
{

    public class TourGroupServiceCosts
    {

        protected QueryHelper query;


        public TourGroupServiceCosts(string sqlConnectionString)
        {
            this.query = new QueryHelper(sqlConnectionString);
        }


        public bool Insert(Entities.TourServiceBase service, Entities.TourCostDetail cost)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@GroupServiceId", service.Id));
                this.query.Parameters.Add(new SqlParameter("@CostGroupId", cost.CostGroup.Id));
                this.query.Parameters.Add(new SqlParameter("@SignUpCount", cost.SignUpCount));
                this.query.Parameters.Add(new SqlParameter("@ParticipantsCount", cost.ParticipantsCount));

                int id;
                res = this.query.ExecuteInsertProc("TourGroupServiceCostAdd", out id);
                cost.Id = id;
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


        internal bool Update(Entities.TourServiceBase service, Entities.TourCostDetail cost)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@GroupServiceId", service.Id));
                this.query.Parameters.Add(new SqlParameter("@CostGroupId", cost.CostGroup.Id));
                this.query.Parameters.Add(new SqlParameter("@SignUpCount", cost.SignUpCount));
                this.query.Parameters.Add(new SqlParameter("@ParticipantsCount", cost.ParticipantsCount));
                this.query.Parameters.Add(new SqlParameter("@CostId", cost.Id));

                int affected;
                res = this.query.ExecuteUpdateProc("TourGroupServiceCostUpdateById", out affected);
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


        internal bool Load(Entities.Abstract.ITourService service)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@ServiceId", service.Id));

                res = this.query.ExecuteReader("TourGroupServiceCostGetByServiceId", MapCostsToObject, service);
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


        protected void MapCostsToObject(SqlDataReader reader, object userData)
        {
            Entities.TourCostDetail cost = new Entities.TourCostDetail();

            cost.Id = Utils.GetSafeInt32(reader, "CostId");
            cost.SignUpCount = Utils.GetSafeInt32(reader, "SignUpCount");
            cost.ParticipantsCount = Utils.GetSafeInt32(reader, "ParticipantsCount");
            cost.CostGroup = DomainModel.TourCostGroups.GetById(Utils.GetSafeInt32(reader, "CostGroupId"));

            cost.IsDirty = false;

            ITourService service = (ITourService)userData;
            service.CostDetails.Add(cost);
        }


        internal bool Delete(Entities.TourCostDetail cost)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@CostId", cost.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("TourGroupServiceCostDeleteById", out affected);
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
