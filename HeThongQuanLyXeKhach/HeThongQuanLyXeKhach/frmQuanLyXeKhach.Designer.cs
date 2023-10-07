namespace HeThongQuanLyXeKhach
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
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.lbVehicleName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lbLicensePlate = new System.Windows.Forms.Label();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.lbSeatNumber = new System.Windows.Forms.Label();
            this.txtVehicleDescription = new System.Windows.Forms.TextBox();
            this.lbVehicleDescription = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnSeacrhCar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalCoach = new System.Windows.Forms.TextBox();
            this.lbVehicleNumber = new System.Windows.Forms.Label();
            this.dgvCoachList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnDataManager.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.pnDataManager);
            this.panel1.Controls.Add(this.pnSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 612);
            this.panel1.TabIndex = 0;
            // 
            // pnDataManager
            // 
            this.pnDataManager.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDataManager.Controls.Add(this.pictureBox1);
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
            this.pnDataManager.Controls.Add(this.txtVehicleDescription);
            this.pnDataManager.Controls.Add(this.lbVehicleDescription);
            this.pnDataManager.Controls.Add(this.btnDelete);
            this.pnDataManager.Controls.Add(this.btnUpdate);
            this.pnDataManager.Controls.Add(this.btnCreate);
            this.pnDataManager.Location = new System.Drawing.Point(774, 223);
            this.pnDataManager.Name = "pnDataManager";
            this.pnDataManager.Size = new System.Drawing.Size(570, 389);
            this.pnDataManager.TabIndex = 17;
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtVehicleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleName.Enabled = false;
            this.txtVehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleName.Location = new System.Drawing.Point(104, 83);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(234, 30);
            this.txtVehicleName.TabIndex = 15;
            // 
            // lbVehicleName
            // 
            this.lbVehicleName.AutoSize = true;
            this.lbVehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleName.Location = new System.Drawing.Point(9, 87);
            this.lbVehicleName.Name = "lbVehicleName";
            this.lbVehicleName.Size = new System.Drawing.Size(82, 22);
            this.lbVehicleName.TabIndex = 14;
            this.lbVehicleName.Text = "Hãng xe:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(104, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(234, 30);
            this.txtID.TabIndex = 13;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(9, 38);
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
            this.txtLicensePlate.Location = new System.Drawing.Point(104, 227);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(234, 30);
            this.txtLicensePlate.TabIndex = 10;
            // 
            // lbLicensePlate
            // 
            this.lbLicensePlate.AutoSize = true;
            this.lbLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicensePlate.Location = new System.Drawing.Point(8, 235);
            this.lbLicensePlate.Name = "lbLicensePlate";
            this.lbLicensePlate.Size = new System.Drawing.Size(75, 22);
            this.lbLicensePlate.TabIndex = 9;
            this.lbLicensePlate.Text = "Biển số:";
            this.lbLicensePlate.Click += new System.EventHandler(this.lbLicensePlate_Click);
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSeatNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatNumber.Location = new System.Drawing.Point(104, 182);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(234, 30);
            this.txtSeatNumber.TabIndex = 8;
            // 
            // lbSeatNumber
            // 
            this.lbSeatNumber.AutoSize = true;
            this.lbSeatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeatNumber.Location = new System.Drawing.Point(8, 190);
            this.lbSeatNumber.Name = "lbSeatNumber";
            this.lbSeatNumber.Size = new System.Drawing.Size(72, 22);
            this.lbSeatNumber.TabIndex = 7;
            this.lbSeatNumber.Text = "Số ghế:";
            // 
            // txtVehicleDescription
            // 
            this.txtVehicleDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtVehicleDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleDescription.Location = new System.Drawing.Point(104, 137);
            this.txtVehicleDescription.Name = "txtVehicleDescription";
            this.txtVehicleDescription.Size = new System.Drawing.Size(234, 30);
            this.txtVehicleDescription.TabIndex = 6;
            // 
            // lbVehicleDescription
            // 
            this.lbVehicleDescription.AutoSize = true;
            this.lbVehicleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleDescription.Location = new System.Drawing.Point(8, 141);
            this.lbVehicleDescription.Name = "lbVehicleDescription";
            this.lbVehicleDescription.Size = new System.Drawing.Size(59, 22);
            this.lbVehicleDescription.TabIndex = 5;
            this.lbVehicleDescription.Text = "Mô tả:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Wheat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(381, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Wheat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(257, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Wheat;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(117, 330);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 35);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnSearch.Controls.Add(this.btnReset);
            this.pnSearch.Controls.Add(this.label4);
            this.pnSearch.Controls.Add(this.label3);
            this.pnSearch.Controls.Add(this.label2);
            this.pnSearch.Controls.Add(this.comboBox3);
            this.pnSearch.Controls.Add(this.comboBox4);
            this.pnSearch.Controls.Add(this.label1);
            this.pnSearch.Controls.Add(this.comboBox2);
            this.pnSearch.Controls.Add(this.comboBox1);
            this.pnSearch.Controls.Add(this.lbSearch);
            this.pnSearch.Controls.Add(this.btnSeacrhCar);
            this.pnSearch.Location = new System.Drawing.Point(774, 3);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(570, 214);
            this.pnSearch.TabIndex = 15;
            this.pnSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSearch_Paint);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Đang chạy",
            "Đang nghỉ"});
            this.comboBox3.Location = new System.Drawing.Point(307, 122);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(248, 30);
            this.comboBox3.TabIndex = 19;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(32, 122);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(258, 30);
            this.comboBox4.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hãng xe";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(307, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(248, 30);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 30);
            this.comboBox1.TabIndex = 15;
            // 
            // lbSearch
            // 
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.Orange;
            this.lbSearch.Location = new System.Drawing.Point(0, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(570, 32);
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
            this.btnSeacrhCar.Location = new System.Drawing.Point(172, 162);
            this.btnSeacrhCar.Name = "btnSeacrhCar";
            this.btnSeacrhCar.Size = new System.Drawing.Size(111, 42);
            this.btnSeacrhCar.TabIndex = 0;
            this.btnSeacrhCar.Text = "Thực hiện";
            this.btnSeacrhCar.UseVisualStyleBackColor = false;
            this.btnSeacrhCar.Click += new System.EventHandler(this.btnSeacrh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.txtTotalCoach);
            this.panel2.Controls.Add(this.lbVehicleNumber);
            this.panel2.Controls.Add(this.dgvCoachList);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 606);
            this.panel2.TabIndex = 0;
            // 
            // txtTotalCoach
            // 
            this.txtTotalCoach.Enabled = false;
            this.txtTotalCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCoach.Location = new System.Drawing.Point(147, 562);
            this.txtTotalCoach.Name = "txtTotalCoach";
            this.txtTotalCoach.Size = new System.Drawing.Size(171, 27);
            this.txtTotalCoach.TabIndex = 24;
            // 
            // lbVehicleNumber
            // 
            this.lbVehicleNumber.AutoSize = true;
            this.lbVehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleNumber.ForeColor = System.Drawing.Color.Orange;
            this.lbVehicleNumber.Location = new System.Drawing.Point(12, 565);
            this.lbVehicleNumber.Name = "lbVehicleNumber";
            this.lbVehicleNumber.Size = new System.Drawing.Size(129, 20);
            this.lbVehicleNumber.TabIndex = 23;
            this.lbVehicleNumber.Text = "Số xe hiện có:";
            this.lbVehicleNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCoachList
            // 
            this.dgvCoachList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCoachList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoachList.Location = new System.Drawing.Point(3, 3);
            this.dgvCoachList.Name = "dgvCoachList";
            this.dgvCoachList.RowHeadersWidth = 51;
            this.dgvCoachList.RowTemplate.Height = 24;
            this.dgvCoachList.Size = new System.Drawing.Size(745, 549);
            this.dgvCoachList.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số ghế";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Loại Xe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Trạng thái";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtWarranty
            // 
            this.txtWarranty.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWarranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarranty.Location = new System.Drawing.Point(104, 275);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(234, 30);
            this.txtWarranty.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bảo hành";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(307, 162);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 42);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Xóa lọc";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(360, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 275);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuanLyXeKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 648);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyXeKhach";
            this.Text = "frmQuanLyXeKhach";
            this.panel1.ResumeLayout(false);
            this.pnDataManager.ResumeLayout(false);
            this.pnDataManager.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel pnDataManager;
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.Label lbVehicleName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lbLicensePlate;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Label lbSeatNumber;
        private System.Windows.Forms.TextBox txtVehicleDescription;
        private System.Windows.Forms.Label lbVehicleDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}