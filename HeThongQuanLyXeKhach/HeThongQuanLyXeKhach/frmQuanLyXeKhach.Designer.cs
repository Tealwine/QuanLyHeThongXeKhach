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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCoachList = new System.Windows.Forms.DataGridView();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.btnSeacrh = new System.Windows.Forms.Button();
            this.lbVehicleNumber = new System.Windows.Forms.Label();
            this.txtTotalCoach = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachList)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.pnDataManager.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1279, 558);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.txtTotalCoach);
            this.panel2.Controls.Add(this.lbVehicleNumber);
            this.panel2.Controls.Add(this.dgvCoachList);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 552);
            this.panel2.TabIndex = 0;
            // 
            // dgvCoachList
            // 
            this.dgvCoachList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCoachList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoachList.Location = new System.Drawing.Point(3, 3);
            this.dgvCoachList.Name = "dgvCoachList";
            this.dgvCoachList.RowHeadersWidth = 51;
            this.dgvCoachList.RowTemplate.Height = 24;
            this.dgvCoachList.Size = new System.Drawing.Size(745, 497);
            this.dgvCoachList.TabIndex = 22;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnSearch.Controls.Add(this.comboBox3);
            this.pnSearch.Controls.Add(this.comboBox4);
            this.pnSearch.Controls.Add(this.label1);
            this.pnSearch.Controls.Add(this.comboBox2);
            this.pnSearch.Controls.Add(this.comboBox1);
            this.pnSearch.Controls.Add(this.lbSearch);
            this.pnSearch.Controls.Add(this.btnSeacrh);
            this.pnSearch.Location = new System.Drawing.Point(774, 3);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(502, 214);
            this.pnSearch.TabIndex = 15;
            // 
            // btnSeacrh
            // 
            this.btnSeacrh.BackColor = System.Drawing.Color.Orange;
            this.btnSeacrh.FlatAppearance.BorderSize = 0;
            this.btnSeacrh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeacrh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSeacrh.Location = new System.Drawing.Point(341, 169);
            this.btnSeacrh.Name = "btnSeacrh";
            this.btnSeacrh.Size = new System.Drawing.Size(109, 38);
            this.btnSeacrh.TabIndex = 0;
            this.btnSeacrh.Text = "Thực hiện";
            this.btnSeacrh.UseVisualStyleBackColor = false;
            // 
            // lbVehicleNumber
            // 
            this.lbVehicleNumber.AutoSize = true;
            this.lbVehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleNumber.ForeColor = System.Drawing.Color.Orange;
            this.lbVehicleNumber.Location = new System.Drawing.Point(12, 518);
            this.lbVehicleNumber.Name = "lbVehicleNumber";
            this.lbVehicleNumber.Size = new System.Drawing.Size(129, 20);
            this.lbVehicleNumber.TabIndex = 23;
            this.lbVehicleNumber.Text = "Số xe hiện có:";
            this.lbVehicleNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalCoach
            // 
            this.txtTotalCoach.Enabled = false;
            this.txtTotalCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCoach.Location = new System.Drawing.Point(147, 515);
            this.txtTotalCoach.Name = "txtTotalCoach";
            this.txtTotalCoach.Size = new System.Drawing.Size(171, 27);
            this.txtTotalCoach.TabIndex = 24;
            // 
            // lbSearch
            // 
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.Orange;
            this.lbSearch.Location = new System.Drawing.Point(0, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(502, 32);
            this.lbSearch.TabIndex = 14;
            this.lbSearch.Text = "Tìm kiếm và lọc";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 30);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(258, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 30);
            this.comboBox2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hãng xe";
            // 
            // pnDataManager
            // 
            this.pnDataManager.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.pnDataManager.Size = new System.Drawing.Size(502, 332);
            this.pnDataManager.TabIndex = 17;
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtVehicleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleName.Enabled = false;
            this.txtVehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleName.Location = new System.Drawing.Point(104, 52);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(198, 30);
            this.txtVehicleName.TabIndex = 15;
            // 
            // lbVehicleName
            // 
            this.lbVehicleName.AutoSize = true;
            this.lbVehicleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleName.Location = new System.Drawing.Point(8, 55);
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
            this.txtID.Location = new System.Drawing.Point(104, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(198, 30);
            this.txtID.TabIndex = 13;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(8, 21);
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
            this.txtLicensePlate.Location = new System.Drawing.Point(104, 159);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(198, 30);
            this.txtLicensePlate.TabIndex = 10;
            // 
            // lbLicensePlate
            // 
            this.lbLicensePlate.AutoSize = true;
            this.lbLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicensePlate.Location = new System.Drawing.Point(8, 158);
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
            this.txtSeatNumber.Location = new System.Drawing.Point(104, 122);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(198, 30);
            this.txtSeatNumber.TabIndex = 8;
            // 
            // lbSeatNumber
            // 
            this.lbSeatNumber.AutoSize = true;
            this.lbSeatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeatNumber.Location = new System.Drawing.Point(8, 123);
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
            this.txtVehicleDescription.Location = new System.Drawing.Point(104, 88);
            this.txtVehicleDescription.Name = "txtVehicleDescription";
            this.txtVehicleDescription.Size = new System.Drawing.Size(198, 30);
            this.txtVehicleDescription.TabIndex = 6;
            // 
            // lbVehicleDescription
            // 
            this.lbVehicleDescription.AutoSize = true;
            this.lbVehicleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehicleDescription.Location = new System.Drawing.Point(8, 89);
            this.lbVehicleDescription.Name = "lbVehicleDescription";
            this.lbVehicleDescription.Size = new System.Drawing.Size(59, 22);
            this.lbVehicleDescription.TabIndex = 5;
            this.lbVehicleDescription.Text = "Mô tả:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(376, 287);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(258, 287);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(126, 287);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 35);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(258, 117);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(192, 30);
            this.comboBox3.TabIndex = 19;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(44, 117);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(208, 30);
            this.comboBox4.TabIndex = 18;
            // 
            // frmQuanLyXeKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 603);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyXeKhach";
            this.Text = "frmQuanLyXeKhach";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachList)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnDataManager.ResumeLayout(false);
            this.pnDataManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Button btnSeacrh;
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
    }
}