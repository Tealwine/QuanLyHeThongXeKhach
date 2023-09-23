using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXK
{
    public partial class frm_datve : Form
    {
        public frm_datve()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdb_Khuhoi_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_1chieu.Checked == true)
            {
                lbl_ngayden.Visible = false;
                dtp_ngayden.Visible = false;
            }
            else
            {
                lbl_ngayden.Width = 0;
                lbl_ngayden.Visible = true;
                dtp_ngayden.Visible = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdb_Khuhoi.Checked = true;
            cb_sove.SelectedItem = "1";
           // linhlbl_QR.BackColor = System.Drawing.Color.Transparent;

        }

        private void btn_datve_Click(object sender, EventArgs e)
        {
          
        }
    }
}
