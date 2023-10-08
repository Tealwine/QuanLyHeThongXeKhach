﻿namespace HeThongQuanLyXeKhach
{
    partial class frmEmployeeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManager));
            this.ctlEmploeeManager = new System.Windows.Forms.TabControl();
            this.tpManagerEmployee = new System.Windows.Forms.TabPage();
            this.panelManageView = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.pcbEmployeeImage = new System.Windows.Forms.PictureBox();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.txtEmployeeDelete = new System.Windows.Forms.Button();
            this.btnEmployeeRefresh = new System.Windows.Forms.Button();
            this.cmbcmbEmployeeRole = new System.Windows.Forms.ComboBox();
            this.dtpEmployeeBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmployeeLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tpLuong = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTinhLuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txFinalSalary = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMinus = new System.Windows.Forms.TextBox();
            this.txtReward = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSalaty = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImPort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExPort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.pnMainManage = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlEmploeeManager.SuspendLayout();
            this.tpManagerEmployee.SuspendLayout();
            this.panelManageView.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmployeeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tpLuong.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhLuong)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnMainManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlEmploeeManager
            // 
            this.ctlEmploeeManager.Controls.Add(this.tpManagerEmployee);
            this.ctlEmploeeManager.Controls.Add(this.tpLuong);
            resources.ApplyResources(this.ctlEmploeeManager, "ctlEmploeeManager");
            this.ctlEmploeeManager.Name = "ctlEmploeeManager";
            this.ctlEmploeeManager.SelectedIndex = 0;
            // 
            // tpManagerEmployee
            // 
            this.tpManagerEmployee.Controls.Add(this.panelManageView);
            resources.ApplyResources(this.tpManagerEmployee, "tpManagerEmployee");
            this.tpManagerEmployee.Name = "tpManagerEmployee";
            this.tpManagerEmployee.UseVisualStyleBackColor = true;
            // 
            // panelManageView
            // 
            this.panelManageView.BackColor = System.Drawing.Color.White;
            this.panelManageView.Controls.Add(this.panel2);
            this.panelManageView.Controls.Add(this.dgvNhanVien);
            resources.ApplyResources(this.panelManageView, "panelManageView");
            this.panelManageView.Name = "panelManageView";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.chkFemale);
            this.panel2.Controls.Add(this.chkMale);
            this.panel2.Controls.Add(this.btnAddImage);
            this.panel2.Controls.Add(this.pcbEmployeeImage);
            this.panel2.Controls.Add(this.btnEmployeeUpdate);
            this.panel2.Controls.Add(this.txtEmployeeDelete);
            this.panel2.Controls.Add(this.btnEmployeeRefresh);
            this.panel2.Controls.Add(this.cmbcmbEmployeeRole);
            this.panel2.Controls.Add(this.dtpEmployeeBirthDay);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.txtEmployeeLocation);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEmployeePhoneNumber);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtEmployeeId);
            this.panel2.Controls.Add(this.txtEmployeeName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // chkFemale
            // 
            resources.ApplyResources(this.chkFemale, "chkFemale");
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.UseVisualStyleBackColor = true;
            // 
            // chkMale
            // 
            resources.ApplyResources(this.chkMale, "chkMale");
            this.chkMale.Name = "chkMale";
            this.chkMale.UseVisualStyleBackColor = true;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnAddImage, "btnAddImage");
            this.btnAddImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // pcbEmployeeImage
            // 
            this.pcbEmployeeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pcbEmployeeImage, "pcbEmployeeImage");
            this.pcbEmployeeImage.Name = "pcbEmployeeImage";
            this.pcbEmployeeImage.TabStop = false;
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.BackColor = System.Drawing.Color.NavajoWhite;
            resources.ApplyResources(this.btnEmployeeUpdate, "btnEmployeeUpdate");
            this.btnEmployeeUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = false;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.btnEmployeeUpdate_Click);
            // 
            // txtEmployeeDelete
            // 
            this.txtEmployeeDelete.BackColor = System.Drawing.Color.NavajoWhite;
            resources.ApplyResources(this.txtEmployeeDelete, "txtEmployeeDelete");
            this.txtEmployeeDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmployeeDelete.Name = "txtEmployeeDelete";
            this.txtEmployeeDelete.UseVisualStyleBackColor = false;
            this.txtEmployeeDelete.Click += new System.EventHandler(this.txtEmployeeDelete_Click);
            // 
            // btnEmployeeRefresh
            // 
            this.btnEmployeeRefresh.BackColor = System.Drawing.Color.NavajoWhite;
            resources.ApplyResources(this.btnEmployeeRefresh, "btnEmployeeRefresh");
            this.btnEmployeeRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployeeRefresh.Name = "btnEmployeeRefresh";
            this.btnEmployeeRefresh.UseVisualStyleBackColor = false;
            this.btnEmployeeRefresh.Click += new System.EventHandler(this.btnEmployeeRefresh_Click);
            // 
            // cmbcmbEmployeeRole
            // 
            resources.ApplyResources(this.cmbcmbEmployeeRole, "cmbcmbEmployeeRole");
            this.cmbcmbEmployeeRole.FormattingEnabled = true;
            this.cmbcmbEmployeeRole.Items.AddRange(new object[] {
            resources.GetString("cmbcmbEmployeeRole.Items"),
            resources.GetString("cmbcmbEmployeeRole.Items1"),
            resources.GetString("cmbcmbEmployeeRole.Items2"),
            resources.GetString("cmbcmbEmployeeRole.Items3")});
            this.cmbcmbEmployeeRole.Name = "cmbcmbEmployeeRole";
            // 
            // dtpEmployeeBirthDay
            // 
            resources.ApplyResources(this.dtpEmployeeBirthDay, "dtpEmployeeBirthDay");
            this.dtpEmployeeBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmployeeBirthDay.Name = "dtpEmployeeBirthDay";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtSalary
            // 
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtSalary, "txtSalary");
            this.txtSalary.Name = "txtSalary";
            // 
            // txtEmployeeLocation
            // 
            this.txtEmployeeLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtEmployeeLocation, "txtEmployeeLocation");
            this.txtEmployeeLocation.Name = "txtEmployeeLocation";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtEmployeePhoneNumber
            // 
            this.txtEmployeePhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtEmployeePhoneNumber, "txtEmployeePhoneNumber");
            this.txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtEmployeeId, "txtEmployeeId");
            this.txtEmployeeId.Name = "txtEmployeeId";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtEmployeeName, "txtEmployeeName");
            this.txtEmployeeName.Name = "txtEmployeeName";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7});
            resources.ApplyResources(this.dgvNhanVien, "dgvNhanVien");
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // tpLuong
            // 
            this.tpLuong.Controls.Add(this.panel1);
            resources.ApplyResources(this.tpLuong, "tpLuong");
            this.tpLuong.Name = "tpLuong";
            this.tpLuong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dgvTinhLuong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // dgvTinhLuong
            // 
            this.dgvTinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvTinhLuong, "dgvTinhLuong");
            this.dgvTinhLuong.Name = "dgvTinhLuong";
            this.dgvTinhLuong.RowTemplate.Height = 24;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnIn);
            this.panel3.Controls.Add(this.btnTinh);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txFinalSalary);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtMinus);
            this.panel3.Controls.Add(this.txtReward);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtSalaty);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtName);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnSua
            // 
            resources.ApplyResources(this.btnSua, "btnSua");
            this.btnSua.Name = "btnSua";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            resources.ApplyResources(this.btnIn, "btnIn");
            this.btnIn.Name = "btnIn";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            resources.ApplyResources(this.btnTinh, "btnTinh");
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txFinalSalary
            // 
            resources.ApplyResources(this.txFinalSalary, "txFinalSalary");
            this.txFinalSalary.Name = "txFinalSalary";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txtMinus
            // 
            resources.ApplyResources(this.txtMinus, "txtMinus");
            this.txtMinus.Name = "txtMinus";
            // 
            // txtReward
            // 
            resources.ApplyResources(this.txtReward, "txtReward");
            this.txtReward.Name = "txtReward";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // txtSalaty
            // 
            resources.ApplyResources(this.txtSalaty, "txtSalaty");
            this.txtSalaty.Name = "txtSalaty";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.toolStripTextBox1,
            this.toolStripSeparator5,
            this.btnImPort,
            this.toolStripSeparator2,
            this.btnExPort,
            this.toolStripSeparator1,
            this.btnPrint});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // toolStripTextBox1
            // 
            resources.ApplyResources(this.toolStripTextBox1, "toolStripTextBox1");
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // btnImPort
            // 
            this.btnImPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnImPort, "btnImPort");
            this.btnImPort.Name = "btnImPort";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // btnExPort
            // 
            this.btnExPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnExPort, "btnExPort");
            this.btnExPort.Name = "btnExPort";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            // 
            // pnMainManage
            // 
            resources.ApplyResources(this.pnMainManage, "pnMainManage");
            this.pnMainManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnMainManage.Controls.Add(this.ctlEmploeeManager);
            this.pnMainManage.Name = "pnMainManage";
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            // 
            // frmEmployeeManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pnMainManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmEmployeeManager";
            this.Load += new System.EventHandler(this.frmEmployeeManager_Load);
            this.ctlEmploeeManager.ResumeLayout(false);
            this.tpManagerEmployee.ResumeLayout(false);
            this.panelManageView.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmployeeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tpLuong.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhLuong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnMainManage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ctlEmploeeManager;
        private System.Windows.Forms.TabPage tpManagerEmployee;
        private System.Windows.Forms.Panel panelManageView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox pcbEmployeeImage;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.Button txtEmployeeDelete;
        private System.Windows.Forms.Button btnEmployeeRefresh;
        private System.Windows.Forms.ComboBox cmbcmbEmployeeRole;
        private System.Windows.Forms.DateTimePicker dtpEmployeeBirthDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmployeeLocation;
        private System.Windows.Forms.TextBox txtEmployeePhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TabPage tpLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvTinhLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txFinalSalary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMinus;
        private System.Windows.Forms.TextBox txtReward;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSalaty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnImPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.Panel pnMainManage;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}