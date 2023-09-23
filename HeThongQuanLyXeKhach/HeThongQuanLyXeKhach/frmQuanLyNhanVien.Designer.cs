namespace HeThongQuanLyXeKhach
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
            this.tpLuong = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSalaty = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReward = new System.Windows.Forms.TextBox();
            this.txtMinus = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txFinalSalary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTinhLuong = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpManagerEmployee = new System.Windows.Forms.TabPage();
            this.panelManageView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeePassWord = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.dtpEmployeeBirthDay = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployeeSex = new System.Windows.Forms.ComboBox();
            this.cmbcmbEmployeeRole = new System.Windows.Forms.ComboBox();
            this.btnEmployeeRefresh = new System.Windows.Forms.Button();
            this.txtEmployeeDelete = new System.Windows.Forms.Button();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.pcbEmployeeImage = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.pnMainManage = new System.Windows.Forms.Panel();
            this.ctlEmploeeManager.SuspendLayout();
            this.tpLuong.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpManagerEmployee.SuspendLayout();
            this.panelManageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmployeeImage)).BeginInit();
            this.pnMainManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlEmploeeManager
            // 
            this.ctlEmploeeManager.Controls.Add(this.tpManagerEmployee);
            this.ctlEmploeeManager.Controls.Add(this.tpLuong);
            this.ctlEmploeeManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlEmploeeManager.Location = new System.Drawing.Point(0, 3);
            this.ctlEmploeeManager.Name = "ctlEmploeeManager";
            this.ctlEmploeeManager.SelectedIndex = 0;
            this.ctlEmploeeManager.Size = new System.Drawing.Size(1269, 679);
            this.ctlEmploeeManager.TabIndex = 0;
            // 
            // tpLuong
            // 
            this.tpLuong.Controls.Add(this.panel1);
            this.tpLuong.Location = new System.Drawing.Point(4, 34);
            this.tpLuong.Name = "tpLuong";
            this.tpLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tpLuong.Size = new System.Drawing.Size(1261, 641);
            this.tpLuong.TabIndex = 1;
            this.tpLuong.Text = "Tính Lương";
            this.tpLuong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dgvTinhLuong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(18, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 609);
            this.panel1.TabIndex = 20;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
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
            this.toolStrip1.Location = new System.Drawing.Point(651, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(547, 37);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(106, 34);
            this.toolStripButton1.Text = "Tìm Kiếm";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 37);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // btnImPort
            // 
            this.btnImPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImPort.Image = ((System.Drawing.Image)(resources.GetObject("btnImPort.Image")));
            this.btnImPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImPort.Name = "btnImPort";
            this.btnImPort.Size = new System.Drawing.Size(34, 34);
            this.btnImPort.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // btnExPort
            // 
            this.btnExPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExPort.Image = ((System.Drawing.Image)(resources.GetObject("btnExPort.Image")));
            this.btnExPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExPort.Name = "btnExPort";
            this.btnExPort.Size = new System.Drawing.Size(34, 34);
            this.btnExPort.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(34, 34);
            this.btnPrint.Text = "toolStripButton3";
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
            this.panel3.Location = new System.Drawing.Point(837, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 416);
            this.panel3.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(131, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 27);
            this.txtName.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 18);
            this.label16.TabIndex = 1;
            this.label16.Text = "Tên Nhân Viên";
            // 
            // txtSalaty
            // 
            this.txtSalaty.Enabled = false;
            this.txtSalaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaty.Location = new System.Drawing.Point(131, 130);
            this.txtSalaty.Name = "txtSalaty";
            this.txtSalaty.Size = new System.Drawing.Size(250, 27);
            this.txtSalaty.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "Lương";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Thưởng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Phạt";
            // 
            // txtReward
            // 
            this.txtReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReward.Location = new System.Drawing.Point(131, 178);
            this.txtReward.Name = "txtReward";
            this.txtReward.Size = new System.Drawing.Size(250, 27);
            this.txtReward.TabIndex = 6;
            // 
            // txtMinus
            // 
            this.txtMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinus.Location = new System.Drawing.Point(131, 225);
            this.txtMinus.Name = "txtMinus";
            this.txtMinus.Size = new System.Drawing.Size(250, 27);
            this.txtMinus.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tổng Lương";
            // 
            // txFinalSalary
            // 
            this.txFinalSalary.Enabled = false;
            this.txFinalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFinalSalary.Location = new System.Drawing.Point(131, 302);
            this.txFinalSalary.Name = "txFinalSalary";
            this.txFinalSalary.Size = new System.Drawing.Size(250, 27);
            this.txFinalSalary.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mã Nhân Viên";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(131, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(250, 27);
            this.txtId.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(384, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "__________________________________";
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(146, 359);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(108, 38);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(273, 359);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(108, 38);
            this.btnIn.TabIndex = 13;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(17, 359);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 38);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "BẢNG TÍNH LƯƠNG";
            // 
            // dgvTinhLuong
            // 
            this.dgvTinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhLuong.Location = new System.Drawing.Point(14, 133);
            this.dgvTinhLuong.Name = "dgvTinhLuong";
            this.dgvTinhLuong.RowHeadersWidth = 51;
            this.dgvTinhLuong.RowTemplate.Height = 24;
            this.dgvTinhLuong.Size = new System.Drawing.Size(807, 416);
            this.dgvTinhLuong.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // tpManagerEmployee
            // 
            this.tpManagerEmployee.Controls.Add(this.panelManageView);
            this.tpManagerEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpManagerEmployee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tpManagerEmployee.Location = new System.Drawing.Point(4, 34);
            this.tpManagerEmployee.Name = "tpManagerEmployee";
            this.tpManagerEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tpManagerEmployee.Size = new System.Drawing.Size(1263, 641);
            this.tpManagerEmployee.TabIndex = 0;
            this.tpManagerEmployee.Text = "Quàn Lý nhân Sự";
            this.tpManagerEmployee.UseVisualStyleBackColor = true;
            // 
            // panelManageView
            // 
            this.panelManageView.BackColor = System.Drawing.Color.White;
            this.panelManageView.Controls.Add(this.panel2);
            this.panelManageView.Controls.Add(this.dataGridView1);
            this.panelManageView.Location = new System.Drawing.Point(17, 21);
            this.panelManageView.Name = "panelManageView";
            this.panelManageView.Size = new System.Drawing.Size(1203, 595);
            this.panelManageView.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnAddImage);
            this.panel2.Controls.Add(this.pcbEmployeeImage);
            this.panel2.Controls.Add(this.btnEmployeeAdd);
            this.panel2.Controls.Add(this.txtEmployeeDelete);
            this.panel2.Controls.Add(this.btnEmployeeRefresh);
            this.panel2.Controls.Add(this.cmbcmbEmployeeRole);
            this.panel2.Controls.Add(this.cmbEmployeeSex);
            this.panel2.Controls.Add(this.dtpEmployeeBirthDay);
            this.panel2.Controls.Add(this.btnEmployeeUpdate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtEmployeeLocation);
            this.panel2.Controls.Add(this.txtEmployeePhoneNumber);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtEmployeeId);
            this.panel2.Controls.Add(this.txtEmployeeName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtEmployeePassWord);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(22, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 264);
            this.panel2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(859, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "GIỚI TÍNH";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(324, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(61, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(61, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "HỌ VÀ TÊN";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(859, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "NGÀY SINH";
            // 
            // txtEmployeePassWord
            // 
            this.txtEmployeePassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeePassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePassWord.Location = new System.Drawing.Point(66, 45);
            this.txtEmployeePassWord.Multiline = true;
            this.txtEmployeePassWord.Name = "txtEmployeePassWord";
            this.txtEmployeePassWord.Size = new System.Drawing.Size(257, 33);
            this.txtEmployeePassWord.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(582, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "CHỨC VỤ";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(66, 138);
            this.txtEmployeeName.Multiline = true;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(257, 33);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(329, 45);
            this.txtEmployeeId.Multiline = true;
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(252, 33);
            this.txtEmployeeId.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(324, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "ĐỊA CHỈ";
            // 
            // txtEmployeePhoneNumber
            // 
            this.txtEmployeePhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePhoneNumber.Location = new System.Drawing.Point(587, 138);
            this.txtEmployeePhoneNumber.Multiline = true;
            this.txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber";
            this.txtEmployeePhoneNumber.Size = new System.Drawing.Size(271, 33);
            this.txtEmployeePhoneNumber.TabIndex = 21;
            // 
            // txtEmployeeLocation
            // 
            this.txtEmployeeLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeLocation.Location = new System.Drawing.Point(329, 138);
            this.txtEmployeeLocation.Multiline = true;
            this.txtEmployeeLocation.Name = "txtEmployeeLocation";
            this.txtEmployeeLocation.Size = new System.Drawing.Size(252, 33);
            this.txtEmployeeLocation.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(582, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "SỐ ĐIỆN THOẠI";
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEmployeeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(587, 204);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(141, 48);
            this.btnEmployeeUpdate.TabIndex = 24;
            this.btnEmployeeUpdate.Text = "Cập nhật";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = false;
            // 
            // dtpEmployeeBirthDay
            // 
            this.dtpEmployeeBirthDay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmployeeBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmployeeBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmployeeBirthDay.Location = new System.Drawing.Point(864, 48);
            this.dtpEmployeeBirthDay.Name = "dtpEmployeeBirthDay";
            this.dtpEmployeeBirthDay.Size = new System.Drawing.Size(140, 30);
            this.dtpEmployeeBirthDay.TabIndex = 23;
            // 
            // cmbEmployeeSex
            // 
            this.cmbEmployeeSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeSex.FormattingEnabled = true;
            this.cmbEmployeeSex.Items.AddRange(new object[] {
            "NAM",
            "NỮ"});
            this.cmbEmployeeSex.Location = new System.Drawing.Point(864, 138);
            this.cmbEmployeeSex.Name = "cmbEmployeeSex";
            this.cmbEmployeeSex.Size = new System.Drawing.Size(140, 33);
            this.cmbEmployeeSex.TabIndex = 24;
            // 
            // cmbcmbEmployeeRole
            // 
            this.cmbcmbEmployeeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcmbEmployeeRole.FormattingEnabled = true;
            this.cmbcmbEmployeeRole.Items.AddRange(new object[] {
            "QUẢN LÝ",
            "NHÂN VIÊN TIẾP TÂN",
            "TÀI XẾ",
            "PHỤ XE",
            "KẾ TOÁN"});
            this.cmbcmbEmployeeRole.Location = new System.Drawing.Point(587, 45);
            this.cmbcmbEmployeeRole.Name = "cmbcmbEmployeeRole";
            this.cmbcmbEmployeeRole.Size = new System.Drawing.Size(271, 33);
            this.cmbcmbEmployeeRole.TabIndex = 25;
            // 
            // btnEmployeeRefresh
            // 
            this.btnEmployeeRefresh.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEmployeeRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployeeRefresh.Location = new System.Drawing.Point(734, 204);
            this.btnEmployeeRefresh.Name = "btnEmployeeRefresh";
            this.btnEmployeeRefresh.Size = new System.Drawing.Size(141, 48);
            this.btnEmployeeRefresh.TabIndex = 26;
            this.btnEmployeeRefresh.Text = "Làm mới";
            this.btnEmployeeRefresh.UseVisualStyleBackColor = false;
            // 
            // txtEmployeeDelete
            // 
            this.txtEmployeeDelete.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtEmployeeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmployeeDelete.Location = new System.Drawing.Point(440, 204);
            this.txtEmployeeDelete.Name = "txtEmployeeDelete";
            this.txtEmployeeDelete.Size = new System.Drawing.Size(141, 48);
            this.txtEmployeeDelete.TabIndex = 27;
            this.txtEmployeeDelete.Text = "Xóa";
            this.txtEmployeeDelete.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEmployeeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployeeAdd.Location = new System.Drawing.Point(293, 204);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(141, 48);
            this.btnEmployeeAdd.TabIndex = 28;
            this.btnEmployeeAdd.Text = "Thêm";
            this.btnEmployeeAdd.UseVisualStyleBackColor = false;
            // 
            // pcbEmployeeImage
            // 
            this.pcbEmployeeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbEmployeeImage.Location = new System.Drawing.Point(1041, 18);
            this.pcbEmployeeImage.Name = "pcbEmployeeImage";
            this.pcbEmployeeImage.Size = new System.Drawing.Size(120, 160);
            this.pcbEmployeeImage.TabIndex = 25;
            this.pcbEmployeeImage.TabStop = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.Transparent;
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddImage.Location = new System.Drawing.Point(1061, 184);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(79, 23);
            this.btnAddImage.TabIndex = 29;
            this.btnAddImage.Text = "Thêm";
            this.btnAddImage.UseVisualStyleBackColor = false;
            // 
            // pnMainManage
            // 
            this.pnMainManage.AutoSize = true;
            this.pnMainManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnMainManage.Controls.Add(this.ctlEmploeeManager);
            this.pnMainManage.Location = new System.Drawing.Point(0, -1);
            this.pnMainManage.Name = "pnMainManage";
            this.pnMainManage.Size = new System.Drawing.Size(1272, 685);
            this.pnMainManage.TabIndex = 9;
            // 
            // frmEmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1267, 677);
            this.Controls.Add(this.pnMainManage);
            this.Name = "frmEmployeeManager";
            this.ctlEmploeeManager.ResumeLayout(false);
            this.tpLuong.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpManagerEmployee.ResumeLayout(false);
            this.panelManageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEmployeeImage)).EndInit();
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
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.Button txtEmployeeDelete;
        private System.Windows.Forms.Button btnEmployeeRefresh;
        private System.Windows.Forms.ComboBox cmbcmbEmployeeRole;
        private System.Windows.Forms.ComboBox cmbEmployeeSex;
        private System.Windows.Forms.DateTimePicker dtpEmployeeBirthDay;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmployeeLocation;
        private System.Windows.Forms.TextBox txtEmployeePhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmployeePassWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}