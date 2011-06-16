using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public class GeneralTypeTextEditor : TextBox, IDataGridViewEditingControl
    {

        protected DataGridView dataGridView;
        protected Int32 rowIndex;
        protected bool valueChanged;


        public GeneralTypeTextEditor()
        {
            this.valueChanged = false;
            this.rowIndex = 0;

            this.Enter += new EventHandler(GeneralTypeTextEditor_Enter);
        }


        void GeneralTypeTextEditor_Enter(object sender, EventArgs e)
        {
            this.valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnTextChanged(e);
        }


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
                return this.Text;
            }
            set
            {
                this.Text = (string)value;
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
    }
}
