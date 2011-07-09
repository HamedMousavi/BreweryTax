using TaxDataStore.Presentation.Controls;
namespace TaxDataStore
{
    partial class FrmDailyTours
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
            this.tlpToursContainer = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.tlpToursToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDate = new System.Windows.Forms.TableLayoutPanel();
            this.dtpCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.tlpTours = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.tlpToursContainer.SuspendLayout();
            this.tlpToursToolbar.SuspendLayout();
            this.tlpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpToursContainer, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(649, 456);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpToursContainer
            // 
            this.tlpToursContainer.BackColor = System.Drawing.Color.White;
            this.tlpToursContainer.ColumnCount = 1;
            this.tlpToursContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToursContainer.Controls.Add(this.tlpToursToolbar, 0, 0);
            this.tlpToursContainer.Controls.Add(this.tlpTours, 0, 1);
            this.tlpToursContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpToursContainer.Location = new System.Drawing.Point(3, 3);
            this.tlpToursContainer.Name = "tlpToursContainer";
            this.tlpToursContainer.RowCount = 2;
            this.tlpToursContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpToursContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToursContainer.Size = new System.Drawing.Size(643, 450);
            this.tlpToursContainer.TabIndex = 8;
            // 
            // tlpToursToolbar
            // 
            this.tlpToursToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpToursToolbar.ColumnCount = 6;
            this.tlpToursToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpToursToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpToursToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpToursToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpToursToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpToursToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToursToolbar.Controls.Add(this.rtbComments, 5, 0);
            this.tlpToursToolbar.Controls.Add(this.tlpButtons, 4, 0);
            this.tlpToursToolbar.Controls.Add(this.tlpDate, 2, 0);
            this.tlpToursToolbar.Location = new System.Drawing.Point(0, 0);
            this.tlpToursToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpToursToolbar.Name = "tlpToursToolbar";
            this.tlpToursToolbar.RowCount = 1;
            this.tlpToursToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToursToolbar.Size = new System.Drawing.Size(643, 32);
            this.tlpToursToolbar.TabIndex = 6;
            // 
            // rtbComments
            // 
            this.rtbComments.BackColor = System.Drawing.Color.White;
            this.rtbComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbComments.Location = new System.Drawing.Point(526, 3);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.ReadOnly = true;
            this.rtbComments.Size = new System.Drawing.Size(74, 26);
            this.rtbComments.TabIndex = 1;
            this.rtbComments.Text = "";
            this.rtbComments.Visible = false;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 4;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(220, 0);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(303, 32);
            this.tlpButtons.TabIndex = 0;
            // 
            // tlpDate
            // 
            this.tlpDate.ColumnCount = 2;
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDate.Controls.Add(this.dtpCurrentDate, 1, 0);
            this.tlpDate.Location = new System.Drawing.Point(20, 0);
            this.tlpDate.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDate.Name = "tlpDate";
            this.tlpDate.RowCount = 1;
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDate.Size = new System.Drawing.Size(200, 31);
            this.tlpDate.TabIndex = 9;
            // 
            // dtpCurrentDate
            // 
            this.dtpCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCurrentDate.Location = new System.Drawing.Point(3, 5);
            this.dtpCurrentDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dtpCurrentDate.Name = "dtpCurrentDate";
            this.dtpCurrentDate.Size = new System.Drawing.Size(194, 22);
            this.dtpCurrentDate.TabIndex = 3;
            this.dtpCurrentDate.ValueChanged += new System.EventHandler(this.dtpCurrentDate_ValueChanged);
            // 
            // tlpTours
            // 
            this.tlpTours.ColumnCount = 1;
            this.tlpTours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTours.Location = new System.Drawing.Point(3, 35);
            this.tlpTours.Name = "tlpTours";
            this.tlpTours.RowCount = 1;
            this.tlpTours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 412F));
            this.tlpTours.Size = new System.Drawing.Size(637, 412);
            this.tlpTours.TabIndex = 7;
            // 
            // FrmDailyTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 456);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmDailyTours";
            this.Text = "Daily tours";
            this.tlpMain.ResumeLayout(false);
            this.tlpToursContainer.ResumeLayout(false);
            this.tlpToursToolbar.ResumeLayout(false);
            this.tlpDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private ContainerLayoutPanel tlpToursContainer;
        private System.Windows.Forms.TableLayoutPanel tlpToursToolbar;
        private System.Windows.Forms.DateTimePicker dtpCurrentDate;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.TableLayoutPanel tlpDate;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.TableLayoutPanel tlpTours;
    }
}