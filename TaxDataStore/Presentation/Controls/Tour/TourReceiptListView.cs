using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class TourReceiptListView : ObjectListView
    {

        protected Tour tour;
        private System.Drawing.Font boldFont;
        private System.Drawing.Font regularFont;


        public TourReceiptListView()
            : base()
        {

            this.boldFont = new Font("Tahoma", 9.25F, FontStyle.Bold);
            this.regularFont = new Font("Tahoma", 10.25F, FontStyle.Regular);

            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();

            this.RightToLeftLayout = false;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = this.regularFont;
            this.FullRowSelect = true;
            this.Location = new Point(0, 0);
            this.Name = "TourReceiptListView";
            this.OwnerDraw = true;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowGroups = false;
            this.ShowImagesOnSubItems = true;
            this.ShowItemToolTips = false;
            this.UseAlternatingBackColors = false;
            this.UseCompatibleStateImageBehavior = false;
            this.UseHotItem = true;
            this.UseSubItemCheckBoxes = false;
            this.View = System.Windows.Forms.View.Details;
            this.VirtualMode = false;
            this.CellEditActivation = ObjectListView.CellEditActivateMode.None;
            //this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridLines = false;
            this.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
//            this.UseItemStyleForSubItems = false;
            this.RowFormatter = ListRowFormatter;
            //this.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            this.RowHeight = 30;
            this.HeaderFont = this.boldFont;

            AddColumns();

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }


        private void AddColumns()
        {   
            OLVColumn column;

            column = new OLVColumn();
            column.Name = "Description";
            column.Text = "Description";
            column.AspectToStringConverter = DescriptionConverter;
            column.FillsFreeSpace = true;
            this.Columns.Add(column);

            column = new OLVColumn();
            column.Name = "PricePerPerson";
            column.Text = "Unit price";
            column.AspectToStringConverter = UnitPriceConverter;
            this.Columns.Add(column);

            column = new OLVColumn();
            column.Name = "Quantity";
            column.Text = "Quantity";
            column.AspectName = "Quantity";
            this.Columns.Add(column);

            column = new OLVColumn();
            column.Name = "Total";
            column.Text = "Total";
            column.AspectToStringConverter = TotalConverter;
            this.Columns.Add(column);


            for (int i = 0; i < this.Columns.Count; i++)
            {
                column = (OLVColumn)this.Columns[i];
                if (string.IsNullOrWhiteSpace(column.AspectName))
                {
                    column.AspectGetter = ObjectAspectGetter;
                }

                column.TextAlign = HorizontalAlignment.Left;
                column.IsEditable = false;
                //column.FillsFreeSpace = false;
            }
        }


        internal void SetDataSource(Entities.Tour tour)
        {
            this.tour = tour;
            this.tour.Receipt.Items.ListChanged += new 
                ListChangedEventHandler(Items_ListChanged);

            this.SetObjects(this.tour.Receipt.Items);
        }


        void Items_ListChanged(object sender, ListChangedEventArgs e)
        {
            try
            {
            this.SetObjects(this.tour.Receipt.Items);
            this.AutoResizeColumns(
                ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
            }
        }


        Object ObjectAspectGetter(Object sender, Object rowObject)
        {
            return rowObject;
        }


        string DescriptionConverter(Object value)
        {
            Entities.TourReceiptItem item =
                (Entities.TourReceiptItem)value;

            if (item.ParentIndex < 0)
            {
                return item.Description;
            }
            else
            {
                return "    " + item.Description;
            }
        }


        string TotalConverter(Object value)
        {
            Entities.TourReceiptItem item =
                (Entities.TourReceiptItem)value;

            if (item.Total.Value > 0) return "+" + item.Total.FormattedValue;
            else return item.Total.FormattedValue;
        }


        string UnitPriceConverter(Object value)
        {
            Entities.TourReceiptItem item =
                (Entities.TourReceiptItem)value;

            return item.PricePerPerson.FormattedValue;
        }


        void ListRowFormatter(OLVListItem olvItem)
        {
            if (olvItem == null || olvItem.RowObject == null) return;

            Entities.TourReceiptItem item =
                (Entities.TourReceiptItem)olvItem.RowObject;

            if (item.IsCustom)
            {
                olvItem.BackColor = Color.White;
            }
            else
            {
                olvItem.BackColor = Color.Ivory;
            }

            if (item.ParentIndex < 0)
            {
                olvItem.BackColor = Color.PapayaWhip;
            }/*
            else
            {
                olvItem.BackColor = Color.White;
            }
            */

            if (item.Total.Value < 0)
            {
                olvItem.ForeColor = Color.DarkGreen;
            }
            else if (item.Total.Value == 0)
            {
                olvItem.ForeColor = Color.Gray;
            }
            else
            {
                olvItem.ForeColor = Color.Black;
            }
        }

        internal void CleanUp()
        {
            try
            {
                if (this.tour != null)
                {
                    this.tour.Receipt.Items.ListChanged -= new
                        ListChangedEventHandler(Items_ListChanged);
                }
            }
            catch { }
        }
    }
}
