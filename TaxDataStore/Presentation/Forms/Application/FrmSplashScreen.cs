using System.Windows.Forms;
using System.Reflection;


namespace TaxDataStore
{

    public partial class FrmSplashScreen : Form
    {

        public FrmSplashScreen()
        {
            InitializeComponent();

            this.Text = Resources.Texts.app_name;


            this.lblAppName.Text = Resources.Texts.app_name;
            this.lblLoading.Text = Resources.Texts.lbl_app_loading;
            this.lblVersionNumber.Text = Assembly.GetExecutingAssembly().
                GetName().Version.ToString();

            this.pbxAppIcon.Image = Resources.Images.beer;
            //this.pbxLoading.Image = Resources.Images.loading;
        }
    }
}
