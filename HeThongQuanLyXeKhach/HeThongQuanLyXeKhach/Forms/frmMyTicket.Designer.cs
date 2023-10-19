namespace HeThongQuanLyXeKhach
{
    partial class frmMyTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyTicket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSeat = new System.Windows.Forms.ComboBox();
            this.btnFindMyTicket = new System.Windows.Forms.Button();
            this.txtCusPhoneToFind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMyTicketPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtMyPay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMyPhoneNumber = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMyName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pnComplete = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.pnTripInfor = new System.Windows.Forms.Panel();
            this.txtMyStartTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.txtMyCoachType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMyStartDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMyDestination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMyStartLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnComplete.SuspendLayout();
            this.pnTripInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnComplete);
            this.panel1.Controls.Add(this.pnTripInfor);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 849);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbSeat);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnFindMyTicket);
            this.panel3.Controls.Add(this.txtCusPhoneToFind);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(10, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1223, 64);
            this.panel3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(672, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số ghế đã đặt";
            // 
            // cmbSeat
            // 
            this.cmbSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeat.FormattingEnabled = true;
            this.cmbSeat.ItemHeight = 20;
            this.cmbSeat.Location = new System.Drawing.Point(801, 20);
            this.cmbSeat.Name = "cmbSeat";
            this.cmbSeat.Size = new System.Drawing.Size(167, 28);
            this.cmbSeat.TabIndex = 1;
            this.cmbSeat.SelectedValueChanged += new System.EventHandler(this.cmbSeat_SelectedValueChanged);
            // 
            // btnFindMyTicket
            // 
            this.btnFindMyTicket.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFindMyTicket.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMyTicket.Location = new System.Drawing.Point(521, 13);
            this.btnFindMyTicket.Name = "btnFindMyTicket";
            this.btnFindMyTicket.Size = new System.Drawing.Size(82, 34);
            this.btnFindMyTicket.TabIndex = 10;
            this.btnFindMyTicket.Text = "Tìm kiếm";
            this.btnFindMyTicket.UseVisualStyleBackColor = false;
            this.btnFindMyTicket.Click += new System.EventHandler(this.btnFindMyTicket_Click);
            // 
            // txtCusPhoneToFind
            // 
            this.txtCusPhoneToFind.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCusPhoneToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusPhoneToFind.Location = new System.Drawing.Point(215, 16);
            this.txtCusPhoneToFind.Name = "txtCusPhoneToFind";
            this.txtCusPhoneToFind.Size = new System.Drawing.Size(300, 27);
            this.txtCusPhoneToFind.TabIndex = 9;
            this.txtCusPhoneToFind.TextChanged += new System.EventHandler(this.txtCusPhoneToFind_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số điện thoại đã đặt vé";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtMyTicketPrice);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.txtMyPay);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtMyPhoneNumber);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.txtMyName);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Location = new System.Drawing.Point(598, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 494);
            this.panel2.TabIndex = 13;
            // 
            // txtMyTicketPrice
            // 
            this.txtMyTicketPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMyTicketPrice.Enabled = false;
            this.txtMyTicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyTicketPrice.Location = new System.Drawing.Point(194, 389);
            this.txtMyTicketPrice.Name = "txtMyTicketPrice";
            this.txtMyTicketPrice.ReadOnly = true;
            this.txtMyTicketPrice.Size = new System.Drawing.Size(363, 27);
            this.txtMyTicketPrice.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(563, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "Giá vé";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(27, 65);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(549, 27);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "_________________________________________________________________________________" +
    "____________________________________________________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(375, 34);
            this.label12.TabIndex = 23;
            this.label12.Text = "THÔNG TIN THANH TOÁN";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(27, 283);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(549, 27);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "_________________________________________________________________________________" +
    "____________________________________________________________________________";
            // 
            // txtMyPay
            // 
            this.txtMyPay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMyPay.Enabled = false;
            this.txtMyPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyPay.Location = new System.Drawing.Point(194, 446);
            this.txtMyPay.Name = "txtMyPay";
            this.txtMyPay.ReadOnly = true;
            this.txtMyPay.Size = new System.Drawing.Size(363, 27);
            this.txtMyPay.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(563, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tổng tiền thanh toán:";
            // 
            // txtMyPhoneNumber
            // 
            this.txtMyPhoneNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMyPhoneNumber.Enabled = false;
            this.txtMyPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyPhoneNumber.Location = new System.Drawing.Point(194, 202);
            this.txtMyPhoneNumber.Name = "txtMyPhoneNumber";
            this.txtMyPhoneNumber.ReadOnly = true;
            this.txtMyPhoneNumber.Size = new System.Drawing.Size(358, 27);
            this.txtMyPhoneNumber.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(23, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(133, 21);
            this.label21.TabIndex = 9;
            this.label21.Text = "Tên khách hàng:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(23, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(378, 34);
            this.label24.TabIndex = 17;
            this.label24.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txtMyName
            // 
            this.txtMyName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMyName.Enabled = false;
            this.txtMyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyName.Location = new System.Drawing.Point(194, 123);
            this.txtMyName.Name = "txtMyName";
            this.txtMyName.ReadOnly = true;
            this.txtMyName.Size = new System.Drawing.Size(358, 27);
            this.txtMyName.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(23, 204);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 21);
            this.label20.TabIndex = 8;
            this.label20.Text = "Số điện thoại:";
            // 
            // pnComplete
            // 
            this.pnComplete.BackColor = System.Drawing.SystemColors.Control;
            this.pnComplete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnComplete.Controls.Add(this.richTextBox1);
            this.pnComplete.Controls.Add(this.label25);
            this.pnComplete.Location = new System.Drawing.Point(10, 573);
            this.pnComplete.Name = "pnComplete";
            this.pnComplete.Size = new System.Drawing.Size(1220, 218);
            this.pnComplete.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(19, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(1145, 153);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DarkOrange;
            this.label25.Location = new System.Drawing.Point(15, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(242, 24);
            this.label25.TabIndex = 18;
            this.label25.Text = "ĐIỀU KHOẢN VÀ LƯU Ý";
            // 
            // pnTripInfor
            // 
            this.pnTripInfor.BackColor = System.Drawing.SystemColors.Control;
            this.pnTripInfor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTripInfor.Controls.Add(this.pictureBox1);
            this.pnTripInfor.Controls.Add(this.txtMyStartTime);
            this.pnTripInfor.Controls.Add(this.label5);
            this.pnTripInfor.Controls.Add(this.textBox15);
            this.pnTripInfor.Controls.Add(this.txtMyCoachType);
            this.pnTripInfor.Controls.Add(this.label6);
            this.pnTripInfor.Controls.Add(this.txtMyStartDate);
            this.pnTripInfor.Controls.Add(this.label4);
            this.pnTripInfor.Controls.Add(this.txtMyDestination);
            this.pnTripInfor.Controls.Add(this.label3);
            this.pnTripInfor.Controls.Add(this.txtMyStartLocation);
            this.pnTripInfor.Controls.Add(this.label2);
            this.pnTripInfor.Controls.Add(this.label1);
            this.pnTripInfor.Location = new System.Drawing.Point(10, 73);
            this.pnTripInfor.Name = "pnTripInfor";
            this.pnTripInfor.Size = new System.Drawing.Size(582, 494);
            this.pnTripInfor.TabIndex = 11;
            // 
            // txtMyStartTime
            // 
            this.txtMyStartTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMyStartTime.Enabled = false;
            this.txtMyStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyStartTime.Location = new System.Drawing.Point(151, 367);
            this.txtMyStartTime.Name = "txtMyStartTime";
            this.txtMyStartTime.ReadOnly = true;
            this.txtMyStartTime.Size = new System.Drawing.Size(300, 27);
            this.txtMyStartTime.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giờ đi:";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Enabled = false;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(19, 63);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(432, 27);
            this.textBox15.TabIndex = 3;
            this.textBox15.Text = "_________________________________________________________________________________" +
    "____________________________________________________________________________";
            // 
            // txtMyCoachType
            // 
            this.txtMyCoachType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMyCoachType.Enabled = false;
            this.txtMyCoachType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyCoachType.Location = new System.Drawing.Point(151, 450);
            this.txtMyCoachType.Name = "txtMyCoachType";
            this.txtMyCoachType.ReadOnly = true;
            this.txtMyCoachType.Size = new System.Drawing.Size(300, 27);
            this.txtMyCoachType.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại xe:";
            // 
            // txtMyStartDate
            // 
            this.txtMyStartDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMyStartDate.Enabled = false;
            this.txtMyStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyStartDate.Location = new System.Drawing.Point(151, 287);
            this.txtMyStartDate.Name = "txtMyStartDate";
            this.txtMyStartDate.ReadOnly = true;
            this.txtMyStartDate.Size = new System.Drawing.Size(300, 27);
            this.txtMyStartDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày đi:";
            // 
            // txtMyDestination
            // 
            this.txtMyDestination.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMyDestination.Enabled = false;
            this.txtMyDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyDestination.Location = new System.Drawing.Point(151, 202);
            this.txtMyDestination.Name = "txtMyDestination";
            this.txtMyDestination.ReadOnly = true;
            this.txtMyDestination.Size = new System.Drawing.Size(300, 27);
            this.txtMyDestination.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điểm đến:";
            // 
            // txtMyStartLocation
            // 
            this.txtMyStartLocation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMyStartLocation.Enabled = false;
            this.txtMyStartLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyStartLocation.Location = new System.Drawing.Point(151, 108);
            this.txtMyStartLocation.Name = "txtMyStartLocation";
            this.txtMyStartLocation.ReadOnly = true;
            this.txtMyStartLocation.Size = new System.Drawing.Size(300, 27);
            this.txtMyStartLocation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm xuất phát:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN CHUYẾN XE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1158, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1026, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "In vé";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // frmMyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 826);
            this.Controls.Add(this.panel1);
            this.Name = "frmMyTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTicket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMyTicket_FormClosing);
            this.Load += new System.EventHandler(this.frmMyTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnComplete.ResumeLayout(false);
            this.pnComplete.PerformLayout();
            this.pnTripInfor.ResumeLayout(false);
            this.pnTripInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnComplete;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtMyPhoneNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMyName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel pnTripInfor;
        private System.Windows.Forms.TextBox txtMyStartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox txtMyCoachType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMyStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMyDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMyStartLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtMyPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFindMyTicket;
        private System.Windows.Forms.TextBox txtCusPhoneToFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSeat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMyTicketPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPrint;
    }
}