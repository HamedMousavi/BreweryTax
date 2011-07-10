using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmGroupServiceEditor : Form
    {

        protected GroupServiceDetails ctrlDetails;
        private Entities.GeneralType serviceType;


        public FrmGroupServiceEditor()
        {
            InitializeComponent();

            this.ctrlDetails = new GroupServiceDetails();
            this.tpgDetails.Controls.Add(this.ctrlDetails);
        }


        public FrmGroupServiceEditor(Entities.GeneralType serviceType)
            : this()
        {
        }
    }
}
