using Entities;
using System;


namespace DomainModel
{

    public class Services
    {

        private static ServiceCollection services;
        private static Repository.Sql.Services repo;


        public static void Init(string sqlConnectionString)
        {
            repo = new Repository.Sql.Services(sqlConnectionString);

            Load();
        }


        private static void Load()
        {
            services = new ServiceCollection();
            repo.Load(services);
        }


        public static ServiceCollection GetAll()
        {
            return services;
        }


        internal static Service GetByType(GeneralType tourType)
        {
            foreach (Service service in services)
            {
                if (service.ServiceType.Id == tourType.Id)
                {
                    return service;
                }
            }

            return null;
        }


        public static bool Save(Service service)
        {
            bool res = false;
            try
            {
                if (service.IsDirty)
                {
                    if (service.Id < 0)
                    {
                        res = repo.Insert(service);

                        if (!services.Contains(service))
                        {
                            services.Add(service);
                        }
                    }
                    else
                    {
                        res = repo.Update(service);
                    }

                    if (res)
                    {
                        service.IsDirty = false;
                    }
                }
                else
                {
                    res = true;
                }
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


        public static bool Delete(Service service)
        {
            bool res = false;

            try
            {
                res = repo.Delete(service);
                if (res)
                {
                    services.Remove(service);
                }
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
