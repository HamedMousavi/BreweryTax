using System;
using System.Data.SqlClient;
using StatusController.Abstract;


namespace DomainModel.Repository.Sql
{

    public class TourCosts
    {

        protected QueryHelper query;


        public TourCosts(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        internal bool Insert(Entities.TourCostDetail cost)
        {
            bool res = false;

            try
            {
                if (cost.Id >= 0)
                {
                    DomainModel.Application.Status.Update(
                        StatusTypes.Warning,
                        "stat_wrn_db_id_already_exists");
                    return true;
                }

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@SignUpCount", cost.SignUpCount));
                this.query.Parameters.Add(new SqlParameter("@ParticipantCount", cost.ParticipantsCount));
                this.query.Parameters.Add(new SqlParameter("@CostGroupId", cost.CostGroup.Id));

                int id;
                res = this.query.ExecuteInsertProc("TourCostAdd", out id);
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


        internal bool Update(Entities.TourCostDetail cost)
        {
            bool res = false;

            try
            {
                if (cost.Id < 0)
                {
                    DomainModel.Application.Status.Update(
                        StatusTypes.Warning,
                        "stat_wrn_db_id_not_exists");
                    return true;
                }

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@SignUpCount", cost.SignUpCount));
                this.query.Parameters.Add(new SqlParameter("@ParticipantCount", cost.ParticipantsCount));
                this.query.Parameters.Add(new SqlParameter("@CostGroupId", cost.CostGroup.Id));
                this.query.Parameters.Add(new SqlParameter("@CostId", cost.Id));

                res = this.query.ExecuteUpdateProc("TourCostUpdateById");
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

                res = this.query.ExecuteReader("TourCostsGetByTourId", MapCostToObject, tour);
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


        protected void MapCostToObject(SqlDataReader reader, object userData)
        {
            Entities.TourCostDetail cost = new Entities.TourCostDetail();

            cost.Id = Utils.GetSafeInt32(reader, "CostId");
            cost.SignUpCount = Utils.GetSafeInt32(reader, "SignUpCount");
            cost.ParticipantsCount = Utils.GetSafeInt32(reader, "ParticipantCount");
            cost.CostGroup = DomainModel.TourCostGroups.GetById(
                Utils.GetSafeInt32(reader, "CostGroupId"));
            cost.IsDirty = false;

            Entities.Tour tour = (Entities.Tour)userData;
            tour.CostDetails.Add(cost);
        }
    }
}
