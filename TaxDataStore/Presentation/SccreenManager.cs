using System;
using System.Windows.Forms;
using System.Drawing;


namespace TaxDataStore.Presentation
{

    public class SccreenManager
    {

        protected Form window;
        protected Entities.User user;


        public SccreenManager()
        {
        }


        public void Attach(Form window, Entities.User user)
        {
            this.user = user;

            if (this.window != window)
            {
                Detach(this.window);
                this.window = window;
            }

            this.window.Load += new EventHandler(window_Load);
            this.window.FormClosing += new FormClosingEventHandler(window_FormClosing);
        }


        void window_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.window == null) return;

            SaveWindow();
        }


        void window_Load(object sender, EventArgs e)
        {
            if (this.window == null) return;

            RestoreWindow();
        }


        private void Detach(Form form)
        {
            if (this.window == null) return;

            this.window.Load -= new EventHandler(window_Load);
            this.window.FormClosing -= new FormClosingEventHandler(window_FormClosing);
        }


        private void SaveWindow()
        {
            // Save last window state in settings
            this.user.Settings.LastWindowState =
                Convert.ToInt32(this.window.WindowState);

            if (this.window.WindowState == FormWindowState.Normal)
            {
                this.user.Settings.WindowBounds =
                    this.window.Bounds;
            }
            else
            {
                this.user.Settings.WindowBounds =
                    this.window.RestoreBounds;
            }

            DomainModel.Membership.UserSettings.Save(this.user);
        }


        private void RestoreWindow()
        {
            // Load window bounds
            if (!this.user.Settings.WindowBounds.IsEmpty)
            {
                this.window.StartPosition = FormStartPosition.Manual;
                this.window.Bounds =
                    this.user.Settings.WindowBounds;
            }
            else
            {
                this.window.StartPosition = FormStartPosition.CenterScreen;
            }

            this.window.WindowState = ((FormWindowState)
                this.user.Settings.LastWindowState);

            if (this.window.WindowState != FormWindowState.Maximized)
            {
                EnsureVisible();
            }
        }


        private void EnsureVisible()
        {
            // Find best display
            Rectangle display = Screen.GetWorkingArea(this.window);
            if (display.IsEmpty)
            {
                display = Screen.PrimaryScreen.Bounds;
            }

            // Ensure size is OK
            if (this.window.Bounds.Width <= 100 ||
                this.window.Bounds.Height <= 100)
            {
                this.window.Bounds = new Rectangle(
                    0,
                    0,
                    display.Width > 800 ? 800 : display.Width,
                    display.Height > 600 ? 600 : display.Height);
            }

            // Ensure position is OK
            if (!display.Contains(this.window.Bounds))
            {
                if (display.IntersectsWith(this.window.Bounds))
                {
                    // Move window
                    this.window.Bounds = new Rectangle(
                        new Point(
                            display.Width - this.window.Bounds.Width,
                            display.Height - this.window.Bounds.Height),
                        this.window.Bounds.Size);
                }
                else
                {
                    this.window.Bounds = new Rectangle(
                        new Point(0, 0),
                        this.window.Size);
                }
            }

        }
    }
}
