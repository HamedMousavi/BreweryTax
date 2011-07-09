using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class TourGroupDetails : UserControl
    {

        protected Entities.TourGroup group;

        protected GeneralTypeMenu mnuSignupType;
        protected GeneralTypeMenu mnuGroupState;

        protected Dictionary<string, Image> sginupTypeImages;
        protected Dictionary<string, Image> groupStateImages;


        public Entities.TourGroup Group
        {
            get { return this.group; }
            set
            {
                if (this.group != value)
                {
                    DetachGroup();
                    this.group = value;
                    AttachGroup();
                }
            }
        }


        private void AttachGroup()
        {
            if (this.group != null)
            {
                this.group.PropertyChanged += new
                    PropertyChangedEventHandler(group_PropertyChanged);

                BindControls();
            }
        }


        private void DetachGroup()
        {
            if (this.group != null)
            {
                this.group.PropertyChanged -= new 
                    PropertyChangedEventHandler(group_PropertyChanged);
            }
        }


        public TourGroupDetails()
        {
            InitializeComponent();

            SetupControls();
            CreateImages();
        }


        public TourGroupDetails(Entities.TourGroup group)
            : this()
        {
            this.Group = group;
        }


        private void SetupControls()
        {
            if (Presentation.View.Theme != null)
            {
                this.BackColor = Presentation.View.Theme.TourGroupItemBackColor;
            }

            this.mnuSignupType = new GeneralTypeMenu(DomainModel.SignUpTypes.GetAll());
            this.mnuSignupType.ClickAction = OnSignupTypeMenu;

            this.mnuGroupState = new GeneralTypeMenu(DomainModel.TourStates.GetAll());
            this.mnuGroupState.ClickAction = OnGroupStateMenu;
        }


        private void CreateImages()
        {
            this.sginupTypeImages = new Dictionary<string, Image>();
            this.sginupTypeImages.Add("tourism_office", DomainModel.Application.ResourceManager.GetImage("signup_type_office"));
            this.sginupTypeImages.Add("email", DomainModel.Application.ResourceManager.GetImage("signup_type_mail"));

            this.groupStateImages = new Dictionary<string, Image>();
            this.groupStateImages.Add("reserved", DomainModel.Application.ResourceManager.GetImage("group_state_reserved"));
            this.groupStateImages.Add("confirmed", DomainModel.Application.ResourceManager.GetImage("group_state_confirmed"));
        }


        private void BindControls()
        {
            UpdateSignupState();
            UpdateGroupState();
        }


        void group_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (string.Equals(e.PropertyName, "SignUpType", System.StringComparison.InvariantCulture))
            {
                UpdateSignupState();
            }
            else if (string.Equals(e.PropertyName, "Status", System.StringComparison.InvariantCulture))
            {
                UpdateGroupState();
            }
        }


        private void UpdateGroupState()
        {
            this.pbxGroupState.Image = GetGroupStateImage(this.group);
        }


        private void UpdateSignupState()
        {
            this.pbxSignupType.Image = GetSignupTypeImage(this.group);
        }


        private Image GetGroupStateImage(Entities.TourGroup group)
        {
            switch (group.Status.Id)
            {
                case 14: // reserved
                    return this.groupStateImages["reserved"];

                case 15: // confirmed
                    return this.groupStateImages["confirmed"];
            }

            return null;
        }


        private Image GetSignupTypeImage(Entities.TourGroup group)
        {
            switch (group.SignUpType.Id)
            {
                case 4: // Tourism office
                    return this.sginupTypeImages["tourism_office"];

                case 5: // E-Mail
                    return this.sginupTypeImages["email"];
            }

            return null;
        }

        private void pbxGroupState_Click(object sender, System.EventArgs e)
        {
            this.mnuGroupState.Show(
                this.pbxGroupState,
                new Point(this.pbxGroupState.Location.X, this.pbxGroupState.Height), 
                ToolStripDropDownDirection.BelowRight);
        }


        private void pbxSignupType_Click(object sender, System.EventArgs e)
        {
            this.mnuSignupType.Show(
                this.pbxSignupType,
                new Point(this.pbxSignupType.Location.X, this.pbxSignupType.Height),
                ToolStripDropDownDirection.BelowRight);
        }

        private void btnDeleteGroup_Click(object sender, System.EventArgs e)
        {
            DomainModel.TourGroups.Delete(this.group);
        }


        public void OnSignupTypeMenu(Entities.GeneralType item)
        {
            Entities.GeneralType old = this.group.SignUpType;

            this.group.SignUpType = item;
            if (!DomainModel.TourGroups.Save(this.group))
            {
                this.group.SignUpType = old;
            }
        }


        public void OnGroupStateMenu(Entities.GeneralType item)
        {
            Entities.GeneralType old = this.group.Status;

            this.group.Status = item;
            if (!DomainModel.TourGroups.Save(this.group))
            {
                this.group.Status = old;
            }
        }
    }
}
