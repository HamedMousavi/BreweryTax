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
            this.lblGuest = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.lblGuestContacts = new TaxDataStore.Presentation.Controls.ToolbarLabel();
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
            this.tlpReceipt = new System.Windows.Forms.TableLayoutPanel();
            this.tbpPayments = new System.Windows.Forms.TabPage();
            this.tlpPayments = new TaxDataStore.Presentation.Controls.ContainerLayoutPanel();
            this.btnAddPayment = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnEditPayment = new TaxDataStore.Presentation.Controls.FlatButton();
            this.btnRemovePayment = new TaxDataStore.Presentation.Controls.FlatButton();
            this.lblPayments = new TaxDataStore.Presentation.Controls.ToolbarLabel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new ButtonBase();
            this.btnSave = new ButtonBase();
            this.lblDate = new FormLabel("lbl_date");
            this.lblTime = new FormLabel("lbl_time");
            this.lblTourStatus = new FormLabel("");
            this.lblTourStatusLabel = new FormLabel("lbl_tour_status");
            this.lblTourType = new FormLabel("lbl_tour_type");
            this.lblGuest = new ToolbarLabel("lbl_guests");
            this.lblGuestContacts = new ToolbarLabel("lbl_guest_contacts");
            this.lblEmployees = new FormLabel("lbl_employees");
            this.lblComments = new FormLabel("lbl_comments");
            this.lblSignupType = new FormLabel("lbl_signup_type");
            this.label1 = new FormLabel("");
            this.label2 = new FormLabel("");
            this.label3 = new FormLabel("");
            this.label4 = new FormLabel("");
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
            
            this.tlpTour.Controls.Add(this.lblTourStatusLabel, 0, 0);
            this.tlpTour.Controls.Add(this.tlpTourState, 1, 0);

            this.tlpTour.Controls.Add(this.lblDate, 0, 1);
            this.tlpTour.Controls.Add(this.dtpDate, 1, 1);

            this.tlpTour.Controls.Add(this.lblTime, 0, 2);
            this.tlpTour.Controls.Add(this.dtpTime, 1, 2);

            this.tlpTour.Controls.Add(this.gpxCostGroups, 0, 5);

            this.tlpTour.Controls.Add(this.lblSignupType, 0, 4);
            this.tlpTour.Controls.Add(this.lblTourType, 0, 3);

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
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(3, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 28);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gray;
            this.lblTime.Location = new System.Drawing.Point(3, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 28);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lblTourType
            // 
            this.lblTourType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTourType.AutoSize = true;
            this.lblTourType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTourType.ForeColor = System.Drawing.Color.Gray;
            this.lblTourType.Location = new System.Drawing.Point(3, 88);
            this.lblTourType.Name = "lblTourType";
            this.lblTourType.Size = new System.Drawing.Size(66, 15);
            this.lblTourType.TabIndex = 4;
            this.lblTourType.Text = "TourType";
            this.lblTourType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSignupType
            // 
            this.lblSignupType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSignupType.AutoSize = true;
            this.lblSignupType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignupType.ForeColor = System.Drawing.Color.Gray;
            this.lblSignupType.Location = new System.Drawing.Point(3, 103);
            this.lblSignupType.Name = "lblSignupType";
            this.lblSignupType.Size = new System.Drawing.Size(79, 14);
            this.lblSignupType.TabIndex = 6;
            this.lblSignupType.Text = "SignUpType";
            this.lblSignupType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpTourState
            // 
            this.tlpTourState.ColumnCount = 3;
            this.tlpTourState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTourState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTourState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTourState.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTourState.Controls.Add(this.lblTourStatus, 0, 0);
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
            this.btnConfirm.Size = new System.Drawing.Size(58, 25);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTourStatusLabel
            // 
            this.lblTourStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTourStatusLabel.AutoSize = true;
            this.lblTourStatusLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTourStatusLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblTourStatusLabel.Location = new System.Drawing.Point(3, 0);
            this.lblTourStatusLabel.Name = "lblTourStatusLabel";
            this.lblTourStatusLabel.Size = new System.Drawing.Size(48, 32);
            this.lblTourStatusLabel.TabIndex = 14;
            this.lblTourStatusLabel.Text = "Status";
            this.lblTourStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGuest
            // 
            this.lblGuest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGuest.ForeColor = System.Drawing.Color.Gray;
            this.lblGuest.Location = new System.Drawing.Point(3, 0);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(42, 30);
            this.lblGuest.TabIndex = 3;
            this.lblGuest.Text = "Guest";
            this.lblGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGuestContacts
            // 
            this.lblGuestContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGuestContacts.AutoSize = true;
            this.lblGuestContacts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGuestContacts.ForeColor = System.Drawing.Color.Gray;
            this.lblGuestContacts.Location = new System.Drawing.Point(173, 0);
            this.lblGuestContacts.Name = "lblGuestContacts";
            this.lblGuestContacts.Size = new System.Drawing.Size(99, 30);
            this.lblGuestContacts.TabIndex = 3;
            this.lblGuestContacts.Text = "Guest contacts";
            this.lblGuestContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmployees
            // 
            this.lblEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEmployees.ForeColor = System.Drawing.Color.Gray;
            this.lblEmployees.Location = new System.Drawing.Point(3, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(71, 32);
            this.lblEmployees.TabIndex = 3;
            this.lblEmployees.Text = "Employees";
            this.lblEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComments
            // 
            this.lblComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblComments.ForeColor = System.Drawing.Color.Gray;
            this.lblComments.Location = new System.Drawing.Point(143, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(72, 32);
            this.lblComments.TabIndex = 17;
            this.lblComments.Text = "Comments";
            this.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "PPS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tlpTourMembers.Controls.Add(this.lblGuestContacts, 1, 0);
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
            this.tlpMemberToolbar.Controls.Add(this.lblGuest, 0, 0);
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
            this.tlpStaff.Controls.Add(this.lblComments, 1, 0);
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
            this.tlpEmployeeToolbar.Controls.Add(this.lblEmployees, 0, 0);
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
            this.tlpReceipt.ColumnCount = 5;
            this.tlpReceipt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpReceipt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpReceipt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpReceipt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpReceipt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReceipt.Controls.Add(this.label1, 0, 0);
            this.tlpReceipt.Controls.Add(this.label2, 1, 0);
            this.tlpReceipt.Controls.Add(this.label3, 2, 0);
            this.tlpReceipt.Controls.Add(this.label4, 3, 0);
            this.tlpReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpReceipt.Location = new System.Drawing.Point(3, 3);
            this.tlpReceipt.Name = "tlpReceipt";
            this.tlpReceipt.RowCount = 2;
            this.tlpReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpReceipt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.tlpPayments.Controls.Add(this.lblPayments, 0, 0);
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
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(6, 3);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(61, 14);
            this.lblPayments.TabIndex = 2;
            this.lblPayments.Text = "Payment";
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
        private FormLabel lblDate;
        private FormLabel lblTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private FormLabel lblTourType;
        private FormLabel lblSignupType;
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
        private FormLabel lblComments;
        private FormLabel lblEmployees;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.TableLayoutPanel tlpEmployeeToolbar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpTourState;
        private ButtonBase btnCancel;
        private ButtonBase btnSave;
        private ButtonBase btnConfirm;
        private FormLabel lblTourStatus;
        private FormLabel lblTourStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tlpMemberToolbar;
        private ToolbarLabel lblGuest;
        private ToolbarLabel lblGuestContacts;
        private System.Windows.Forms.GroupBox gpxCostGroups;
        private System.Windows.Forms.TabPage tbpReceipt;
        private System.Windows.Forms.TableLayoutPanel tlpReceipt;
        private FormLabel label1;
        private FormLabel label2;
        private FormLabel label3;
        private FormLabel label4;
        private ToolbarLabel lblPayments;
    }
}