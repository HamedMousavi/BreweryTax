using System.Windows.Forms;
using System.ComponentModel;


namespace TaxDataStore.Presentation.Controls
{

    public partial class JobProgress : UserControl
    {

        protected Entities.JobProgress job;
        protected AsyncCalls appUpdAsyncHelper;


        public JobProgress(Entities.JobProgress Progress)
        {
            InitializeComponent();

            this.appUpdAsyncHelper = new AsyncCalls();

            job = Progress;
            if (job != null)
            {
                job.PropertyChanged += new PropertyChangedEventHandler(job_PropertyChanged);
            }
        }


        void job_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Entities.JobProgress progress = (Entities.JobProgress)sender;
            Update(progress);
        }


        private delegate void UpdateDelegate(Entities.JobProgress info);
        private void Update(Entities.JobProgress info)
        {
            // Ensure inside UI thread
            if (!this.appUpdAsyncHelper.Execute(
                this, new UpdateDelegate(Update), info)) return;

            if (this.InvokeRequired) return;

            switch (info.Status)
            {
                case Entities.JobProgress.JobStatus.InProgress:
                    if(!this.Visible) this.Visible = true;
                    break;

                case Entities.JobProgress.JobStatus.Idle:
                case Entities.JobProgress.JobStatus.Done:
                    if (this.Visible) this.Visible = false;
                    break;
            }

            this.lblJobName.Text = info.JobName;
            this.pgsMainBar.Value = info.Percent;
            Application.DoEvents();
        }
    }
}
