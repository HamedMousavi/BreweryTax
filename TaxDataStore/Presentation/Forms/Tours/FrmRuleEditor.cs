using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;
using System.Drawing;


namespace TaxDataStore
{

    public partial class FrmRuleEditor : BaseForm
    {
        private FormLabel lblRuleName;
        private FormLabel lblFormula;

        protected readonly string[] opImageNames = new string[] { "plus", "minus" };
        protected readonly string[] opLabels = new string[] { "%" };

        protected TourFormulaOperationComboBox cbxPriceOperation;
        
        protected Entities.TourCostRule rule;
        protected Entities.TourCostRule editRule;


        protected FlatGridView fgvConstraints;


        public FrmRuleEditor()
        {
            this.rule = new Entities.TourCostRule();

            InitializeComponent();

            CreateControls();

            SetupControls();
            BindControlsData();

            SelectValueOperation(this.rule.Formula.ValueOperation, this.rule.Formula.Currency);
            SelectPriceOperation(this.rule.Formula.PriceOperation);
            this.tbxValue.Text = Convert.ToString(this.rule.Formula.Value);
        }


        private void CreateControls()
        {
            this.lblRuleName = new FormLabel(0, "lblRuleName", false, "lbl_rule_name");
            this.lblFormula = new FormLabel(0, "lblFormula", false, "lbl_formula");

            this.tlpMain.Controls.Add(this.lblRuleName, 0, 0);
            this.tlpMain.Controls.Add(this.lblFormula, 0, 1);
            
        }


        public FrmRuleEditor(Entities.TourCostRule editRule) :
            this()
        {
            this.editRule = editRule;
            this.editRule.CopyTo(this.rule);

            SelectPriceOperation(this.rule.Formula.PriceOperation);
            SelectValueOperation(this.rule.Formula.ValueOperation, this.rule.Formula.Currency);
            this.tbxValue.Text = Convert.ToString(this.rule.Formula.Value);
        }


        private void SetupControls()
        {
            this.BackColor = Color.White;

            this.cbxPriceOperation = new TourFormulaOperationComboBox();
            this.cbxPriceOperation.Anchor = AnchorStyles.Top | 
                AnchorStyles.Left | AnchorStyles.Right;
            //this.cbxPriceOperation.FormattingEnabled = true;
            this.cbxPriceOperation.Location = new System.Drawing.Point(3, 3);
            this.cbxPriceOperation.Name = "cbxPriceOperation";
            this.cbxPriceOperation.Size = new System.Drawing.Size(72, 22);
            this.cbxPriceOperation.TabIndex = 3;
            this.tlpFormula.Controls.Add(this.cbxPriceOperation, 0, 0);

            this.btnConstraintsAdd.Image = DomainModel.Application.ResourceManager.GetImage("add");
            this.btnConstraintsDelete.Image = DomainModel.Application.ResourceManager.GetImage("delete");
            this.btnConstraintsEdit.Image = DomainModel.Application.ResourceManager.GetImage("pencil");

            this.btnConstraintsAdd.Click += new EventHandler(btnConstraintsAdd_Click);
            this.btnConstraintsEdit.Click += new EventHandler(btnConstraintsEdit_Click);
            this.btnConstraintsDelete.Click += new EventHandler(btnConstraintsDelete_Click);

            this.fgvConstraints = new FlatGridView();
            this.tlpConstraints.Controls.Add(this.fgvConstraints, 0, 1);
            this.fgvConstraints.SetDataSource(this.rule.Constraints);
            this.fgvConstraints.HiddenColumnNames.Add("ConstraintType");
            this.fgvConstraints.HiddenColumnNames.Add("Properties");
            this.fgvConstraints.ColumnHeadersVisible = false;

            SetupTexts();
        }


        void btnConstraintsDelete_Click(object sender, EventArgs e)
        {
            Entities.TourCostRuleConstraint con =
                (Entities.TourCostRuleConstraint)
                    this.fgvConstraints.SelectedItem;

            if (con != null)
            {
                if (con.Id < 0)
                {
                    this.rule.Constraints.Remove(con);
                }
                else
                {
                    // undone:
                    // Add to delete list first
                }
            }
        }


        void btnConstraintsEdit_Click(object sender, EventArgs e)
        {
            Entities.TourCostRuleConstraint con = 
                (Entities.TourCostRuleConstraint)
                    this.fgvConstraints.SelectedItem;

            if (con != null)
            {
                Presentation.Controllers.TourFinance.EditConstraint(this.rule, con);
            }
        }


        void btnConstraintsAdd_Click(object sender, EventArgs e)
        {
            Presentation.Controllers.TourFinance.AddConstraint(this.rule);
        }


        private void SetupTexts()
        {
            this.Text = Resources.Texts.frm_title_rule_editor;
        }


        private void BindControlsData()
        {

            Array priceOperations = Enum.GetValues(typeof(Entities.TourCostFormula.PriceOperations));
            foreach (Entities.TourCostFormula.PriceOperations operation in priceOperations)
            {
                Presentation.Models.PriceOperationItem item = new Presentation.Models.PriceOperationItem();
                item.Id = Convert.ToInt32(operation);
                item.Name = Convert.ToString(operation);
                item.ImageName = this.opImageNames[item.Id];

                this.cbxPriceOperation.Items.Add(item);
            }
            //this.cbxPriceOperation.DisplayMember = "Name";


            Array valueOperations = Enum.GetValues(typeof(Entities.TourCostFormula.ValueOperations));
            foreach (Entities.TourCostFormula.ValueOperations operation in valueOperations)
            {
                if (operation != Entities.TourCostFormula.ValueOperations.Currency)
                {
                    Presentation.Models.ValueOperationItem item = new Presentation.Models.ValueOperationItem();
                    item.Id = Convert.ToInt32(operation);
                    item.Name = Convert.ToString(operation);
                    item.Label = this.opLabels[item.Id];
                    item.CustomObject = operation;

                    this.cbxValueOperation.Items.Add(item);
                }
            }

            foreach (Entities.MoneyCurrency currency in DomainModel.Currencies.GetAll())
            {
                Presentation.Models.ValueOperationItem item = new Presentation.Models.ValueOperationItem();
                item.Id = currency.Id;
                item.Name = currency.Name;
                item.Label = currency.Symbol;
                item.CustomObject = currency;

                this.cbxValueOperation.Items.Add(item);
            }
            this.cbxValueOperation.DisplayMember = "Label";


            this.tbxRuleName.DataBindings.Add(
                new Binding(
                    "Text",
                    this.rule,
                    "Name",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));
        }


        private void SelectPriceOperation(Entities.TourCostFormula.PriceOperations price)
        {
            Int32 priceId = (Int32)price;
            foreach(Presentation.Models.PriceOperationItem item in this.cbxPriceOperation.Items)
            {
                if (item.Id == priceId)
                {
                    this.cbxPriceOperation.SelectedItem = item;
                    break;
                }
            }
        }


        private void SelectValueOperation(Entities.TourCostFormula.ValueOperations value, Entities.MoneyCurrency currency)
        {
            if (value == Entities.TourCostFormula.ValueOperations.Percent)
            {
                Int32 valueId = (Int32)value;

                foreach (Presentation.Models.ValueOperationItem item in this.cbxValueOperation.Items)
                {
                    if (item.Id == valueId)
                    {
                        this.cbxValueOperation.SelectedItem = item;
                        break;
                    }
                }
            }
            else
            {
                foreach (Presentation.Models.ValueOperationItem item in this.cbxValueOperation.Items)
                {
                    if (item.Id == currency.Id)
                    {
                        this.cbxValueOperation.SelectedItem = item;
                        break;
                    }
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            return;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            GetUserInput();
            if (this.editRule != null)
            {
                // Update edit user and database
                this.rule.CopyTo(this.editRule);
            }

            if (DomainModel.TourCostRules.Save(this.rule))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }


        private void GetUserInput()
        {
            this.rule.Formula.Value = Convert.ToDecimal(this.tbxValue.Text);

            Presentation.Models.PriceOperationItem op =
                (Presentation.Models.PriceOperationItem)
                    this.cbxPriceOperation.SelectedItem;

            Presentation.Models.ValueOperationItem val =
                (Presentation.Models.ValueOperationItem)
                    this.cbxValueOperation.SelectedItem;

            if (op != null && val != null)
            {
                this.rule.Formula.PriceOperation =
                    (Entities.TourCostFormula.PriceOperations)op.Id;

                if (val.CustomObject is Entities.MoneyCurrency)
                {
                    this.rule.Formula.Currency =
                        val.CustomObject as Entities.MoneyCurrency;

                    this.rule.Formula.ValueOperation =
                        Entities.TourCostFormula.ValueOperations.Currency;
                }
                else
                {
                    this.rule.Formula.ValueOperation =
                        Entities.TourCostFormula.ValueOperations.Percent;
                }
            }
        }
    }
}
