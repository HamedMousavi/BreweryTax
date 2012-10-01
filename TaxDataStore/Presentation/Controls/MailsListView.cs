using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public sealed class MailsListView : ObjectListView
    {
        private BindingSource _bindingSource;
        //private Entities.MailCollection _datasource;


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
            RowHeight = 26;

            //this.HighlightBackgroundColor = this.BackColor;
            //this.HighlightForegroundColor = this.ForeColor;

            ((ISupportInitialize)(this)).EndInit();

            Disposed += OnListDisposed;
            this.SelectedIndexChanged += MailsListViewSelectedIndexChanged;
        }


        void MailsListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_bindingSource != null && 
                    _bindingSource.DataSource != null &&
                    SelectedObject != null)
                {
                    int index = _bindingSource.IndexOf(SelectedObject);

                    _bindingSource.Position = index;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void AddColumns()
        {
            _columnType = new OLVColumn
            {
                Text = "",
                Name = "",
                AspectName = "IsSent",
                TextAlign = HorizontalAlignment.Left,
                ImageGetter = MailTypeImageGetter,
                AspectToStringConverter = MailTypeTextGetter,
                IsEditable = false,
                FillsFreeSpace = false,
                Width = 32
            };

            Columns.Add(_columnType);

            _columnValue = new OLVColumn
            {
                Text = "",
                Name = "Title",
                AspectName = "Title",
                TextAlign = HorizontalAlignment.Left,
                IsEditable = false,
                FillsFreeSpace = true
            };

            Font = Presentation.View.Theme.FormLabelFont;

            Columns.Add(_columnValue);
        }


        private Object MailTypeImageGetter(Object rowObject)
        {
            Mail mail = (Entities.Mail)rowObject;
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

        /*
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
        }*/


        void DatasourceListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsDisposed || Disposing)
            {
                return;
            }

            try
            {

                if (_bindingSource != null && _bindingSource.DataSource != null)
                {
                    MailCollection mails = (MailCollection) _bindingSource.DataSource;
                    if (mails.Count > 0)
                    {
                        SetObjects(mails);
                        SelectObject(mails[0]);
                        Focus();

                        return;
                    }
                }

                SetObjects(null);
            }
            catch (Exception)
            { }
        }


        void OnListDisposed(object sender, EventArgs e)
        {
            UnwireBindings();
        }


        internal void SetBinding(BindingSource bindingSource)
        {
            if (bindingSource == null) return;

            UnwireBindings();

            _bindingSource = bindingSource;

            if (_bindingSource != null)
            {
                _bindingSource.ListChanged += DatasourceListChanged;
            }

            SetObjects((MailCollection)_bindingSource.DataSource);
        }


        private void UnwireBindings()
        {
            if (_bindingSource != null)
            {
                _bindingSource.ListChanged -= DatasourceListChanged;
            }
        }
    }
}
