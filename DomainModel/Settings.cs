using System.Configuration;


namespace DomainModel
{

    public class Settings
    {

        private ApplicationSettingsBase appSettings;

        public ApplicationSettingsBase AppSettings
        {
            get
            {
                return this.appSettings;
            }

            set
            {
                this.appSettings = value;
            }
        }


        public Settings(ApplicationSettingsBase applicationSettings)
        {
            this.appSettings = applicationSettings;
        }

        /*
        public object this[string name]
        {
            get
            {
                return this.appSettings[name];
            }
        }*/

        public string DefaultLocale 
        {
            get
            {
                return (string)this.appSettings["DefaultLocale"];
            }
        }

        public string SqlConnectionString
        {
            get
            {
                return (string)this.appSettings["DatabaseConnectionString"];
            }
        }

        public string StartupPath { get; set; }
    }
}
