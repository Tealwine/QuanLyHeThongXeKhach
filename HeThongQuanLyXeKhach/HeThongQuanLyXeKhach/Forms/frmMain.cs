﻿using HeThongQuanLyXeKhach.Forms;
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

            frmSystem frmSystem = new frmSystem();
            if (ExistForm(frmSystem))
                return;
            ViewForm(frmSystem);

        }

        

        private void btnTicketManage_Click(object sender, EventArgs e)
        {
            panel1.Height = btnTripManage.Height;
            panel1.Top = btnTripManage.Top;
            frmQuanLyChuyen frmQuanLyChuyen = new frmQuanLyChuyen();
            if (ExistForm(frmQuanLyChuyen))
                return;
            ViewForm(frmQuanLyChuyen);

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
            frmThuVaChi frmThuVaChi = new frmThuVaChi();
            if (ExistForm(frmThuVaChi))
                return;
            ViewForm(frmThuVaChi);
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
            form.Location = new Point(159, 59);
            form.Size = new Size(1370, 699);
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

        private void submenuMyAccount_Click(object sender, EventArgs e)
        {
            frmSystem frmSystem = new frmSystem();
            if (ExistForm(frmSystem))
                return;
            ViewForm(frmSystem);
        }

        public void HideButton()
        {
            btnEmployeeManager.Hide();
        }
        
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(check == true)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    frmStart frmStart = new frmStart();
                    frmStart.Show();
                }
                
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
          
            

        }
        string Nhan4;
        public string IDAcc2 { get { return Nhan4; } set { Nhan4 = value; } }
        
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.White;
                    // 4#
                    break;
                }
            }
            frmSystem frmSystem = new frmSystem();
            frmSystem.IDAcc = IDAcc2;
            if (ExistForm(frmSystem))
                return;
            ViewForm(frmSystem);
        }

       

        private void menuIncome_Click(object sender, EventArgs e)
        {
            frmThuVaChi frmThuVaChi = new frmThuVaChi();
            if (ExistForm(frmThuVaChi))
                return;
            ViewForm(frmThuVaChi);
        }

        private void menuBill_Click(object sender, EventArgs e)
        {
            frmTicket frmTicket = new frmTicket();
            if (ExistForm(frmTicket))
                return;
            ViewForm(frmTicket);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool check=false;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check = true;
            this.Close();
        }

        DateTime now;

        // Xử lý sự kiện Tick của Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Lấy ngày giờ hiện tại từ hệ thống
            now = DateTime.Now;

            // Hiển thị ngày giờ hiện tại trên Label1 theo định dạng dd/MM/yyyy HH:mm:ss
            lblTime.Text = now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void menuSystem_Click(object sender, EventArgs e)
        {

        }
    }
}

