using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyXeKhach
{
    public partial class frmDatVe : Form
    {
        public frmDatVe()
        {
            InitializeComponent();
        }

        private void btnFind1_Click(object sender, EventArgs e)
        {
            frmInfoChuyen frmInfoChuyen = new frmInfoChuyen();
            frmInfoChuyen.ShowDialog();
        }

     

        private void frmDatVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart frmStart = new frmStart();
            frmStart.Show();
        }
    }
}
