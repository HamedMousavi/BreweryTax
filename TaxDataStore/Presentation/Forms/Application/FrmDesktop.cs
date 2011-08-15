using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmDesktop : BaseForm
    {

        protected WorkbenchMessagePad messagePad;
        protected WorkbenchCalendar tourCalendar;
        protected WorkbenchAddressBook addressBook;
        protected WorkbenchWorklog worklog;
        protected WorkbenchFloppy floppy;
        protected WorkbenchReports reports;
        protected WorkbenchSearch search;


        public FrmDesktop()
        {
            InitializeComponent();

            SetupControls();
        }


        private void SetupControls()
        {
            this.SuspendLayout();

            this.Dock = DockStyle.Fill;

            this.messagePad = new WorkbenchMessagePad();
            this.tourCalendar = new WorkbenchCalendar();
            this.addressBook = new WorkbenchAddressBook();
            this.worklog = new WorkbenchWorklog();
            this.floppy = new WorkbenchFloppy();
            this.reports = new WorkbenchReports();
            this.search = new WorkbenchSearch();

            this.tlpMain.Controls.Add(this.reports, 0, 0);
            this.tlpMain.Controls.Add(this.tourCalendar, 1, 0);
            this.tlpMain.Controls.Add(this.floppy, 3, 0);

            //this.tlpMain.Controls.Add(this.search, 0, 1);

            this.tlpMain.Controls.Add(this.messagePad, 0, 3);
            //this.tlpMain.Controls.Add(this.worklog, 1, 3);
            this.tlpMain.Controls.Add(this.addressBook, 3, 3);


            this.tlpMain.SetColumnSpan(this.tourCalendar, 2);
            //this.tlpMain.SetColumnSpan(this.worklog, 2);

            this.tlpMain.SetRowSpan(this.search, 2);
            //this.tlpMain.SetRowSpan(, 2);

            //this.tlpMain.Anchor = AnchorStyles.Top |
            //    AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;

            this.ResumeLayout(false);
        }
    }
}
