using Entities;
using System.Configuration;


namespace DomainModel
{

    public class Application
    {

        private static User user;
        private static Settings settings;
        private static ResourceManager resourceManager;
        private static Entities.Culture culture;

        public static User User { get { return user; } set { user = value; } }
        public static Settings Settings { get { return settings; } set { settings = value; } }
        public static ResourceManager ResourceManager { get { return resourceManager; } set { resourceManager = value; } }
        public static ApplicationStatus Status;
        public static Entities.Culture Culture { get { return culture; } set { culture = value; } }


        public static void Init(ApplicationSettingsBase applicationSettings)
        {
            Cultures.Init();
            culture = Cultures.GetAll()["en-us"];

            // Load application settings
            settings = new DomainModel.Settings(applicationSettings);

            // Create a resource manager to access localized resources
            resourceManager = new ResourceManager(settings.DefaultLocale);

            Status = new ApplicationStatus();
            Status.Init(new StatusController.Controller.StatusController());

            // Init repositories
            Membership.Tasks.Init(settings.SqlConnectionString);
            Membership.Roles.Init(settings.SqlConnectionString);
            Membership.UserSettings.Init(settings.SqlConnectionString);
            Membership.Users.Init(settings.SqlConnectionString, Cultures.GetAll());

            Employees.Init(settings.SqlConnectionString);
            Tours.Init(settings.SqlConnectionString);

            // Set a default invalid user for application
            user = new Entities.User();
        }
    }
}
