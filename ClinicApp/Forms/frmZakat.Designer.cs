namespace ClinicApp.Forms
{
    partial class frmZakat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZakat));
            this.panel11 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.zakaterEntry = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashFilter = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgZakatList = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.ZakatEntry = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtZakatRemark = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbZakaterType = new System.Windows.Forms.ComboBox();
            this.dtZakatDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtZakatAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnZakaterFetch = new System.Windows.Forms.Button();
            this.txtZakaterSearch = new System.Windows.Forms.TextBox();
            this.txtZakaterName = new System.Windows.Forms.TextBox();
            this.rtZakaterAddress = new System.Windows.Forms.RichTextBox();
            this.lblZakaterID = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtZakaterNic = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.errorProviderZakat = new System.Windows.Forms.ErrorProvider(this.components);
            this.ZakaterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZakatCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZakatDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZakatRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZakatDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totallbldgzakatdebit = new System.Windows.Forms.Label();
            this.lbldgzakatcredit = new System.Windows.Forms.Label();
            this.panel11.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.zakaterEntry.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZakatList)).BeginInit();
            this.panel12.SuspendLayout();
            this.ZakatEntry.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZakat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label8);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(646, 42);
            this.panel11.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Zakat";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.zakaterEntry);
            this.tabControl1.Controls.Add(this.ZakatEntry);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // zakaterEntry
            // 
            this.zakaterEntry.Controls.Add(this.panel1);
            this.zakaterEntry.Controls.Add(this.dgZakatList);
            this.zakaterEntry.Controls.Add(this.panel12);
            this.zakaterEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zakaterEntry.Location = new System.Drawing.Point(4, 22);
            this.zakaterEntry.Name = "zakaterEntry";
            this.zakaterEntry.Padding = new System.Windows.Forms.Padding(3);
            this.zakaterEntry.Size = new System.Drawing.Size(638, 424);
            this.zakaterEntry.TabIndex = 0;
            this.zakaterEntry.Text = "Zakater";
            this.zakaterEntry.ToolTipText = "Available Donations";
            this.zakaterEntry.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDashFilter);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.dtEndDate);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.dtStartDate);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 40);
            this.panel1.TabIndex = 5;
            // 
            // btnDashFilter
            // 
            this.btnDashFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDashFilter.Location = new System.Drawing.Point(413, 6);
            this.btnDashFilter.Name = "btnDashFilter";
            this.btnDashFilter.Size = new System.Drawing.Size(82, 24);
            this.btnDashFilter.TabIndex = 9;
            this.btnDashFilter.Text = "Filter";
            this.btnDashFilter.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(213, 9);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(75, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = ": End Date";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(292, 6);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(118, 23);
            this.dtEndDate.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 9);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(80, 17);
            this.label19.TabIndex = 6;
            this.label19.Text = ": Start Date";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(91, 6);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(118, 23);
            this.dtStartDate.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(479, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search ";
            // 
            // dgZakatList
            // 
            this.dgZakatList.AllowUserToAddRows = false;
            this.dgZakatList.AllowUserToDeleteRows = false;
            this.dgZakatList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgZakatList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgZakatList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZakaterName,
            this.ZakatCredit,
            this.ZakatDebit,
            this.ZakatRemarks,
            this.ZakatDate});
            this.dgZakatList.Location = new System.Drawing.Point(3, 43);
            this.dgZakatList.Name = "dgZakatList";
            this.dgZakatList.ReadOnly = true;
            this.dgZakatList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgZakatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgZakatList.Size = new System.Drawing.Size(632, 338);
            this.dgZakatList.TabIndex = 4;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lbldgzakatcredit);
            this.panel12.Controls.Add(this.totallbldgzakatdebit);
            this.panel12.Controls.Add(this.label11);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(3, 378);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(632, 43);
            this.panel12.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total : 100";
            // 
            // ZakatEntry
            // 
            this.ZakatEntry.Controls.Add(this.panel2);
            this.ZakatEntry.Controls.Add(this.toolStrip2);
            this.ZakatEntry.Location = new System.Drawing.Point(4, 22);
            this.ZakatEntry.Name = "ZakatEntry";
            this.ZakatEntry.Padding = new System.Windows.Forms.Padding(3);
            this.ZakatEntry.Size = new System.Drawing.Size(638, 424);
            this.ZakatEntry.TabIndex = 1;
            this.ZakatEntry.Text = "Zakat Entry";
            this.ZakatEntry.ToolTipText = "Zakat Entry";
            this.ZakatEntry.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.rtZakatRemark);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbZakaterType);
            this.groupBox2.Controls.Add(this.dtZakatDate);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.txtZakatAmount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(632, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zakat Entry";
            // 
            // rtZakatRemark
            // 
            this.rtZakatRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtZakatRemark.Location = new System.Drawing.Point(128, 83);
            this.rtZakatRemark.Name = "rtZakatRemark";
            this.rtZakatRemark.Size = new System.Drawing.Size(453, 66);
            this.rtZakatRemark.TabIndex = 42;
            this.rtZakatRemark.Text = "";
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
            // cmbZakaterType
            // 
            this.cmbZakaterType.FormattingEnabled = true;
            this.cmbZakaterType.Items.AddRange(new object[] {
            "Person",
            "Welfare Trust",
            "Government",
            "Other"});
            this.cmbZakaterType.Location = new System.Drawing.Point(128, 32);
            this.cmbZakaterType.Name = "cmbZakaterType";
            this.cmbZakaterType.Size = new System.Drawing.Size(209, 24);
            this.cmbZakaterType.TabIndex = 40;
            // 
            // dtZakatDate
            // 
            this.dtZakatDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtZakatDate.Location = new System.Drawing.Point(398, 58);
            this.dtZakatDate.Name = "dtZakatDate";
            this.dtZakatDate.Size = new System.Drawing.Size(182, 23);
            this.dtZakatDate.TabIndex = 39;
            this.dtZakatDate.ValueChanged += new System.EventHandler(this.dtZakatDate_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(24, 35);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label23.Size = new System.Drawing.Size(101, 17);
            this.label23.TabIndex = 37;
            this.label23.Text = ": Zakater Type";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(2, 61);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label24.Size = new System.Drawing.Size(104, 17);
            this.label24.TabIndex = 36;
            this.label24.Text = ": Zakat Amount";
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
            // txtZakatAmount
            // 
            this.txtZakatAmount.Location = new System.Drawing.Point(128, 58);
            this.txtZakatAmount.Name = "txtZakatAmount";
            this.txtZakatAmount.Size = new System.Drawing.Size(209, 23);
            this.txtZakatAmount.TabIndex = 29;
            this.txtZakatAmount.Text = "0";
            this.txtZakatAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZakatAmount_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZakaterFetch);
            this.groupBox1.Controls.Add(this.txtZakaterSearch);
            this.groupBox1.Controls.Add(this.txtZakaterName);
            this.groupBox1.Controls.Add(this.rtZakaterAddress);
            this.groupBox1.Controls.Add(this.lblZakaterID);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtZakaterNic);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(632, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zakater Personal Information";
            // 
            // btnZakaterFetch
            // 
            this.btnZakaterFetch.Location = new System.Drawing.Point(319, 0);
            this.btnZakaterFetch.Name = "btnZakaterFetch";
            this.btnZakaterFetch.Size = new System.Drawing.Size(75, 23);
            this.btnZakaterFetch.TabIndex = 28;
            this.btnZakaterFetch.Text = "Fetch";
            this.btnZakaterFetch.UseVisualStyleBackColor = true;
            this.btnZakaterFetch.Click += new System.EventHandler(this.btnZakaterFetch_Click);
            // 
            // txtZakaterSearch
            // 
            this.txtZakaterSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtZakaterSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtZakaterSearch.Location = new System.Drawing.Point(187, 0);
            this.txtZakaterSearch.MaxLength = 99;
            this.txtZakaterSearch.Name = "txtZakaterSearch";
            this.txtZakaterSearch.Size = new System.Drawing.Size(113, 23);
            this.txtZakaterSearch.TabIndex = 27;
            this.txtZakaterSearch.TextChanged += new System.EventHandler(this.txtZakaterSearch_TextChanged);
            // 
            // txtZakaterName
            // 
            this.txtZakaterName.Location = new System.Drawing.Point(128, 44);
            this.txtZakaterName.MaxLength = 99;
            this.txtZakaterName.Name = "txtZakaterName";
            this.txtZakaterName.Size = new System.Drawing.Size(172, 23);
            this.txtZakaterName.TabIndex = 0;
            // 
            // rtZakaterAddress
            // 
            this.rtZakaterAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtZakaterAddress.Location = new System.Drawing.Point(129, 70);
            this.rtZakaterAddress.Name = "rtZakaterAddress";
            this.rtZakaterAddress.Size = new System.Drawing.Size(453, 63);
            this.rtZakaterAddress.TabIndex = 26;
            this.rtZakaterAddress.Text = "";
            // 
            // lblZakaterID
            // 
            this.lblZakaterID.AutoSize = true;
            this.lblZakaterID.Location = new System.Drawing.Point(132, 21);
            this.lblZakaterID.Name = "lblZakaterID";
            this.lblZakaterID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblZakaterID.Size = new System.Drawing.Size(35, 17);
            this.lblZakaterID.TabIndex = 25;
            this.lblZakaterID.Text = "New";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 21);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = ": Zakater ID";
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
            // txtZakaterNic
            // 
            this.txtZakaterNic.Location = new System.Drawing.Point(398, 44);
            this.txtZakaterNic.MaxLength = 19;
            this.txtZakaterNic.Name = "txtZakaterNic";
            this.txtZakaterNic.Size = new System.Drawing.Size(182, 23);
            this.txtZakaterNic.TabIndex = 1;
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
            // errorProviderZakat
            // 
            this.errorProviderZakat.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderZakat.ContainerControl = this;
            // 
            // ZakaterName
            // 
            this.ZakaterName.HeaderText = "Name";
            this.ZakaterName.Name = "ZakaterName";
            this.ZakaterName.ReadOnly = true;
            // 
            // ZakatCredit
            // 
            this.ZakatCredit.HeaderText = "Zakat Credit";
            this.ZakatCredit.Name = "ZakatCredit";
            this.ZakatCredit.ReadOnly = true;
            // 
            // ZakatDebit
            // 
            this.ZakatDebit.HeaderText = "Zakat Debit";
            this.ZakatDebit.Name = "ZakatDebit";
            this.ZakatDebit.ReadOnly = true;
            // 
            // ZakatRemarks
            // 
            this.ZakatRemarks.HeaderText = "Zakat Remarks";
            this.ZakatRemarks.Name = "ZakatRemarks";
            this.ZakatRemarks.ReadOnly = true;
            // 
            // ZakatDate
            // 
            this.ZakatDate.HeaderText = "Date";
            this.ZakatDate.Name = "ZakatDate";
            this.ZakatDate.ReadOnly = true;
            // 
            // totallbldgzakatdebit
            // 
            this.totallbldgzakatdebit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.totallbldgzakatdebit.AutoSize = true;
            this.totallbldgzakatdebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbldgzakatdebit.Location = new System.Drawing.Point(373, 16);
            this.totallbldgzakatdebit.Name = "totallbldgzakatdebit";
            this.totallbldgzakatdebit.Size = new System.Drawing.Size(75, 15);
            this.totallbldgzakatdebit.TabIndex = 3;
            this.totallbldgzakatdebit.Text = "Total : 100";
            // 
            // lbldgzakatcredit
            // 
            this.lbldgzakatcredit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbldgzakatcredit.AutoSize = true;
            this.lbldgzakatcredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldgzakatcredit.Location = new System.Drawing.Point(169, 16);
            this.lbldgzakatcredit.Name = "lbldgzakatcredit";
            this.lbldgzakatcredit.Size = new System.Drawing.Size(75, 15);
            this.lbldgzakatcredit.TabIndex = 4;
            this.lbldgzakatcredit.Text = "Total : 100";
            // 
            // frmZakat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel11);
            this.Name = "frmZakat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmZakat";
            this.Load += new System.EventHandler(this.frm_ZakatInfo);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.zakaterEntry.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZakatList)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ZakatEntry.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZakat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage zakaterEntry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashFilter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgZakatList;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage ZakatEntry;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtZakatRemark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbZakaterType;
        private System.Windows.Forms.DateTimePicker dtZakatDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtZakatAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtZakaterAddress;
        private System.Windows.Forms.Label lblZakaterID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtZakaterNic;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Button btnZakaterFetch;
        private System.Windows.Forms.TextBox txtZakaterSearch;
        private System.Windows.Forms.TextBox txtZakaterName;
        private System.Windows.Forms.ErrorProvider errorProviderZakat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZakaterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZakatCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZakatDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZakatRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZakatDate;
        private System.Windows.Forms.Label lbldgzakatcredit;
        private System.Windows.Forms.Label totallbldgzakatdebit;
    }
}