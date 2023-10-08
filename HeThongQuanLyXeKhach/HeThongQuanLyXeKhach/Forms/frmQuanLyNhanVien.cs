﻿ using BUS;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyXeKhach
{
   
    public partial class frmEmployeeManager : Form
    {
        private readonly EmployeeBUS employeeBUS = new EmployeeBUS();
        private readonly PositionBUS positionBUS = new PositionBUS();
        public frmEmployeeManager()
        {
            InitializeComponent();
        }

        public void FillComboboxJobTitle(List<Position> list)
        {
            this.cmbcmbEmployeeRole.DataSource = list;
            this.cmbcmbEmployeeRole.DisplayMember = "JobTitle";
            this.cmbcmbEmployeeRole.ValueMember = "PositionId";
        }

        public void BindGrid(List<Employee> list)
        {
            dgvNhanVien.Rows.Clear();
            foreach (Employee emp in list)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = emp.EmployeeId;
                dgvNhanVien.Rows[index].Cells[1].Value = emp.EmployeeName;
                dgvNhanVien.Rows[index].Cells[2].Value = emp.Position.JobTitle;
                dgvNhanVien.Rows[index].Cells[3].Value = emp.Gender;
                dgvNhanVien.Rows[index].Cells[4].Value = emp.Birth.ToShortDateString();
                dgvNhanVien.Rows[index].Cells[5].Value = emp.EmpAddress;
                dgvNhanVien.Rows[index].Cells[6].Value = emp.Phone;
                ShowAvatar(emp.Avatar);
                
            }
        }
        private void ShowAvatar(string ImageName)
        {
            if (string.IsNullOrEmpty(ImageName))
                pcbEmployeeImage.Image = null;
            else
            {
                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, "Resources", ImageName);
                pcbEmployeeImage.Image = Image.FromFile(imagePath);
                pcbEmployeeImage.Refresh();
            }
        }
        private string tenAnh;
        private string duongDan;
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp ảnh (.jpg, *.jpeg, *.png)|.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tenAnh = Path.GetFileName(openFileDialog.FileName);
                duongDan = openFileDialog.FileName;
            }
            pcbEmployeeImage.Image = Image.FromFile(duongDan);

        }


        private void frmEmployeeManager_Load(object sender, EventArgs e)
        {
            try
            {
                var listEmployee = employeeBUS.GetAll();
                var listPos = positionBUS.GetAll();
                BindGrid(listEmployee);
                BindGridSalary(listEmployee);
                FillComboboxJobTitle(listPos);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var listEmp = employeeBUS.GetAll();
                var listPos = positionBUS.GetAll();
                string gioiTinh;
                if (chkMale.Checked) gioiTinh = "Nam";
                else
                {
                    gioiTinh = "Nữ";
                }

                var chucVu = listPos.FirstOrDefault(p=>p.JobTitle == cmbcmbEmployeeRole.Text);

                string maNV = txtEmployeeId.Text.ToString();
                string tenNV = txtEmployeeName.Text.ToString();
                string diaChi = txtEmployeeLocation.Text.ToString();
                DateTime ngaySinh = dtpEmployeeBirthDay.Value;
                string sdt = txtEmployeePhoneNumber.Text.ToString();

                var emp = new Employee
                {
                    EmployeeId = maNV,
                    EmployeeName = tenNV,
                    PositionId = chucVu.PositionId,
                    Gender = gioiTinh,
                    EmpAddress = diaChi,
                    Birth = ngaySinh,//Convert.ToDateTime( ngaySinh),
                    Phone = sdt,
                    Avatar = tenAnh
                };

                employeeBUS.InsertUpdate(emp);
                BindGrid(employeeBUS.GetAll());


                MessageBox.Show("Cập nhật thành công");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || dgvNhanVien.Rows[index].Cells[0].Value == null) return;
            DataGridViewRow row = dgvNhanVien.Rows[index];
            txtEmployeeId.Text = row.Cells[0].Value.ToString();
            txtEmployeeName.Text = row.Cells[1].Value.ToString();
            cmbcmbEmployeeRole.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value.ToString() == "Nam")
            {
                chkMale.Checked = true;
                chkFemale.Checked = false;
            } else
            {
                chkFemale.Checked = true;
                chkMale.Checked = false;
            }
            dtpEmployeeBirthDay.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            txtEmployeeLocation.Text = row.Cells[5].Value.ToString();
            txtEmployeePhoneNumber.Text = row.Cells[6].Value.ToString();
           

            var listEmp = employeeBUS.GetAll();
            var duLieuAnh = listEmp.Where(emp => emp.EmployeeId.ToString() == txtEmployeeId.Text.ToString()).FirstOrDefault();
            if (duLieuAnh.Avatar == null) pcbEmployeeImage.Image = null;
            else
            {
                string imagePath = Path.Combine(@"D:\QuanLyHeThongXeKhach\HeThongQuanLyXeKhach\HeThongQuanLyXeKhach\Resources", duLieuAnh.Avatar);
                if (!string.IsNullOrEmpty(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    pcbEmployeeImage.Image = image;
                }
                else
                {
                    pcbEmployeeImage.Image = null;
                }
            }

        }

        private void ClearTextbox()
        {
            txtEmployeeId.Text = "";
            txtEmployeeName.Text = "";
            txtEmployeePhoneNumber.Text = "";
            txtEmployeeLocation.Text = "";
            cmbcmbEmployeeRole.Text = "";
            dtpEmployeeBirthDay.Value = DateTime.Now;
            chkFemale.Checked = false;
            chkMale.Checked = false;
            pcbEmployeeImage.Image = null;
        }

        private void txtEmployeeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var listEmp = employeeBUS.GetAll();
                var Employee = listEmp.FirstOrDefault(emp=>emp.EmployeeId == txtEmployeeId.Text.ToString());
                if (Employee != null) 
                { 
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        employeeBUS.DeleteEmployee(Employee);
                        frmEmployeeManager_Load(sender, e);
                        MessageBox.Show("Xóa nhân viên thành công");
                        ClearTextbox();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEmployeeRefresh_Click(object sender, EventArgs e)
        {
            frmEmployeeManager_Load(sender, e);
            ClearTextbox() ;
            MessageBox.Show("Đã làm mới");
        }

        private void BindGridSalary(List<Employee> listEmp)
        {
           
            var listPos = positionBUS.GetAll();
            dgvTinhLuong.Rows.Clear();
            foreach ( var emp in listEmp )
            {
                int index = dgvTinhLuong.Rows.Add();
                double TotalSalary = (double)(emp.Position.Salary * emp.Position.Coefficient);
                dgvTinhLuong.Rows[index].Cells[0].Value = emp.EmployeeId;
                dgvTinhLuong.Rows[index].Cells[1].Value = emp.EmployeeName;
                dgvTinhLuong.Rows[index].Cells[2].Value = emp.Position.JobTitle;
                dgvTinhLuong.Rows[index].Cells[3].Value = emp.Position.Salary;
                dgvTinhLuong.Rows[index].Cells[4].Value = emp.Position.Coefficient;
                dgvTinhLuong.Rows[index].Cells[5].Value = TotalSalary;
            }
        }

        private void dgvTinhLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || dgvTinhLuong.Rows[index].Cells[0].Value == null) return;
            DataGridViewRow row = dgvTinhLuong.Rows[index];
            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtBasicSalary.Text = row.Cells[3].Value.ToString();
            txtMulti.Text = row.Cells[4].Value.ToString();
            txtFinalSalary.Text = row.Cells[5].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var listEmp = employeeBUS.GetAll();
                var listPos = positionBUS.GetAll();

                string ma = txtId.Text.ToString();
                if(employeeBUS.FindById(ma) != null)
                {
                    Employee employee = employeeBUS.FindById(ma);
                    employee.Position.Salary = Convert.ToInt32(txtBasicSalary.Text.ToString());
                    employee.Position.Coefficient = double.Parse(txtMulti.Text.ToString());
                    employeeBUS.InsertUpdate(employee);
                    frmEmployeeManager_Load(sender, e);
                    MessageBox.Show("Cập nhật lương thành công");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ctlEmploeeManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmEmployeeManager_Load(sender, e);
        }
    }
}
