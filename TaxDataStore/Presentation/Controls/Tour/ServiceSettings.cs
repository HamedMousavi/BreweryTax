using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public partial class ServiceSettings : UserControl
    {

        protected FlatGridView dgvServices;
        protected EditToolbar etbServices;

        
        public ServiceSettings()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            if (Presentation.View.Theme != null)
            {
                this.BackColor = Presentation.View.Theme.GroupPanelBackColor;
                this.tlpMain.BackColor = Presentation.View.Theme.GroupPanelBackColor;
            }

            this.dgvServices = new FlatGridView();
            this.dgvServices.ColumnHeadersVisible = false;
            this.dgvServices.SetDataSource(DomainModel.Services.GetAll());
            GeneralTypeDataGridViewColumn col =
                new GeneralTypeDataGridViewColumn(
                    DomainModel.ServiceTypes.GetAll(),
                    false,
                    "ServiceType");
            this.dgvServices.Columns.Add(col);
            this.dgvServices.Font = Presentation.View.Theme.FormLabelFont;

            this.etbServices = new EditToolbar(
                DomainModel.Application.ResourceManager.GetText("lbl_services")
                );
            this.etbServices.ButtonAutohide = false;

            this.tlpMain.Controls.Add(this.etbServices, 0, 0);
            this.tlpMain.Controls.Add(this.dgvServices, 0, 1);

            this.etbServices.AddButtonClick += new System.EventHandler(etbServices_AddButtonClick);
            this.etbServices.EditButtonClick += new System.EventHandler(etbServices_EditButtonClick);
            this.etbServices.DeleteButtonClick += new System.EventHandler(etbServices_DeleteButtonClick);
        }


        void etbServices_DeleteButtonClick(object sender, System.EventArgs e)
        {
            DeleteCurrentService();
        }


        void etbServices_EditButtonClick(object sender, System.EventArgs e)
        {
            EditCurrentService();
        }


        void etbServices_AddButtonClick(object sender, System.EventArgs e)
        {
            AddNewService();
        }


        private void EditCurrentService()
        {
            Entities.Service service =
                (Entities.Service)this.dgvServices.SelectedItem;
            
            Presentation.Controllers.TourServices.Edit(service);
        }


        private void DeleteCurrentService()
        {
            Entities.Service service =
                (Entities.Service)this.dgvServices.SelectedItem;

            Presentation.Controllers.TourServices.Delete(service);
        }


        private void AddNewService()
        {
            Presentation.Controllers.TourServices.AddNew();
        }
    }
}
