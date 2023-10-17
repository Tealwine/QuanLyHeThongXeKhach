using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HeThongQuanLyXeKhach
{
    public partial class frmLogin : Form
    {
        private readonly LogInAccountBUS logInAccountBUS = new LogInAccountBUS();
        public frmLogin()
        {
            InitializeComponent();
        }
        
        
        private void btnSignIn_Click(object sender, EventArgs e)
        {

           
      
            try
            {
              

                var logAcc = logInAccountBUS.GetAll();
                

                bool test = false;
                foreach (var log in logAcc)
                {
                    if (log.UserId == txtUserId.Text && log.Pass == txtPass.Text)
                    {
                        test = true;
                        MessageBox.Show("Đăng nhập thành công");
                        
                        this.Hide();
                        if (log.UserId == "admin")
                        {
                            
                            frmMain main = new frmMain();
                            main.IDAcc2 = txtUserId.Text;
                            main.Show();

                        }
                        else if (log.UserId == "nhanvien")
                        {
                            frmMain frmMain = new frmMain();
                            frmMain.IDAcc2 = txtUserId.Text;
                            frmMain.HideButton();
                            frmMain.Show();
                        }
                    }
                }
                if (test == false && txtUserId.Text.ToString() != "" && txtPass.Text.ToString() != "")
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "LỖI");
                    txtUserId.Focus();
                }
            }
            catch 
            {

               
            }

        }

        

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';

        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                lblMessage.Visible = true;
                
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text) && string.IsNullOrWhiteSpace(txtPass.Text))
            {
                lblMessage.Visible = true;

            }
        }

        private void txtUserId_Enter(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            lblMessage.Visible=false;
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart frmStart = new frmStart();
            frmStart.Show();
           
        }

      
        private void btnHide_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.PasswordChar == '*')
                {
                    txtPass.PasswordChar = '\0';
                }
                else
                {
                    txtPass.PasswordChar = '*';
                }
            }
            catch
            {


            }
        }
    }
}
