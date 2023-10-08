﻿using System;
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

            frmEmployeeManager frmEmployeeManager = new frmEmployeeManager();
            if (ExistForm(frmEmployeeManager))
                return;
            ViewForm(frmEmployeeManager);

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
            frmQuanLyXeKhach frmQuanLyXeKhach = new frmQuanLyXeKhach();
            if (ExistForm(frmQuanLyXeKhach))
                return;
            ViewForm(frmQuanLyXeKhach);

        }


        private void ViewForm(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(159, 71);
            form.Size = new Size(1350, 715);
            form.Show();
        }


        private bool ExistForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
    }
}

