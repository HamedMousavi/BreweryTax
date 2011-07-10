using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmServiceSettingEditor : BaseForm
    {
        private FormLabel lblServiceType;
        private FormLabel lblServicePrice;
        private FormLabel lblServiceName;

        protected MoneyPicker mpkBasePrice;
        protected ComboBox cbxServiceTypes;
        protected TextBox tbxServiceName;


        private Entities.Service service;


        public FrmServiceSettingEditor(Entities.Service service)
            : this()
        {
            this.service = service;
            BindControls();
        }


        public FrmServiceSettingEditor()
        {
            InitializeComponent();

            CreateControls();
            SetupControls();
            BindControls();
        }


        private void CreateControls()
        {
            this.lblServiceType = new FormLabel(0, "lblServiceType", false, "lbl_tour_type");
            this.lblServiceName = new FormLabel(1, "lblServiceName", false, "lbl_service_name");
            this.lblServicePrice = new FormLabel(2, "lblServicePrice", false, "lbl_price");

            this.cbxServiceTypes = new ComboBox();
            this.tbxServiceName = new TextBox();
            this.mpkBasePrice = new MoneyPicker();
        }


        private void SetupControls()
        {
            this.mpkBasePrice.Anchor = AnchorStyles.Top | 
                AnchorStyles.Left | AnchorStyles.Right;

            this.cbxServiceTypes.Anchor = AnchorStyles.Top |
                AnchorStyles.Left | AnchorStyles.Right;

            this.tbxServiceName.Anchor = AnchorStyles.Top |
                AnchorStyles.Left | AnchorStyles.Right;

            this.tlpMain.Controls.Add(this.lblServiceType, 0, 0);
            this.tlpMain.Controls.Add(this.cbxServiceTypes, 1, 0);
            this.tlpMain.Controls.Add(this.lblServiceName, 0, 1);
            this.tlpMain.Controls.Add(this.tbxServiceName, 1, 1);
            this.tlpMain.Controls.Add(this.lblServicePrice, 0, 2);
            this.tlpMain.Controls.Add(this.mpkBasePrice, 1, 2);

            this.Text = Resources.Texts.frm_title_base_price_editor;

        }


        private void BindControls()
        {
            this.cbxServiceTypes.DataSource = DomainModel.ServiceTypes.GetAll();

            SetControlData();

            this.sbbMain.SaveButtonClick += new EventHandler(sbbMain_SaveButtonClick);
            this.sbbMain.CancelButtonClick += new EventHandler(sbbMain_CancelButtonClick);
        }


        void sbbMain_CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }


        void sbbMain_SaveButtonClick(object sender, EventArgs e)
        {
            GetControlData();

            if (DomainModel.Services.Save(this.service))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }


        private void SetControlData()
        {
            if (this.service != null)
            {
                this.tbxServiceName.Text = this.service.Name;
                this.cbxServiceTypes.SelectedItem = this.service.ServiceType;
                this.mpkBasePrice.Value.Currency = this.service.PricePerPerson.Currency;
                this.mpkBasePrice.ValueEditor = Convert.ToString(this.service.PricePerPerson.Value);
            }
        }


        private void GetControlData()
        {
            if (this.service == null)
            {
                this.service = new Entities.Service();
            }

            this.service.Name = this.tbxServiceName.Text;
            this.service.PricePerPerson.Value = this.mpkBasePrice.Value.Value;
            this.service.PricePerPerson.Currency = this.mpkBasePrice.Value.Currency;
            this.service.ServiceType = (Entities.GeneralType)
                this.cbxServiceTypes.SelectedItem;
        }
    }
}
