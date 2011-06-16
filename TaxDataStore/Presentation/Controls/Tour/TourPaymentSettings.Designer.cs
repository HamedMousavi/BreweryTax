namespace TaxDataStore.Presentation.Controls
{
    partial class TourPaymentSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPaymentGroups = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.tlpPaymentGroupButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddGroup = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnEditGroup = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnRemoveGroup = new TaxDataStore.Presentation.Controls.FlatButton();
            this.lblGroup = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.lblGroupRules = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.tlpTourPriceContainer = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditTourPrice = new TaxDataStore.Presentation.Controls.FlatButton();
            this.lblTourPrices = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.tlpPaymentRules = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.tlpPaymentRuleButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRule = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnEditRule = new TaxDataStore.Presentation.Controls.FlatButton();
            this.lblPaymentRules = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.btnRemoveRule = new TaxDataStore.Presentation.Controls.FlatButton();
            this.tlpMain.SuspendLayout();
            this.tlpPaymentGroups.SuspendLayout();
            this.tlpPaymentGroupButtons.SuspendLayout();
            this.tlpTourPriceContainer.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpPaymentRules.SuspendLayout();
            this.tlpPaymentRuleButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpMain.Controls.Add(this.tlpPaymentGroups, 0, 1);
            this.tlpMain.Controls.Add(this.tlpTourPriceContainer, 0, 0);
            this.tlpMain.Controls.Add(this.tlpPaymentRules, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(466, 516);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpPaymentGroups
            // 
            this.tlpPaymentGroups.BackColor = System.Drawing.Color.White;
            this.tlpPaymentGroups.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpPaymentGroups, 2);
            this.tlpPaymentGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpPaymentGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpPaymentGroups.Controls.Add(this.tlpPaymentGroupButtons, 0, 0);
            this.tlpPaymentGroups.Controls.Add(this.lblGroupRules, 1, 0);
            this.tlpPaymentGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentGroups.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpPaymentGroups.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlpPaymentGroups.Location = new System.Drawing.Point(3, 261);
            this.tlpPaymentGroups.Name = "tlpPaymentGroups";
            this.tlpPaymentGroups.RowCount = 2;
            this.tlpPaymentGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPaymentGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentGroups.Size = new System.Drawing.Size(460, 252);
            this.tlpPaymentGroups.TabIndex = 5;
            // 
            // tlpPaymentGroupButtons
            // 
            this.tlpPaymentGroupButtons.ColumnCount = 5;
            this.tlpPaymentGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaymentGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaymentGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaymentGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaymentGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentGroupButtons.Controls.Add(this.btnAddGroup, 1, 0);
            this.tlpPaymentGroupButtons.Controls.Add(this.btnEditGroup, 2, 0);
            this.tlpPaymentGroupButtons.Controls.Add(this.btnRemoveGroup, 3, 0);
            this.tlpPaymentGroupButtons.Controls.Add(this.lblGroup, 0, 0);
            this.tlpPaymentGroupButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentGroupButtons.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpPaymentGroupButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpPaymentGroupButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPaymentGroupButtons.Name = "tlpPaymentGroupButtons";
            this.tlpPaymentGroupButtons.RowCount = 1;
            this.tlpPaymentGroupButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentGroupButtons.Size = new System.Drawing.Size(161, 30);
            this.tlpPaymentGroupButtons.TabIndex = 0;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(50, 3);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(24, 24);
            this.btnAddGroup.TabIndex = 0;
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.Location = new System.Drawing.Point(80, 3);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(24, 24);
            this.btnEditGroup.TabIndex = 1;
            this.btnEditGroup.UseVisualStyleBackColor = true;
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.Location = new System.Drawing.Point(110, 3);
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveGroup.TabIndex = 2;
            this.btnRemoveGroup.UseVisualStyleBackColor = true;
            this.btnRemoveGroup.Click += new System.EventHandler(this.btnRemoveGroup_Click);
            // 
            // lblGroup
            // 
            this.lblGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGroup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblGroup.Location = new System.Drawing.Point(3, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(41, 30);
            this.lblGroup.TabIndex = 3;
            this.lblGroup.Text = "Group";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGroupRules
            // 
            this.lblGroupRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGroupRules.AutoSize = true;
            this.lblGroupRules.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGroupRules.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblGroupRules.Location = new System.Drawing.Point(164, 0);
            this.lblGroupRules.Name = "lblGroupRules";
            this.lblGroupRules.Size = new System.Drawing.Size(72, 30);
            this.lblGroupRules.TabIndex = 1;
            this.lblGroupRules.Text = "Group rules";
            this.lblGroupRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpTourPriceContainer
            // 
            this.tlpTourPriceContainer.BackColor = System.Drawing.Color.White;
            this.tlpTourPriceContainer.ColumnCount = 1;
            this.tlpTourPriceContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourPriceContainer.Controls.Add(this.tlpButtons, 0, 0);
            this.tlpTourPriceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTourPriceContainer.Location = new System.Drawing.Point(3, 3);
            this.tlpTourPriceContainer.Name = "tlpTourPriceContainer";
            this.tlpTourPriceContainer.RowCount = 2;
            this.tlpTourPriceContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTourPriceContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourPriceContainer.Size = new System.Drawing.Size(157, 252);
            this.tlpTourPriceContainer.TabIndex = 3;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 3;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Controls.Add(this.btnEditTourPrice, 1, 0);
            this.tlpButtons.Controls.Add(this.lblTourPrices, 0, 0);
            this.tlpButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(156, 30);
            this.tlpButtons.TabIndex = 2;
            // 
            // btnEditTourPrice
            // 
            this.btnEditTourPrice.Location = new System.Drawing.Point(79, 3);
            this.btnEditTourPrice.Name = "btnEditTourPrice";
            this.btnEditTourPrice.Size = new System.Drawing.Size(22, 24);
            this.btnEditTourPrice.TabIndex = 0;
            this.btnEditTourPrice.UseVisualStyleBackColor = true;
            this.btnEditTourPrice.Click += new System.EventHandler(this.btnEditTourPrice_Click);
            // 
            // lblTourPrices
            // 
            this.lblTourPrices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTourPrices.AutoSize = true;
            this.lblTourPrices.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTourPrices.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTourPrices.Location = new System.Drawing.Point(3, 0);
            this.lblTourPrices.Name = "lblTourPrices";
            this.lblTourPrices.Size = new System.Drawing.Size(70, 30);
            this.lblTourPrices.TabIndex = 0;
            this.lblTourPrices.Text = "Tour prices";
            this.lblTourPrices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpPaymentRules
            // 
            this.tlpPaymentRules.BackColor = System.Drawing.Color.White;
            this.tlpPaymentRules.ColumnCount = 1;
            this.tlpPaymentRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentRules.Controls.Add(this.tlpPaymentRuleButtons, 0, 0);
            this.tlpPaymentRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentRules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlpPaymentRules.Location = new System.Drawing.Point(166, 3);
            this.tlpPaymentRules.Name = "tlpPaymentRules";
            this.tlpPaymentRules.RowCount = 2;
            this.tlpPaymentRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPaymentRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentRules.Size = new System.Drawing.Size(297, 252);
            this.tlpPaymentRules.TabIndex = 4;
            // 
            // tlpPaymentRuleButtons
            // 
            this.tlpPaymentRuleButtons.ColumnCount = 5;
            this.tlpPaymentRuleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaymentRuleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaymentRuleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaymentRuleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaymentRuleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentRuleButtons.Controls.Add(this.btnAddRule, 1, 0);
            this.tlpPaymentRuleButtons.Controls.Add(this.btnEditRule, 2, 0);
            this.tlpPaymentRuleButtons.Controls.Add(this.lblPaymentRules, 0, 0);
            this.tlpPaymentRuleButtons.Controls.Add(this.btnRemoveRule, 3, 0);
            this.tlpPaymentRuleButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentRuleButtons.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpPaymentRuleButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpPaymentRuleButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPaymentRuleButtons.Name = "tlpPaymentRuleButtons";
            this.tlpPaymentRuleButtons.RowCount = 1;
            this.tlpPaymentRuleButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaymentRuleButtons.Size = new System.Drawing.Size(297, 30);
            this.tlpPaymentRuleButtons.TabIndex = 1;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(101, 3);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(22, 24);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // btnEditRule
            // 
            this.btnEditRule.Location = new System.Drawing.Point(129, 3);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(22, 24);
            this.btnEditRule.TabIndex = 3;
            this.btnEditRule.UseVisualStyleBackColor = true;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // lblPaymentRules
            // 
            this.lblPaymentRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaymentRules.AutoSize = true;
            this.lblPaymentRules.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPaymentRules.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPaymentRules.Location = new System.Drawing.Point(3, 0);
            this.lblPaymentRules.Name = "lblPaymentRules";
            this.lblPaymentRules.Size = new System.Drawing.Size(92, 30);
            this.lblPaymentRules.TabIndex = 1;
            this.lblPaymentRules.Text = "Payment Rules";
            this.lblPaymentRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemoveRule
            // 
            this.btnRemoveRule.Location = new System.Drawing.Point(157, 3);
            this.btnRemoveRule.Name = "btnRemoveRule";
            this.btnRemoveRule.Size = new System.Drawing.Size(22, 24);
            this.btnRemoveRule.TabIndex = 0;
            this.btnRemoveRule.UseVisualStyleBackColor = true;
            this.btnRemoveRule.Click += new System.EventHandler(this.btnRemoveRule_Click);
            // 
            // TourPaymentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "TourPaymentSettings";
            this.Size = new System.Drawing.Size(466, 516);
            this.tlpMain.ResumeLayout(false);
            this.tlpPaymentGroups.ResumeLayout(false);
            this.tlpPaymentGroups.PerformLayout();
            this.tlpPaymentGroupButtons.ResumeLayout(false);
            this.tlpPaymentGroupButtons.PerformLayout();
            this.tlpTourPriceContainer.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.tlpPaymentRules.ResumeLayout(false);
            this.tlpPaymentRuleButtons.ResumeLayout(false);
            this.tlpPaymentRuleButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Presentation.Controls.ContainerLayoutPanel tlpTourPriceContainer;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private FlatButton btnEditTourPrice;
        private ToolbarLabel lblTourPrices;
        private Presentation.Controls.ContainerLayoutPanel tlpPaymentRules;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentRuleButtons;
        private FlatButton btnAddRule;
        private FlatButton btnEditRule;
        private ToolbarLabel lblPaymentRules;
        private FlatButton btnRemoveRule;
        private Presentation.Controls.ContainerLayoutPanel tlpPaymentGroups;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentGroupButtons;
        private FlatButton btnAddGroup;
        private FlatButton btnEditGroup;
        private FlatButton btnRemoveGroup;
        private ToolbarLabel lblGroup;
        private ToolbarLabel lblGroupRules;
    }
}
