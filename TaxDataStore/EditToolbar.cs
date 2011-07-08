using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;
using System.Drawing;


namespace TaxDataStore
{

    public partial class EditToolbar : UserControl
    {

        public bool ButtonAutohide 
        {
            get { return this.autoHide; }
            set
            {
                if (this.autoHide != value)
                {
                    this.autoHide = value;
                    ShowEditOptions(!this.autoHide);
                }
            }
        }


        private FlatButton btnAdd;
        private FlatButton btnEdit;
        private FlatButton btnDelete;
        private ToolbarLabel lblTitle;


        private bool autoHide;
        private bool showAdd;
        private bool showEdit;
        private bool showDelete;


        public EditToolbar()
        {
            InitializeComponent();

            this.showAdd = true;
            this.showEdit = true;
            this.showDelete = true;
            this.autoHide = true;

            SetupControls();
        }


        public EditToolbar(string title, bool showAdd = true, bool showEdit = true, bool showDelete = true)
            : this()
        {
            this.showAdd = showAdd;
            this.showEdit = showEdit;
            this.showDelete = showDelete;

            this.lblTitle.Text = title;
        }


        private void SetupControls()
        {
            this.Name = "EditToolbar";

            this.lblTitle = new ToolbarLabel(0, "lblTitle", "title");
            this.btnAdd = new FlatButton(1, "btnAdd", "add", "");
            this.btnEdit = new FlatButton(2, "btnEdit", "pencil", "");
            this.btnDelete = new FlatButton(3, "btnDelete", "delete", "");

            this.tlpMain.Controls.Add(this.lblTitle, 0, 0);
            this.tlpMain.Controls.Add(this.btnAdd, 1, 0);
            this.tlpMain.Controls.Add(this.btnEdit, 2, 0);
            this.tlpMain.Controls.Add(this.btnDelete, 3, 0);

            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            if (Presentation.View.Theme != null)
            {
                this.lblTitle.ForeColor = Presentation.View.Theme.TourForeColor;
            }
            ShowEditOptions(false);

            this.PerformLayout();

            this.Disposed += new EventHandler(EditToolbar_Disposed);
            AttachMouseEvents(this);
        }


        void EditToolbar_Disposed(object sender, EventArgs e)
        {
            DetachMouseEvents(this);
        }


        private void AttachMouseEvents(Control child)
        {
            foreach (Control ctrl in child.Controls)
            {
                AttachMouseEvents(ctrl);
            }

            child.MouseEnter += new EventHandler(OnMouseEnter);
            child.MouseLeave += new EventHandler(OnMouseLeave);
        }


        private void DetachMouseEvents(Control child)
        {
            foreach (Control ctrl in child.Controls)
            {
                DetachMouseEvents(ctrl);
            }

            child.MouseEnter -= new EventHandler(OnMouseEnter);
            child.MouseLeave -= new EventHandler(OnMouseLeave);
        }


        void OnMouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(
                    this.PointToClient(Control.MousePosition)))
            {
                if (this.autoHide)
                {
                    ShowEditOptions(false);
                }
            }
        }


        void OnMouseEnter(object sender, EventArgs e)
        {
            ShowEditOptions(true);
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


        internal void ShowEditOptions(bool show)
        {
            this.btnAdd.Visible = show & this.showAdd;
            this.btnEdit.Visible = show & this.showEdit;
            this.btnDelete.Visible = show & this.showDelete;
        }
    }
}
