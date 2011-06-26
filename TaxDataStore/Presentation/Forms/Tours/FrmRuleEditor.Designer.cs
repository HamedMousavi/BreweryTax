using TaxDataStore.Presentation.Controls;
namespace TaxDataStore
{
    partial class FrmRuleEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tbxRuleName = new System.Windows.Forms.TextBox();
            this.tlpFormula = new System.Windows.Forms.TableLayoutPanel();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.cbxValueOperation = new System.Windows.Forms.ComboBox();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new TaxDataStore.Presentation.Controls.ButtonBase();
            this.btnSave = new TaxDataStore.Presentation.Controls.ButtonBase();
            this.tlpConstraints = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.tlpConstraintButtons = new System.Windows.Forms.TableLayoutPanel();
            this.lblConstraints = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.btnConstraintsEdit = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnConstraintsAdd = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnConstraintsDelete = new TaxDataStore.Presentation.Controls.FlatButton();
            this.tlpMain.SuspendLayout();
            this.tlpFormula.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpConstraints.SuspendLayout();
            this.tlpConstraintButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tbxRuleName, 1, 0);
            this.tlpMain.Controls.Add(this.tlpFormula, 1, 1);
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 3);
            this.tlpMain.Controls.Add(this.tlpConstraints, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(395, 244);
            this.tlpMain.TabIndex = 0;
            // 
            // tbxRuleName
            // 
            this.tbxRuleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRuleName.Location = new System.Drawing.Point(3, 3);
            this.tbxRuleName.Name = "tbxRuleName";
            this.tbxRuleName.Size = new System.Drawing.Size(389, 22);
            this.tbxRuleName.TabIndex = 1;
            // 
            // tlpFormula
            // 
            this.tlpFormula.ColumnCount = 3;
            this.tlpFormula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpFormula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpFormula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFormula.Controls.Add(this.tbxValue, 1, 0);
            this.tlpFormula.Controls.Add(this.cbxValueOperation, 2, 0);
            this.tlpFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFormula.Location = new System.Drawing.Point(3, 31);
            this.tlpFormula.Name = "tlpFormula";
            this.tlpFormula.RowCount = 1;
            this.tlpFormula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFormula.Size = new System.Drawing.Size(389, 32);
            this.tlpFormula.TabIndex = 5;
            // 
            // tbxValue
            // 
            this.tbxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxValue.Location = new System.Drawing.Point(178, 3);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(130, 22);
            this.tbxValue.TabIndex = 4;
            // 
            // cbxValueOperation
            // 
            this.cbxValueOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxValueOperation.FormattingEnabled = true;
            this.cbxValueOperation.Location = new System.Drawing.Point(314, 3);
            this.cbxValueOperation.Name = "cbxValueOperation";
            this.cbxValueOperation.Size = new System.Drawing.Size(72, 22);
            this.cbxValueOperation.TabIndex = 5;
            // 
            // tlpButtons
            // 
            this.tlpButtons.AutoSize = true;
            this.tlpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpButtons.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tlpButtons, 2);
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.Controls.Add(this.btnCancel, 2, 0);
            this.tlpButtons.Controls.Add(this.btnSave, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(0, 212);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(395, 32);
            this.tlpButtons.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(317, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(236, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tlpConstraints
            // 
            this.tlpConstraints.BackColor = System.Drawing.Color.White;
            this.tlpConstraints.ColumnCount = 1;
            this.tlpMain.SetColumnSpan(this.tlpConstraints, 2);
            this.tlpConstraints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConstraints.Controls.Add(this.tlpConstraintButtons, 0, 0);
            this.tlpConstraints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConstraints.Location = new System.Drawing.Point(3, 69);
            this.tlpConstraints.Name = "tlpConstraints";
            this.tlpConstraints.RowCount = 2;
            this.tlpConstraints.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConstraints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConstraints.Size = new System.Drawing.Size(389, 140);
            this.tlpConstraints.TabIndex = 7;
            // 
            // tlpConstraintButtons
            // 
            this.tlpConstraintButtons.AutoSize = true;
            this.tlpConstraintButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpConstraintButtons.ColumnCount = 5;
            this.tlpConstraintButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpConstraintButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpConstraintButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpConstraintButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpConstraintButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConstraintButtons.Controls.Add(this.lblConstraints, 0, 0);
            this.tlpConstraintButtons.Controls.Add(this.btnConstraintsEdit, 2, 0);
            this.tlpConstraintButtons.Controls.Add(this.btnConstraintsAdd, 1, 0);
            this.tlpConstraintButtons.Controls.Add(this.btnConstraintsDelete, 3, 0);
            this.tlpConstraintButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConstraintButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpConstraintButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpConstraintButtons.Name = "tlpConstraintButtons";
            this.tlpConstraintButtons.RowCount = 1;
            this.tlpConstraintButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConstraintButtons.Size = new System.Drawing.Size(389, 30);
            this.tlpConstraintButtons.TabIndex = 0;
            // 
            // lblConstraints
            // 
            this.lblConstraints.AutoSize = true;
            this.lblConstraints.Location = new System.Drawing.Point(3, 0);
            this.lblConstraints.Name = "lblConstraints";
            this.lblConstraints.Size = new System.Drawing.Size(67, 14);
            this.lblConstraints.TabIndex = 0;
            this.lblConstraints.Text = "Constraints";
            // 
            // btnConstraintsEdit
            // 
            this.btnConstraintsEdit.Location = new System.Drawing.Point(165, 3);
            this.btnConstraintsEdit.Name = "btnConstraintsEdit";
            this.btnConstraintsEdit.Size = new System.Drawing.Size(75, 23);
            this.btnConstraintsEdit.TabIndex = 2;
            this.btnConstraintsEdit.Text = "Edit";
            this.btnConstraintsEdit.UseVisualStyleBackColor = true;
            // 
            // btnConstraintsAdd
            // 
            this.btnConstraintsAdd.AutoSize = true;
            this.btnConstraintsAdd.Location = new System.Drawing.Point(76, 3);
            this.btnConstraintsAdd.Name = "btnConstraintsAdd";
            this.btnConstraintsAdd.Size = new System.Drawing.Size(83, 24);
            this.btnConstraintsAdd.TabIndex = 3;
            this.btnConstraintsAdd.Text = "Add";
            this.btnConstraintsAdd.UseVisualStyleBackColor = true;
            // 
            // btnConstraintsDelete
            // 
            this.btnConstraintsDelete.Location = new System.Drawing.Point(246, 3);
            this.btnConstraintsDelete.Name = "btnConstraintsDelete";
            this.btnConstraintsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnConstraintsDelete.TabIndex = 4;
            this.btnConstraintsDelete.Text = "Remove";
            this.btnConstraintsDelete.UseVisualStyleBackColor = true;
            // 
            // FrmRuleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 244);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRuleEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit rule";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpFormula.ResumeLayout(false);
            this.tlpFormula.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.tlpConstraints.ResumeLayout(false);
            this.tlpConstraints.PerformLayout();
            this.tlpConstraintButtons.ResumeLayout(false);
            this.tlpConstraintButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TextBox tbxRuleName;
        private System.Windows.Forms.TableLayoutPanel tlpFormula;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.ComboBox cbxValueOperation;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private ButtonBase btnCancel;
        private ButtonBase btnSave;
        private ContainerLayoutPanel tlpConstraints;
        private System.Windows.Forms.TableLayoutPanel tlpConstraintButtons;
        private ToolbarLabel lblConstraints;
        private FlatButton btnConstraintsEdit;
        private FlatButton btnConstraintsDelete;
        private FlatButton btnConstraintsAdd;
    }
}