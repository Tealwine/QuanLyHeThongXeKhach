using BUS;
using DAL.Models;
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

    public partial class frmSystem : Form
    {
        private readonly LogInAccountBUS logInAccountBUS = new LogInAccountBUS();
        public bool IntegralHeight { get; set; }
        public frmSystem()
        {
            InitializeComponent();
        }

        private void BindData(LogInAccount item)
        {
            txtId.Text = item.UserId.ToString();
            txtName.Text = item.Employee.EmployeeName.ToString();
            txtPhoneNumber.Text = item.Employee.Phone.ToString();
            txtRole.Text = item.Employee.Position.JobTitle.ToString();
            txtLocation.Text = item.Employee.EmpAddress.ToString();
            txtPassword.Text = item.Pass.ToString();
            txtBirthDate.Text = item.Employee.Birth.ToShortDateString();
            if (item.Employee.Gender == "Nam")
            {
                chkMale.Checked = true;
                chkFemale.Checked = false;
            }
            else
            {
                chkFemale.Checked = true;
                chkMale.Checked = false;
            }
            lblName.Text = item.Employee.EmployeeName.ToString();
            lblPosition.Text = item.Employee.Position.JobTitle.ToString();
        }
       
        string Nhan3;
        public string IDAcc { get { return Nhan3; } set { Nhan3 = value; } }
        private void frm_Load(object sender, EventArgs e)
        {
    
          var listacc = logInAccountBUS.GetAll();
            foreach (var item in listacc)
                
            { 
                if(item.UserId == IDAcc)
                {
                    BindData(item);
                }
            }
          
        }
       
 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
