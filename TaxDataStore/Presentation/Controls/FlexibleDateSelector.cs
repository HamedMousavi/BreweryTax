using System;
using System.Windows.Forms;
using Entities;


namespace TaxDataStore.Presentation.Controls
{

    public partial class ConstraintDateSelector : UserControl
    {

        private FormLabel lblYear;
        private FormLabel lblMonth;
        private FormLabel lblDay;


        public TourConstraintDateItem Date { get; set; }


        public ConstraintDateSelector()
        {
            InitializeComponent();

            CreateControls();

            this.Date = new TourConstraintDateItem();

            this.cbxYear.TextChanged += new EventHandler(cbxYear_TextChanged);
            this.cbxMonths.TextChanged += new EventHandler(cbxMonths_TextChanged);
            this.cbxDay.TextChanged += new EventHandler(cbxDay_TextChanged);
        }


        private void CreateControls()
        {
            this.lblYear = new FormLabel(0, "lblYear", false, "Year");
            this.lblMonth = new FormLabel(1, "lblMonth", false, "Month");
            this.lblDay = new FormLabel(2, "lblDay", false, "Day");

            this.tlpMain.Controls.Add(this.lblMonth, 2, 0);
            this.tlpMain.Controls.Add(this.lblDay, 4, 0);
            this.tlpMain.Controls.Add(this.lblYear, 0, 0);
        }

        void cbxYear_TextChanged(object sender, EventArgs e)
        {
            this.Date.Year = GetValue((ComboBox)sender);
        }

        void cbxMonths_TextChanged(object sender, EventArgs e)
        {
            this.Date.Month = GetValue((ComboBox)sender);
        }

        void cbxDay_TextChanged(object sender, EventArgs e)
        {
            this.Date.Day = GetValue((ComboBox)sender);
        }


        internal void UpdateControlData()
        {
            SetValue(this.cbxDay, this.Date.Day);
            SetValue(this.cbxMonths, this.Date.Month);
            SetValue(this.cbxYear, this.Date.Year);
        }


        private void SetValue(ComboBox comboBox, int value)
        {
            try
            {
                if (value == -1)
                {
                    comboBox.SelectedIndex = 0;
                }
                else
                {
                    int index = comboBox.FindString(value.ToString());
                    if (index >= 0)
                    {
                        comboBox.SelectedIndex = index;
                    }
                    else
                    {
                        comboBox.Text = value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                comboBox.Text = string.Empty;
            }
        }


        private int GetValue(ComboBox comboBox)
        {
            Int32 value;
            try
            {
                int index = comboBox.FindString(comboBox.Text);

                if (index == 0)
                {
                    value = -1;
                }
                else
                {
                    value = Convert.ToInt32(comboBox.Text);
                }
            }
            catch (Exception ex)
            {
                value = -2;
            }

            return value;
        }
    }
}
