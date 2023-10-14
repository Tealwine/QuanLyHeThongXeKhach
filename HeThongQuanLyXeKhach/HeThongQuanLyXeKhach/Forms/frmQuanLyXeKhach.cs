using BUS;
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
    public partial class frmQuanLyXeKhach : Form
    {
        private readonly CoachBUS coachBUS = new CoachBUS();
        private readonly CoachTypeBUS coachTypeBUS = new CoachTypeBUS();
        public frmQuanLyXeKhach()
        {
            InitializeComponent();
        }

        private void FillComboboxCoachType(List<CoachType> listCoachType)
        {
            this.cmbCoachType.DataSource = listCoachType;
            this.cmbCoachType.DisplayMember = "TypeName";
            this.cmbCoachType.ValueMember = "TypeId";
        }

        private void BindGrid(List<Coach> coaches)
        {
            dgvCoachList.Rows.Clear();
            foreach (var item in coaches)
            {
                int index = dgvCoachList.Rows.Add();
                dgvCoachList.Rows[index].Cells[0].Value = item.CoachId;
                dgvCoachList.Rows[index].Cells[1].Value = item.CoachPlate;
                dgvCoachList.Rows[index].Cells[2].Value = item.CoachBrand;
                dgvCoachList.Rows[index].Cells[3].Value = "";
                dgvCoachList.Rows[index].Cells[4].Value = item.Warranty;
                dgvCoachList.Rows[index].Cells[5].Value = item.CoachType.TypeName;
                ShowAvatar(tenAnh);
                //txtTotalCoach.Text = dgvCoachList.Rows.Count.ToString();
                int rowCount = dgvCoachList.Rows.Cast<DataGridViewRow>().Where(row => !row.IsNewRow).Count();
                txtTotalCoach.Text = rowCount.ToString();

            }
        }

        private void frmQuanLyXeKhach_Load(object sender, EventArgs e)
        {
            try
            {
                var coachList = coachBUS.GetAll();
                var coachTypeList = coachTypeBUS.GetAll();
                FillComboboxCoachType(coachTypeList);
                BindGrid(coachList);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ShowAvatar(string ImageName)
        {
            if (string.IsNullOrEmpty(ImageName))
                picCoach.Image = null;
            else
            {
                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, "Resources", ImageName);
                picCoach.Image = Image.FromFile(imagePath);
                picCoach.Refresh();
            }
        }
        private string tenAnh;
        private string duongDan;

        private void picCoach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp ảnh (.jpg, *.jpeg, *.png)|.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tenAnh = Path.GetFileName(openFileDialog.FileName);
                duongDan = openFileDialog.FileName;
            }
            picCoach.Image = Image.FromFile(duongDan);
        }

        private void dgvCoachList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || dgvCoachList.Rows[index].Cells[0].Value == null) return;
            DataGridViewRow row = dgvCoachList.Rows[index];
            txtID.Text = row.Cells[0].Value.ToString();
            txtLicensePlate.Text = row.Cells[1].Value.ToString();
            txtVehicleName.Text = row.Cells[2].Value.ToString();
            txtSeatNumber.Text = row.Cells[3].Value.ToString();
            txtWarranty.Text = row.Cells[4].Value.ToString();
            txtCoachType.Text = row.Cells[5].Value.ToString();

            var listCoach = coachBUS.GetAll();
            var duLieuAnh = listCoach.Where(emp => emp.CoachId.ToString() == txtID.Text.ToString()).FirstOrDefault();
            if (duLieuAnh.CoachImg == null) picCoach.Image = null;
            else
            {
                string imagePath = Path.Combine(@"D:\QuanLyHeThongXeKhach\HeThongQuanLyXeKhach\HeThongQuanLyXeKhach\Resources", duLieuAnh.CoachImg);
                if (!string.IsNullOrEmpty(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    picCoach.Image = image;
                }
                else
                {
                    picCoach.Image = null;
                }
            }

        }


        private void ClearControl()
        {
            txtID.Text = "";
            txtLicensePlate.Text = "";
            txtCoachType.Text = "";
            txtSeatNumber.Text = "";
            txtVehicleName.Text = "";
            txtWarranty.Text = "";
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClearControl();
            frmQuanLyXeKhach_Load(sender, e);
            MessageBox.Show("Đã làm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var listCoach = coachBUS.GetAll();
                var listCoachType = coachTypeBUS.GetAll();
               
                var type = listCoachType.FirstOrDefault(t=>t.TypeName == txtCoachType.Text.ToString());

                string maXe = txtID.Text.ToString();
                string hang = txtVehicleName.Text.ToString();
                int loai = Convert.ToInt32( txtCoachType.Text.ToString());
                int soGhe = Convert.ToInt32(txtSeatNumber.Text.ToString());
                string bienSo = txtLicensePlate.Text.ToString();
                int baoHanh = Convert.ToInt32( txtWarranty.Text.ToString());

                var coach = new Coach
                {
                    CoachId = maXe,
                    TypeId = type.TypeId,
                    CoachBrand = hang,
                    CoachPlate = bienSo,
                    //SeatNumber = soGhe,
                    CoachImg = tenAnh
                };

                coachBUS.InsertUpdate(coach);
                BindGrid(coachBUS.GetAll());
                MessageBox.Show("Cập nhật thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var listCoach = coachBUS.GetAll();
                var coach = listCoach.FirstOrDefault(c => c.CoachId == txtID.Text.ToString());
                if (coach != null)
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        coachBUS.DeleteCoach(coach);
                        frmQuanLyXeKhach_Load(sender, e);
                        MessageBox.Show("Xóa xe thành công");
                        ClearControl();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
