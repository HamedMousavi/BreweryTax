using System;
using System.Windows.Forms;


namespace TaxDataStore
{

    public partial class EditToolbar : UserControl
    {

        public EditToolbar()
        {
            InitializeComponent();
        }

        public EditToolbar(string title, bool showAdd = true, bool showEdit = true, bool showDelete = true)
            : this()
        {
            this.btnAdd.Visible = showAdd;
            this.btnDelete.Visible = showDelete;
            this.btnEdit.Visible = showEdit;
            this.lblTitle.Text = title;

            SetupControls();
        }


        private void SetupControls()
        {
            if (DomainModel.Application.ResourceManager != null)
            {
                this.btnAdd.Text = DomainModel.Application.ResourceManager.GetText("add");
                this.btnDelete.Text = DomainModel.Application.ResourceManager.GetText("delete");
                this.btnEdit.Text = DomainModel.Application.ResourceManager.GetText("edit");

                this.btnAdd.Image = DomainModel.Application.ResourceManager.GetImage("add");
                this.btnDelete.Image = DomainModel.Application.ResourceManager.GetImage("delete");
                this.btnEdit.Image = DomainModel.Application.ResourceManager.GetImage("pencil");
            }
        }


        public event EventHandler AddButtonClick
        {
            add
            {
                this.btnAdd.Click += value;
            }

            remove
            {
                this.btnAdd.Click -= value;
            }
        }


        public event EventHandler DeleteButtonClick
        {
            add
            {
                this.btnDelete.Click += value;
            }

            remove
            {
                this.btnDelete.Click -= value;
            }
        }


        public event EventHandler EditButtonClick
        {
            add
            {
                this.btnEdit.Click += value;
            }

            remove
            {
                this.btnEdit.Click -= value;
            }
        }


        public string Title
        {
            get
            {
                return this.lblTitle.Text;
            }

            set
            {
                this.lblTitle.Text = value;
            }
        }
    }
}
