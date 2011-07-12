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


        protected ContextMenuStrip addContextMenu;
        public ContextMenuStrip AddContextMenu
        {
            get
            {
                return this.addContextMenu;
            }

            set
            {
                DetachMenu();
                this.addContextMenu = value;
                AttachMenu();
            }
        }


        private void AttachMenu()
        {
            if (this.addContextMenu != null)
            {
                this.addContextMenu.Closing += new
                    ToolStripDropDownClosingEventHandler(addContextMenu_Closing);
            }
        }


        private void DetachMenu()
        {
            if (this.addContextMenu != null)
            {
                this.addContextMenu.Closing -= new
                    ToolStripDropDownClosingEventHandler(addContextMenu_Closing);
            }
        }


        void addContextMenu_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (this.autoHide)
            {
                ShowEditOptions(false);
            }
        }


        private FlatButton btnAdd;
        private FlatButton btnEdit;
        private FlatButton btnDelete;
        private ToolbarLabel lblTitle;


        private bool autoHide;


        public bool ShowAdd { get; set; }
        public bool ShowEdit { get; set; }
        public bool ShowDelete { get; set; }


        public EditToolbar()
        {
            InitializeComponent();

            this.ShowAdd = true;
            this.ShowEdit = true;
            this.ShowDelete = true;
            this.autoHide = true;

            SetupControls();
        }


        public EditToolbar(string title, bool showAdd = true, bool showEdit = true, bool showDelete = true)
            : this()
        {
            this.ShowAdd = showAdd;
            this.ShowEdit = showEdit;
            this.ShowDelete = showDelete;

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

            this.btnAdd.Click += new EventHandler(OnButtonClick);
            this.btnDelete.Click += new EventHandler(OnButtonClick);
            this.btnEdit.Click += new EventHandler(OnButtonClick);

            this.Disposed += new EventHandler(EditToolbar_Disposed);
            AttachMouseEvents(this);
        }


        void OnButtonClick(object sender, EventArgs e)
        {
            if (sender == this.btnAdd && this.AddContextMenu != null)
            {
                this.AddContextMenu.Show(
                    this.btnAdd,
                    new Point(this.btnAdd.Location.X, this.btnAdd.Height),
                    ToolStripDropDownDirection.BelowLeft);
            }
            else if (this.autoHide)
            {
                ShowEditOptions(false);
            }
        }


        void EditToolbar_Disposed(object sender, EventArgs e)
        {
            DetachMouseEvents(this);

            this.btnAdd.Click -= new EventHandler(OnButtonClick);
            this.btnDelete.Click -= new EventHandler(OnButtonClick);
            this.btnEdit.Click -= new EventHandler(OnButtonClick);
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
                    if (this.addContextMenu != null && this.addContextMenu.Visible)
                    {
                    }
                    else
                    {
                        ShowEditOptions(false);
                    }
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
            this.btnAdd.Visible = show & this.ShowAdd;
            this.btnEdit.Visible = show & this.ShowEdit;
            this.btnDelete.Visible = show & this.ShowDelete;
        }
    }
}
