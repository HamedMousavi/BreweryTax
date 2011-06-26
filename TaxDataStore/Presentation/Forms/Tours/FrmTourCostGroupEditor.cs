using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmTourCostGroupEditor : BaseForm
    {
        private FormLabel lblGroupName;

        protected Entities.TourCostGroup group;
        protected Entities.TourCostGroup editGroup;


        public FrmTourCostGroupEditor()
        {
            InitializeComponent();

            this.group = new Entities.TourCostGroup();
            CreateControls();
            SetupControls();
            BindControls();
        }


        private void CreateControls()
        {
            this.lblGroupName = new FormLabel(0, "lblGroupName", false, "lbl_tour_group_name");
            this.tlpMain.Controls.Add(this.lblGroupName, 0, 1);
        }


        public FrmTourCostGroupEditor(Entities.TourCostGroup group = null)
            : this()
        {
            group.CopyTo(this.group);
            this.editGroup = group;
        }


        private void SetupControls()
        {
            this.Text = Resources.Texts.frm_title_tour_Cost_group_editor;

            this.btnSave.Text = Resources.Texts.save;
            this.btnCancel.Text = Resources.Texts.cancel;
        }


        private void BindControls()
        {
            this.tbxGroupName.DataBindings.Add(new Binding(
                "Text",
                this.group,
                "Name",
                false,
                DataSourceUpdateMode.OnPropertyChanged,
                string.Empty,
                string.Empty,
                null));
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.editGroup != null)
            {
                this.group.CopyTo(this.editGroup);
            }

            if (DomainModel.TourCostGroups.Save(this.group))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
