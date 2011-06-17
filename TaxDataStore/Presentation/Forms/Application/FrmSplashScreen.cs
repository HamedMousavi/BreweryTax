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
        }
    }
}
