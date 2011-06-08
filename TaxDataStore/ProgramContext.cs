using System.Windows.Forms;
using System;


namespace TaxDataStore
{

    public class ProgramContext : ApplicationContext
    {

        internal ProgramContext()
        {
            StartApplication();
        }


        private void StartApplication()
        {
            ShowSplashScreen();
            InitApplication();
            LoadAppSettings();
            SetupUpdater();
            HideSplashScreen();
            BeginAuthenticate();
        }


        private void ShowSplashScreen()
        {
            Presentation.Controllers.SplashScreen.Show();
        }


        private void LoadAppSettings()
        {
            Presentation.View.Locale =
                Properties.Settings.Default.DefaultLocale;
        }


        private void InitApplication()
        { 
            DomainModel.Application.Init(Properties.Settings.Default);
        }


        private void SetupUpdater()
        {
            if (TaxDataStoreUpdater.ServiceInterface.ServiceExists)
            {
                //TaxDataStoreUpdater.ServiceInterface.UnInstall();
                //return;
            }
            else
            {
                TaxDataStoreUpdater.ServiceInterface.Install();
            }

            if (TaxDataStoreUpdater.ServiceInterface.ServiceIsRunning)
            {
            }
            else
            {
                TaxDataStoreUpdater.ServiceInterface.Start();
            }
        }


        private void HideSplashScreen()
        {
            Presentation.Controllers.SplashScreen.Hide();
        }


        private void BeginAuthenticate()
        {
#if DEBUG
            DomainModel.Membership.Users.Authenticate(
                new Entities.User("Hamed", "1"));

            EndAuthenticate(true);
#else

            Presentation.Controllers.Users.DisplayLoginWindow(this);
#endif
        }


        internal void EndAuthenticate(bool authenticated)
        {
            if (authenticated)
            {
                if (DomainModel.Application.User.IsAuthenticated)
                {
                    LoadUserSettings();
                    BeginMainWindow();
                }
                else
                {
                    ExitThread();
                }
            }
            else
            {
                ExitThread();
            }
        }


        private void LoadUserSettings()
        {
            Presentation.View.Locale =
                DomainModel.Application.User.Culture.CultureName;

            // Set app culture by finding it in app list of cultures
            DomainModel.Application.Culture =
                DomainModel.Application.User.Culture;
        }


        private void BeginMainWindow()
        {
            Presentation.Controllers.Application.DisplayMainWindow(this);
        }


        internal void EndMainWindow()
        {
            ExitThread();
        }
    }
}
