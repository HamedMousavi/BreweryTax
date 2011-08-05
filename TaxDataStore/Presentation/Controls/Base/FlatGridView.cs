using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;


namespace TaxDataStore.Presentation.Controls
{

    public class FlatGridView : DataGridView
    {

        public BindingSource BindingSource
        {
            get
            {
                return this.bs;
            }

            set
            {
                this.bs = value;
                this.DataSource = this.bs;
            }
        }
        public List<string> HiddenColumnNames { get { return this.hiddenColumnNames; } }

        protected BindingSource bs;
        protected DataGridViewCellStyle headerCellStyle;
        protected DataGridViewCellStyle defaultCellStyle;
        protected List<string> hiddenColumnNames;
        protected List<string> readonlyColumnNames;
        protected Dictionary<string, string> headerColumnNames;


        public FlatGridView(bool bReadonly = true, bool bRowSelect = true, BindingSource binding = null)
            : base()
        {
            Color headTextColor = Color.Gray;
            Color headBkColor = Color.White;

            Color bkColor = Color.White;
            Color textColor = Color.Black;

            Color selectedTextColor = Color.White;
            Color selectedBkColor = Color.CornflowerBlue;

            this.headerCellStyle = new DataGridViewCellStyle();

            this.headerCellStyle.ForeColor = headTextColor;
            this.headerCellStyle.BackColor = headBkColor;
            this.headerCellStyle.SelectionBackColor = headBkColor;
            this.headerCellStyle.SelectionForeColor = headTextColor;

            this.headerCellStyle.Font = new Font("Tahoma", 10.25F, FontStyle.Bold);
            this.headerCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.headerCellStyle.WrapMode = DataGridViewTriState.True;

            this.ColumnHeadersDefaultCellStyle = this.headerCellStyle;
            this.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;


            this.defaultCellStyle = new DataGridViewCellStyle();

            this.defaultCellStyle.ForeColor = textColor;
            this.defaultCellStyle.BackColor = bkColor;
            this.defaultCellStyle.SelectionBackColor = selectedBkColor;
            this.defaultCellStyle.SelectionForeColor = selectedTextColor;

            this.defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.defaultCellStyle.Font = new Font("Tahoma", 9.25F, FontStyle.Regular);
            this.defaultCellStyle.WrapMode = DataGridViewTriState.False;

            this.DefaultCellStyle = this.defaultCellStyle;

            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.RowHeadersVisible = false;

            this.RightToLeft = View.LayoutDirection;

            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.AutoGenerateColumns = true;

            this.BackgroundColor = Color.White;
            this.GridColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            this.EditMode = DataGridViewEditMode.EditOnEnter;
            this.EnableHeadersVisualStyles = false;
            this.MultiSelect = false;
            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 0);
            this.Size = new Size(100, 100);
            this.ReadOnly = bReadonly;

            this.SelectionMode = bRowSelect ?
                DataGridViewSelectionMode.FullRowSelect :
                DataGridViewSelectionMode.CellSelect;

            this.hiddenColumnNames = new List<string>();
            this.readonlyColumnNames = new List<string>();
            this.headerColumnNames = new Dictionary<string, string>();

            this.DataBindingComplete += new
                DataGridViewBindingCompleteEventHandler(FlatGridView_DataBindingComplete);

            if (binding == null)
            {
                this.bs = new BindingSource();
            }
            else
            {
                this.bs = binding;
            }

            this.DataSource = this.bs;
        }


        public object SelectedItem
        {
            get
            {
                try
                {
                    if (this.DataSource != null &&
                        this.BindingContext != null &&
                        this.BindingContext[this.DataSource] != null)
                    {
                        if (this.BindingContext[this.DataSource].Count <= 0 ||
                            this.BindingContext[this.DataSource].Position < 0) return null;

                        return this.BindingContext[this.DataSource].Current;
                    }
                }
                catch (Exception ex)
                {
                }

                return null;
            }

        }

        /*
        void Columns_CollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e)
        {
            //if (this.Columns.Count > 0) AdjustColumns();
        }
        */

        protected void AdjustColumns()
        {
            foreach (DataGridViewColumn column in this.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (this.Columns.Count > 0)
            {
                this.Columns[this.Columns.Count - 1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        public void SetDataSource(IEnumerable list)
        {
            this.bs.DataSource = list;
            this.bs.ResetBindings(true);
        }


        public void UpdateBinding()
        {
            this.bs.ResetBindings(true);
        }


        void FlatGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in this.Columns)
            {
                if (this.hiddenColumnNames.Contains(column.Name))
                {
                    column.Visible = false;
                }
                
                if (headerColumnNames.ContainsKey(column.Name))
                {
                    column.HeaderText = headerColumnNames[column.Name];
                }

                if (readonlyColumnNames.Contains(column.Name))
                {
                    column.ReadOnly = true;
                }
            }

            AdjustColumns();
        }


        protected override void OnDataError(bool displayErrorDialogIfNoHandler, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
        {/*
            //base.OnDataError(displayErrorDialogIfNoHandler, e);
            DomainModel.ApplicationState.Instance.Controller.UpdateStatus(
                new StatusController.Entities.StatusInfo(
                (Int16)StatusCodes.Assemblies.Codes.ElectronicMeterProgrammer,
                (Int16)StatusCodes.Sections.Codes.Presentation,
                StatusController.Abstract.StatusTypes.Error,
                (Int32)StatusCodes.Errors.Codes.DataError,
                null, e.Exception.ToString()));*/
        }


        public void SelectLastItem()
        {
            if (this.Rows.Count > 0)
            {
                this.Rows[this.Rows.Count - 1].Selected = false;
                this.Rows[this.Rows.Count - 1].Selected = true;
            }
        }
    }
}
