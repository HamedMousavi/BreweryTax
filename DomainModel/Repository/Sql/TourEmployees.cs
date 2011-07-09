using System;
using System.Data.SqlClient;


namespace DomainModel.Repository.Sql
{
    public class TourEmployees
    {

        protected QueryHelper query;


        public TourEmployees(string sqlCnnStr)
        {
            this.query = new QueryHelper(sqlCnnStr);
        }


        protected void MapTourEmployeesToObject(SqlDataReader reader, object userData)
        {
            Entities.User user = DomainModel.Membership.Users.GetById(
                Utils.GetSafeInt32(reader, "EmployeeId"));

            Entities.Employee emp = new Entities.Employee(user);
            emp.IsDirty = false;

            Entities.TourGroup group = (Entities.TourGroup)userData;
            group.Employees.Add(emp);
        }


        internal bool GetByGroup(Entities.TourGroup group)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();
                this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));

                res = this.query.ExecuteReader("TourGroupEmployeesGetByTourId", MapTourEmployeesToObject, group);
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


        internal bool Delete(Entities.TourGroup group, Entities.Employee employee)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));
                this.query.Parameters.Add(new SqlParameter("@EmployeeId", employee.User.Id));


                int affected;
                res = this.query.ExecuteUpdateProc("TourGroupEmployeesDeleteById", out affected);

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


        internal bool Insert(Entities.TourGroup group, Entities.Employee employee)
        {
            bool res = false;

            try
            {
                this.query.Parameters.Clear();

                this.query.Parameters.Add(new SqlParameter("@GroupId", group.Id));
                this.query.Parameters.Add(new SqlParameter("@EmployeeId", employee.User.Id));

                int ret;
                res = this.query.ExecuteInsertProc("TourGroupEmployeesAdd", out ret);
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
