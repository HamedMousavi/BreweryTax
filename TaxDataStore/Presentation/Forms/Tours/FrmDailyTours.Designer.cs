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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEmployees = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.lblEmployees = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.tlpTourMembers = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.lblTourMembers = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.tlpMemberContacts = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.lblMemberContacts = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.tlpTourCosts = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.lblTourCosts = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.tlpToursContainer = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.tlpTours = new System.Windows.Forms.TableLayoutPanel();
            this.tlpToursToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTour = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnEditTour = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnDeleteTour = new TaxDataStore.Presentation.Controls.FlatButton();
            this.label1 = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.tlpDate = new System.Windows.Forms.TableLayoutPanel();
            this.dtpCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.tlpNotes = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.lblNotes = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpEmployees.SuspendLayout();
            this.tlpTourMembers.SuspendLayout();
            this.tlpMemberContacts.SuspendLayout();
            this.tlpTourCosts.SuspendLayout();
            this.tlpToursContainer.SuspendLayout();
            this.tlpToursToolbar.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpDate.SuspendLayout();
            this.tlpNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.White;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpEmployees, 0, 3);
            this.tlpMain.Controls.Add(this.tlpNotes, 1, 3);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpMain.Controls.Add(this.tlpToursContainer, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Size = new System.Drawing.Size(649, 456);
            this.tlpMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tlpTourMembers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpMemberContacts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpTourCosts, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 205);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 136);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tlpEmployees
            // 
            this.tlpEmployees.BackColor = System.Drawing.Color.White;
            this.tlpEmployees.ColumnCount = 1;
            this.tlpEmployees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployees.Controls.Add(this.lblEmployees, 0, 0);
            this.tlpEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployees.Location = new System.Drawing.Point(3, 344);
            this.tlpEmployees.Name = "tlpEmployees";
            this.tlpEmployees.RowCount = 2;
            this.tlpEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployees.Size = new System.Drawing.Size(154, 109);
            this.tlpEmployees.TabIndex = 6;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(3, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(65, 14);
            this.lblEmployees.TabIndex = 0;
            this.lblEmployees.Text = "Employees";
            // 
            // tlpTourMembers
            // 
            this.tlpTourMembers.BackColor = System.Drawing.Color.White;
            this.tlpTourMembers.ColumnCount = 1;
            this.tlpTourMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourMembers.Controls.Add(this.lblTourMembers, 0, 0);
            this.tlpTourMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTourMembers.Location = new System.Drawing.Point(3, 3);
            this.tlpTourMembers.Name = "tlpTourMembers";
            this.tlpTourMembers.RowCount = 2;
            this.tlpTourMembers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTourMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourMembers.Size = new System.Drawing.Size(154, 130);
            this.tlpTourMembers.TabIndex = 6;
            // 
            // lblTourMembers
            // 
            this.lblTourMembers.AutoSize = true;
            this.lblTourMembers.Location = new System.Drawing.Point(3, 0);
            this.lblTourMembers.Name = "lblTourMembers";
            this.lblTourMembers.Size = new System.Drawing.Size(86, 14);
            this.lblTourMembers.TabIndex = 0;
            this.lblTourMembers.Text = "Tour Members";
            // 
            // tlpMemberContacts
            // 
            this.tlpMemberContacts.BackColor = System.Drawing.Color.White;
            this.tlpMemberContacts.ColumnCount = 1;
            this.tlpMemberContacts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMemberContacts.Controls.Add(this.lblMemberContacts, 0, 0);
            this.tlpMemberContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMemberContacts.Location = new System.Drawing.Point(163, 3);
            this.tlpMemberContacts.Name = "tlpMemberContacts";
            this.tlpMemberContacts.RowCount = 2;
            this.tlpMemberContacts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMemberContacts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMemberContacts.Size = new System.Drawing.Size(222, 130);
            this.tlpMemberContacts.TabIndex = 6;
            // 
            // lblMemberContacts
            // 
            this.lblMemberContacts.AutoSize = true;
            this.lblMemberContacts.Location = new System.Drawing.Point(3, 0);
            this.lblMemberContacts.Name = "lblMemberContacts";
            this.lblMemberContacts.Size = new System.Drawing.Size(103, 14);
            this.lblMemberContacts.TabIndex = 0;
            this.lblMemberContacts.Text = "Member Contacts";
            // 
            // tlpTourCosts
            // 
            this.tlpTourCosts.BackColor = System.Drawing.Color.White;
            this.tlpTourCosts.ColumnCount = 1;
            this.tlpTourCosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourCosts.Controls.Add(this.lblTourCosts, 0, 0);
            this.tlpTourCosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTourCosts.Location = new System.Drawing.Point(391, 3);
            this.tlpTourCosts.Name = "tlpTourCosts";
            this.tlpTourCosts.RowCount = 2;
            this.tlpTourCosts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTourCosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourCosts.Size = new System.Drawing.Size(255, 130);
            this.tlpTourCosts.TabIndex = 6;
            // 
            // lblTourCosts
            // 
            this.lblTourCosts.AutoSize = true;
            this.lblTourCosts.Location = new System.Drawing.Point(3, 0);
            this.lblTourCosts.Name = "lblTourCosts";
            this.lblTourCosts.Size = new System.Drawing.Size(66, 14);
            this.lblTourCosts.TabIndex = 0;
            this.lblTourCosts.Text = "Tour Costs";
            // 
            // tlpToursContainer
            // 
            this.tlpToursContainer.BackColor = System.Drawing.Color.White;
            this.tlpToursContainer.ColumnCount = 1;
            this.tlpMain.SetColumnSpan(this.tlpToursContainer, 2);
            this.tlpToursContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToursContainer.Controls.Add(this.tlpTours, 0, 1);
            this.tlpToursContainer.Controls.Add(this.tlpToursToolbar, 0, 0);
            this.tlpToursContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpToursContainer.Location = new System.Drawing.Point(3, 3);
            this.tlpToursContainer.Name = "tlpToursContainer";
            this.tlpToursContainer.RowCount = 2;
            this.tlpToursContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpToursContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToursContainer.Size = new System.Drawing.Size(643, 199);
            this.tlpToursContainer.TabIndex = 8;
            // 
            // tlpTours
            // 
            this.tlpTours.BackColor = System.Drawing.Color.White;
            this.tlpTours.ColumnCount = 1;
            this.tlpTours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTours.Location = new System.Drawing.Point(3, 35);
            this.tlpTours.Name = "tlpTours";
            this.tlpTours.RowCount = 1;
            this.tlpTours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTours.Size = new System.Drawing.Size(637, 161);
            this.tlpTours.TabIndex = 7;
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
            this.tlpToursToolbar.Controls.Add(this.tlpButtons, 4, 0);
            this.tlpToursToolbar.Controls.Add(this.label1, 0, 0);
            this.tlpToursToolbar.Controls.Add(this.tlpDate, 2, 0);
            this.tlpToursToolbar.Location = new System.Drawing.Point(0, 0);
            this.tlpToursToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpToursToolbar.Name = "tlpToursToolbar";
            this.tlpToursToolbar.RowCount = 1;
            this.tlpToursToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpToursToolbar.Size = new System.Drawing.Size(643, 32);
            this.tlpToursToolbar.TabIndex = 6;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 4;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Controls.Add(this.btnAddTour, 0, 0);
            this.tlpButtons.Controls.Add(this.btnEditTour, 1, 0);
            this.tlpButtons.Controls.Add(this.btnDeleteTour, 2, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(267, 0);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(303, 32);
            this.tlpButtons.TabIndex = 0;
            // 
            // btnAddTour
            // 
            this.btnAddTour.AutoSize = true;
            this.btnAddTour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnAddTour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnAddTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTour.ForeColor = System.Drawing.Color.Black;
            this.btnAddTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTour.Location = new System.Drawing.Point(0, 0);
            this.btnAddTour.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddTour.Size = new System.Drawing.Size(70, 28);
            this.btnAddTour.TabIndex = 0;
            this.btnAddTour.Text = "Add tour";
            this.btnAddTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTour.UseVisualStyleBackColor = false;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // btnEditTour
            // 
            this.btnEditTour.AutoSize = true;
            this.btnEditTour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnEditTour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnEditTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTour.ForeColor = System.Drawing.Color.Black;
            this.btnEditTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTour.Location = new System.Drawing.Point(70, 0);
            this.btnEditTour.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditTour.Name = "btnEditTour";
            this.btnEditTour.Padding = new System.Windows.Forms.Padding(1);
            this.btnEditTour.Size = new System.Drawing.Size(69, 28);
            this.btnEditTour.TabIndex = 1;
            this.btnEditTour.Text = "Edit tour";
            this.btnEditTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTour.UseVisualStyleBackColor = false;
            this.btnEditTour.Click += new System.EventHandler(this.btnEditTour_Click);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.AutoSize = true;
            this.btnDeleteTour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.btnDeleteTour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(135)))), ((int)(((byte)(160)))));
            this.btnDeleteTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTour.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTour.Location = new System.Drawing.Point(139, 0);
            this.btnDeleteTour.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Padding = new System.Windows.Forms.Padding(1);
            this.btnDeleteTour.Size = new System.Drawing.Size(84, 28);
            this.btnDeleteTour.TabIndex = 2;
            this.btnDeleteTour.Text = "Delete tour";
            this.btnDeleteTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteTour.UseVisualStyleBackColor = false;
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tours";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpDate
            // 
            this.tlpDate.ColumnCount = 2;
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDate.Controls.Add(this.dtpCurrentDate, 1, 0);
            this.tlpDate.Controls.Add(this.lblDate, 0, 0);
            this.tlpDate.Location = new System.Drawing.Point(67, 0);
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
            this.dtpCurrentDate.Location = new System.Drawing.Point(45, 5);
            this.dtpCurrentDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dtpCurrentDate.Name = "dtpCurrentDate";
            this.dtpCurrentDate.Size = new System.Drawing.Size(152, 22);
            this.dtpCurrentDate.TabIndex = 3;
            this.dtpCurrentDate.ValueChanged += new System.EventHandler(this.dtpCurrentDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.Location = new System.Drawing.Point(3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 31);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpNotes
            // 
            this.tlpNotes.BackColor = System.Drawing.Color.White;
            this.tlpNotes.ColumnCount = 1;
            this.tlpNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNotes.Controls.Add(this.rtbComments, 0, 1);
            this.tlpNotes.Controls.Add(this.lblNotes, 0, 0);
            this.tlpNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNotes.Location = new System.Drawing.Point(163, 344);
            this.tlpNotes.Name = "tlpNotes";
            this.tlpNotes.RowCount = 2;
            this.tlpNotes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNotes.Size = new System.Drawing.Size(483, 109);
            this.tlpNotes.TabIndex = 6;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(3, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(39, 14);
            this.lblNotes.TabIndex = 0;
            this.lblNotes.Text = "Notes";
            // 
            // rtbComments
            // 
            this.rtbComments.BackColor = System.Drawing.Color.White;
            this.rtbComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbComments.Location = new System.Drawing.Point(3, 17);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.ReadOnly = true;
            this.rtbComments.Size = new System.Drawing.Size(477, 89);
            this.rtbComments.TabIndex = 1;
            this.rtbComments.Text = "";
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpEmployees.ResumeLayout(false);
            this.tlpEmployees.PerformLayout();
            this.tlpTourMembers.ResumeLayout(false);
            this.tlpTourMembers.PerformLayout();
            this.tlpMemberContacts.ResumeLayout(false);
            this.tlpMemberContacts.PerformLayout();
            this.tlpTourCosts.ResumeLayout(false);
            this.tlpTourCosts.PerformLayout();
            this.tlpToursContainer.ResumeLayout(false);
            this.tlpToursToolbar.ResumeLayout(false);
            this.tlpToursToolbar.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.tlpDate.ResumeLayout(false);
            this.tlpDate.PerformLayout();
            this.tlpNotes.ResumeLayout(false);
            this.tlpNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ContainerLayoutPanel tlpToursContainer;
        private System.Windows.Forms.TableLayoutPanel tlpToursToolbar;
        private System.Windows.Forms.DateTimePicker dtpCurrentDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private FlatButton btnAddTour;
        private FlatButton btnEditTour;
        private FlatButton btnDeleteTour;
        private ToolbarLabel label1;
        private System.Windows.Forms.TableLayoutPanel tlpTours;
        private System.Windows.Forms.TableLayoutPanel tlpDate;
        private ContainerLayoutPanel tlpTourMembers;
        private ToolbarLabel lblTourMembers;
        private ContainerLayoutPanel tlpEmployees;
        private ToolbarLabel lblEmployees;
        private ContainerLayoutPanel tlpMemberContacts;
        private ToolbarLabel lblMemberContacts;
        private ContainerLayoutPanel tlpTourCosts;
        private ToolbarLabel lblTourCosts;
        private ContainerLayoutPanel tlpNotes;
        private ToolbarLabel lblNotes;
        private System.Windows.Forms.RichTextBox rtbComments;
    }
}