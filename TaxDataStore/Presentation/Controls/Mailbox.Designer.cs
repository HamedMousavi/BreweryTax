namespace TaxDataStore.Presentation.Controls
{
    sealed partial class Mailbox
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
            this.tlpMails = new System.Windows.Forms.TableLayoutPanel();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblTile = new System.Windows.Forms.Label();
            this.tbxContent = new System.Windows.Forms.TextBox();
            this.etbMailList = new TaxDataStore.EditToolbar();
            this.etbMail = new TaxDataStore.EditToolbar();
            this.tlpMails.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMails
            // 
            this.tlpMails.ColumnCount = 2;
            this.tlpMails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMails.Controls.Add(this.etbMailList, 0, 0);
            this.tlpMails.Controls.Add(this.etbMail, 1, 0);
            this.tlpMails.Controls.Add(this.tlpContent, 1, 1);
            this.tlpMails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpMails.Location = new System.Drawing.Point(0, 0);
            this.tlpMails.Name = "tlpMails";
            this.tlpMails.RowCount = 2;
            this.tlpMails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMails.Size = new System.Drawing.Size(490, 440);
            this.tlpMails.TabIndex = 1;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 1;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Controls.Add(this.lblTile, 0, 0);
            this.tlpContent.Controls.Add(this.tbxContent, 0, 1);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(248, 32);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 2;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(239, 405);
            this.tlpContent.TabIndex = 2;
            // 
            // lblTile
            // 
            this.lblTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTile.AutoSize = true;
            this.lblTile.BackColor = System.Drawing.SystemColors.Window;
            this.lblTile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTile.Location = new System.Drawing.Point(3, 0);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(233, 19);
            this.lblTile.TabIndex = 3;
            this.lblTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxContent
            // 
            this.tbxContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxContent.Location = new System.Drawing.Point(3, 22);
            this.tbxContent.Multiline = true;
            this.tbxContent.Name = "tbxContent";
            this.tbxContent.Size = new System.Drawing.Size(233, 380);
            this.tbxContent.TabIndex = 4;
            // 
            // etbMailList
            // 
            this.etbMailList.AddContextMenu = null;
            this.etbMailList.AutoSize = true;
            this.etbMailList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.etbMailList.ButtonAutohide = false;
            this.etbMailList.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.etbMailList.Location = new System.Drawing.Point(0, 0);
            this.etbMailList.Margin = new System.Windows.Forms.Padding(0);
            this.etbMailList.Name = "etbMailList";
            this.etbMailList.ShowAdd = true;
            this.etbMailList.ShowDelete = true;
            this.etbMailList.ShowEdit = true;
            this.etbMailList.Size = new System.Drawing.Size(245, 29);
            this.etbMailList.TabIndex = 0;
            this.etbMailList.Title = "Messages";
            // 
            // etbMail
            // 
            this.etbMail.AddContextMenu = null;
            this.etbMail.AutoSize = true;
            this.etbMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.etbMail.ButtonAutohide = false;
            this.etbMail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.etbMail.Location = new System.Drawing.Point(245, 0);
            this.etbMail.Margin = new System.Windows.Forms.Padding(0);
            this.etbMail.Name = "etbMail";
            this.etbMail.ShowAdd = true;
            this.etbMail.ShowDelete = true;
            this.etbMail.ShowEdit = true;
            this.etbMail.Size = new System.Drawing.Size(245, 29);
            this.etbMail.TabIndex = 1;
            this.etbMail.Title = "Selected";
            // 
            // Mailbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMails);
            this.Name = "Mailbox";
            this.Size = new System.Drawing.Size(490, 440);
            this.tlpMails.ResumeLayout(false);
            this.tlpMails.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.tlpContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMails;
        private EditToolbar etbMailList;
        private EditToolbar etbMail;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.TextBox tbxContent;
    }
}
