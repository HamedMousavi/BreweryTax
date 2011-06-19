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
                if (tour.Id >= 0)
                {
                    DomainModel.Application.Status.Update(
                        StatusTypes.Warning,
                        "stat_wrn_db_id_already_exists");
                    return true;
                }

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@TourTime", tour.Time.Value));
                this.query.Parameters.Add(new SqlParameter("@TourState", tour.Status.Id));
                this.query.Parameters.Add(new SqlParameter("@TourTypeId", tour.TourType.Id));
                this.query.Parameters.Add(new SqlParameter("@SignupTypeId", tour.SignUpType.Id));
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
                if (tour.Id < 0)
                {
                    DomainModel.Application.Status.Update(
                        StatusTypes.Warning,
                        "stat_wrn_db_id_not_exists");
                    return true;
                }

                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@TourTime", tour.Time.Value));
                this.query.Parameters.Add(new SqlParameter("@TourState", tour.Status == null ? -1 : tour.Status.Id));
                this.query.Parameters.Add(new SqlParameter("@TourTypeId", tour.TourType.Id));
                this.query.Parameters.Add(new SqlParameter("@SignupTypeId", tour.SignUpType.Id));
                this.query.Parameters.Add(new SqlParameter("@Comments", tour.Comments));
                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));

                res = this.query.ExecuteUpdateProc("ToursUpdateById");
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
                this.query.Parameters.Add(new SqlParameter("@TourTime", date));

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
            tour.Time.Value = Utils.GetSafeDateTime(reader, "TourTime", DateTime.UtcNow);
            tour.Status = DomainModel.TourStates.GetById(Utils.GetSafeInt32(reader, "TourState"));
            tour.TourType = DomainModel.TourTypes.GetById(Utils.GetSafeInt32(reader, "TourTypeId"));
            tour.SignUpType = DomainModel.SignUpTypes.GetById(Utils.GetSafeInt32(reader, "SignupTypeId"));
            tour.Comments = Utils.GetSafeString(reader, "Comments");
            
            if (tour.SignUpType != null) tour.SignUpType.IsDirty = false;
            if (tour.Time != null) tour.Time.IsDirty = false;
            if (tour.TourType != null) tour.TourType.IsDirty = false;
            if (tour.Status != null) tour.Status.IsDirty = false;
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

                res = this.query.ExecuteUpdateProc("ToursDeleteById");
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

