using System.Drawing;
using System.Windows.Forms;

namespace TaxDataStore.Presentation.Controls
{
    public class Toolbar : ToolStrip
    {

        #region Fields

        private ToolStripSeparator[] separators;

        private ToolbarButton tbbTours;
        private ToolbarButton tbbStaffPresence;
        private ToolbarButton tbbSettings;
        private ToolbarButton tbbAppSettings;

        #endregion


        public Toolbar(int tabIndex)
        {
            // Initialize this
            this.Name = "tlbMain";
            this.TabIndex = tabIndex;
            this.AutoSize = false;
            this.Dock = System.Windows.Forms.DockStyle.None;
            this.Stretch = true;
            this.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Location = new System.Drawing.Point(0, 24);
            this.Size = new System.Drawing.Size(800, 25);
            this.RightToLeft = View.LayoutDirection;
            
            this.BackColor = Color.FromArgb(255, 35, 50, 65);
            this.ForeColor = Color.WhiteSmoke;

            // Initialize buttons
            SetupButtons();
        }


        private void SetupButtons()
        {
            // initiate separators
            int index = 0;

            this.separators = new ToolStripSeparator[3];
            for (index = 0; index < this.separators.Length; index++)
            {
                this.separators[index] = new ToolStripSeparator();
                this.separators[index].Name = string.Format("sep_{0}", index);
                this.separators[index].Size = new System.Drawing.Size(6, 25);
            }

            // Create buttons
            this.tbbTours = new ToolbarButton(
                "tours",
                "calendar_select_days",
                "View daily tours",
                Presentation.Controllers.Tours.Today);

            this.tbbStaffPresence = new ToolbarButton(
                "presence",
                "alarm_clock_blue",
                "View staff presence",
                Presentation.Controllers.Users.Presence);

            this.tbbSettings = new ToolbarButton(
                "user_settings",
                "gear",
                string.Empty,
                Presentation.Controllers.Users.Settings);

            this.tbbAppSettings = new ToolbarButton(
                "app_settings",
                "app_settings",
                string.Empty,
                Presentation.Controllers.Application.Settings);

            // Now add all buttons to this toolbar
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbTours,
            this.separators[0],
            this.tbbStaffPresence,
            this.separators[1],
            this.tbbSettings,
            this.tbbAppSettings});
        }
    }
}
