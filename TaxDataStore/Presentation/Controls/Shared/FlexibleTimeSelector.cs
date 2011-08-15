using System;
using System.Windows.Forms;


namespace TaxDataStore.Presentation.Controls
{

    public partial class FlexibleTimeSelector : UserControl
    {

        private FormLabel lblHour;
        private FormLabel lblMinute;


        public Entities.TourConstraintTimeItem Time { get; set; }


        public FlexibleTimeSelector()
        {
            InitializeComponent();

            CreateControls();

            for (int i = 1; i < 25; i++)
            {
                this.cbxHour.Items.Add(i.ToString());
            }

            for (int i = 0; i < 60; i++)
            {
                this.cbxMinute.Items.Add(i.ToString());
            }

            this.Time = new Entities.TourConstraintTimeItem();

            this.cbxHour.TextChanged += new EventHandler(cbxHour_TextChanged);
            this.cbxMinute.TextChanged += new EventHandler(cbxMinute_TextChanged);
        }


        private void CreateControls()
        {
            this.lblHour = new FormLabel(0, "lblHour", false, "Hour");
            this.lblMinute = new FormLabel(1, "lblMinute", false, "Minute");

            this.tlpMain.Controls.Add(this.lblHour, 0, 0);
            this.tlpMain.Controls.Add(this.lblMinute, 2, 0);
        }


        private void cbxHour_TextChanged(object sender, System.EventArgs e)
        {
            this.Time.Hour = GetValue((ComboBox)sender);
        }


        private void cbxMinute_TextChanged(object sender, System.EventArgs e)
        {
            this.Time.Minute = GetValue((ComboBox)sender);
        }


        internal void UpdateControlData()
        {
            SetValue(this.cbxHour, this.Time.Hour);
            SetValue(this.cbxMinute, this.Time.Minute);
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
