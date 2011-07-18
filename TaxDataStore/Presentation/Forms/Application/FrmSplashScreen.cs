using System.Windows.Forms;
using System.Reflection;


namespace TaxDataStore
{

    public partial class FrmSplashScreen : BaseForm
    {

        protected Presentation.Controls.JobProgress progressBar;

        public FrmSplashScreen()
        {
            InitializeComponent();

            this.Text = Resources.Texts.app_name;


            this.lblAppName.Text = Resources.Texts.app_name;
            this.lblLoading.Text = Resources.Texts.lbl_app_loading;
            this.lblVersionNumber.Text = Assembly.GetExecutingAssembly().
                GetName().Version.ToString();

            this.pbxAppIcon.Image = Resources.Images.app_big;
            //this.pbxLoading.Image = Resources.Images.loading;
        }

        
        public Entities.JobProgress Progress
        {
            set
            {
                if (value != null)
                {
                    this.progressBar = new Presentation.Controls.JobProgress(value);
                    this.tlpControls.Controls.Add(this.progressBar, 0, 4);
                    this.tlpControls.SetColumnSpan(this.progressBar, 2);
                    this.progressBar.Visible = true;
                }
            }
        }
    }
}
