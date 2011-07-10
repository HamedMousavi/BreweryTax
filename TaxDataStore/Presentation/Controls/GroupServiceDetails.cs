using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace TaxDataStore.Presentation.Controls
{
    
    public partial class GroupServiceDetails : UserControl
    {

        Entities.TourServiceBase service;
        
        private FormLabel lblServiceType;
        protected ComboBox cbxServiceTypes;

        private FormLabel lblserved;
        protected TourCostDetailsGridView dgvServedMembers;


        public GroupServiceDetails()
        {
            InitializeComponent();

            this.service = new Entities.TourServiceBase();

            SetupControls();
        }


        private void SetupControls()
        {
            this.Dock = DockStyle.Fill;

            this.lblServiceType = new FormLabel(0, "lblServiceType", false, "lbl_tour_type");
            this.lblserved = new FormLabel(1, "lblCostMembers", false, "lbl_served");

            this.cbxServiceTypes = new ComboBox();
            this.cbxServiceTypes.Anchor = AnchorStyles.Top |
                AnchorStyles.Left | AnchorStyles.Right;


            this.dgvServedMembers = new TourCostDetailsGridView(this.service.CostDetails);

            this.tlpMain.Controls.Add(this.lblServiceType, 0, 0);
            this.tlpMain.Controls.Add(this.cbxServiceTypes, 1, 0);
            this.tlpMain.Controls.Add(this.lblserved, 0, 1);
            this.tlpMain.Controls.Add(this.dgvServedMembers, 0, 2);

            this.tlpMain.SetColumnSpan(this.dgvServedMembers, 2);
        }
    }
}
