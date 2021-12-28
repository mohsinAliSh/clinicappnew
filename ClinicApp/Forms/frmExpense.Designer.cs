
namespace ClinicApp.Forms
{
    partial class frmExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpense));
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExpense = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashFilter = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgExpenseList = new System.Windows.Forms.DataGridView();
            this.ExpenseCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tabAddExpense = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbExpenseFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbExpenseCategory = new System.Windows.Forms.ComboBox();
            this.rtExpenseDescription = new System.Windows.Forms.RichTextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.errorProviderExpense = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabExpense.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenseList)).BeginInit();
            this.panel12.SuspendLayout();
            this.tabAddExpense.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panelPatient.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabExpense);
            this.tabControl1.Controls.Add(this.tabAddExpense);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabExpense
            // 
            this.tabExpense.AccessibleName = "tabofexpense";
            this.tabExpense.Controls.Add(this.panel1);
            this.tabExpense.Controls.Add(this.dgExpenseList);
            this.tabExpense.Controls.Add(this.panel12);
            this.tabExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExpense.Location = new System.Drawing.Point(4, 22);
            this.tabExpense.Name = "tabExpense";
            this.tabExpense.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpense.Size = new System.Drawing.Size(638, 424);
            this.tabExpense.TabIndex = 0;
            this.tabExpense.Text = "Expense";
            this.tabExpense.ToolTipText = "Expense Log";
            this.tabExpense.UseVisualStyleBackColor = true;
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
            this.btnDashFilter.Location = new System.Drawing.Point(235, 7);
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
            this.dtStartDate.CustomFormat = "MMM, yyyy";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(102, 8);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(118, 23);
            this.dtStartDate.TabIndex = 5;
            // 
            // dgExpenseList
            // 
            this.dgExpenseList.AllowUserToAddRows = false;
            this.dgExpenseList.AllowUserToDeleteRows = false;
            this.dgExpenseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgExpenseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgExpenseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpenseCategory,
            this.ExpenseFrom,
            this.ExpenseAmount,
            this.ExpenseDate,
            this.ExpenseDescription});
            this.dgExpenseList.Location = new System.Drawing.Point(3, 43);
            this.dgExpenseList.Name = "dgExpenseList";
            this.dgExpenseList.ReadOnly = true;
            this.dgExpenseList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgExpenseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgExpenseList.Size = new System.Drawing.Size(632, 326);
            this.dgExpenseList.TabIndex = 4;
            // 
            // ExpenseCategory
            // 
            this.ExpenseCategory.HeaderText = "Category";
            this.ExpenseCategory.Name = "ExpenseCategory";
            this.ExpenseCategory.ReadOnly = true;
            // 
            // ExpenseFrom
            // 
            this.ExpenseFrom.HeaderText = "ExpenseFrom";
            this.ExpenseFrom.Name = "ExpenseFrom";
            this.ExpenseFrom.ReadOnly = true;
            // 
            // ExpenseAmount
            // 
            this.ExpenseAmount.HeaderText = "Amount";
            this.ExpenseAmount.Name = "ExpenseAmount";
            this.ExpenseAmount.ReadOnly = true;
            // 
            // ExpenseDate
            // 
            this.ExpenseDate.HeaderText = "Date";
            this.ExpenseDate.Name = "ExpenseDate";
            this.ExpenseDate.ReadOnly = true;
            // 
            // ExpenseDescription
            // 
            this.ExpenseDescription.HeaderText = "Description";
            this.ExpenseDescription.Name = "ExpenseDescription";
            this.ExpenseDescription.ReadOnly = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lblTotalAmount);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(3, 370);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(632, 51);
            this.panel12.TabIndex = 3;
            // 
            // tabAddExpense
            // 
            this.tabAddExpense.Controls.Add(this.panel2);
            this.tabAddExpense.Controls.Add(this.toolStrip2);
            this.tabAddExpense.Location = new System.Drawing.Point(4, 22);
            this.tabAddExpense.Name = "tabAddExpense";
            this.tabAddExpense.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddExpense.Size = new System.Drawing.Size(638, 424);
            this.tabAddExpense.TabIndex = 1;
            this.tabAddExpense.Text = "Expense Entry";
            this.tabAddExpense.ToolTipText = "Expense Entry";
            this.tabAddExpense.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 360);
            this.panel2.TabIndex = 261;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbExpenseFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbExpenseCategory);
            this.groupBox1.Controls.Add(this.rtExpenseDescription);
            this.groupBox1.Controls.Add(this.lblPatientID);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtExpenseAmount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(632, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enpense Entry";
            // 
            // label4
            // 
            this.label4.AccessibleName = "lblExpenseFrom";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 78);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = ": Expense From";
            // 
            // cmbExpenseFrom
            // 
            this.cmbExpenseFrom.AccessibleName = "cmbExpenseFrom";
            this.cmbExpenseFrom.FormattingEnabled = true;
            this.cmbExpenseFrom.Items.AddRange(new object[] {
            "Clinic Fund",
            "Donation Fund"});
            this.cmbExpenseFrom.Location = new System.Drawing.Point(148, 75);
            this.cmbExpenseFrom.Name = "cmbExpenseFrom";
            this.cmbExpenseFrom.Size = new System.Drawing.Size(169, 24);
            this.cmbExpenseFrom.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 141);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = ": Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 23);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = ": Expense Category";
            // 
            // cmbExpenseCategory
            // 
            this.cmbExpenseCategory.FormattingEnabled = true;
            this.cmbExpenseCategory.Items.AddRange(new object[] {
            "---Medical Expense---",
            "Ket",
            "---Clinic Expense---",
            "Fuel",
            "Bill"});
            this.cmbExpenseCategory.Location = new System.Drawing.Point(148, 45);
            this.cmbExpenseCategory.Name = "cmbExpenseCategory";
            this.cmbExpenseCategory.Size = new System.Drawing.Size(169, 24);
            this.cmbExpenseCategory.TabIndex = 27;
            // 
            // rtExpenseDescription
            // 
            this.rtExpenseDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtExpenseDescription.Location = new System.Drawing.Point(148, 166);
            this.rtExpenseDescription.Name = "rtExpenseDescription";
            this.rtExpenseDescription.Size = new System.Drawing.Size(453, 63);
            this.rtExpenseDescription.TabIndex = 26;
            this.rtExpenseDescription.Text = "";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(148, 21);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatientID.Size = new System.Drawing.Size(35, 17);
            this.lblPatientID.TabIndex = 25;
            this.lblPatientID.Text = "New";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(60, 21);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(87, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = ": Expense ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 168);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(87, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = ": Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 112);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = ": Amount";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(148, 106);
            this.txtExpenseAmount.MaxLength = 19;
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(169, 23);
            this.txtExpenseAmount.TabIndex = 1;
            this.txtExpenseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpenseAmount_KeyPress);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
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
            this.panelPatient.TabIndex = 5;
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
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Expense";
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Donator";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // PatientCNIC
            // 
            this.PatientCNIC.HeaderText = "Donator CNIC";
            this.PatientCNIC.Name = "PatientCNIC";
            this.PatientCNIC.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Amount";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // ExEdit
            // 
            this.ExEdit.HeaderText = "";
            this.ExEdit.Name = "ExEdit";
            this.ExEdit.ReadOnly = true;
            // 
            // errorProviderExpense
            // 
            this.errorProviderExpense.ContainerControl = this;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(262, 15);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(75, 15);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "Total : 100";
            // 
            // frmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 492);
            this.Controls.Add(this.panelPatient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmExpense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.frm_expensedata);
            this.tabControl1.ResumeLayout(false);
            this.tabExpense.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenseList)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tabAddExpense.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panelPatient.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExpense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExpense;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashFilter;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DataGridView dgExpenseList;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TabPage tabAddExpense;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbExpenseCategory;
        private System.Windows.Forms.RichTextBox rtExpenseDescription;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn ExEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbExpenseFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseDescription;
        private System.Windows.Forms.ErrorProvider errorProviderExpense;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}