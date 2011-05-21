using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace TaxDataStore
{

    public partial class FrmMain : Form
    {

        public Presentation.SccreenManager ScreenManager { get; private set; }
        public Presentation.Controls.Toolbar ToolBar { get; private set; }
        public Presentation.Controls.Menubar MenuBar { get; private set; }
        public Presentation.Controls.Statusbar StatusBar { get; private set; }
        public Presentation.ClientFormManager ClientFormManager { get; private set; }


        public FrmMain()
        {
            InitializeComponent();

            SetupMainWindow();
            SetupMenuBar();
            SetupToolBar();
            SetupStatusBar();
            SetupFormManager();
        }



        private void SetupMainWindow()
        {
            this.Text = Resources.Texts.app_name;
            Presentation.View.MainWindow = this;

            this.ScreenManager = new Presentation.SccreenManager();
            //this.ScreenManager.Attach(this, DomainModel.Application.User);
        }


        private void SetupMenuBar()
        {
            this.MenuBar = new Presentation.Controls.Menubar();
            this.barsHolder.TopToolStripPanel.Controls.Add(this.MenuBar);
        }


        private void SetupToolBar()
        {
        }


        private void SetupStatusBar()
        {
        }


        private void SetupFormManager()
        {
            this.ClientFormManager = new Presentation.ClientFormManager();
            this.ClientFormManager.Attach(this.barsHolder.ContentPanel);
        }

    }
}
