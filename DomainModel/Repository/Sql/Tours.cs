using System;
using System.Data.SqlClient;
using StatusController.Abstract;


namespace DomainModel.Repository.Sql
{

    public class Tours
    {

        protected QueryHelper query;


        public Tours(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        internal bool Insert(Entities.Tour tour)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@TourTime", Utils.GetDbTime(tour.Time.Value)));
                this.query.Parameters.Add(new SqlParameter("@Comments", tour.Comments));

                int id;
                res = this.query.ExecuteInsertProc("ToursAdd", out id);
                tour.Id = id;
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


        internal bool Update(Entities.Tour tour)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@TourTime", Utils.GetDbTime(tour.Time.Value)));
                this.query.Parameters.Add(new SqlParameter("@Comments", tour.Comments));
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("ToursUpdateById", out affected);
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


        internal bool GetByDate(Entities.TourCollection tours, DateTime date)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@TourTime", Utils.GetDbTime(date)));

                res = this.query.ExecuteReader("ToursGetByDate", MapTourToObject, tours);
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


        protected void MapTourToObject(SqlDataReader reader, object userData)
        {
            Entities.TourCollection tours = (Entities.TourCollection)userData;
            Entities.Tour tour = new Entities.Tour();

            tour.Id = Utils.GetSafeInt32(reader, "TourId");
            tour.Time.Value = Utils.GetSafeDateTime(reader, "TourTime", DateTime.Now);
            tour.Comments = Utils.GetSafeString(reader, "Comments");
            
            if (tour.Time != null) tour.Time.IsDirty = false;
            tour.IsDirty = false;

            tours.Add(tour);
        }


        internal bool Delete(Entities.Tour tour)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("ToursDeleteById", out affected);
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

