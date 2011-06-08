using System;
using System.Windows.Forms;
using System.ComponentModel;


namespace TaxDataStore.Presentation.Controls
{

    public partial class MoneyPicker : UserControl
    {

        protected string decimalSeprator;
        protected string valueStr;


        [BrowsableAttribute(false)]
        public Entities.Money Value { get; protected set; }
        

        public string ValueEditor
        {
            get
            {
                return this.valueStr;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    value = value.Replace(".", this.decimalSeprator);
                    value = value.Replace(",", this.decimalSeprator);
                    this.valueStr = value.ToString();
                }

                decimal res;
                decimal.TryParse(this.valueStr, out res);
                if (res != 0 && res != this.Value.Value) 
                    this.Value.Value = res;
            }
        }


        public MoneyPicker()
        {
            InitializeComponent();

            try
            {
                
                System.Globalization.CultureInfo inf = new 
                    System.Globalization.CultureInfo(
                        DomainModel.Application.User.Culture.CultureName);
                //this.lblDecimalPoint.Text = inf.NumberFormat.NumberDecimalSeparator;
                this.decimalSeprator = inf.NumberFormat.NumberDecimalSeparator;

                this.Value = new Entities.Money(0.0m, null);


                this.tbxValue.DataBindings.Add(
                    new Binding(
                        "Text",
                        this,
                        "ValueEditor",
                        false,
                        DataSourceUpdateMode.OnPropertyChanged,
                        0.0m,
                        string.Empty,
                        null));

                this.cbxUnit.DataSource = DomainModel.Currencies.GetAll(); //DomainModel.Currencies.GetAll();
                this.cbxUnit.DisplayMember = "Symbol";

                this.cbxUnit.DataBindings.Add(
                    new Binding(
                        "SelectedItem",
                        this.Value,
                        "Currency",
                        false,
                        DataSourceUpdateMode.OnPropertyChanged,
                        null,
                        string.Empty,
                        null));
            }
            catch (Exception)
            {
            }
        }


        public MoneyPicker(Entities.Money money, string culture)
        {
            InitializeComponent();

            try
            {

                if (string.IsNullOrWhiteSpace(culture))
                {
                    culture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
                }

                System.Globalization.CultureInfo inf = new
                    System.Globalization.CultureInfo(culture);
                this.decimalSeprator = inf.NumberFormat.NumberDecimalSeparator;

                this.Value = money;

                this.tbxValue.DataBindings.Add(
                    new Binding(
                        "Text",
                        this,
                        "ValueEditor",
                        false,
                        DataSourceUpdateMode.OnPropertyChanged,
                        0.0m,
                        string.Empty,
                        null));

                this.cbxUnit.DataSource = DomainModel.Currencies.GetAll(); //DomainModel.Currencies.GetAll();
                this.cbxUnit.DisplayMember = "Symbol";

                this.cbxUnit.DataBindings.Add(
                    new Binding(
                        "SelectedItem",
                        this.Value,
                        "Currency",
                        false,
                        DataSourceUpdateMode.OnPropertyChanged,
                        null,
                        string.Empty,
                        null));
            }
            catch (Exception)
            {
            }
        }
    }
}
