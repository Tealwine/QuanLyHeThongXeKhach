namespace HeThongQuanLyXeKhach
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnMainFuncion = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnEmployeeManager = new System.Windows.Forms.Button();
            this.btnTripManage = new System.Windows.Forms.Button();
            this.btnCarManage = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuMyAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBill = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnMainFuncion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMainFuncion
            // 
            this.pnMainFuncion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnMainFuncion.Controls.Add(this.pictureBox1);
            this.pnMainFuncion.Controls.Add(this.panel1);
            this.pnMainFuncion.Controls.Add(this.btnCash);
            this.pnMainFuncion.Controls.Add(this.btnEmployeeManager);
            this.pnMainFuncion.Controls.Add(this.btnTripManage);
            this.pnMainFuncion.Controls.Add(this.btnCarManage);
            this.pnMainFuncion.Controls.Add(this.btnSystem);
            this.pnMainFuncion.Location = new System.Drawing.Point(0, 36);
            this.pnMainFuncion.Name = "pnMainFuncion";
            this.pnMainFuncion.Size = new System.Drawing.Size(200, 1051);
            this.pnMainFuncion.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(187, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 67);
            this.panel1.TabIndex = 1;
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.Location = new System.Drawing.Point(3, 431);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(194, 67);
            this.btnCash.TabIndex = 4;
            this.btnCash.Text = "Thu chi";
            this.btnCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnEmployeeManager
            // 
            this.btnEmployeeManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManager.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeManager.Image")));
            this.btnEmployeeManager.Location = new System.Drawing.Point(3, 504);
            this.btnEmployeeManager.Name = "btnEmployeeManager";
            this.btnEmployeeManager.Size = new System.Drawing.Size(194, 67);
            this.btnEmployeeManager.TabIndex = 3;
            this.btnEmployeeManager.Text = "Quản lý \r\nnhân viên";
            this.btnEmployeeManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeManager.UseVisualStyleBackColor = true;
            this.btnEmployeeManager.Click += new System.EventHandler(this.btnEmployeeManager_Click);
            // 
            // btnTripManage
            // 
            this.btnTripManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTripManage.Image = ((System.Drawing.Image)(resources.GetObject("btnTripManage.Image")));
            this.btnTripManage.Location = new System.Drawing.Point(3, 358);
            this.btnTripManage.Name = "btnTripManage";
            this.btnTripManage.Size = new System.Drawing.Size(194, 67);
            this.btnTripManage.TabIndex = 2;
            this.btnTripManage.Text = "Quản lý\r\n chuyến\r\n";
            this.btnTripManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTripManage.UseVisualStyleBackColor = true;
            this.btnTripManage.Click += new System.EventHandler(this.btnTicketManage_Click);
            // 
            // btnCarManage
            // 
            this.btnCarManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarManage.Image = ((System.Drawing.Image)(resources.GetObject("btnCarManage.Image")));
            this.btnCarManage.Location = new System.Drawing.Point(3, 285);
            this.btnCarManage.Name = "btnCarManage";
            this.btnCarManage.Size = new System.Drawing.Size(194, 67);
            this.btnCarManage.TabIndex = 1;
            this.btnCarManage.Text = "Quản lý\r\nxe khách";
            this.btnCarManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarManage.UseVisualStyleBackColor = true;
            this.btnCarManage.Click += new System.EventHandler(this.btnCarManage_Click_1);
            // 
            // btnSystem
            // 
            this.btnSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.Image = ((System.Drawing.Image)(resources.GetObject("btnSystem.Image")));
            this.btnSystem.Location = new System.Drawing.Point(3, 212);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(194, 67);
            this.btnSystem.TabIndex = 0;
            this.btnSystem.Text = "Tài Khoản";
            this.btnSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1934, 77);
            this.panel2.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1523, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(280, 34);
            this.lblTime.TabIndex = 3;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(201, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ XE KHÁCH";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuStatistic});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1916, 36);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuMyAccount,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuSystem.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSystem.Image = global::HeThongQuanLyXeKhach.Properties.Resources.operation;
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuSystem.Size = new System.Drawing.Size(140, 32);
            this.menuSystem.Text = "Hệ thống";
            this.menuSystem.Click += new System.EventHandler(this.menuSystem_Click);
            // 
            // submenuMyAccount
            // 
            this.submenuMyAccount.Image = global::HeThongQuanLyXeKhach.Properties.Resources.user;
            this.submenuMyAccount.Name = "submenuMyAccount";
            this.submenuMyAccount.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.submenuMyAccount.Size = new System.Drawing.Size(350, 32);
            this.submenuMyAccount.Text = "Tài khoản của tôi";
            this.submenuMyAccount.Click += new System.EventHandler(this.submenuMyAccount_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::HeThongQuanLyXeKhach.Properties.Resources.logout;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(350, 32);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::HeThongQuanLyXeKhach.Properties.Resources.log_out;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(350, 32);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // menuStatistic
            // 
            this.menuStatistic.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStatistic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIncome,
            this.menuBill});
            this.menuStatistic.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStatistic.Image = global::HeThongQuanLyXeKhach.Properties.Resources.statistics;
            this.menuStatistic.Name = "menuStatistic";
            this.menuStatistic.Size = new System.Drawing.Size(140, 32);
            this.menuStatistic.Text = "Thống kê";
            // 
            // menuIncome
            // 
            this.menuIncome.Image = global::HeThongQuanLyXeKhach.Properties.Resources.financial_profit;
            this.menuIncome.Name = "menuIncome";
            this.menuIncome.Size = new System.Drawing.Size(303, 32);
            this.menuIncome.Text = "Thống kê doanh thu";
            this.menuIncome.Click += new System.EventHandler(this.menuIncome_Click);
            // 
            // menuBill
            // 
            this.menuBill.Image = global::HeThongQuanLyXeKhach.Properties.Resources.bill;
            this.menuBill.Name = "menuBill";
            this.menuBill.Size = new System.Drawing.Size(303, 32);
            this.menuBill.Text = "Hóa đơn";
            this.menuBill.Click += new System.EventHandler(this.menuBill_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1916, 1033);
            this.Controls.Add(this.pnMainFuncion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Ampersand Travel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnMainFuncion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMainFuncion;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Button btnCarManage;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnEmployeeManager;
        private System.Windows.Forms.Button btnTripManage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem submenuMyAccount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStatistic;
        private System.Windows.Forms.ToolStripMenuItem menuIncome;
        private System.Windows.Forms.ToolStripMenuItem menuBill;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}