using System;
using System.Data.SqlClient;
using DomainModel.Repository.Sql;
using StatusController.Abstract;


namespace DomainModel.Repository.Sql
{
    public class TourEmployees
    {

        protected QueryHelper query;


        public TourEmployees(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        public bool Insert(Entities.Tour tour, Entities.Employee employee)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));
                this.query.Parameters.Add(new SqlParameter("@EmployeeId", employee.User.Id));

                int ret;
                res = this.query.ExecuteInsertProc("TourEmployeesAdd", out ret);
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


        public bool Delete(Entities.Tour tour, Entities.Employee employee)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@TourId", tour.Id));
                this.query.Parameters.Add(new SqlParameter("@EmployeeId", employee.User.Id));

                res = this.query.ExecuteUpdateProc("TourEmployeesDeleteById");

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

                res = this.query.ExecuteReader("TourEmployeesGetByTourId", MapTourEmployeesToObject, tour);
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


        protected void MapTourEmployeesToObject(SqlDataReader reader, object userData)
        {
            Entities.User user = DomainModel.Membership.Users.GetById(
                Utils.GetSafeInt32(reader, "EmployeeId"));

            Entities.Employee emp = new Entities.Employee(user);

            Entities.Tour tour = (Entities.Tour)userData;
            tour.Employees.Add(emp);
        }
    }
}
