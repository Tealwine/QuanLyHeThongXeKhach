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
            var logAcc = logInAccountBUS.GetAll();
            bool test = false;
            foreach (var log in logAcc)
            {
                if(log.UserId == txtUserId.Text && log.Pass == txtPass.Text)
                {
                    test = true;
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    frmMain main = new frmMain();
                    main.Show();
                }
            }
            if (test == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "LỖI");
                txtUserId.Focus();
            }


        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    }
}
