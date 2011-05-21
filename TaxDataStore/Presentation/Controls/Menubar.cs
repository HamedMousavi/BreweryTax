using System.Windows.Forms;
using System.Drawing;

namespace TaxDataStore.Presentation.Controls
{
    public class Menubar : MenuStrip
    {
        #region Fields

        protected MenuItem miSettlement;
        protected MenuItem miTours;
        protected MenuItem miPresence;
        protected MenuItem miSettlementExit;

        protected MenuItem miStaff;
        protected MenuItem miStaffPresence;

        protected MenuItem miTools;
        protected MenuItem miToolsUserSettings;
        protected MenuItem miToolsAppSettings;

        protected MenuItem miHelp;
        protected MenuItem miHelpContent;
        protected MenuItem miHelpAbout;


        protected ToolStripSeparator[] separators;

        #endregion Fields


        #region Properties

        public MenuItem Exit
        {
            get { return this.miSettlementExit; }
        }

        #endregion


        public Menubar()
        {
            this.RightToLeft = View.LayoutDirection;

            this.Dock = System.Windows.Forms.DockStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(800, 24);
            this.TabIndex = 0;
            this.Name = "menuBar";
            this.Text = "mainMenu";
            this.Font = new Font("Tahoma", 9, FontStyle.Regular);

            SetupMenuItems();
        }


        private void SetupMenuItems()
        {
            this.separators = new ToolStripSeparator[3];
            for (int i = 0; i < this.separators.Length; i++)
            {
                this.separators[i] = new ToolStripSeparator();
            }

            this.miTours = new MenuItem(
                "tours",
                "currency_euro",
                string.Empty,
                Presentation.Controllers.Tours.Today);

            this.miSettlementExit = new MenuItem(
                "exit",
                string.Empty,
                string.Empty,
                Presentation.Controllers.Application.Exit); // Action is set in main form

            this.miSettlement = new MenuItem(
                "settlement",
                string.Empty,
                string.Empty,
                null);

            this.miSettlement.DropDownItems.AddRange(
                new ToolStripItem[] 
                {
                    this.miTours,
                    this.separators[0],
                    this.miSettlementExit
                });


            this.miStaff = new MenuItem(
                "staff",
                string.Empty,
                string.Empty,
                null);

            this.miStaffPresence = new MenuItem(
                "presence",
                "alarm_clock_blue",
                string.Empty,
                Presentation.Controllers.Users.Presence);

            this.miStaff.DropDownItems.AddRange(
                new ToolStripItem[] 
                {
                    this.miStaffPresence
                });


            this.miToolsUserSettings = new MenuItem(
                "user_settings",
                "hammer",
                string.Empty,
                Presentation.Controllers.Users.Settings);

            this.miToolsAppSettings = new MenuItem(
                "app_settings",
                "app_settings",
                string.Empty,
                Presentation.Controllers.Application.Settings);

            this.miTools = new MenuItem(
                "tools",
                string.Empty,
                string.Empty,
                null);

            this.miTools.DropDownItems.AddRange(
                new ToolStripItem[] 
                {
                    this.miToolsUserSettings,
                    this.miToolsAppSettings
                });

            this.miHelpContent = new MenuItem(
                "help_content",
                string.Empty,
                string.Empty,
                null);

            this.miHelpAbout = new MenuItem(
                "help_about",
                string.Empty,
                string.Empty,
                Presentation.Controllers.Help.About);

            this.miHelp = new MenuItem(
                "help",
                string.Empty,
                string.Empty,
                null);

            this.miHelp.DropDownItems.AddRange(
                new ToolStripItem[] 
                {
                    this.miHelpContent,
                    this.miHelpAbout
                });

            this.Items.AddRange(
                new ToolStripItem[] 
                {
                    this.miSettlement,
                    this.miStaff,
                    this.miTools,
                    this.miHelp
                });
        }
    }
}
