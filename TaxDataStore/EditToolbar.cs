﻿using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class EditToolbar : UserControl
    {

        private FlatButton btnAdd;
        private FlatButton btnEdit;
        private FlatButton btnDelete;
        private ToolbarLabel lblTitle;


        public EditToolbar()
        {
            InitializeComponent();

            SetupControls();
        }

        public EditToolbar(string title, bool showAdd = true, bool showEdit = true, bool showDelete = true)
            : this()
        {
            this.btnAdd.Visible = showAdd;
            this.btnDelete.Visible = showDelete;
            this.btnEdit.Visible = showEdit;
            this.lblTitle.Text = title;
        }


        private void SetupControls()
        {
            this.lblTitle = new ToolbarLabel(0, "lblTitle", "title");
            this.btnAdd = new FlatButton(1, "btnAdd", "add", "");
            this.btnEdit =      new FlatButton(2, "btnEdit", "pencil", "");
            this.btnDelete =    new FlatButton(3, "btnDelete", "delete", "");

            this.tlpMain.Controls.Add(this.lblTitle, 0, 0);
            this.tlpMain.Controls.Add(this.btnAdd, 1, 0);
            this.tlpMain.Controls.Add(this.btnEdit, 2, 0);
            this.tlpMain.Controls.Add(this.btnDelete, 3, 0);
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
