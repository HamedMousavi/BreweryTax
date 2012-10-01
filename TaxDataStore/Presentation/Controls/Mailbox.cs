using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public sealed partial class Mailbox : UserControl
    {

        private readonly MailsListView _lsvMails;
        private readonly BindingSource _bindingSource;


        public object DataSource
        {
            get
            {
                return _bindingSource.DataSource;
            }

            set
            {
                if (value != null && value != _bindingSource.DataSource)
                {
                    _bindingSource.DataSource = value;
                }

                lblTile.DataBindings.Clear();
                lblTile.DataBindings.Add(new Binding("Text", _bindingSource, "Title", false, DataSourceUpdateMode.OnPropertyChanged, string.Empty, string.Empty, null));

                tbxContent.DataBindings.Clear();
                tbxContent.DataBindings.Add(new Binding("Text", _bindingSource, "Text", false, DataSourceUpdateMode.OnPropertyChanged, string.Empty, string.Empty, null));

                _lsvMails.SetBinding(_bindingSource);
            }
        }

        
        public Mailbox()
        {
            InitializeComponent();

            _bindingSource = new BindingSource();
            
            if (View.Theme != null)
            {
                BackColor = View.Theme.GroupPanelBackColor;
                //this.tlpMain.BackColor = Presentation.View.Theme.GroupPanelBackColor;
            }
            tlpContent.BackColor = System.Drawing.SystemColors.Window;

            _lsvMails = new MailsListView();
            tlpMails.Controls.Add(_lsvMails, 0, 1);

            etbMail.AddButtonClick += etbMail_AddButtonClick;
            etbMail.DeleteButtonClick += etbMail_DeleteButtonClick;

            etbMailList.AddButtonClick += etbMailList_AddButtonClick;
        }


        void etbMailList_AddButtonClick(object sender, System.EventArgs e)
        {
            Presentation.Controllers.Mails.Compose();
        }


        void etbMail_DeleteButtonClick(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        void etbMail_AddButtonClick(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
