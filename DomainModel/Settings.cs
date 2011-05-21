using System.Configuration;


namespace DomainModel
{

    public class Settings
    {

        private ApplicationSettingsBase appSettings;


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
                return (string)this.appSettings.
                    Properties["DefaultLocale"].DefaultValue;
            }
        }

        public string SqlConnectionString
        {
            get
            {
                return (string)this.appSettings.
                    Properties["DatabaseConnectionString"].DefaultValue;
            }
        }
    }
}
