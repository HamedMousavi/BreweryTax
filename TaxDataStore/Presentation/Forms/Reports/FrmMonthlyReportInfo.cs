using System;
using System.Windows.Forms;
using Entities;


namespace TaxDataStore
{

    public partial class FrmMonthlyReportInfo : Form
    {

        public FrmMonthlyReportInfo(ReportInfo info)
        {
            InitializeComponent();

            this.tbxDestination.DataBindings.Add(
                new Binding(
                    "Text",
                    info,
                    "Path",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));
        
            this.dtpStartDate.DataBindings.Add(
                new Binding(
                    "Value",
                    info,
                    "StartTime",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    DateTime.Now,
                    string.Empty,
                    null));

            this.dtpEndDate.DataBindings.Add(
                new Binding(
                    "Value",
                    info,
                    "EndTime",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    DateTime.Now,
                    string.Empty,
                    null));

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string path = DomainModel.Application.Settings.DefaultReportPath +
                System.IO.Path.DirectorySeparatorChar +
                GenerateFileName();

            path = Presentation.Controllers.
                File.BrowseSave("Excel Files (*.xls)|*.xls", path);

            if (!string.IsNullOrEmpty(path))
            {
                this.tbxDestination.Text = path;
            }
            else return;

            /*
        if (System.IO.File.Exists(path))
            {
                int overwrite = Presentation.Controllers.
                    MessageBox.ConfirmOverWrite();
                if (overwrite == 0)
                {
                    return;
                }
                else if (overwrite == 2)
                {
                    path = string.Empty;
                    goto BrowseNewPath;
                }
            }*/

            //DomainModel.Repository.Meter.Document.Save(View.Document);
        }


        private string GenerateFileName()
        {
            return string.Format("MonthlyBill-{0} {1}-{2}", 
                DateTime.Now.Year,
                this.dtpStartDate.Value.ToString("MMMM"),
                this.dtpEndDate.Value.ToString("MMMM"));
        }
    }
}
