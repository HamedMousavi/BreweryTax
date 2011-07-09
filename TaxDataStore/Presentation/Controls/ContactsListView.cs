using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using BrightIdeasSoftware;


namespace TaxDataStore.Presentation.Controls
{

    public class ContactsListView : ObjectListView
    {

        protected OLVColumn columnType;
        protected OLVColumn columnValue;

        protected Dictionary<int, string> mediaImages;


        public ContactsListView()
            : base()
        {
            LoadImages();

            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();

            AddColumns();

            this.RightToLeftLayout = false;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = new System.Drawing.Font(
                "Tahoma", 9.25F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                ((byte)(0)));
            this.FullRowSelect = true;
            this.Location = new Point(0, 0);
            this.Name = "ContactsListView";
            this.OwnerDraw = true;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowGroups = false;
            this.ShowImagesOnSubItems = true;
            this.ShowItemToolTips = true;
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
            this.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;

            this.HighlightBackgroundColor = this.BackColor;
            this.HighlightForegroundColor = this.ForeColor;

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }


        private void LoadImages()
        {
            this.mediaImages = new Dictionary<int, string>();
            this.mediaImages.Add(5, "address_book");
            this.mediaImages.Add(10, "telephone");
            this.mediaImages.Add(11, "mobile_phone");
            this.mediaImages.Add(12, "mail");
            this.mediaImages.Add(13, "fax");
        }


        private void AddColumns()
        {
            columnType = new OLVColumn();
            columnType.Text = "";
            columnType.Name = "";
            columnType.AspectName = "Media";
            columnType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            columnType.ImageGetter = ContactMediaImageGetter;
            columnType.AspectToStringConverter = ContactMediaTextGetter;
            columnType.IsEditable = false;
            columnType.FillsFreeSpace = false;
            columnType.Width = 20;

            this.Columns.Add(columnType);

            columnValue = new OLVColumn();
            columnValue.Text = "";
            columnValue.Name = "Value";
            columnValue.AspectName = "Value";
            columnValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            columnValue.IsEditable = false;
            columnValue.FillsFreeSpace = true;
            
            this.Font = Presentation.View.Theme.FormLabelFont;

            this.Columns.Add(columnValue);
        }
        
        
        protected Object ContactMediaImageGetter(Object rowObject)
        {
            Entities.Contact contact = (Entities.Contact)rowObject;
            if (contact != null)
            {
                if (this.mediaImages.ContainsKey(contact.Media.Id))
                {
                    return DomainModel.Application.ResourceManager.GetImage(this.mediaImages[contact.Media.Id]);
                }
            }

            return null;
        }


        string ContactMediaTextGetter(Object value)
        {
            return string.Empty;
        }


        Entities.ContactCollection datasource;


        internal void SetDataSource(Entities.ContactCollection contacts)
        {
            if (this.datasource != null)
            {
                this.datasource.ListChanged -= new
                    ListChangedEventHandler(datasource_ListChanged);
            }

            this.datasource = contacts;
            if (this.datasource != null)
            {
                this.datasource.ListChanged += new
                    ListChangedEventHandler(datasource_ListChanged);
            }

            this.SetObjects(contacts);
        }


        void datasource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            this.SetObjects(this.datasource);
        }
    }
}
