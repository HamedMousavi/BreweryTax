using System;
using System.ComponentModel;
using System.Windows.Forms;
using TaxDataStore.Presentation;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class TourControl : TourBaseControl
    {

        protected Entities.Tour tour;
        public Entities.Tour Tour 
        {
            get { return this.tour; }
            set 
            {
                if (this.tour != value)
                {
                    BindControls(value);
                }
            }
        }

        protected Panel pnlGroups;
        protected EditToolbar etbGroups;
        protected FormControlManager ctrlManager;


        public TourControl(Entities.Tour tour)
            : base()
        {
            InitializeComponent();

            SetupControls();

            BindControls(tour);
        }


        private void SetupControls()
        {
            if (Presentation.View.Theme != null)
            {
                this.lblDetails.ForeColor = Presentation.View.Theme.TourForeColor;
                this.lblTourTime.ForeColor = Presentation.View.Theme.TourForeColor;
                this.lblDetails.Font = Presentation.View.Theme.FormLabelFont;
                this.lblTourTime.Font = Presentation.View.Theme.TourTitleFont;
                this.tlpMain.BackColor = Presentation.View.Theme.TourBackColor;
                this.BackColor = Presentation.View.Theme.TourListBackColor;
            }

            this.lblTourTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;

            this.pnlGroups = new Panel();
            this.pnlGroups.AutoScroll = false;
            this.pnlGroups.AutoSize = true;
            this.pnlGroups.Anchor = AnchorStyles.Left |
                AnchorStyles.Top | AnchorStyles.Right;

            this.etbGroups = new EditToolbar(
                GetGroupEditTitle(),true, false, false);

            this.etbGroups.ButtonAutohide = false;
            this.etbGroups.Anchor = AnchorStyles.Left |
                AnchorStyles.Bottom | AnchorStyles.Right;
            this.etbGroups.AddButtonClick += new EventHandler(Groups_AddButtonClick);

            this.tlpTourDetail.Controls.Add(this.etbGroups, 1, 0);
            this.tlpMain.Controls.Add(this.pnlGroups, 0, 1);

            this.Disposed += new EventHandler(TourControl_Disposed);

            this.lblTourTime.Cursor = Cursors.Hand;
            this.lblTourTime.Click += new EventHandler(lblTourTime_Click);

            this.btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            this.btnClose.BackgroundImage = DomainModel.Application.ResourceManager.GetImage("close");

            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpTourDetail.AutoSize = true;
            this.tlpTourDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
        }


        private string GetGroupEditTitle()
        {
            return string.Format(
                "{0}({1})",
                DomainModel.Application.ResourceManager.GetText("lbl_groups"),
                this.Tour == null? 0 : this.Tour.Groups.Count);
        }


        void lblTourTime_Click(object sender, EventArgs e)
        {
            if (this.Tour != null)
            {
                Presentation.Controllers.Tours.Edit(this.Tour);
                UpdateData(true);
            }
        }


        void Groups_AddButtonClick(object sender, EventArgs e)
        {
            Entities.TourGroup group = Presentation.Controllers.Tours.AddGroup(this.Tour);
            if (group != null)
            {
                group.Services.ListChanged +=
                    new ListChangedEventHandler(Services_ListChanged);
            }
        }


        private void BindControls(Entities.Tour tour)
        {
            Detach();
            this.tour = tour;
            Attach();

            this.ctrlManager = new FormControlManager(this.pnlGroups, tour.Groups);
            this.ctrlManager.CreateControl = CreateTourGroup;
            this.ctrlManager.FindControl = TourGroupFindControl;
            this.ctrlManager.ListContainsControl = ListContainsTourGroup;

            UpdateData(true);
        }


        private void Attach()
        {
            if (this.Tour == null) return;

            foreach (Entities.TourGroup group in this.Tour.Groups)
            {
                group.Services.ListChanged += 
                    new ListChangedEventHandler(Services_ListChanged);
            }

            this.Tour.Groups.ListChanged += new
                ListChangedEventHandler(Groups_ListChanged);
        }


        private void Detach()
        {
            if (this.Tour == null) return;

            foreach (Entities.TourGroup group in this.Tour.Groups)
            {
                group.Services.ListChanged -=
                    new ListChangedEventHandler(Services_ListChanged);
            }

            this.Tour.Groups.ListChanged -= new 
                ListChangedEventHandler(Groups_ListChanged);
        }


        void Services_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateData();
        }

        
        public Control CreateTourGroup(object item)
        {
            TourGroup client = new TourGroup();
            client.Group = (Entities.TourGroup)item;
            client.Tour = this.Tour;
            client.Dock = DockStyle.Top;

            return client;
        }


        public Control TourGroupFindControl(object item)
        {
            Entities.TourGroup group =
                (Entities.TourGroup)item;

            return FindInClients(group);
        }


        public bool ListContainsTourGroup(UserControl ctrl)
        {
            TourGroup tg = (TourGroup)ctrl;
            return this.Tour.Groups.Contains(tg.Group);
        }


        void Groups_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsDisposed) return;

            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                UpdateData(false);
            }
            else
            {
                UpdateData(true);
            }
        }


        private TourGroup FindInClients(Entities.TourGroup group)
        {
            foreach (UserControl ctrl in this.pnlGroups.Controls)
            {
                TourGroup grpCtrl = ctrl as TourGroup;
                if (grpCtrl != null)
                {
                    if (grpCtrl.Group == group)
                    {
                        return grpCtrl;
                    }
                }
            }

            return null;
        }


        public void UpdateData(bool updateLayout = false)
        {
            this.lblTourTime.Text = this.Tour.Time.ToString();
            this.lblDetails.Text = string.Format(
                "{0}({1})",
                DomainModel.Application.ResourceManager.GetText("lbl_participants"),
                this.Tour.GetServiceCountExcept(DomainModel.ServiceTypes.GetById(20))// Exclude (20 = Drink)
                );

            this.etbGroups.Title = GetGroupEditTitle();

            if (updateLayout)
            {
                this.SuspendLayout();
                this.ctrlManager.Sync();
                //SetupClientSize();
                this.ResumeLayout(true);
            }
        }
        

        void TourControl_Disposed(object sender, EventArgs e)
        {
            Detach();
        }


        void btnClose_Click(object sender, System.EventArgs e)
        {
            if (Presentation.Controllers.Tours.DeleteTour(this.tour))
            {
            }
        }
    }
}
