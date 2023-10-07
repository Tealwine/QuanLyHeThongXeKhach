namespace HeThongQuanLyXeKhach
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTakeTicket = new System.Windows.Forms.Button();
            this.btnFindMyTicket = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.btnTakeTicket);
            this.panel1.Controls.Add(this.btnFindMyTicket);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 571);
            this.panel1.TabIndex = 0;
            // 
            // btnTakeTicket
            // 
            this.btnTakeTicket.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeTicket.ForeColor = System.Drawing.Color.Turquoise;
            this.btnTakeTicket.Location = new System.Drawing.Point(313, 465);
            this.btnTakeTicket.Name = "btnTakeTicket";
            this.btnTakeTicket.Size = new System.Drawing.Size(182, 61);
            this.btnTakeTicket.TabIndex = 3;
            this.btnTakeTicket.Text = "Đặt vé";
            this.btnTakeTicket.UseVisualStyleBackColor = true;
            this.btnTakeTicket.Click += new System.EventHandler(this.btnTakeTicket_Click);
            // 
            // btnFindMyTicket
            // 
            this.btnFindMyTicket.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMyTicket.ForeColor = System.Drawing.Color.Turquoise;
            this.btnFindMyTicket.Location = new System.Drawing.Point(563, 465);
            this.btnFindMyTicket.Name = "btnFindMyTicket";
            this.btnFindMyTicket.Size = new System.Drawing.Size(173, 61);
            this.btnFindMyTicket.TabIndex = 2;
            this.btnFindMyTicket.Text = "Vé đã đặt";
            this.btnFindMyTicket.UseVisualStyleBackColor = true;
            this.btnFindMyTicket.Click += new System.EventHandler(this.btnFindMyTicket_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(866, 21);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 43);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 575);
            this.Controls.Add(this.panel1);
            this.Name = "frmStart";
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnTakeTicket;
        private System.Windows.Forms.Button btnFindMyTicket;
    }
}