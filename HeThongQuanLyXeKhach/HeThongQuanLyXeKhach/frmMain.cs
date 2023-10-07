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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
           panel1.Height = btnSystem.Height;
           panel1.Top = btnSystem.Top;
           
           

        }

        

        private void btnTicketManage_Click(object sender, EventArgs e)
        {
            panel1.Height = btnTicketManage.Height;
            panel1.Top = btnTicketManage.Top;
        
          
        }

        private void btnEmployeeManager_Click(object sender, EventArgs e)
        {
            panel1.Height = btnEmployeeManager.Height;
            panel1.Top = btnEmployeeManager.Top;
           
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            panel1.Height = btnCash.Height;
            panel1.Top = btnCash.Top;
        }

        private void btnCarManage_Click_1(object sender, EventArgs e)
        {
            panel1.Height = btnCarManage.Height;
            panel1.Top = btnCarManage.Top;
           
        }
    }
}

