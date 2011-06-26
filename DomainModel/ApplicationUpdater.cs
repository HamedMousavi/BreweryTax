using System;
using Entities;

namespace DomainModel
{
    public class ApplicationUpdater
    {
        private static UpdaterSettings settings;
        private static Repository.ApplicationUpdater repo;


        public static UpdaterSettings LoadSettings()
        {
            try
            {
                if (repo == null)
                {
                    repo = new Repository.ApplicationUpdater();
                }

                return repo.Load();
            }
            catch (Exception ex)
            {
                //EventLogger.Instance.Add(ex.Message);
            }

            return null;
        }


        public static bool SaveSettings(UpdaterSettings settings)
        {
            try
            {
                if (repo == null)
                {
                    repo = new Repository.ApplicationUpdater();
                }

                if (!settings.UpdateUri.Contains("http://"))
                {
                    settings.UpdateUri = "http://" + settings.UpdateUri;
                }

                return repo.Save(settings);
            }
            catch (Exception ex)
            {
                //EventLogger.Instance.Add(ex.Message);
            }

            return false;
        }
    }
}
