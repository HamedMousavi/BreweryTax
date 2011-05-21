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
            InitApplication();
            LoadAppSettings();
            BeginAuthenticate();
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


        private void BeginAuthenticate()
        {
#if DEBUG
            DomainModel.Application.User.Id = 0;
            DomainModel.Application.User.IsAuthenticated = true;
            DomainModel.Application.User.IsEnabled = true;
            DomainModel.Application.User.Name = "hamed";
            DomainModel.Application.User.Culture = new Entities.Culture("German", "de-DE");
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
