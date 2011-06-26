using System.Windows.Forms;
using System;


namespace TaxDataStore
{

    public class ProgramContext : ApplicationContext
    {

        internal ProgramContext()
        {
            try
            {
                StartApplication();
            }
            catch (Exception ex)
            {
                Exit(ex.Message);
            }
        }


        private void StartApplication()
        {
            ShowSplashScreen();
            InitApplication();
            LoadAppSettings();
            HideSplashScreen();
            SetupUpdater();
            BeginAuthenticate();
        }


        private void ShowSplashScreen()
        {
            try
            {
                Presentation.Controllers.SplashScreen.Show();
                Application.DoEvents();
            }
            catch { /*Splash screen failed. No problem. */ }

        }


        private void InitApplication()
        {
            try
            {
                DomainModel.Application.Init(
                    Properties.Settings.Default,
                    Application.StartupPath);
            }
            catch (Exception ex)
            {
                // Domain model failed. No reason to continue
                Exit(ex.Message);
            }
        }


        private void LoadAppSettings()
        {
            try
            {
                Presentation.View.Theme =
                    new Presentation.Theme();

                Presentation.View.Locale =
                    Properties.Settings.Default.DefaultLocale;
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "", ex.Message);
                }
                catch { }

                // GUI failed. No reason to continue
                Exit("");
            }
        }


        private void HideSplashScreen()
        {
            try
            {
                Presentation.Controllers.SplashScreen.Hide();
            }
            catch { /*Splash failed to hide. No problem. */ }
        }


        private void SetupUpdater()
        {
            AppUpdateController.StartUpdater();
        }


        private void BeginAuthenticate()
        {
#if DEBUG
            DomainModel.Membership.Users.Authenticate(
                new Entities.User("Hamed", "1"));

            EndAuthenticate(true);
#else

            try
            {
                Presentation.Controllers.Users.DisplayLoginWindow(this);
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "", ex.Message);
                }
                catch { }

                // GUI failed. No reason to continue
                Exit(ex.Message);
            }
#endif
        }


        internal void EndAuthenticate(bool authenticated)
        {
            if (authenticated)
            {
                if (DomainModel.Application.User.IsAuthenticated)
                {
                    ShowSplashScreen();

                    LoadUserSettings();
                    BeginMainWindow();
                }
                else
                {
                    Exit("");
                }
            }
            else
            {
                Exit("");
            }
        }


        private void LoadUserSettings()
        {
            try
            {
                Presentation.View.Locale =
                    DomainModel.Application.User.Culture.CultureName;

                // Set app culture by finding it in app list of cultures
                DomainModel.Application.Culture =
                    DomainModel.Application.User.Culture;
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "", ex.Message);
                }
                catch { }

                // User is not known. Security issue. Shall exit
                Exit(ex.Message);
            }
        }


        private void BeginMainWindow()
        {
            try
            {
                Presentation.Controllers.Application.DisplayMainWindow(this);
            }
            catch (Exception ex)
            {
                try
                {
                    DomainModel.Application.Status.Update(
                        StatusController.Abstract.StatusTypes.Error,
                        "", ex.Message);
                }
                catch { }

                // Main window failed. Shall exit now
                Exit(ex.Message);
            }

            try
            {
                HideSplashScreen();
            }
            catch { }
        }


        internal void EndMainWindow()
        {
            ExitThread();
        }


        private void Exit(string message)
        {
            try
            {
                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message);
                }
            
                ExitThread();
            }
            catch 
            { 
                // Now what?!
            }

        }
    }
}
