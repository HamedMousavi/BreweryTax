using System.Windows.Forms;
using System.Reflection;


namespace TaxDataStore
{

    public partial class FrmSplashScreen : Form
    {

        public FrmSplashScreen()
        {
            InitializeComponent();

            this.lblVersionNumber.Text = 
                Assembly.GetExecutingAssembly().GetName().Version.ToString();

            this.pbxAppIcon.Image = Resources.Images.beer;
            this.lblAppName.Text = Resources.Texts.app_name;
            this.lblLoading.Text = Resources.Texts.lbl_app_loading;
        }
    }
}
