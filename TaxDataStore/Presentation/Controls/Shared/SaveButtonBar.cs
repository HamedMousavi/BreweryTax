using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public partial class SaveButtonBar : UserControl
    {

        public SaveButtonBar()
        {
            InitializeComponent();

            this.btnSave.Text = Resources.Texts.save;
            this.btnCancel.Text = Resources.Texts.cancel;

        }


        public event EventHandler SaveButtonClick
        {
            add
            {
                this.btnSave.Click += value;
            }

            remove
            {
                this.btnSave.Click -= value;
            }
        }


        public event EventHandler CancelButtonClick
        {
            add
            {
                this.btnCancel.Click += value;
            }

            remove
            {
                this.btnCancel.Click -= value;
            }
        }



    }
}
