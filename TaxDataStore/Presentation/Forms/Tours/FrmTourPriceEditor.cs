﻿using System;
using System.Windows.Forms;
using TaxDataStore.Presentation.Controls;


namespace TaxDataStore
{

    public partial class FrmTourPriceEditor : BaseForm
    {
        private FormLabel lblTourType;
        private FormLabel lblBasePrice;

        protected MoneyPicker mpkBasePrice;

        private Entities.TourBasePrice price;


        public FrmTourPriceEditor()
        {
            InitializeComponent();

            CreateControls();

            this.Text = Resources.Texts.frm_title_base_price_editor;
            this.btnSave.Text = Resources.Texts.save;
            this.btnCancel.Text = Resources.Texts.cancel;
        }


        private void CreateControls()
        {
            this.lblTourType = new FormLabel(0, "lblTourType", false, "lbl_tour_type");
            this.lblBasePrice = new FormLabel(1, "lblBasePrice", false, "lbl_price");
            this.tlpMain.Controls.Add(this.lblTourType, 0, 0);
            this.tlpMain.Controls.Add(this.lblBasePrice, 0, 1);
        }


        public FrmTourPriceEditor(Entities.TourBasePrice price)
            : this()
        {
            this.price = price;

            this.tbxTourType.DataBindings.Add(
                new Binding(
                    "Text",
                    this.price.TourType,
                    "Name",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged,
                    string.Empty,
                    string.Empty,
                    null));


            this.mpkBasePrice = new Presentation.Controls.MoneyPicker();
            this.mpkBasePrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.tlpMain.Controls.Add(this.mpkBasePrice, 1, 1);

            this.mpkBasePrice.Value.Currency = this.price.PricePerPerson.Currency;
            this.mpkBasePrice.ValueEditor = Convert.ToString(this.price.PricePerPerson.Value);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DomainModel.TourBasePrices.Save(this.price.Id, this.mpkBasePrice.Value))
            {
                this.price.PricePerPerson.Value = this.mpkBasePrice.Value.Value;
                this.price.PricePerPerson.Currency = this.mpkBasePrice.Value.Currency;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
