using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmTourEditor : BaseForm
    {

        private FormLabel lblDate;
        private FormLabel lblTime;
        private FormLabel lblComments;
        private RichTextBox rtbComments;

        private DateTimePicker dtpDate;
        private DateTimePicker dtpTime;

        protected Entities.Tour tour;
        protected Entities.Tour editTour;
        

        public FrmTourEditor()
        {
            InitializeComponent();

            CreateControls();
            SetupControls();
            BindControls();
        }


        private void CreateControls()
        {
            this.lblDate = new FormLabel(0, "lblDate", false, "lbl_date");
            this.lblTime = new FormLabel(2, "lblTime", false, "lbl_time");
            this.lblComments = new FormLabel(4, "lblComments", false, "lbl_comments");

            this.dtpDate = new DateTimePicker();
            this.dtpDate.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
                        | AnchorStyles.Right)));
            this.dtpDate.Format = DateTimePickerFormat.Short;
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.TabIndex = 1;

            this.dtpTime = new DateTimePicker();
            this.dtpTime.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
                        | AnchorStyles.Right)));
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = DateTimePickerFormat.Custom;
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.TabIndex = 3;

            this.rtbComments = new RichTextBox();
            this.rtbComments.BorderStyle = BorderStyle.FixedSingle;
            this.rtbComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.TabIndex = 5;
            this.rtbComments.Text = "";

            this.tlpMain.Controls.Add(this.lblDate, 0, 1);
            this.tlpMain.Controls.Add(this.dtpDate, 1, 1);
            this.tlpMain.Controls.Add(this.lblTime, 0, 2);
            this.tlpMain.Controls.Add(this.dtpTime, 1, 2);
            this.tlpMain.Controls.Add(this.lblComments, 0, 3);
            this.tlpMain.Controls.Add(this.rtbComments, 1, 3);
        }


        public FrmTourEditor(Entities.Tour editTour)
            : this()
        {
            this.editTour = editTour;
            if (editTour != null)
            {
                this.editTour.CopyTo(this.tour);
            }
        }


        public FrmTourEditor(DateTime? date)
            : this()
        {
            if (date != null && date.HasValue)
            {
                this.tour.Time.Date = date.Value.Date;
            }
        }


        private void SetupControls()
        {
            SetupControlTexts();
        }


        private void SetupControlTexts()
        {
            this.Text = Resources.Texts.frm_title_tour_editor;

            this.btnSave.Text = Resources.Texts.save;
            this.btnCancel.Text = Resources.Texts.cancel;
        }


        private void BindControls()
        {
            this.tour = new Entities.Tour();
            
            this.dtpTime.DataBindings.Add(
                new Binding(
                    "Value",
                    this.tour.Time,
                    "Time",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));

            this.dtpDate.DataBindings.Add(
                new Binding(
                    "Value",
                    this.tour.Time,
                    "Date",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));


            this.rtbComments.DataBindings.Add(
                new Binding(
                    "Text",
                    this.tour,
                    "Comments",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    0.00M,
                    string.Empty,
                    null));
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool res = false;

            if (this.editTour != null)
            {
                // Update edit user and database
                this.tour.CopyTo(this.editTour);
                res = DomainModel.Tours.Save(this.editTour);
            }
            else
            {
                res = DomainModel.Tours.Save(this.tour);
            }

            if (res)
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
