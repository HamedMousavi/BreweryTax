using System;


namespace DomainModel
{

    public class TourGroupEmployees
    {
        private static Repository.Sql.TourEmployees empRepo;


        public static void Init(string sqlConnectionString)
        {
            empRepo = new Repository.Sql.TourEmployees(sqlConnectionString);
        }


        internal static void Load(Entities.TourGroup group)
        {
            try
            {
                empRepo.GetByGroup(group);
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
        }


        public static bool Add(Entities.TourGroup group, Entities.Employee emp)
        {
            bool res;

            try
            {
                if ((res = empRepo.Insert(group, emp)))
                {
                    group.Employees.Add(emp);
                }
            }
            catch (Exception ex)
            {
                res = false;

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


        public static bool Delete(Entities.TourGroup group, Entities.Employee emp)
        {
            bool res;

            try
            {
                res = empRepo.Delete(group, emp);
            }
            catch (Exception ex)
            {
                res = false;

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
