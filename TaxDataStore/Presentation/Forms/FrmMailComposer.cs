using System;
using System.Windows.Forms;
using Entities;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmMailComposer : BaseForm
    {

        private readonly Mail _mail;
        private readonly UsersCheckedListBox _chlbxRecipients;


        public FrmMailComposer()
        {
            InitializeComponent();

            _chlbxRecipients = new UsersCheckedListBox {Dock = DockStyle.Fill};
            tlpContent.Controls.Add(_chlbxRecipients, 2, 0);
            tlpContent.SetRowSpan(_chlbxRecipients, 3);

            _mail = new Mail();
            tbxTitle.DataBindings.Add(
                    new Binding(
                        "Text",
                        _mail,
                        "Title",
                        false,
                        DataSourceUpdateMode.OnValidation,
                        string.Empty,
                        string.Empty,
                        null));

            tbxContent.DataBindings.Add(
                    new Binding(
                        "Text",
                        _mail,
                        "Text",
                        false,
                        DataSourceUpdateMode.OnValidation,
                        string.Empty,
                        string.Empty,
                        null));
        }


        private void BtnSendClick(object sender, EventArgs e)
        {
            if (DomainModel.Mails.Send(_mail, _chlbxRecipients.SelectedUsers))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }


        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
