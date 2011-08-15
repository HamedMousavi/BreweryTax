using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using BrightIdeasSoftware;


namespace TaxDataStore.Presentation.Controls
{

    public sealed class MailsListView : ObjectListView
    {
        private Entities.MailCollection _datasource;

        private OLVColumn _columnType;
        private OLVColumn _columnValue;

        private Dictionary<bool, string> _mediaImages;


        public MailsListView()
        {
            LoadImages();

            ((ISupportInitialize)(this)).BeginInit();

            AddColumns();

            RightToLeftLayout = false;
            Dock = System.Windows.Forms.DockStyle.Fill;
            Font = new Font(
                "Tahoma", 9.25F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                0);
            FullRowSelect = true;
            Location = new Point(0, 0);
            Name = "ContactsListView";
            OwnerDraw = true;
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            ShowGroups = false;
            ShowImagesOnSubItems = true;
            ShowItemToolTips = true;
            UseAlternatingBackColors = false;
            UseCompatibleStateImageBehavior = false;
            UseHotItem = true;
            UseSubItemCheckBoxes = false;
            View = System.Windows.Forms.View.Details;
            VirtualMode = false;
            CellEditActivation = CellEditActivateMode.None;
            //this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            BorderStyle = System.Windows.Forms.BorderStyle.None;
            GridLines = false;
            HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;

            //this.HighlightBackgroundColor = this.BackColor;
            //this.HighlightForegroundColor = this.ForeColor;

            ((ISupportInitialize)(this)).EndInit();

            Disposed += OnListDisposed;
        }


        private void AddColumns()
        {
            _columnType = new OLVColumn
                              {
                                  Text = "",
                                  Name = "",
                                  AspectName = "IsSent",
                                  TextAlign = System.Windows.Forms.HorizontalAlignment.Left,
                                  ImageGetter = MailTypeImageGetter,
                                  AspectToStringConverter = MailTypeTextGetter,
                                  IsEditable = false,
                                  FillsFreeSpace = false,
                                  Width = 20
                              };

            Columns.Add(_columnType);

            _columnValue = new OLVColumn
                               {
                                   Text = "",
                                   Name = "Title",
                                   AspectName = "Title",
                                   TextAlign = System.Windows.Forms.HorizontalAlignment.Left,
                                   IsEditable = false,
                                   FillsFreeSpace = true
                               };

            Font = Presentation.View.Theme.FormLabelFont;

            Columns.Add(_columnValue);
        }


        private Object MailTypeImageGetter(Object rowObject)
        {
            Entities.Mail mail = (Entities.Mail)rowObject;
            if (_mediaImages != null && mail != null)
            {
                if (_mediaImages.ContainsKey(mail.IsSent))
                {
                    return DomainModel.Application.ResourceManager.GetImage(
                        _mediaImages[mail.IsSent]);
                }
            }

            return null;
        }


        string MailTypeTextGetter(Object value)
        {
            return string.Empty;
        }


        private void LoadImages()
        {
            _mediaImages = new Dictionary<bool, string>
                               {
                                   {false, "Get_Mail"},
                                   {true, "Send_Mail"}
                               };
        }


        public void SetDataSource(Entities.MailCollection mails)
        {
            if (_datasource != null)
            {
                _datasource.ListChanged -= DatasourceListChanged;
            }

            _datasource = mails;
            if (_datasource != null)
            {
                _datasource.ListChanged += DatasourceListChanged;
            }

            SetObjects(mails);
        }


        void DatasourceListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsDisposed || Disposing)
            {
                return;
            }

            try
            {
                if (_datasource == null || _datasource.Count == 0)
                {
                    SetObjects(null);
                }
                else
                {
                    SetObjects(_datasource);
                }
            }
            catch (Exception)
            { }
        }


        void OnListDisposed(object sender, EventArgs e)
        {
            if (_datasource != null)
            {
                _datasource.ListChanged -= DatasourceListChanged;
            }
        }
    }
}
