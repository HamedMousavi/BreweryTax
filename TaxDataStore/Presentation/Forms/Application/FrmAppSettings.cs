﻿using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmAppSettings : BaseForm
    {
        protected Presentation.Controls.Settings.Database ctrlDatabase;
        protected Presentation.Controls.Settings.Updates ctrlUpdates;
        protected Presentation.Controls.Settings.General ctrlGeneral;
        protected Presentation.Controls.Settings.Types ctrlTypes;

        protected UsersManager ctrlUsers;
        protected RoleManager ctrlRoles;
        protected TourCostSettings ctrlTourCostSettings;


        public FrmAppSettings()
        {
            InitializeComponent();

            SetupControls();
        }


        private void SetupControls()
        {
            this.tabUsers.ImageList = new ImageList();
            this.tabUsers.ImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage("clipboard_task"));
            this.tabUsers.ImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage("manage_users"));
            this.tabUsers.ImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage("money_coin"));
            this.tabUsers.ImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage("database"));
            this.tabUsers.ImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage("globe_green"));
            this.tabUsers.ImageList.Images.Add(
                DomainModel.Application.ResourceManager.GetImage("node_select_all"));

            this.tbpRoles.ImageIndex = 0;
            this.tbpUsers.ImageIndex = 1;
            this.tbpTourCost.ImageIndex = 2;
            this.tbpUpdates.ImageIndex = 4;
            this.tbpDatabase.ImageIndex = 3;
            this.tbpCategories.ImageIndex = 5;

            if (DomainModel.Membership.Users.Authorise("User management"))
            {
                this.ctrlUsers = new UsersManager();
                this.tbpUsers.Controls.Add(this.ctrlUsers);
            }
            else
            {
                this.tabUsers.Controls.Remove(this.tbpUsers);
            }


            if (DomainModel.Membership.Users.Authorise("Role management"))
            {
                this.ctrlRoles = new RoleManager();
                this.tbpRoles.Controls.Add(this.ctrlRoles);
            }
            else
            {
                this.tabUsers.Controls.Remove(this.tbpRoles);
            }

            /*
            this.ctrlGeneral = new Presentation.Controls.Settings.General();
                this.tbpGeneral.Controls.Add(this.ctrlGeneral);
            */
            
            this.ctrlTourCostSettings = new TourCostSettings();
            this.tbpTourCost.Controls.Add(this.ctrlTourCostSettings);

            this.ctrlDatabase = new Presentation.Controls.Settings.Database();
            this.tbpDatabase.Controls.Add(this.ctrlDatabase);
            
            this.ctrlUpdates = new Presentation.Controls.Settings.Updates();
            this.tbpUpdates.Controls.Add(this.ctrlUpdates);

            this.ctrlTypes = new Presentation.Controls.Settings.Types();
            this.tbpCategories.Controls.Add(this.ctrlTypes);


            this.tlpMain.Controls.Add(new WorkbenchViewButton(), 1, 0);
        }
    }
}
