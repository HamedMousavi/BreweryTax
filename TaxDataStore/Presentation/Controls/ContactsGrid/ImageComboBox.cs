using System;
using System.Drawing;
using System.Windows.Forms;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public class ImageComboBox : ComboBox, IDataGridViewEditingControl
    {

        protected readonly int imagesize = 16;
        protected readonly int padding = 2;
        
        protected DataGridView dataGridView;
        protected Int32 rowIndex;
        protected bool valueChanged;


        public ImageComboBox()
        {
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DrawItem += new DrawItemEventHandler(ImageComboBox_DrawItem);
           
            this.DataSource = DomainModel.Types.GetByName(
                "ContactMediaTypes", DomainModel.Application.User.Culture);
            this.DisplayMember = "Name";
        }


        void ImageComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                GeneralType contactMedia = (GeneralType)this.Items[e.Index];
                if (contactMedia != null)
                {
                    Image img = GetContactImage(contactMedia);

                    if (img != null)
                    {
                        e.Graphics.DrawImage(img, e.Bounds.X + padding, e.Bounds.Y, imagesize, imagesize);
                    }

                    e.Graphics.DrawString(
                        contactMedia.Name, this.Font, Brushes.Black,
                            new RectangleF(new PointF
                                (e.Bounds.X + imagesize + 2 * padding, e.Bounds.Y), e.Bounds.Size));
                }

                e.DrawFocusRectangle();
            }
        }

/*
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (e.Index >= 0)
            {
                e.DrawBackground();

                GeneralType contactMedia = (GeneralType)this.Items[e.Index];
                if (contactMedia != null)
                {
                    Image img = GetContactImage(contactMedia);

                    if (img != null)
                    {
                        e.Graphics.DrawImage(img, e.Bounds.X + padding, e.Bounds.Y, imagesize, imagesize);
                    }

                    e.Graphics.DrawString(
                        contactMedia.Name, this.Font, Brushes.Black,
                            new RectangleF(new PointF
                                (e.Bounds.X + imagesize + 2 * padding, e.Bounds.Y), e.Bounds.Size));
                }

                e.DrawFocusRectangle();
            }
        }

*/
        private Image GetContactImage(GeneralType contactMedia)
        {
            if (contactMedia == null || string.IsNullOrEmpty(contactMedia.Name)) return null;

            string name = contactMedia.Name.ToLower();
            name = name.Replace(' ', '_');
            return DomainModel.Application.ResourceManager.GetImage(name);
        }


        #region IDataGridViewEditingControl


        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.ForeColor = dataGridViewCellStyle.ForeColor;
            this.BackColor = dataGridViewCellStyle.BackColor;
        }


        public DataGridView EditingControlDataGridView
        {
            get
            {
                return this.dataGridView;
            }
            set
            {
                this.dataGridView = value;
            }
        }


        public object EditingControlFormattedValue
        {

            get
            {
                return (GeneralType)this.SelectedItem;
            }

            set
            {
                if (value is String)
                {
                    try
                    {
                        // This will throw an exception of the string is 
                        // null, empty, or not in the format of a date.
                        //this.SelectedItem = DateTime.Parse(((String)value));
                    }
                    catch
                    {
                        // In the case of an exception, just use the 
                        // default value so we're not left with a null
                        // value.
                    }
                }
                else if (value is GeneralType)
                {
                    try
                    {
                        this.SelectedItem = (GeneralType)value;
                    }
                    catch (Exception)
                    {
                        //this.SelectedItem = null;
                    }
                }
            }
        }


        public int EditingControlRowIndex
        {
            get
            {
                return this.rowIndex;
            }
            set
            {
                this.rowIndex = value;
            }
        }


        public bool EditingControlValueChanged
        {
            get
            {
                return this.valueChanged;
            }
            set
            {
                this.valueChanged = value;
            }
        }


        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            // Let the DateTimePicker handle the keys listed.
            switch (keyData & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }


        public Cursor EditingPanelCursor
        {
            get { return base.Cursor; }
        }


        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return this.EditingControlFormattedValue;
        }


        public void PrepareEditingControlForEdit(bool selectAll)
        {
        }


        public bool RepositionEditingControlOnValueChange
        {
            get { return false; }
        }

        #endregion IDataGridViewEditingControl
    }
}
