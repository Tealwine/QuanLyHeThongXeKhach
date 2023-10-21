namespace HeThongQuanLyXeKhach
{
    partial class frmThuVaChi
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
            this.rptThongKeNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbThongKe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rptThongKeNgay
            // 
            this.rptThongKeNgay.Location = new System.Drawing.Point(48, 119);
            this.rptThongKeNgay.Name = "rptThongKeNgay";
            this.rptThongKeNgay.ServerReport.BearerToken = null;
            this.rptThongKeNgay.Size = new System.Drawing.Size(1111, 682);
            this.rptThongKeNgay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê theo:";
            // 
            // cmbThongKe
            // 
            this.cmbThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThongKe.FormattingEnabled = true;
            this.cmbThongKe.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.cmbThongKe.Location = new System.Drawing.Point(261, 36);
            this.cmbThongKe.Name = "cmbThongKe";
            this.cmbThongKe.Size = new System.Drawing.Size(236, 33);
            this.cmbThongKe.TabIndex = 2;
            this.cmbThongKe.SelectedIndexChanged += new System.EventHandler(this.cmbThongKe_SelectedIndexChanged);
            // 
            // frmThuVaChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 828);
            this.Controls.Add(this.cmbThongKe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptThongKeNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmThuVaChi";
            this.Text = "Thu/Chi";
            this.Load += new System.EventHandler(this.frmThuVaChi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptThongKeNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbThongKe;
    }
}