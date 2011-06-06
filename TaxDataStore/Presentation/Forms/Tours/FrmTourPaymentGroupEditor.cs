using System;
using System.Windows.Forms;


namespace TaxDataStore
{

    public partial class FrmTourPaymentGroupEditor : Form
    {

        protected Entities.TourPaymentGroup group;
        protected Entities.TourPaymentGroup editGroup;


        public FrmTourPaymentGroupEditor()
        {
            InitializeComponent();

            this.group = new Entities.TourPaymentGroup();

            SetupControls();
            BindControls();
        }


        public FrmTourPaymentGroupEditor(Entities.TourPaymentGroup group = null)
            : this()
        {
            group.CopyTo(this.group);
            this.editGroup = group;
        }


        private void SetupControls()
        {
            this.Text = Resources.Texts.frm_title_tour_payment_group_editor;

            this.lblGroupName.Text = Resources.Texts.lbl_tour_group_name;
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

            if (DomainModel.TourPaymentGroups.Save(this.group))
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
