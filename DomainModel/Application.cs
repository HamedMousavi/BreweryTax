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
        public static ApplicationStatus Status { get; private set; }
        public static Entities.Culture Culture 
        { 
            get { return culture; } 
            set 
            { 
                culture = value;
                Init(value);
            } 
        }


        public static void Init(ApplicationSettingsBase applicationSettings, string startupPath)
        {
            // Load application settings
            settings = new DomainModel.Settings(applicationSettings);
            settings.StartupPath = startupPath;

            Cultures.Init(settings.SqlConnectionString);
            //culture = Cultures.GetAll()["en-us"];

            // Create a resource manager to access localized resources
            resourceManager = new ResourceManager(settings.DefaultLocale);

            Status = new ApplicationStatus(new 
                StatusController.Controller.StatusController());

            // Init repository
            InitRepository();

            // Set a default invalid user for application
            user = new Entities.User();
        }


        private static void InitRepository()
        {
            Membership.Tasks.Init(settings.SqlConnectionString);
            Membership.Roles.Init(settings.SqlConnectionString);
            Membership.UserSettings.Init(settings.SqlConnectionString);
            Membership.Users.Init(settings.SqlConnectionString, Cultures.GetAll());

            Currencies.Init(settings.SqlConnectionString);
            Types.Init(settings.SqlConnectionString);
            Employees.Init(settings.SqlConnectionString);
            Tours.Init(settings.SqlConnectionString);
            TourCostRules.Init(settings.SqlConnectionString);
            TourCostGroups.Init(settings.SqlConnectionString);
            Categories.Init(settings.SqlConnectionString);

            Tours.Init(settings.SqlConnectionString);
            TourEmployees.Init(settings.SqlConnectionString);
            TourCosts.Init(settings.SqlConnectionString);
            TourPayments.Init(settings.SqlConnectionString);
            TourMembers.Init(settings.SqlConnectionString);
        }


        private static void Init(Entities.Culture culture)
        {
            SignUpTypes.Init(settings.SqlConnectionString, culture);
            PersonTitleTypes.Init(settings.SqlConnectionString, culture);
            ContactMediaTypes.Init(settings.SqlConnectionString, culture);
            TourTypes.Init(settings.SqlConnectionString, culture);
            PaymentTypes.Init(settings.SqlConnectionString, culture);

            TourBasePrices.Init(settings.SqlConnectionString);
        }
    }
}
