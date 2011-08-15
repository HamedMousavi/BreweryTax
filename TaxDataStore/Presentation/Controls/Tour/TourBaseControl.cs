using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public partial class TourBaseControl : UserControl
    {

        public TourBaseControl()
        {
            InitializeComponent();

            if (Presentation.View.Theme != null)
            {
                this.Font = Presentation.View.Theme.TourControlsRegularFont;
            }
        }
    }
}
