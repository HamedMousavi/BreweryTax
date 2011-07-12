using Entities;
using System.Configuration;
using System;
using System.Collections.Generic;


namespace DomainModel
{

    public class Application
    {
        private static User user;
        private static Settings settings;
        private static ResourceManager resourceManager;
        private static JobProgressController progressController;
        private static Entities.Culture culture;

        public static User User { get { return user; } set { user = value; } }
        public static Settings Settings { get { return settings; } set { settings = value; } }
        public static ResourceManager ResourceManager { get { return resourceManager; } set { resourceManager = value; } }
        public static ApplicationStatus Status { get; private set; }
        public static JobProgressController Progress { get { return progressController; } }
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
            progressController = new JobProgressController();

            // Load application settings
            settings = new DomainModel.Settings(applicationSettings);
            settings.StartupPath = startupPath;

            Status = new ApplicationStatus(new 
                StatusController.Controller.StatusController());

            try
            {
                Cultures.Init(settings.SqlConnectionString);
                //culture = Cultures.GetAll()["en-us"];
            }
            catch (Exception ex)
            {
                try
                {
                    // Unable to load cultures
                    Status.Update(StatusController.Abstract.StatusTypes.Error, "", ex.Message);
                }
                catch { }
            }



            // Create a resource manager to access localized resources
            resourceManager = new ResourceManager(settings.DefaultLocale);

            // Init repository
            InitRepository();

            // Set a default invalid user for application
            user = new Entities.User();
        }


        private static void InitRepository()
        {
            JobProgress progress = progressController.CreateJob(0, 4, "Init");

            Membership.Tasks.Init(settings.SqlConnectionString);
            progressController.IncrementValue(progress.JobId);

            Membership.Roles.Init(settings.SqlConnectionString);
            progressController.IncrementValue(progress.JobId);

            Membership.UserSettings.Init(settings.SqlConnectionString);
            progressController.IncrementValue(progress.JobId);

            Membership.Users.Init(settings.SqlConnectionString, Cultures.GetAll());
            progressController.IncrementValue(progress.JobId);
        }


        private static void Init(Entities.Culture culture)
        {
            JobProgress progress = progressController.Jobs.GetByName("Init");
            if (progress == null)
            {
                progress = progressController.CreateJob(0, 24, "Init");
            }
            else
            {
                progress.MinValue = 0;
                progress.MaxValue = 24;
            }

            Currencies.Init(settings.SqlConnectionString);
            progress.Value++;

            Types.Init(settings.SqlConnectionString);
            progress.Value++;

            Categories.Init(settings.SqlConnectionString);
            progress.Value++;

            Employees.Init(settings.SqlConnectionString);
            progress.Value++;

            SignUpTypes.Init(settings.SqlConnectionString, culture);
            progress.Value++;

            PersonTitleTypes.Init(settings.SqlConnectionString, culture);
            progress.Value++;

            ContactMediaTypes.Init(settings.SqlConnectionString, culture);
            progress.Value++;

            TourTypes.Init(settings.SqlConnectionString, culture);
            progress.Value++;

            PaymentTypes.Init(settings.SqlConnectionString, culture);
            progress.Value++;

            TourMembershipTypes.Init(settings.SqlConnectionString, culture);
            progress.Value++;

            TourStates.Init(settings.SqlConnectionString, culture);
            progress.Value++;

            TourCostConstraintTypes.Init(settings.SqlConnectionString, culture);
            progress.Value++;

            Tours.Init(settings.SqlConnectionString);
            progress.Value++;

            ServiceTypes.Init(settings.SqlConnectionString, culture);
            progress.Value++;

            TourRuleConstraints.Init(settings.SqlConnectionString);
            progress.Value++;

            TourCostRules.Init(settings.SqlConnectionString);
            progress.Value++;

            TourCostGroups.Init(settings.SqlConnectionString);
            progress.Value++;

            TourGroupServiceCosts.Init(settings.SqlConnectionString);
            progress.Value++;

            TourGroupServicePayments.Init(settings.SqlConnectionString);
            progress.Value++;

            TourGroupMembers.Init(settings.SqlConnectionString);
            progress.Value++;

            TourGroupEmployees.Init(settings.SqlConnectionString);
            progress.Value++;

            TourGroups.Init(settings.SqlConnectionString);
            progress.Value++;

            Services.Init(settings.SqlConnectionString);
            progress.Value++;

            TourGroupServices.Init(settings.SqlConnectionString);
            progress.Value++;

            // Note: please fix # of progress jobs if you added 
            // anything else here.
        }
    }
}
