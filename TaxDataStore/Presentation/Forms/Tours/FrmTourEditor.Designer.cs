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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblTourType = new System.Windows.Forms.Label();
            this.lblSignupType = new System.Windows.Forms.Label();
            this.lblSignupCount = new System.Windows.Forms.Label();
            this.lblParticipantCount = new System.Windows.Forms.Label();
            this.tbxParticipantCount = new System.Windows.Forms.TextBox();
            this.tbxSignupCount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTourStatus = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTourStatusLabel = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbpTour = new System.Windows.Forms.TabPage();
            this.tbpPayments = new System.Windows.Forms.TabPage();
            this.tlpPayments = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnEditPayment = new System.Windows.Forms.Button();
            this.btnRemovePayment = new System.Windows.Forms.Button();
            this.tbpMembers = new System.Windows.Forms.TabPage();
            this.tlpTourMembers = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTourMember = new System.Windows.Forms.Button();
            this.btnRemoveTourMember = new System.Windows.Forms.Button();
            this.btnEditTourMember = new System.Windows.Forms.Button();
            this.tbpStaff = new System.Windows.Forms.TabPage();
            this.tlpStaff = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEmployeeToolbar = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpTour.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tbpTour.SuspendLayout();
            this.tbpPayments.SuspendLayout();
            this.tlpPayments.SuspendLayout();
            this.tbpMembers.SuspendLayout();
            this.tlpTourMembers.SuspendLayout();
            this.tbpStaff.SuspendLayout();
            this.tlpStaff.SuspendLayout();
            this.tlpEmployeeToolbar.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTour
            // 
            this.tlpTour.ColumnCount = 2;
            this.tlpTour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTour.Controls.Add(this.dtpDate, 1, 0);
            this.tlpTour.Controls.Add(this.lblDate, 0, 0);
            this.tlpTour.Controls.Add(this.lblTime, 0, 1);
            this.tlpTour.Controls.Add(this.dtpTime, 1, 1);
            this.tlpTour.Controls.Add(this.lblTourType, 0, 2);
            this.tlpTour.Controls.Add(this.lblSignupType, 0, 3);
            this.tlpTour.Controls.Add(this.lblSignupCount, 0, 4);
            this.tlpTour.Controls.Add(this.lblParticipantCount, 0, 5);
            this.tlpTour.Controls.Add(this.tbxParticipantCount, 1, 5);
            this.tlpTour.Controls.Add(this.tbxSignupCount, 1, 4);
            this.tlpTour.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tlpTour.Controls.Add(this.lblTourStatusLabel, 0, 6);
            this.tlpTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tlpTour.Location = new System.Drawing.Point(3, 3);
            this.tlpTour.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTour.Name = "tlpTour";
            this.tlpTour.RowCount = 8;
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTour.Size = new System.Drawing.Size(561, 326);
            this.tlpTour.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(112, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(446, 21);
            this.dtpDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 15);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // dtpTime
            // 
            this.dtpTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTime.CustomFormat = "HH:MM";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(112, 30);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(446, 21);
            this.dtpTime.TabIndex = 3;
            // 
            // lblTourType
            // 
            this.lblTourType.AutoSize = true;
            this.lblTourType.Location = new System.Drawing.Point(3, 54);
            this.lblTourType.Name = "lblTourType";
            this.lblTourType.Size = new System.Drawing.Size(58, 15);
            this.lblTourType.TabIndex = 4;
            this.lblTourType.Text = "TourType";
            // 
            // lblSignupType
            // 
            this.lblSignupType.AutoSize = true;
            this.lblSignupType.Location = new System.Drawing.Point(3, 69);
            this.lblSignupType.Name = "lblSignupType";
            this.lblSignupType.Size = new System.Drawing.Size(74, 15);
            this.lblSignupType.TabIndex = 6;
            this.lblSignupType.Text = "SignUpType";
            // 
            // lblSignupCount
            // 
            this.lblSignupCount.AutoSize = true;
            this.lblSignupCount.Location = new System.Drawing.Point(3, 84);
            this.lblSignupCount.Name = "lblSignupCount";
            this.lblSignupCount.Size = new System.Drawing.Size(80, 15);
            this.lblSignupCount.TabIndex = 8;
            this.lblSignupCount.Text = "SignUpCount";
            // 
            // lblParticipantCount
            // 
            this.lblParticipantCount.AutoSize = true;
            this.lblParticipantCount.Location = new System.Drawing.Point(3, 111);
            this.lblParticipantCount.Name = "lblParticipantCount";
            this.lblParticipantCount.Size = new System.Drawing.Size(103, 15);
            this.lblParticipantCount.TabIndex = 10;
            this.lblParticipantCount.Text = "ParticipantsCount";
            // 
            // tbxParticipantCount
            // 
            this.tbxParticipantCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxParticipantCount.Location = new System.Drawing.Point(112, 114);
            this.tbxParticipantCount.Name = "tbxParticipantCount";
            this.tbxParticipantCount.Size = new System.Drawing.Size(446, 21);
            this.tbxParticipantCount.TabIndex = 11;
            // 
            // tbxSignupCount
            // 
            this.tbxSignupCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSignupCount.Location = new System.Drawing.Point(112, 87);
            this.tbxSignupCount.Name = "tbxSignupCount";
            this.tbxSignupCount.Size = new System.Drawing.Size(446, 21);
            this.tbxSignupCount.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblTourStatus, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnConfirm, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(109, 138);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(452, 32);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // lblTourStatus
            // 
            this.lblTourStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTourStatus.AutoSize = true;
            this.lblTourStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTourStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTourStatus.Location = new System.Drawing.Point(3, 0);
            this.lblTourStatus.Name = "lblTourStatus";
            this.lblTourStatus.Size = new System.Drawing.Size(90, 32);
            this.lblTourStatus.TabIndex = 1;
            this.lblTourStatus.Text = "[ Reserved ]";
            this.lblTourStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Location = new System.Drawing.Point(99, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 26);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTourStatusLabel
            // 
            this.lblTourStatusLabel.AutoSize = true;
            this.lblTourStatusLabel.Location = new System.Drawing.Point(3, 138);
            this.lblTourStatusLabel.Name = "lblTourStatusLabel";
            this.lblTourStatusLabel.Size = new System.Drawing.Size(41, 15);
            this.lblTourStatusLabel.TabIndex = 14;
            this.lblTourStatusLabel.Text = "Status";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbpTour);
            this.tabMain.Controls.Add(this.tbpMembers);
            this.tabMain.Controls.Add(this.tbpStaff);
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
            this.tbpTour.Margin = new System.Windows.Forms.Padding(0);
            this.tbpTour.Name = "tbpTour";
            this.tbpTour.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTour.Size = new System.Drawing.Size(567, 332);
            this.tbpTour.TabIndex = 0;
            this.tbpTour.Text = "Tour";
            this.tbpTour.UseVisualStyleBackColor = true;
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
            this.tlpPayments.ColumnCount = 3;
            this.tlpPayments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPayments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPayments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPayments.Controls.Add(this.btnAddPayment, 0, 0);
            this.tlpPayments.Controls.Add(this.btnEditPayment, 1, 0);
            this.tlpPayments.Controls.Add(this.btnRemovePayment, 2, 0);
            this.tlpPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPayments.Location = new System.Drawing.Point(0, 0);
            this.tlpPayments.Name = "tlpPayments";
            this.tlpPayments.RowCount = 3;
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPayments.Size = new System.Drawing.Size(567, 332);
            this.tlpPayments.TabIndex = 2;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(3, 3);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(24, 24);
            this.btnAddPayment.TabIndex = 1;
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnEditPayment
            // 
            this.btnEditPayment.Location = new System.Drawing.Point(33, 3);
            this.btnEditPayment.Name = "btnEditPayment";
            this.btnEditPayment.Size = new System.Drawing.Size(24, 24);
            this.btnEditPayment.TabIndex = 1;
            this.btnEditPayment.UseVisualStyleBackColor = true;
            this.btnEditPayment.Click += new System.EventHandler(this.btnEditPayment_Click);
            // 
            // btnRemovePayment
            // 
            this.btnRemovePayment.Location = new System.Drawing.Point(63, 3);
            this.btnRemovePayment.Name = "btnRemovePayment";
            this.btnRemovePayment.Size = new System.Drawing.Size(24, 24);
            this.btnRemovePayment.TabIndex = 1;
            this.btnRemovePayment.UseVisualStyleBackColor = true;
            this.btnRemovePayment.Click += new System.EventHandler(this.btnRemovePayment_Click);
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
            this.tlpTourMembers.ColumnCount = 4;
            this.tlpTourMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTourMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTourMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpTourMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpTourMembers.Controls.Add(this.btnAddTourMember, 0, 0);
            this.tlpTourMembers.Controls.Add(this.btnRemoveTourMember, 2, 0);
            this.tlpTourMembers.Controls.Add(this.btnEditTourMember, 1, 0);
            this.tlpTourMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTourMembers.Location = new System.Drawing.Point(0, 0);
            this.tlpTourMembers.Name = "tlpTourMembers";
            this.tlpTourMembers.RowCount = 3;
            this.tlpTourMembers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTourMembers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTourMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourMembers.Size = new System.Drawing.Size(567, 332);
            this.tlpTourMembers.TabIndex = 1;
            // 
            // btnAddTourMember
            // 
            this.btnAddTourMember.Location = new System.Drawing.Point(3, 3);
            this.btnAddTourMember.Name = "btnAddTourMember";
            this.btnAddTourMember.Size = new System.Drawing.Size(24, 24);
            this.btnAddTourMember.TabIndex = 1;
            this.btnAddTourMember.UseVisualStyleBackColor = true;
            this.btnAddTourMember.Click += new System.EventHandler(this.btnAddTourMember_Click);
            // 
            // btnRemoveTourMember
            // 
            this.btnRemoveTourMember.Location = new System.Drawing.Point(63, 3);
            this.btnRemoveTourMember.Name = "btnRemoveTourMember";
            this.btnRemoveTourMember.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveTourMember.TabIndex = 1;
            this.btnRemoveTourMember.UseVisualStyleBackColor = true;
            this.btnRemoveTourMember.Click += new System.EventHandler(this.btnRemoveTourMember_Click);
            // 
            // btnEditTourMember
            // 
            this.btnEditTourMember.Location = new System.Drawing.Point(33, 3);
            this.btnEditTourMember.Name = "btnEditTourMember";
            this.btnEditTourMember.Size = new System.Drawing.Size(24, 24);
            this.btnEditTourMember.TabIndex = 2;
            this.btnEditTourMember.UseVisualStyleBackColor = true;
            // 
            // tbpStaff
            // 
            this.tbpStaff.Controls.Add(this.tlpStaff);
            this.tbpStaff.Location = new System.Drawing.Point(4, 23);
            this.tbpStaff.Name = "tbpStaff";
            this.tbpStaff.Padding = new System.Windows.Forms.Padding(3);
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
            this.tlpStaff.Controls.Add(this.lblComments, 1, 0);
            this.tlpStaff.Controls.Add(this.rtbComments, 1, 1);
            this.tlpStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStaff.Location = new System.Drawing.Point(3, 3);
            this.tlpStaff.Margin = new System.Windows.Forms.Padding(0);
            this.tlpStaff.Name = "tlpStaff";
            this.tlpStaff.RowCount = 2;
            this.tlpStaff.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStaff.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStaff.Size = new System.Drawing.Size(561, 326);
            this.tlpStaff.TabIndex = 0;
            // 
            // tlpEmployeeToolbar
            // 
            this.tlpEmployeeToolbar.ColumnCount = 4;
            this.tlpEmployeeToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEmployeeToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEmployeeToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEmployeeToolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployeeToolbar.Controls.Add(this.btnRemoveEmployee, 2, 0);
            this.tlpEmployeeToolbar.Controls.Add(this.lblEmployees, 0, 0);
            this.tlpEmployeeToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployeeToolbar.Location = new System.Drawing.Point(0, 0);
            this.tlpEmployeeToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEmployeeToolbar.Name = "tlpEmployeeToolbar";
            this.tlpEmployeeToolbar.RowCount = 1;
            this.tlpEmployeeToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployeeToolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpEmployeeToolbar.Size = new System.Drawing.Size(140, 28);
            this.tlpEmployeeToolbar.TabIndex = 3;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(74, 3);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(24, 22);
            this.btnRemoveEmployee.TabIndex = 1;
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // lblEmployees
            // 
            this.lblEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEmployees.Location = new System.Drawing.Point(3, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(65, 28);
            this.lblEmployees.TabIndex = 3;
            this.lblEmployees.Text = "Employees";
            this.lblEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComments
            // 
            this.lblComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblComments.Location = new System.Drawing.Point(143, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(65, 28);
            this.lblComments.TabIndex = 17;
            this.lblComments.Text = "Comments";
            this.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbComments
            // 
            this.rtbComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbComments.Location = new System.Drawing.Point(143, 31);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(415, 292);
            this.rtbComments.TabIndex = 19;
            this.rtbComments.Text = "";
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tbpTour.ResumeLayout(false);
            this.tbpPayments.ResumeLayout(false);
            this.tlpPayments.ResumeLayout(false);
            this.tbpMembers.ResumeLayout(false);
            this.tlpTourMembers.ResumeLayout(false);
            this.tbpStaff.ResumeLayout(false);
            this.tlpStaff.ResumeLayout(false);
            this.tlpStaff.PerformLayout();
            this.tlpEmployeeToolbar.ResumeLayout(false);
            this.tlpEmployeeToolbar.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTour;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTourType;
        private System.Windows.Forms.Label lblSignupType;
        private System.Windows.Forms.Label lblSignupCount;
        private System.Windows.Forms.Label lblParticipantCount;
        private System.Windows.Forms.TextBox tbxParticipantCount;
        private System.Windows.Forms.TextBox tbxSignupCount;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbpTour;
        private System.Windows.Forms.TabPage tbpPayments;
        private System.Windows.Forms.TabPage tbpMembers;
        private System.Windows.Forms.TabPage tbpStaff;
        private System.Windows.Forms.TableLayoutPanel tlpPayments;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnRemovePayment;
        private System.Windows.Forms.TableLayoutPanel tlpTourMembers;
        private System.Windows.Forms.Button btnAddTourMember;
        private System.Windows.Forms.Button btnRemoveTourMember;
        private System.Windows.Forms.TableLayoutPanel tlpStaff;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.TableLayoutPanel tlpEmployeeToolbar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTourStatus;
        private System.Windows.Forms.Label lblTourStatusLabel;
        private System.Windows.Forms.Button btnEditTourMember;
        private System.Windows.Forms.Button btnEditPayment;
    }
}