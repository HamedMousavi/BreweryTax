﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Entities.Abstract;


namespace TaxDataStore
{

    public partial class TourServiceItem : UserControl
    {

        public ITourService Service { get; set; }

        protected Dictionary<string, Image> images;


        public TourServiceItem(ITourService service)
        {
            InitializeComponent();

            this.Service = service;

            SetupControls();
            CreateImages();
            BindControls(service);
        }


        private void SetupControls()
        {
            if (Presentation.View.Theme != null)
            {
                this.BackColor = Presentation.View.Theme.TourGroupItemBackColor;
                this.lblServiceCount.Font = Presentation.View.Theme.TourGroupServiceCountFont;
                this.lblServiceType.Font = Presentation.View.Theme.TourGroupServiceNameFont;
                this.lblServiceCount.ForeColor = Presentation.View.Theme.TourGroupServiceCountForeColor;
                this.lblServiceType.ForeColor = Presentation.View.Theme.TourGroupServiceNameForeColor;
            }
        }


        private void CreateImages()
        {
            this.images = new Dictionary<string, Image>();
            this.images.Add("visit", DomainModel.Application.ResourceManager.GetImage("bucket"));
            this.images.Add("drink", DomainModel.Application.ResourceManager.GetImage("bottle"));
        }


        private void BindControls(ITourService service)
        {
            service.PropertyChanged += new PropertyChangedEventHandler(service_PropertyChanged);
            UpdateService(service);
        }


        void service_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (string.Equals(e.PropertyName, "ClientCount", System.StringComparison.InvariantCulture) ||
                string.Equals(e.PropertyName, "Type", System.StringComparison.InvariantCulture))
            {
                UpdateService((ITourService)sender);
            }
        }


        private void UpdateService(ITourService service)
        {
            this.lblServiceType.Text = service.Name;
            this.lblServiceCount.Text = service.ClientCount.ToString();
            this.pbxServiceType.Image = GetServiceImage(service);
        }


        private Image GetServiceImage(ITourService service)
        {
            switch (service.Detail.ServiceType.Id)
            {
                case 19: // Visit
                    return this.images["visit"];

                case 20: // Drink
                    return this.images["drink"];
            }

            return null;
        }


        internal void UpdateData()
        {
             UpdateService(this.Service);
        }
    }
}