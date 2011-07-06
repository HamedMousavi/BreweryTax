namespace TaxDataStore.Presentation.Controls
{
    partial class TourCostSettings
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
            this.tlpCostGroups = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.tlpCostGroupButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTourPriceContainer = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCostRules = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.tlpCostRuleButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.tlpCostGroups.SuspendLayout();
            this.tlpCostGroupButtons.SuspendLayout();
            this.tlpTourPriceContainer.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpCostRules.SuspendLayout();
            this.tlpCostRuleButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpMain.Controls.Add(this.tlpCostGroups, 0, 1);
            this.tlpMain.Controls.Add(this.tlpTourPriceContainer, 0, 0);
            this.tlpMain.Controls.Add(this.tlpCostRules, 1, 0);
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
            // tlpCostGroups
            // 
            this.tlpCostGroups.BackColor = System.Drawing.Color.White;
            this.tlpCostGroups.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpCostGroups, 2);
            this.tlpCostGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpCostGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpCostGroups.Controls.Add(this.tlpCostGroupButtons, 0, 0);
            this.tlpCostGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCostGroups.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpCostGroups.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlpCostGroups.Location = new System.Drawing.Point(3, 261);
            this.tlpCostGroups.Name = "tlpCostGroups";
            this.tlpCostGroups.RowCount = 2;
            this.tlpCostGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCostGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCostGroups.Size = new System.Drawing.Size(460, 252);
            this.tlpCostGroups.TabIndex = 5;
            // 
            // tlpCostGroupButtons
            // 
            this.tlpCostGroupButtons.ColumnCount = 5;
            this.tlpCostGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCostGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCostGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCostGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCostGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCostGroupButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCostGroupButtons.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpCostGroupButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpCostGroupButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCostGroupButtons.Name = "tlpCostGroupButtons";
            this.tlpCostGroupButtons.RowCount = 1;
            this.tlpCostGroupButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCostGroupButtons.Size = new System.Drawing.Size(161, 30);
            this.tlpCostGroupButtons.TabIndex = 0;
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
            this.tlpButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(156, 30);
            this.tlpButtons.TabIndex = 2;
            // 
            // tlpCostRules
            // 
            this.tlpCostRules.BackColor = System.Drawing.Color.White;
            this.tlpCostRules.ColumnCount = 1;
            this.tlpCostRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCostRules.Controls.Add(this.tlpCostRuleButtons, 0, 0);
            this.tlpCostRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCostRules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlpCostRules.Location = new System.Drawing.Point(166, 3);
            this.tlpCostRules.Name = "tlpCostRules";
            this.tlpCostRules.RowCount = 2;
            this.tlpCostRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCostRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCostRules.Size = new System.Drawing.Size(297, 252);
            this.tlpCostRules.TabIndex = 4;
            // 
            // tlpCostRuleButtons
            // 
            this.tlpCostRuleButtons.ColumnCount = 5;
            this.tlpCostRuleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCostRuleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCostRuleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCostRuleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCostRuleButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCostRuleButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCostRuleButtons.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpCostRuleButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpCostRuleButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCostRuleButtons.Name = "tlpCostRuleButtons";
            this.tlpCostRuleButtons.RowCount = 1;
            this.tlpCostRuleButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCostRuleButtons.Size = new System.Drawing.Size(297, 30);
            this.tlpCostRuleButtons.TabIndex = 1;
            // 
            // TourCostSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "TourCostSettings";
            this.Size = new System.Drawing.Size(466, 516);
            this.tlpMain.ResumeLayout(false);
            this.tlpCostGroups.ResumeLayout(false);
            this.tlpCostGroups.PerformLayout();
            this.tlpCostGroupButtons.ResumeLayout(false);
            this.tlpCostGroupButtons.PerformLayout();
            this.tlpTourPriceContainer.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.tlpCostRules.ResumeLayout(false);
            this.tlpCostRuleButtons.ResumeLayout(false);
            this.tlpCostRuleButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Presentation.Controls.ContainerLayoutPanel tlpTourPriceContainer;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private Presentation.Controls.ContainerLayoutPanel tlpCostRules;
        private System.Windows.Forms.TableLayoutPanel tlpCostRuleButtons;
        private Presentation.Controls.ContainerLayoutPanel tlpCostGroups;
        private System.Windows.Forms.TableLayoutPanel tlpCostGroupButtons;
    }
}
