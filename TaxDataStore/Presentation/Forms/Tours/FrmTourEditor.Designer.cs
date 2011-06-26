using TaxDataStore.Presentation.Controls;
namespace TaxDataStore
{
    partial class FrmTourEditor
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
            this.tlpTour = new System.Windows.Forms.TableLayoutPanel();
            this.gpxCostGroups = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.tlpTourState = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirm = new ButtonBase();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbpTour = new System.Windows.Forms.TabPage();
            this.tbpMembers = new System.Windows.Forms.TabPage();
            this.tlpTourMembers = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.tlpMemberToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTourMember = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnRemoveTourMember = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnEditTourMember = new TaxDataStore.Presentation.Controls.FlatButton();
            this.tbpStaff = new System.Windows.Forms.TabPage();
            this.tlpStaff = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEmployeeToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveEmployee = new ButtonBase();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.tbpReceipt = new System.Windows.Forms.TabPage();
            this.tlpReceipt = new ContainerLayoutPanel();
            this.tbpPayments = new System.Windows.Forms.TabPage();
            this.tlpPayments = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.btnAddPayment = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnEditPayment = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnRemovePayment = new TaxDataStore.Presentation.Controls.FlatButton();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new ButtonBase();
            this.btnSave = new ButtonBase();
            this.tlpTour.SuspendLayout();
            this.tlpTourState.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbpTour.SuspendLayout();
            this.tbpMembers.SuspendLayout();
            this.tlpTourMembers.SuspendLayout();
            this.tlpMemberToolbar.SuspendLayout();
            this.tbpStaff.SuspendLayout();
            this.tlpStaff.SuspendLayout();
            this.tlpEmployeeToolbar.SuspendLayout();
            this.tbpReceipt.SuspendLayout();
            this.tlpReceipt.SuspendLayout();
            this.tbpPayments.SuspendLayout();
            this.tlpPayments.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTour
            // 
            this.tlpTour.ColumnCount = 2;
            this.tlpTour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));

            this.tlpTour.Controls.Add(this.gpxCostGroups, 0, 5);

            this.tlpTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTour.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpTour.Location = new System.Drawing.Point(0, 0);
            this.tlpTour.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTour.Name = "tlpTour";
            this.tlpTour.RowCount = 6;
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTour.Size = new System.Drawing.Size(567, 332);
            this.tlpTour.TabIndex = 0;
            // 
            // gpxCostGroups
            // 
            this.tlpTour.SetColumnSpan(this.gpxCostGroups, 2);
            this.gpxCostGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpxCostGroups.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpxCostGroups.ForeColor = System.Drawing.Color.Gray;
            this.gpxCostGroups.Location = new System.Drawing.Point(3, 120);
            this.gpxCostGroups.Name = "gpxCostGroups";
            this.gpxCostGroups.Size = new System.Drawing.Size(561, 209);
            this.gpxCostGroups.TabIndex = 16;
            this.gpxCostGroups.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(88, 35);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(476, 22);
            this.dtpDate.TabIndex = 1;
            // 
            // dtpTime
            // 
            this.dtpTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(88, 63);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(476, 22);
            this.dtpTime.TabIndex = 3;
            // 
            // tlpTourState
            // 
            this.tlpTourState.ColumnCount = 3;
            this.tlpTourState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTourState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTourState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTourState.Controls.Add(this.btnConfirm, 1, 0);
            this.tlpTourState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTourState.Location = new System.Drawing.Point(85, 0);
            this.tlpTourState.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTourState.Name = "tlpTourState";
            this.tlpTourState.RowCount = 1;
            this.tlpTourState.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourState.Size = new System.Drawing.Size(482, 32);
            this.tlpTourState.TabIndex = 13;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Location = new System.Drawing.Point(99, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(58, 25);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbpTour);
            this.tabMain.Controls.Add(this.tbpMembers);
            this.tabMain.Controls.Add(this.tbpStaff);
            this.tabMain.Controls.Add(this.tbpReceipt);
            this.tabMain.Controls.Add(this.tbpPayments);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabMain.Location = new System.Drawing.Point(3, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(575, 359);
            this.tabMain.TabIndex = 2;
            // 
            // tbpTour
            // 
            this.tbpTour.Controls.Add(this.tlpTour);
            this.tbpTour.Location = new System.Drawing.Point(4, 23);
            this.tbpTour.Name = "tbpTour";
            this.tbpTour.Size = new System.Drawing.Size(567, 332);
            this.tbpTour.TabIndex = 0;
            this.tbpTour.Text = "Tour";
            this.tbpTour.UseVisualStyleBackColor = true;
            // 
            // tbpMembers
            // 
            this.tbpMembers.Controls.Add(this.tlpTourMembers);
            this.tbpMembers.Location = new System.Drawing.Point(4, 23);
            this.tbpMembers.Name = "tbpMembers";
            this.tbpMembers.Size = new System.Drawing.Size(567, 332);
            this.tbpMembers.TabIndex = 3;
            this.tbpMembers.Text = "Members/Contacts";
            this.tbpMembers.UseVisualStyleBackColor = true;
            // 
            // tlpTourMembers
            // 
            this.tlpTourMembers.ColumnCount = 2;
            this.tlpTourMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpTourMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpTourMembers.Controls.Add(this.tlpMemberToolbar, 0, 0);
            this.tlpTourMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTourMembers.Location = new System.Drawing.Point(0, 0);
            this.tlpTourMembers.Name = "tlpTourMembers";
            this.tlpTourMembers.RowCount = 2;
            this.tlpTourMembers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTourMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTourMembers.Size = new System.Drawing.Size(567, 332);
            this.tlpTourMembers.TabIndex = 1;
            // 
            // tlpMemberToolbar
            // 
            this.tlpMemberToolbar.ColumnCount = 4;
            this.tlpMemberToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMemberToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMemberToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMemberToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMemberToolbar.Controls.Add(this.btnAddTourMember, 1, 0);
            this.tlpMemberToolbar.Controls.Add(this.btnRemoveTourMember, 3, 0);
            this.tlpMemberToolbar.Controls.Add(this.btnEditTourMember, 2, 0);
            this.tlpMemberToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMemberToolbar.Location = new System.Drawing.Point(0, 0);
            this.tlpMemberToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMemberToolbar.Name = "tlpMemberToolbar";
            this.tlpMemberToolbar.RowCount = 1;
            this.tlpMemberToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMemberToolbar.Size = new System.Drawing.Size(170, 30);
            this.tlpMemberToolbar.TabIndex = 3;
            // 
            // btnAddTourMember
            // 
            this.btnAddTourMember.Location = new System.Drawing.Point(83, 3);
            this.btnAddTourMember.Name = "btnAddTourMember";
            this.btnAddTourMember.Size = new System.Drawing.Size(24, 24);
            this.btnAddTourMember.TabIndex = 1;
            this.btnAddTourMember.UseVisualStyleBackColor = true;
            this.btnAddTourMember.Click += new System.EventHandler(this.btnAddTourMember_Click);
            // 
            // btnRemoveTourMember
            // 
            this.btnRemoveTourMember.Location = new System.Drawing.Point(143, 3);
            this.btnRemoveTourMember.Name = "btnRemoveTourMember";
            this.btnRemoveTourMember.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveTourMember.TabIndex = 1;
            this.btnRemoveTourMember.UseVisualStyleBackColor = true;
            this.btnRemoveTourMember.Click += new System.EventHandler(this.btnRemoveTourMember_Click);
            // 
            // btnEditTourMember
            // 
            this.btnEditTourMember.Location = new System.Drawing.Point(113, 3);
            this.btnEditTourMember.Name = "btnEditTourMember";
            this.btnEditTourMember.Size = new System.Drawing.Size(24, 24);
            this.btnEditTourMember.TabIndex = 2;
            this.btnEditTourMember.UseVisualStyleBackColor = true;
            this.btnEditTourMember.Click += new System.EventHandler(this.btnEditTourMember_Click);
            // 
            // tbpStaff
            // 
            this.tbpStaff.Controls.Add(this.tlpStaff);
            this.tbpStaff.Location = new System.Drawing.Point(4, 23);
            this.tbpStaff.Name = "tbpStaff";
            this.tbpStaff.Size = new System.Drawing.Size(567, 332);
            this.tbpStaff.TabIndex = 1;
            this.tbpStaff.Text = "Staff";
            this.tbpStaff.UseVisualStyleBackColor = true;
            // 
            // tlpStaff
            // 
            this.tlpStaff.ColumnCount = 2;
            this.tlpStaff.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpStaff.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStaff.Controls.Add(this.tlpEmployeeToolbar, 0, 0);
            this.tlpStaff.Controls.Add(this.rtbComments, 1, 1);
            this.tlpStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStaff.Location = new System.Drawing.Point(0, 0);
            this.tlpStaff.Margin = new System.Windows.Forms.Padding(0);
            this.tlpStaff.Name = "tlpStaff";
            this.tlpStaff.RowCount = 2;
            this.tlpStaff.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStaff.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStaff.Size = new System.Drawing.Size(567, 332);
            this.tlpStaff.TabIndex = 0;
            // 
            // tlpEmployeeToolbar
            // 
            this.tlpEmployeeToolbar.ColumnCount = 3;
            this.tlpEmployeeToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployeeToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEmployeeToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEmployeeToolbar.Controls.Add(this.btnRemoveEmployee, 2, 0);
            this.tlpEmployeeToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployeeToolbar.Location = new System.Drawing.Point(0, 0);
            this.tlpEmployeeToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEmployeeToolbar.Name = "tlpEmployeeToolbar";
            this.tlpEmployeeToolbar.RowCount = 1;
            this.tlpEmployeeToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployeeToolbar.Size = new System.Drawing.Size(140, 32);
            this.tlpEmployeeToolbar.TabIndex = 3;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.AutoSize = true;
            this.btnRemoveEmployee.Location = new System.Drawing.Point(113, 3);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveEmployee.TabIndex = 1;
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // rtbComments
            // 
            this.rtbComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbComments.Location = new System.Drawing.Point(143, 35);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(421, 294);
            this.rtbComments.TabIndex = 19;
            this.rtbComments.Text = "";
            // 
            // tbpReceipt
            // 
            this.tbpReceipt.Controls.Add(this.tlpReceipt);
            this.tbpReceipt.Location = new System.Drawing.Point(4, 23);
            this.tbpReceipt.Name = "tbpReceipt";
            this.tbpReceipt.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReceipt.Size = new System.Drawing.Size(567, 332);
            this.tbpReceipt.TabIndex = 4;
            this.tbpReceipt.Text = "Receipt";
            this.tbpReceipt.UseVisualStyleBackColor = true;
            // 
            // tlpReceipt
            // 
            this.tlpReceipt.ColumnCount = 1;
            this.tlpReceipt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpReceipt.Location = new System.Drawing.Point(3, 3);
            this.tlpReceipt.Name = "tlpReceipt";
            this.tlpReceipt.RowCount = 3;
            this.tlpReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpReceipt.Size = new System.Drawing.Size(561, 326);
            this.tlpReceipt.TabIndex = 0;
            // 
            // tbpPayments
            // 
            this.tbpPayments.Controls.Add(this.tlpPayments);
            this.tbpPayments.Location = new System.Drawing.Point(4, 23);
            this.tbpPayments.Name = "tbpPayments";
            this.tbpPayments.Size = new System.Drawing.Size(567, 332);
            this.tbpPayments.TabIndex = 2;
            this.tbpPayments.Text = "Payments";
            this.tbpPayments.UseVisualStyleBackColor = true;
            // 
            // tlpPayments
            // 
            this.tlpPayments.BackColor = System.Drawing.Color.White;
            this.tlpPayments.ColumnCount = 4;
            this.tlpPayments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPayments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPayments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPayments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPayments.Controls.Add(this.btnAddPayment, 1, 0);
            this.tlpPayments.Controls.Add(this.btnEditPayment, 2, 0);
            this.tlpPayments.Controls.Add(this.btnRemovePayment, 3, 0);
            this.tlpPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPayments.Location = new System.Drawing.Point(0, 0);
            this.tlpPayments.Name = "tlpPayments";
            this.tlpPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tlpPayments.RowCount = 3;
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPayments.Size = new System.Drawing.Size(567, 332);
            this.tlpPayments.TabIndex = 2;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(73, 6);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(24, 24);
            this.btnAddPayment.TabIndex = 1;
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnEditPayment
            // 
            this.btnEditPayment.Location = new System.Drawing.Point(103, 6);
            this.btnEditPayment.Name = "btnEditPayment";
            this.btnEditPayment.Size = new System.Drawing.Size(24, 24);
            this.btnEditPayment.TabIndex = 1;
            this.btnEditPayment.UseVisualStyleBackColor = true;
            this.btnEditPayment.Click += new System.EventHandler(this.btnEditPayment_Click);
            // 
            // btnRemovePayment
            // 
            this.btnRemovePayment.Location = new System.Drawing.Point(133, 6);
            this.btnRemovePayment.Name = "btnRemovePayment";
            this.btnRemovePayment.Size = new System.Drawing.Size(24, 24);
            this.btnRemovePayment.TabIndex = 1;
            this.btnRemovePayment.UseVisualStyleBackColor = true;
            this.btnRemovePayment.Click += new System.EventHandler(this.btnRemovePayment_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tabMain, 0, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMain.Size = new System.Drawing.Size(581, 397);
            this.tlpMain.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 365);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 32);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(503, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(422, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmTourEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 397);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTourEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TourEditor";
            this.tlpTour.ResumeLayout(false);
            this.tlpTour.PerformLayout();
            this.tlpTourState.ResumeLayout(false);
            this.tlpTourState.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tbpTour.ResumeLayout(false);
            this.tbpMembers.ResumeLayout(false);
            this.tlpTourMembers.ResumeLayout(false);
            this.tlpTourMembers.PerformLayout();
            this.tlpMemberToolbar.ResumeLayout(false);
            this.tlpMemberToolbar.PerformLayout();
            this.tbpStaff.ResumeLayout(false);
            this.tlpStaff.ResumeLayout(false);
            this.tlpStaff.PerformLayout();
            this.tlpEmployeeToolbar.ResumeLayout(false);
            this.tlpEmployeeToolbar.PerformLayout();
            this.tbpReceipt.ResumeLayout(false);
            this.tlpReceipt.ResumeLayout(false);
            this.tlpReceipt.PerformLayout();
            this.tbpPayments.ResumeLayout(false);
            this.tlpPayments.ResumeLayout(false);
            this.tlpPayments.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTour;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbpTour;
        private System.Windows.Forms.TabPage tbpPayments;
        private System.Windows.Forms.TabPage tbpMembers;
        private System.Windows.Forms.TabPage tbpStaff;
        private ContainerLayoutPanel tlpPayments;
        private FlatButton btnAddPayment;
        private FlatButton btnEditPayment;
        private FlatButton btnRemovePayment;
        private ContainerLayoutPanel tlpTourMembers;
        private FlatButton btnAddTourMember;
        private FlatButton btnRemoveTourMember;
        private FlatButton btnEditTourMember;
        private System.Windows.Forms.TableLayoutPanel tlpStaff;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private ButtonBase btnRemoveEmployee;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.TableLayoutPanel tlpEmployeeToolbar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpTourState;
        private ButtonBase btnCancel;
        private ButtonBase btnSave;
        private ButtonBase btnConfirm;
        private System.Windows.Forms.TableLayoutPanel tlpMemberToolbar;
        private System.Windows.Forms.GroupBox gpxCostGroups;
        private System.Windows.Forms.TabPage tbpReceipt;
        private ContainerLayoutPanel tlpReceipt;
    }
}