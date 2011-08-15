using System;
using System.Windows.Forms;
using Entities;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmMailBox : BaseForm
    {

        private MailCollection _todayMails;


        public FrmMailBox()
        {
            InitializeComponent();

            //this.tlpMain.BackColor = this.BackColor;
            tlpMain.Controls.Add(new WorkbenchViewButton(), 1, 0);

            tabMain.ImageList = new ImageList();
            tabMain.ImageList.Images.Add(DomainModel.Application.ResourceManager.GetImage("mail"));
            tabMain.ImageList.Images.Add(DomainModel.Application.ResourceManager.GetImage("mails_stack"));

            tbpToday.ImageIndex = 0;
            tbpAll.ImageIndex = 1;

            _todayMails = new MailCollection();
            this.mbxToday.DataSource = _todayMails;

            // UNDONE: Do this in a thread
            DomainModel.Mails.LoadByDate(DateTime.Now, _todayMails);
        }
    }
}
