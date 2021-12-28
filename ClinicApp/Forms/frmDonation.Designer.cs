
namespace ClinicApp.Forms
{
    partial class frmDonation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonation));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.donationList = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashFilter = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgDonationList = new System.Windows.Forms.DataGridView();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonationCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonationDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblDonationDebitSum = new System.Windows.Forms.Label();
            this.lblDonationCreditSum = new System.Windows.Forms.Label();
            this.tabAddDonation = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtDonationRemark = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDonatorType = new System.Windows.Forms.ComboBox();
            this.dtDonationDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDonationAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDonatorFetch = new System.Windows.Forms.Button();
            this.txtDonatorSearch = new System.Windows.Forms.TextBox();
            this.txtDonator = new System.Windows.Forms.TextBox();
            this.rtDonatorAddress = new System.Windows.Forms.RichTextBox();
            this.lblDonatorID = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonatorNic = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderDonation = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.donationList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDonationList)).BeginInit();
            this.panel12.SuspendLayout();
            this.tabAddDonation.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panelPatient.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDonation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.donationList);
            this.tabControl1.Controls.Add(this.tabAddDonation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // donationList
            // 
            this.donationList.Controls.Add(this.panel1);
            this.donationList.Controls.Add(this.dgDonationList);
            this.donationList.Controls.Add(this.panel12);
            this.donationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donationList.Location = new System.Drawing.Point(4, 22);
            this.donationList.Name = "donationList";
            this.donationList.Padding = new System.Windows.Forms.Padding(3);
            this.donationList.Size = new System.Drawing.Size(638, 424);
            this.donationList.TabIndex = 0;
            this.donationList.Text = "Bank Funds";
            this.donationList.ToolTipText = "Available Donations";
            this.donationList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDashFilter);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.dtStartDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 40);
            this.panel1.TabIndex = 5;
            // 
            // btnDashFilter
            // 
            this.btnDashFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDashFilter.Location = new System.Drawing.Point(226, 5);
            this.btnDashFilter.Name = "btnDashFilter";
            this.btnDashFilter.Size = new System.Drawing.Size(82, 24);
            this.btnDashFilter.TabIndex = 9;
            this.btnDashFilter.Text = "Filter";
            this.btnDashFilter.UseVisualStyleBackColor = true;
            this.btnDashFilter.Click += new System.EventHandler(this.btnDashFilter_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 9);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(89, 17);
            this.label19.TabIndex = 6;
            this.label19.Text = ": Select Date";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "MMM   yyyy";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(102, 6);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(118, 23);
            this.dtStartDate.TabIndex = 5;
            // 
            // dgDonationList
            // 
            this.dgDonationList.AllowUserToAddRows = false;
            this.dgDonationList.AllowUserToDeleteRows = false;
            this.dgDonationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDonationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDonationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DName,
            this.DonationCredit,
            this.DonationDebit,
            this.DRemarks,
            this.DDate});
            this.dgDonationList.Location = new System.Drawing.Point(3, 43);
            this.dgDonationList.Name = "dgDonationList";
            this.dgDonationList.ReadOnly = true;
            this.dgDonationList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgDonationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDonationList.Size = new System.Drawing.Size(632, 338);
            this.dgDonationList.TabIndex = 4;
            // 
            // DName
            // 
            this.DName.HeaderText = "Name";
            this.DName.Name = "DName";
            this.DName.ReadOnly = true;
            // 
            // DonationCredit
            // 
            this.DonationCredit.HeaderText = "Donation Credit";
            this.DonationCredit.Name = "DonationCredit";
            this.DonationCredit.ReadOnly = true;
            // 
            // DonationDebit
            // 
            this.DonationDebit.HeaderText = "Donation Debit";
            this.DonationDebit.Name = "DonationDebit";
            this.DonationDebit.ReadOnly = true;
            // 
            // DRemarks
            // 
            this.DRemarks.HeaderText = "Remarks";
            this.DRemarks.Name = "DRemarks";
            this.DRemarks.ReadOnly = true;
            // 
            // DDate
            // 
            this.DDate.HeaderText = "Donation Date";
            this.DDate.Name = "DDate";
            this.DDate.ReadOnly = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lblDonationDebitSum);
            this.panel12.Controls.Add(this.lblDonationCreditSum);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(3, 378);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(632, 43);
            this.panel12.TabIndex = 3;
            // 
            // lblDonationDebitSum
            // 
            this.lblDonationDebitSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDonationDebitSum.AutoSize = true;
            this.lblDonationDebitSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonationDebitSum.Location = new System.Drawing.Point(406, 16);
            this.lblDonationDebitSum.Name = "lblDonationDebitSum";
            this.lblDonationDebitSum.Size = new System.Drawing.Size(75, 15);
            this.lblDonationDebitSum.TabIndex = 4;
            this.lblDonationDebitSum.Text = "Total : 100";
            // 
            // lblDonationCreditSum
            // 
            this.lblDonationCreditSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDonationCreditSum.AutoSize = true;
            this.lblDonationCreditSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonationCreditSum.Location = new System.Drawing.Point(134, 16);
            this.lblDonationCreditSum.Name = "lblDonationCreditSum";
            this.lblDonationCreditSum.Size = new System.Drawing.Size(75, 15);
            this.lblDonationCreditSum.TabIndex = 3;
            this.lblDonationCreditSum.Text = "Total : 100";
            // 
            // tabAddDonation
            // 
            this.tabAddDonation.Controls.Add(this.panel2);
            this.tabAddDonation.Controls.Add(this.toolStrip2);
            this.tabAddDonation.Location = new System.Drawing.Point(4, 22);
            this.tabAddDonation.Name = "tabAddDonation";
            this.tabAddDonation.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddDonation.Size = new System.Drawing.Size(638, 424);
            this.tabAddDonation.TabIndex = 1;
            this.tabAddDonation.Text = "Bank Entry";
            this.tabAddDonation.ToolTipText = "Donation Entry";
            this.tabAddDonation.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 360);
            this.panel2.TabIndex = 261;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtDonationRemark);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbDonatorType);
            this.groupBox2.Controls.Add(this.dtDonationDate);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.txtDonationAmount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(632, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Donation Entry";
            // 
            // rtDonationRemark
            // 
            this.rtDonationRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtDonationRemark.Location = new System.Drawing.Point(128, 83);
            this.rtDonationRemark.Name = "rtDonationRemark";
            this.rtDonationRemark.Size = new System.Drawing.Size(453, 66);
            this.rtDonationRemark.TabIndex = 42;
            this.rtDonationRemark.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 83);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = ": Remark";
            // 
            // cmbDonatorType
            // 
            this.cmbDonatorType.FormattingEnabled = true;
            this.cmbDonatorType.Items.AddRange(new object[] {
            "Clinic Fund",
            "Bank Fund"});
            this.cmbDonatorType.Location = new System.Drawing.Point(128, 32);
            this.cmbDonatorType.Name = "cmbDonatorType";
            this.cmbDonatorType.Size = new System.Drawing.Size(209, 24);
            this.cmbDonatorType.TabIndex = 40;
            // 
            // dtDonationDate
            // 
            this.dtDonationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDonationDate.Location = new System.Drawing.Point(398, 58);
            this.dtDonationDate.Name = "dtDonationDate";
            this.dtDonationDate.Size = new System.Drawing.Size(182, 23);
            this.dtDonationDate.TabIndex = 39;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 35);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label23.Size = new System.Drawing.Size(109, 17);
            this.label23.TabIndex = 37;
            this.label23.Text = ": Donation Type";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(-4, 61);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label24.Size = new System.Drawing.Size(125, 17);
            this.label24.TabIndex = 36;
            this.label24.Text = ": Donation Amount";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(351, 61);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(46, 17);
            this.label26.TabIndex = 34;
            this.label26.Text = ": Date";
            // 
            // txtDonationAmount
            // 
            this.txtDonationAmount.Location = new System.Drawing.Point(128, 58);
            this.txtDonationAmount.Name = "txtDonationAmount";
            this.txtDonationAmount.Size = new System.Drawing.Size(209, 23);
            this.txtDonationAmount.TabIndex = 29;
            this.txtDonationAmount.Text = "0";
            this.txtDonationAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonationAmount_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDonatorFetch);
            this.groupBox1.Controls.Add(this.txtDonatorSearch);
            this.groupBox1.Controls.Add(this.txtDonator);
            this.groupBox1.Controls.Add(this.rtDonatorAddress);
            this.groupBox1.Controls.Add(this.lblDonatorID);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDonatorNic);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(632, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donator Personal Information";
            // 
            // btnDonatorFetch
            // 
            this.btnDonatorFetch.Location = new System.Drawing.Point(398, 0);
            this.btnDonatorFetch.Name = "btnDonatorFetch";
            this.btnDonatorFetch.Size = new System.Drawing.Size(75, 23);
            this.btnDonatorFetch.TabIndex = 29;
            this.btnDonatorFetch.Text = "Fetch";
            this.btnDonatorFetch.UseVisualStyleBackColor = true;
            this.btnDonatorFetch.Click += new System.EventHandler(this.btnDonatorFetch_Click);
            // 
            // txtDonatorSearch
            // 
            this.txtDonatorSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDonatorSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDonatorSearch.Location = new System.Drawing.Point(198, 0);
            this.txtDonatorSearch.MaxLength = 99;
            this.txtDonatorSearch.Name = "txtDonatorSearch";
            this.txtDonatorSearch.Size = new System.Drawing.Size(172, 23);
            this.txtDonatorSearch.TabIndex = 28;
            this.txtDonatorSearch.TextChanged += new System.EventHandler(this.txtDonatorSearch_TextChanged);
            // 
            // txtDonator
            // 
            this.txtDonator.Location = new System.Drawing.Point(129, 44);
            this.txtDonator.MaxLength = 99;
            this.txtDonator.Name = "txtDonator";
            this.txtDonator.Size = new System.Drawing.Size(172, 23);
            this.txtDonator.TabIndex = 0;
            // 
            // rtDonatorAddress
            // 
            this.rtDonatorAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtDonatorAddress.Location = new System.Drawing.Point(129, 70);
            this.rtDonatorAddress.Name = "rtDonatorAddress";
            this.rtDonatorAddress.Size = new System.Drawing.Size(453, 63);
            this.rtDonatorAddress.TabIndex = 26;
            this.rtDonatorAddress.Text = "";
            // 
            // lblDonatorID
            // 
            this.lblDonatorID.AutoSize = true;
            this.lblDonatorID.Location = new System.Drawing.Point(132, 21);
            this.lblDonatorID.Name = "lblDonatorID";
            this.lblDonatorID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDonatorID.Size = new System.Drawing.Size(35, 17);
            this.lblDonatorID.TabIndex = 25;
            this.lblDonatorID.Text = "New";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 21);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(84, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = ": Donator ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 70);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = ": Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 47);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = ": CNIC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 47);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = ": Name";
            // 
            // txtDonatorNic
            // 
            this.txtDonatorNic.Location = new System.Drawing.Point(398, 44);
            this.txtDonatorNic.MaxLength = 19;
            this.txtDonatorNic.Name = "txtDonatorNic";
            this.txtDonatorNic.Size = new System.Drawing.Size(182, 23);
            this.txtDonatorNic.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.tsbCancel,
            this.tsbClear,
            this.tsbRefresh});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(632, 58);
            this.toolStrip2.TabIndex = 260;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(43, 57);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.AutoSize = false;
            this.tsbCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(43, 60);
            this.tsbCancel.Text = "Close";
            this.tsbCancel.Visible = false;
            // 
            // tsbClear
            // 
            this.tsbClear.AutoSize = false;
            this.tsbClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbClear.Image")));
            this.tsbClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(43, 60);
            this.tsbClear.Text = "Clear";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.AutoSize = false;
            this.tsbRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(55, 65);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.ToolTipText = "Refresh";
            this.tsbRefresh.Visible = false;
            // 
            // panelPatient
            // 
            this.panelPatient.Controls.Add(this.tabControl1);
            this.panelPatient.Controls.Add(this.panel11);
            this.panelPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPatient.Location = new System.Drawing.Point(0, 0);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(646, 492);
            this.panelPatient.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label8);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(646, 42);
            this.panel11.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bank Fund";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Amount";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // PatientCNIC
            // 
            this.PatientCNIC.HeaderText = "Donator CNIC";
            this.PatientCNIC.Name = "PatientCNIC";
            this.PatientCNIC.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Donator";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // errorProviderDonation
            // 
            this.errorProviderDonation.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDonation.ContainerControl = this;
            // 
            // frmDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 492);
            this.Controls.Add(this.panelPatient);
            this.Name = "frmDonation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDonation";
            this.Load += new System.EventHandler(this.frm_DonatorInfo);
            this.tabControl1.ResumeLayout(false);
            this.donationList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDonationList)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tabAddDonation.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panelPatient.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDonation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage donationList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashFilter;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DataGridView dgDonationList;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TabPage tabAddDonation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtDonationRemark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDonatorType;
        private System.Windows.Forms.DateTimePicker dtDonationDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtDonationAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDonator;
        private System.Windows.Forms.RichTextBox rtDonatorAddress;
        private System.Windows.Forms.Label lblDonatorID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDonatorNic;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button btnDonatorFetch;
        private System.Windows.Forms.TextBox txtDonatorSearch;
        private System.Windows.Forms.ErrorProvider errorProviderDonation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonationCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonationDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDate;
        private System.Windows.Forms.Label lblDonationDebitSum;
        private System.Windows.Forms.Label lblDonationCreditSum;
    }
}