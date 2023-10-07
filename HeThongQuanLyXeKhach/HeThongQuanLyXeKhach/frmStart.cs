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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnTakeTicket_Click(object sender, EventArgs e)
        {
           frmDatVe frmDatVe = new frmDatVe();
            frmDatVe.ShowDialog();
        }

        private void btnFindMyTicket_Click(object sender, EventArgs e)
        {
            frmMyTicket frmMyTicket = new frmMyTicket();    
            frmMyTicket.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(); 
            frmLogin.ShowDialog();
        }
    }
}
