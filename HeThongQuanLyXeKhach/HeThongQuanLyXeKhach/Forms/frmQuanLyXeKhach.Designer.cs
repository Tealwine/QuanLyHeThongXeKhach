﻿namespace HeThongQuanLyXeKhach
{
    partial class frmQuanLyXeKhach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnDataManager = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.picCoach = new System.Windows.Forms.PictureBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.lbVehicleName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lbLicensePlate = new System.Windows.Forms.Label();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.lbSeatNumber = new System.Windows.Forms.Label();
            this.lblCoachType = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.cmbCoachType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSeatNumber = new System.Windows.Forms.ComboBox();
            this.cmbCoachBrand = new System.Windows.Forms.ComboBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnSeacrhCar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalCoach = new System.Windows.Forms.TextBox();
            this.lbVehicleNumber = new System.Windows.Forms.Label();
            this.dgvCoachList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pnDataManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoach)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pnDataManager);
            this.panel1.Controls.Add(this.pnSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(37, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 766);
            this.panel1.TabIndex = 0;
            // 
            // pnDataManager
            // 
            this.pnDataManager.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDataManager.Controls.Add(this.cmbType);
            this.pnDataManager.Controls.Add(this.label6);
            this.pnDataManager.Controls.Add(this.picCoach);
            this.pnDataManager.Controls.Add(this.txtWarranty);
            this.pnDataManager.Controls.Add(this.label5);
            this.pnDataManager.Controls.Add(this.txtVehicleName);
            this.pnDataManager.Controls.Add(this.lbVehicleName);
            this.pnDataManager.Controls.Add(this.txtID);
            this.pnDataManager.Controls.Add(this.lbID);
            this.pnDataManager.Controls.Add(this.txtLicensePlate);
            this.pnDataManager.Controls.Add(this.lbLicensePlate);
            this.pnDataManager.Controls.Add(this.txtSeatNumber);
            this.pnDataManager.Controls.Add(this.lbSeatNumber);
            this.pnDataManager.Controls.Add(this.lblCoachType);
            this.pnDataManager.Controls.Add(this.btnDelete);
            this.pnDataManager.Controls.Add(this.btnUpdate);
            this.pnDataManager.Controls.Add(this.btnCreate);
            this.pnDataManager.Location = new System.Drawing.Point(989, 282);
            this.pnDataManager.Name = "pnDataManager";
            this.pnDataManager.Size = new System.Drawing.Size(667, 455);
            this.pnDataManager.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "năm";
            // 
            // picCoach
            // 
            this.picCoach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCoach.Location = new System.Drawing.Point(389, 60);
            this.picCoach.Name = "picCoach";
            this.picCoach.Size = new System.Drawing.Size(195, 275);
            this.picCoach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoach.TabIndex = 18;
            this.picCoach.TabStop = false;
            this.picCoach.Click += new System.EventHandler(this.picCoach_Click);
            // 
            // txtWarranty
            // 
            this.txtWarranty.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWarranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarranty.Location = new System.Drawing.Point(133, 305);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(177, 30);
            this.txtWarranty.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bảo hành:";
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtVehicleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleName.Location = new System.Drawing.Point(133, 113);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(234, 30);
            this.txtVehicleName.TabIndex = 15;
            // 
            // lbVehicleName
            // 
            this.lbVehicleName.AutoSize = true;
            this.lbVehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleName.Location = new System.Drawing.Point(38, 117);
            this.lbVehicleName.Name = "lbVehicleName";
            this.lbVehicleName.Size = new System.Drawing.Size(82, 22);
            this.lbVehicleName.TabIndex = 14;
            this.lbVehicleName.Text = "Hãng xe:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(133, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(234, 30);
            this.txtID.TabIndex = 13;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(38, 68);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(32, 22);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "ID:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicensePlate.Location = new System.Drawing.Point(133, 257);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(234, 30);
            this.txtLicensePlate.TabIndex = 10;
            // 
            // lbLicensePlate
            // 
            this.lbLicensePlate.AutoSize = true;
            this.lbLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicensePlate.Location = new System.Drawing.Point(37, 265);
            this.lbLicensePlate.Name = "lbLicensePlate";
            this.lbLicensePlate.Size = new System.Drawing.Size(75, 22);
            this.lbLicensePlate.TabIndex = 9;
            this.lbLicensePlate.Text = "Biển số:";
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSeatNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatNumber.Location = new System.Drawing.Point(133, 212);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(234, 30);
            this.txtSeatNumber.TabIndex = 8;
            // 
            // lbSeatNumber
            // 
            this.lbSeatNumber.AutoSize = true;
            this.lbSeatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeatNumber.Location = new System.Drawing.Point(37, 220);
            this.lbSeatNumber.Name = "lbSeatNumber";
            this.lbSeatNumber.Size = new System.Drawing.Size(72, 22);
            this.lbSeatNumber.TabIndex = 7;
            this.lbSeatNumber.Text = "Số ghế:";
            // 
            // lblCoachType
            // 
            this.lblCoachType.AutoSize = true;
            this.lblCoachType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachType.Location = new System.Drawing.Point(37, 168);
            this.lblCoachType.Name = "lblCoachType";
            this.lblCoachType.Size = new System.Drawing.Size(73, 22);
            this.lblCoachType.TabIndex = 5;
            this.lblCoachType.Text = "Loại xe:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Wheat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(410, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Wheat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(234, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Thêm/Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Wheat;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(107, 360);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 35);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Làm mới";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnSearch.Controls.Add(this.btnReset);
            this.pnSearch.Controls.Add(this.label4);
            this.pnSearch.Controls.Add(this.label3);
            this.pnSearch.Controls.Add(this.label2);
            this.pnSearch.Controls.Add(this.cmbState);
            this.pnSearch.Controls.Add(this.cmbCoachType);
            this.pnSearch.Controls.Add(this.label1);
            this.pnSearch.Controls.Add(this.cmbSeatNumber);
            this.pnSearch.Controls.Add(this.cmbCoachBrand);
            this.pnSearch.Controls.Add(this.lbSearch);
            this.pnSearch.Controls.Add(this.btnSeacrhCar);
            this.pnSearch.Location = new System.Drawing.Point(989, 10);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(667, 266);
            this.pnSearch.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(331, 193);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 42);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Xóa lọc";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Loại Xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số ghế";
            // 
            // cmbState
            // 
            this.cmbState.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Đang chạy",
            "Đang nghỉ"});
            this.cmbState.Location = new System.Drawing.Point(327, 135);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(248, 30);
            this.cmbState.TabIndex = 19;
            // 
            // cmbCoachType
            // 
            this.cmbCoachType.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoachType.FormattingEnabled = true;
            this.cmbCoachType.Location = new System.Drawing.Point(52, 135);
            this.cmbCoachType.Name = "cmbCoachType";
            this.cmbCoachType.Size = new System.Drawing.Size(258, 30);
            this.cmbCoachType.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hãng xe";
            // 
            // cmbSeatNumber
            // 
            this.cmbSeatNumber.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeatNumber.FormattingEnabled = true;
            this.cmbSeatNumber.Location = new System.Drawing.Point(327, 73);
            this.cmbSeatNumber.Name = "cmbSeatNumber";
            this.cmbSeatNumber.Size = new System.Drawing.Size(248, 30);
            this.cmbSeatNumber.TabIndex = 16;
            // 
            // cmbCoachBrand
            // 
            this.cmbCoachBrand.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoachBrand.FormattingEnabled = true;
            this.cmbCoachBrand.Location = new System.Drawing.Point(52, 73);
            this.cmbCoachBrand.Name = "cmbCoachBrand";
            this.cmbCoachBrand.Size = new System.Drawing.Size(258, 30);
            this.cmbCoachBrand.TabIndex = 15;
            // 
            // lbSearch
            // 
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.Orange;
            this.lbSearch.Location = new System.Drawing.Point(0, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(667, 32);
            this.lbSearch.TabIndex = 14;
            this.lbSearch.Text = "Tìm kiếm và lọc";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSeacrhCar
            // 
            this.btnSeacrhCar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSeacrhCar.FlatAppearance.BorderSize = 0;
            this.btnSeacrhCar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeacrhCar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSeacrhCar.Location = new System.Drawing.Point(159, 193);
            this.btnSeacrhCar.Name = "btnSeacrhCar";
            this.btnSeacrhCar.Size = new System.Drawing.Size(148, 42);
            this.btnSeacrhCar.TabIndex = 0;
            this.btnSeacrhCar.Text = "Thực hiện";
            this.btnSeacrhCar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.txtTotalCoach);
            this.panel2.Controls.Add(this.lbVehicleNumber);
            this.panel2.Controls.Add(this.dgvCoachList);
            this.panel2.Location = new System.Drawing.Point(12, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 727);
            this.panel2.TabIndex = 0;
            // 
            // txtTotalCoach
            // 
            this.txtTotalCoach.Enabled = false;
            this.txtTotalCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCoach.Location = new System.Drawing.Point(217, 653);
            this.txtTotalCoach.Name = "txtTotalCoach";
            this.txtTotalCoach.Size = new System.Drawing.Size(171, 27);
            this.txtTotalCoach.TabIndex = 24;
            // 
            // lbVehicleNumber
            // 
            this.lbVehicleNumber.AutoSize = true;
            this.lbVehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleNumber.ForeColor = System.Drawing.Color.Orange;
            this.lbVehicleNumber.Location = new System.Drawing.Point(64, 656);
            this.lbVehicleNumber.Name = "lbVehicleNumber";
            this.lbVehicleNumber.Size = new System.Drawing.Size(129, 20);
            this.lbVehicleNumber.TabIndex = 23;
            this.lbVehicleNumber.Text = "Số xe hiện có:";
            this.lbVehicleNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCoachList
            // 
            this.dgvCoachList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoachList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCoachList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoachList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvCoachList.Location = new System.Drawing.Point(16, 3);
            this.dgvCoachList.Name = "dgvCoachList";
            this.dgvCoachList.RowHeadersWidth = 51;
            this.dgvCoachList.RowTemplate.Height = 24;
            this.dgvCoachList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoachList.Size = new System.Drawing.Size(933, 622);
            this.dgvCoachList.TabIndex = 22;
            this.dgvCoachList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoachList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Xe";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Biển Số";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hãng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số ghế";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Bảo hành";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Loại Xe";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(134, 166);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(233, 24);
            this.cmbType.TabIndex = 20;
            // 
            // frmQuanLyXeKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 782);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmQuanLyXeKhach";
            this.Text = "Quản Lý Xe Khách";
            this.Load += new System.EventHandler(this.frmQuanLyXeKhach_Load);
            this.panel1.ResumeLayout(false);
            this.pnDataManager.ResumeLayout(false);
            this.pnDataManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoach)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Button btnSeacrhCar;
        private System.Windows.Forms.DataGridView dgvCoachList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotalCoach;
        private System.Windows.Forms.Label lbVehicleNumber;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.ComboBox cmbCoachBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSeatNumber;
        private System.Windows.Forms.Panel pnDataManager;
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.Label lbVehicleName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lbLicensePlate;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Label lbSeatNumber;
        private System.Windows.Forms.Label lblCoachType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.ComboBox cmbCoachType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbType;
    }
}