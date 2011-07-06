using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace TaxDataStore
{

    public partial class TourGroupDetails : UserControl
    {

        protected Entities.TourGroup group;

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
                UpdateSignupState();
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

        
        protected Dictionary<string, Image> images;


        public TourGroupDetails()
        {
            InitializeComponent();

            SetupControls();
            CreateImages();
            BindControls();
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
        }


        private void CreateImages()
        {
            this.images = new Dictionary<string, Image>();
            this.images.Add("tourism_office", DomainModel.Application.ResourceManager.GetImage("home"));
            this.images.Add("email", DomainModel.Application.ResourceManager.GetImage("email_open"));
        }


        private void BindControls()
        {
        }


        void group_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (string.Equals(e.PropertyName, "SignUpType", System.StringComparison.InvariantCulture))
            {
                UpdateSignupState();
            }
        }


        private void UpdateSignupState()
        {
            this.lblSignupType.Text = this.group.SignUpType.Name;
            this.pbxSignupType.Image = GetSignupTypeImage(this.group);
        }


        private Image GetSignupTypeImage(Entities.TourGroup group)
        {
            switch (group.SignUpType.Id)
            {
                case 4: // Tourism office
                    return this.images["tourism_office"];

                case 5: // E-Mail
                    return this.images["email"];
            }

            return null;
        }

    }
}
