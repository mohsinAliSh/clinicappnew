
namespace ClinicApp.Forms
{
    partial class frmPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatient));
            this.panelPatient = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPatientList = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashFilter = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgPatientList = new System.Windows.Forms.DataGridView();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZakatAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClinicFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblclinicsum = new System.Windows.Forms.Label();
            this.lblzakatsum = new System.Windows.Forms.Label();
            this.lblTotalPatients = new System.Windows.Forms.Label();
            this.tabAddPatient = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetAmount = new System.Windows.Forms.TextBox();
            this.lblKetAmount = new System.Windows.Forms.Label();
            this.cmbKet = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.dtFeeDate = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ZakatAmountLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtClinicFee = new System.Windows.Forms.TextBox();
            this.txtZakatAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btpatientinfofetcher = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtpatientsearch = new System.Windows.Forms.TextBox();
            this.rtPatientAddress = new System.Windows.Forms.RichTextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPatientEmergencyContatact = new System.Windows.Forms.TextBox();
            this.txtPatientContact = new System.Windows.Forms.TextBox();
            this.cmbPatientMerital = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPatientGender = new System.Windows.Forms.ComboBox();
            this.dtPatientDOB = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPatientCountry = new System.Windows.Forms.TextBox();
            this.txtPatientEmail = new System.Windows.Forms.TextBox();
            this.txtPatientCity = new System.Windows.Forms.TextBox();
            this.txtPatientNic = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProviderPForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.frmPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmPatientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelPatient.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPatientList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientList)).BeginInit();
            this.panel12.SuspendLayout();
            this.tabAddPatient.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPatientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPatient
            // 
            this.panelPatient.Controls.Add(this.tabControl1);
            this.panelPatient.Controls.Add(this.panel11);
            this.panelPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPatient.Location = new System.Drawing.Point(0, 0);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(1048, 463);
            this.panelPatient.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPatientList);
            this.tabControl1.Controls.Add(this.tabAddPatient);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 418);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPatientList
            // 
            this.tabPatientList.Controls.Add(this.panel1);
            this.tabPatientList.Controls.Add(this.dgPatientList);
            this.tabPatientList.Controls.Add(this.panel12);
            this.tabPatientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPatientList.Location = new System.Drawing.Point(4, 22);
            this.tabPatientList.Name = "tabPatientList";
            this.tabPatientList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientList.Size = new System.Drawing.Size(1040, 392);
            this.tabPatientList.TabIndex = 0;
            this.tabPatientList.Text = "Patient List";
            this.tabPatientList.ToolTipText = "Active Patients List";
            this.tabPatientList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDashFilter);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.dtStartDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 40);
            this.panel1.TabIndex = 5;
            // 
            // btnDashFilter
            // 
            this.btnDashFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDashFilter.Location = new System.Drawing.Point(230, 7);
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
            this.label19.Location = new System.Drawing.Point(11, 9);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(89, 17);
            this.label19.TabIndex = 6;
            this.label19.Text = ": Select Date";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "MMM  yyyy";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(106, 7);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(118, 23);
            this.dtStartDate.TabIndex = 5;
            // 
            // dgPatientList
            // 
            this.dgPatientList.AllowUserToAddRows = false;
            this.dgPatientList.AllowUserToDeleteRows = false;
            this.dgPatientList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientName,
            this.PatientCNIC,
            this.Gender,
            this.Contact,
            this.ZakatAmount,
            this.ClinicFee,
            this.TotalAmount,
            this.Date});
            this.dgPatientList.Location = new System.Drawing.Point(3, 43);
            this.dgPatientList.Name = "dgPatientList";
            this.dgPatientList.ReadOnly = true;
            this.dgPatientList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPatientList.Size = new System.Drawing.Size(1034, 312);
            this.dgPatientList.TabIndex = 4;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // PatientCNIC
            // 
            this.PatientCNIC.HeaderText = "Patient CNIC";
            this.PatientCNIC.Name = "PatientCNIC";
            this.PatientCNIC.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // ZakatAmount
            // 
            this.ZakatAmount.HeaderText = "Zakat Amount";
            this.ZakatAmount.Name = "ZakatAmount";
            this.ZakatAmount.ReadOnly = true;
            // 
            // ClinicFee
            // 
            this.ClinicFee.HeaderText = "Clinic Fee";
            this.ClinicFee.Name = "ClinicFee";
            this.ClinicFee.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lblclinicsum);
            this.panel12.Controls.Add(this.lblzakatsum);
            this.panel12.Controls.Add(this.lblTotalPatients);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(3, 355);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1034, 34);
            this.panel12.TabIndex = 3;
            // 
            // lblclinicsum
            // 
            this.lblclinicsum.AutoSize = true;
            this.lblclinicsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclinicsum.Location = new System.Drawing.Point(665, 9);
            this.lblclinicsum.Name = "lblclinicsum";
            this.lblclinicsum.Size = new System.Drawing.Size(55, 15);
            this.lblclinicsum.TabIndex = 4;
            this.lblclinicsum.Text = "label17";
            // 
            // lblzakatsum
            // 
            this.lblzakatsum.AutoSize = true;
            this.lblzakatsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzakatsum.Location = new System.Drawing.Point(344, 9);
            this.lblzakatsum.Name = "lblzakatsum";
            this.lblzakatsum.Size = new System.Drawing.Size(55, 15);
            this.lblzakatsum.TabIndex = 3;
            this.lblzakatsum.Text = "label11";
            // 
            // lblTotalPatients
            // 
            this.lblTotalPatients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPatients.AutoSize = true;
            this.lblTotalPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPatients.Location = new System.Drawing.Point(12, 9);
            this.lblTotalPatients.Name = "lblTotalPatients";
            this.lblTotalPatients.Size = new System.Drawing.Size(75, 15);
            this.lblTotalPatients.TabIndex = 2;
            this.lblTotalPatients.Text = "Total : 100";
            // 
            // tabAddPatient
            // 
            this.tabAddPatient.Controls.Add(this.panel2);
            this.tabAddPatient.Controls.Add(this.toolStrip2);
            this.tabAddPatient.Location = new System.Drawing.Point(4, 22);
            this.tabAddPatient.Name = "tabAddPatient";
            this.tabAddPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddPatient.Size = new System.Drawing.Size(1040, 392);
            this.tabAddPatient.TabIndex = 1;
            this.tabAddPatient.Text = "New Patient";
            this.tabAddPatient.ToolTipText = "New Patient Entry";
            this.tabAddPatient.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 328);
            this.panel2.TabIndex = 261;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetAmount);
            this.groupBox2.Controls.Add(this.lblKetAmount);
            this.groupBox2.Controls.Add(this.cmbKet);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtTotalAmount);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.cmbPaymentType);
            this.groupBox2.Controls.Add(this.dtFeeDate);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.ZakatAmountLabel);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.txtClinicFee);
            this.groupBox2.Controls.Add(this.txtZakatAmount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(1034, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fee Entry";
            // 
            // txtKetAmount
            // 
            this.txtKetAmount.Location = new System.Drawing.Point(413, 84);
            this.txtKetAmount.MaxLength = 49;
            this.txtKetAmount.Name = "txtKetAmount";
            this.txtKetAmount.Size = new System.Drawing.Size(107, 23);
            this.txtKetAmount.TabIndex = 51;
            this.txtKetAmount.Text = "0";
            this.txtKetAmount.Visible = false;
            this.txtKetAmount.TextChanged += new System.EventHandler(this.txtKetAmount_TextChanged);
            this.txtKetAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKetAmount_KeyPress);
            // 
            // lblKetAmount
            // 
            this.lblKetAmount.AutoSize = true;
            this.lblKetAmount.Location = new System.Drawing.Point(318, 87);
            this.lblKetAmount.Name = "lblKetAmount";
            this.lblKetAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblKetAmount.Size = new System.Drawing.Size(89, 17);
            this.lblKetAmount.TabIndex = 50;
            this.lblKetAmount.Text = ": Ket Amount";
            this.lblKetAmount.Visible = false;
            // 
            // cmbKet
            // 
            this.cmbKet.FormattingEnabled = true;
            this.cmbKet.Items.AddRange(new object[] {
            "Self",
            "Clinic"});
            this.cmbKet.Location = new System.Drawing.Point(413, 33);
            this.cmbKet.Name = "cmbKet";
            this.cmbKet.Size = new System.Drawing.Size(107, 24);
            this.cmbKet.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(318, 37);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(32, 17);
            this.label16.TabIndex = 48;
            this.label16.Text = ": Kit";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(413, 88);
            this.txtTotalAmount.MaxLength = 49;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(107, 26);
            this.txtTotalAmount.TabIndex = 47;
            this.txtTotalAmount.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(318, 62);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label21.Size = new System.Drawing.Size(77, 17);
            this.label21.TabIndex = 41;
            this.label21.Text = ": Clinic Fee";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Self",
            "Zakat",
            "Self+Zakat"});
            this.cmbPaymentType.Location = new System.Drawing.Point(138, 33);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(107, 24);
            this.cmbPaymentType.TabIndex = 40;
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentType_SelectedIndexChanged);
            // 
            // dtFeeDate
            // 
            this.dtFeeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFeeDate.Location = new System.Drawing.Point(138, 87);
            this.dtFeeDate.Name = "dtFeeDate";
            this.dtFeeDate.Size = new System.Drawing.Size(107, 23);
            this.dtFeeDate.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(328, 90);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(59, 20);
            this.label22.TabIndex = 38;
            this.label22.Text = ": Total";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 37);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label23.Size = new System.Drawing.Size(107, 17);
            this.label23.TabIndex = 37;
            this.label23.Text = ": Payment Type";
            // 
            // ZakatAmountLabel
            // 
            this.ZakatAmountLabel.AutoSize = true;
            this.ZakatAmountLabel.Location = new System.Drawing.Point(10, 65);
            this.ZakatAmountLabel.Name = "ZakatAmountLabel";
            this.ZakatAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ZakatAmountLabel.Size = new System.Drawing.Size(104, 17);
            this.ZakatAmountLabel.TabIndex = 36;
            this.ZakatAmountLabel.Text = ": Zakat Amount";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(15, 90);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(46, 17);
            this.label26.TabIndex = 34;
            this.label26.Text = ": Date";
            // 
            // txtClinicFee
            // 
            this.txtClinicFee.Location = new System.Drawing.Point(413, 59);
            this.txtClinicFee.MaxLength = 49;
            this.txtClinicFee.Name = "txtClinicFee";
            this.txtClinicFee.Size = new System.Drawing.Size(107, 23);
            this.txtClinicFee.TabIndex = 31;
            this.txtClinicFee.Text = "0";
            this.txtClinicFee.TextChanged += new System.EventHandler(this.txtClinicFee_TextChanged);
            this.txtClinicFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClinicFee_KeyPress);
            // 
            // txtZakatAmount
            // 
            this.txtZakatAmount.Location = new System.Drawing.Point(138, 62);
            this.txtZakatAmount.Name = "txtZakatAmount";
            this.txtZakatAmount.Size = new System.Drawing.Size(107, 23);
            this.txtZakatAmount.TabIndex = 29;
            this.txtZakatAmount.Text = "0";
            this.txtZakatAmount.TextChanged += new System.EventHandler(this.txtZakatAmount_TextChanged);
            this.txtZakatAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonationAmount_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btpatientinfofetcher);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.txtpatientsearch);
            this.groupBox1.Controls.Add(this.rtPatientAddress);
            this.groupBox1.Controls.Add(this.lblPatientID);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtPatientEmergencyContatact);
            this.groupBox1.Controls.Add(this.txtPatientContact);
            this.groupBox1.Controls.Add(this.cmbPatientMerital);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbPatientGender);
            this.groupBox1.Controls.Add(this.dtPatientDOB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPatientCountry);
            this.groupBox1.Controls.Add(this.txtPatientEmail);
            this.groupBox1.Controls.Add(this.txtPatientCity);
            this.groupBox1.Controls.Add(this.txtPatientNic);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(1034, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Personal Information";
            // 
            // btpatientinfofetcher
            // 
            this.btpatientinfofetcher.Location = new System.Drawing.Point(338, 0);
            this.btpatientinfofetcher.Name = "btpatientinfofetcher";
            this.btpatientinfofetcher.Size = new System.Drawing.Size(75, 23);
            this.btpatientinfofetcher.TabIndex = 29;
            this.btpatientinfofetcher.Text = "Fetch";
            this.btpatientinfofetcher.UseVisualStyleBackColor = true;
            this.btpatientinfofetcher.Click += new System.EventHandler(this.btpatientinfofetcher_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(120, 44);
            this.txtPatientName.MaxLength = 99;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(146, 23);
            this.txtPatientName.TabIndex = 0;
            // 
            // txtpatientsearch
            // 
            this.txtpatientsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtpatientsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtpatientsearch.Location = new System.Drawing.Point(186, 0);
            this.txtpatientsearch.MaxLength = 19;
            this.txtpatientsearch.Name = "txtpatientsearch";
            this.txtpatientsearch.Size = new System.Drawing.Size(146, 23);
            this.txtpatientsearch.TabIndex = 28;
            this.txtpatientsearch.TextChanged += new System.EventHandler(this.txtpatientsearch_TextChanged);
            // 
            // rtPatientAddress
            // 
            this.rtPatientAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtPatientAddress.Location = new System.Drawing.Point(389, 92);
            this.rtPatientAddress.Name = "rtPatientAddress";
            this.rtPatientAddress.Size = new System.Drawing.Size(641, 48);
            this.rtPatientAddress.TabIndex = 26;
            this.rtPatientAddress.Text = "";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(120, 23);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatientID.Size = new System.Drawing.Size(35, 17);
            this.lblPatientID.TabIndex = 25;
            this.lblPatientID.Text = "New";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 23);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = ": Patient ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(318, 92);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = ": Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(753, 70);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(139, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = ": Emergency Contact";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(548, 70);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = ": Contact";
            // 
            // txtPatientEmergencyContatact
            // 
            this.txtPatientEmergencyContatact.Location = new System.Drawing.Point(897, 67);
            this.txtPatientEmergencyContatact.MaxLength = 14;
            this.txtPatientEmergencyContatact.Name = "txtPatientEmergencyContatact";
            this.txtPatientEmergencyContatact.Size = new System.Drawing.Size(132, 23);
            this.txtPatientEmergencyContatact.TabIndex = 19;
            // 
            // txtPatientContact
            // 
            this.txtPatientContact.Location = new System.Drawing.Point(618, 67);
            this.txtPatientContact.MaxLength = 14;
            this.txtPatientContact.Name = "txtPatientContact";
            this.txtPatientContact.Size = new System.Drawing.Size(131, 23);
            this.txtPatientContact.TabIndex = 18;
            // 
            // cmbPatientMerital
            // 
            this.cmbPatientMerital.FormattingEnabled = true;
            this.cmbPatientMerital.Items.AddRange(new object[] {
            "Married",
            "UnMarried"});
            this.cmbPatientMerital.Location = new System.Drawing.Point(120, 69);
            this.cmbPatientMerital.Name = "cmbPatientMerital";
            this.cmbPatientMerital.Size = new System.Drawing.Size(146, 24);
            this.cmbPatientMerital.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = ": Merital Status";
            // 
            // cmbPatientGender
            // 
            this.cmbPatientGender.FormattingEnabled = true;
            this.cmbPatientGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbPatientGender.Location = new System.Drawing.Point(898, 40);
            this.cmbPatientGender.Name = "cmbPatientGender";
            this.cmbPatientGender.Size = new System.Drawing.Size(131, 24);
            this.cmbPatientGender.TabIndex = 15;
            // 
            // dtPatientDOB
            // 
            this.dtPatientDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPatientDOB.Location = new System.Drawing.Point(618, 41);
            this.dtPatientDOB.Name = "dtPatientDOB";
            this.dtPatientDOB.Size = new System.Drawing.Size(131, 23);
            this.dtPatientDOB.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = ": Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(753, 44);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = ": Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 98);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = ": City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 70);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = ": Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 44);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = ": DOB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 44);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = ": CNIC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 47);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = ": Name";
            // 
            // txtPatientCountry
            // 
            this.txtPatientCountry.Location = new System.Drawing.Point(120, 120);
            this.txtPatientCountry.MaxLength = 49;
            this.txtPatientCountry.Name = "txtPatientCountry";
            this.txtPatientCountry.Size = new System.Drawing.Size(146, 23);
            this.txtPatientCountry.TabIndex = 4;
            // 
            // txtPatientEmail
            // 
            this.txtPatientEmail.Location = new System.Drawing.Point(389, 67);
            this.txtPatientEmail.MaxLength = 49;
            this.txtPatientEmail.Name = "txtPatientEmail";
            this.txtPatientEmail.Size = new System.Drawing.Size(146, 23);
            this.txtPatientEmail.TabIndex = 3;
            // 
            // txtPatientCity
            // 
            this.txtPatientCity.Location = new System.Drawing.Point(120, 95);
            this.txtPatientCity.Name = "txtPatientCity";
            this.txtPatientCity.Size = new System.Drawing.Size(146, 23);
            this.txtPatientCity.TabIndex = 2;
            // 
            // txtPatientNic
            // 
            this.txtPatientNic.Location = new System.Drawing.Point(389, 41);
            this.txtPatientNic.MaxLength = 19;
            this.txtPatientNic.Name = "txtPatientNic";
            this.txtPatientNic.Size = new System.Drawing.Size(146, 23);
            this.txtPatientNic.TabIndex = 1;
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
            this.toolStrip2.Size = new System.Drawing.Size(1034, 58);
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
            // panel11
            // 
            this.panel11.Controls.Add(this.label8);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1048, 45);
            this.panel11.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Patient List";
            // 
            // errorProviderPForm
            // 
            this.errorProviderPForm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPForm.ContainerControl = this;
            // 
            // frmPatientBindingSource
            // 
            this.frmPatientBindingSource.DataSource = typeof(ClinicApp.Forms.frmPatient);
            // 
            // frmPatientBindingSource1
            // 
            this.frmPatientBindingSource1.DataSource = typeof(ClinicApp.Forms.frmPatient);
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 463);
            this.Controls.Add(this.panelPatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPatient";
            this.Text = "frmPatient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPatient_Load);
            this.panelPatient.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPatientList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientList)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tabAddPatient.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmPatientBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPatientList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgPatientList;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblTotalPatients;
        private System.Windows.Forms.TabPage tabAddPatient;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetAmount;
        private System.Windows.Forms.Label lblKetAmount;
        private System.Windows.Forms.ComboBox cmbKet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.DateTimePicker dtFeeDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label ZakatAmountLabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtClinicFee;
        private System.Windows.Forms.TextBox txtZakatAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtPatientAddress;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPatientEmergencyContatact;
        private System.Windows.Forms.TextBox txtPatientContact;
        private System.Windows.Forms.ComboBox cmbPatientMerital;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPatientGender;
        private System.Windows.Forms.DateTimePicker dtPatientDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPatientCountry;
        private System.Windows.Forms.TextBox txtPatientEmail;
        private System.Windows.Forms.TextBox txtPatientCity;
        private System.Windows.Forms.TextBox txtPatientNic;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Button btnDashFilter;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.TextBox txtpatientsearch;
        private System.Windows.Forms.ErrorProvider errorProviderPForm;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Button btpatientinfofetcher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZakatAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClinicFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label lblclinicsum;
        private System.Windows.Forms.Label lblzakatsum;
        private System.Windows.Forms.BindingSource frmPatientBindingSource;
        private System.Windows.Forms.BindingSource frmPatientBindingSource1;
    }
}