﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace TaxDataStore
{

    public partial class TourControl : UserControl
    {

        public Entities.Tour Tour { get; set; }

        protected Panel pnlGroups;
        protected EditToolbar etbGroups;

        public TourControl(Entities.Tour tour)
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
                DomainModel.Application.ResourceManager.
                GetText("lbl_groups"), true, false, false);
            this.etbGroups.ButtonAutohide = false;
            this.etbGroups.Anchor = AnchorStyles.Left |
                AnchorStyles.Top | AnchorStyles.Right;
            this.etbGroups.AddButtonClick += new EventHandler(Groups_AddButtonClick);

            this.tlpTourDetail.Controls.Add(this.etbGroups, 1, 0);
            this.tlpMain.Controls.Add(this.pnlGroups, 0, 1);
        }


        void Groups_AddButtonClick(object sender, EventArgs e)
        {
            Presentation.Controllers.Tours.AddGroup(this.Tour);
        }


        private void BindControls(Entities.Tour tour)
        {
            this.Tour = tour;

            tour.Groups.ListChanged += new 
                ListChangedEventHandler(Groups_ListChanged);

            UpdateData();
        }


        void Groups_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsDisposed) return;

            UpdateData();
        }


        private void UpdateData(Entities.Tour tour)
        {
            if (IsDisposed) return;

            this.lblTourTime.Text = tour.Time.ToString();
            this.lblDetails.Text = string.Format(
                "{0}: {1}     {2}:{3}",
                DomainModel.Application.ResourceManager.GetText("lbl_groups"),
                tour.Groups.Count,
                DomainModel.Application.ResourceManager.GetText("lbl_services"),
                tour.ServiceCount
                );
            
            List<TourGroup> removable = new List<TourGroup>();

            foreach (UserControl ctrl in this.pnlGroups.Controls)
            {
                TourGroup grpCtrl = ctrl as TourGroup;
                if (grpCtrl != null)
                {
                    Entities.TourGroup grp = grpCtrl.Group;

                    if (tour.Groups.Contains(grp))
                    {
                        //grpCtrl.UpdateData();
                    }
                    else
                    {
                        removable.Add(grpCtrl);
                    }
                }
            }

            lock (this)
            {
                this.pnlGroups.SuspendLayout();

                foreach (TourGroup grpCtrl in removable)
                {
                    this.pnlGroups.Controls.Remove(grpCtrl);
                    grpCtrl.Dispose();
                }
                removable.Clear();

                foreach (Entities.TourGroup grp in tour.Groups)
                {
                    TourGroup ctrl = FindInClients(grp);
                    if (ctrl == null)
                    {
                        TourGroup client = new TourGroup(grp);
                        client.Dock = DockStyle.Top;
                        this.pnlGroups.Controls.Add(client);
                    }
                }

                SetupClientSize();

                this.pnlGroups.ResumeLayout(true);
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


        internal void UpdateData()
        {
            UpdateData(this.Tour);
        }


        private void SetupClientSize()
        {/*
            Int32 height = 0;

            foreach (Control client in this.rptGroups.Controls)
            {
                height += client.Height +
                    this.rptGroups.Margin.Size.Height;

                //Int32 width =
                //    this.ClientRectangle.Width -
                //    this.Margin.Size.Width -
                //    this.rptGroups.Margin.Size.Width;

                //client.Width = width;
                //client.MinimumSize = new Size(width, client.Height);
                //client.MaximumSize = new Size(width, client.Height);
            }*/
            /**/

            Int32 height = 
                this.Tour.Groups.Count * 120 +
                this.tlpTourDetail.Height +
                this.tlpTourDetail.Margin.Size.Height +
                this.Margin.Size.Height +
                this.Padding.Size.Height+
                this.tlpMain.Margin.Size.Height;

            if (this.Height != height)
            {
                this.Height = height;
            }
            //this.pnlGroups.PerformLayout();
        }
    }
}
