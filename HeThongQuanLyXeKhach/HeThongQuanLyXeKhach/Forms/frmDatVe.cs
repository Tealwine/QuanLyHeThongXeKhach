using BUS;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;



namespace HeThongQuanLyXeKhach
{
    public partial class frmDatVe : Form
    {
        private readonly TripBUS tripBUS = new TripBUS();
        private readonly CoachTypeBUS coachTypeBUS = new CoachTypeBUS();
        private readonly TripInfBUS infBUS = new TripInfBUS();
        private readonly TicketInfBUS ticketInfBUS = new TicketInfBUS();
        private readonly CusBUS cusBUS = new CusBUS();
        List<Button> buttonList = new List<Button>();

        private List<Control> items = new List<Control>();
        public frmDatVe()
        {
            InitializeComponent();
            txtTotalMoney.Enabled = false;
            dtpBackDate.Enabled = false;
            foreach (Control control in pnPickSeat.Controls)
            {
                items.Add(control);
                originalLocations.Add(control, control.Location);

            }
        }



        private void FillComboboxCoachType(List<CoachType> listCoachType)
        {
            this.cmbCoachType.DataSource = listCoachType;
            this.cmbCoachType.DisplayMember = "TypeName";
            this.cmbCoachType.ValueMember = "TypeId";
        }

        private void FillcmbStartLocation(List<Trip> listTripBUSS)
        {
            List<Trip> list = new List<Trip>();
            foreach (Trip item in listTripBUSS)
            {
                if (!cmbStartLocation.Items.Contains(item.StartPlace))
                {
                    // Nếu chưa tồn tại, thì thêm vào combobox
                    cmbStartLocation.Items.Add(item.StartPlace);
                }
            }
        }

        private void FillcmbEndLocation(List<Trip> listTripBUSE)
        {
            List<Trip> list = new List<Trip>();
            foreach (Trip item in listTripBUSE)
            {
                if (!cmbEndLocation.Items.Contains(item.ArrivePlace))
                {
                    // Nếu chưa tồn tại, thì thêm vào combobox
                    cmbEndLocation.Items.Add(item.ArrivePlace);
                }
            }
        }



        private void btnFind1_Click(object sender, EventArgs e)
        {

        }



        private void frmDatVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStart frmStart = new frmStart();
            frmStart.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            var coachTypeList = coachTypeBUS.GetAll();
            var TripList = tripBUS.GetAll();

            pnPickSeat.Hide();
            FillComboboxCoachType(coachTypeList);
            FillcmbStartLocation(TripList);
            FillcmbEndLocation(TripList);

        }

        private void btnSeatA01_Click(object sender, EventArgs e)
        {
            btnChooseASeat(sender, e);
        }

        int count = 0;
        private void btnChooseASeat(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Gray)
            {
                if (btn.BackColor == Color.LightSkyBlue)
                {
                    btn.BackColor = Color.PaleVioletRed;
                    buttonList.Add(btn);
                    count++;
                } 
                else
                {
                    btn.BackColor = Color.LightSkyBlue;
                    buttonList.Remove(btn);
                    count--;
                }
            }
            else
            {
                MessageBox.Show("Ghế đã có người chọn!!!");
            }
            txtNumber.Text = count.ToString();
            int total = int.Parse(txtNumber.Text)*int.Parse(txtPrice.Text);
            txtTotalMoney.Text = total.ToString(); 
        }

        private void cmbCoachType_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }





        public Dictionary<Control, Point> originalLocations = new Dictionary<Control, Point>();

        private void ResetLocations()
        {
            foreach (Control control in pnPickSeat.Controls)
            {
                // Lấy vị trí ban đầu từ Dictionary
                Point originalLocation;
                if (originalLocations.TryGetValue(control, out originalLocation))
                {
                    // Gán lại vị trí cho item
                    control.Location = originalLocation;
                }
            }
        }
        private void ShowAllItems()
        {
            foreach (Control control in items)
            {
                // Thiết lập trạng thái hiển thị cho item
                control.Visible = true;

            }
        }


        private void checktype()
        {
            ResetLocations();

            if (cmbCoachType.Text == "Ghế")
            {

                panel5.Location = new Point(150, 44);
                panel4.Hide();
                label1.Hide();

                pnPickSeat.Show();
                btnSeatA16.Show();
                btnSeatA17.Show();
                btnSeatA18.Show();
                btnSeatA19.Show();
                btnSeatA20.Show();
                btnSeatA21.Show();
                btnSeatA22.Show();
            }
            if (cmbCoachType.Text == "Giường Nằm")
            {

                pnPickSeat.Show();
                panel4.Show();
                btnSeatA16.Show();
                btnSeatA17.Show();
                btnSeatA18.Show();
                btnSeatA19.Show();
                btnSeatA20.Show();
                btnSeatA21.Show();
                btnSeatA22.Show();
            }
            if (cmbCoachType.Text == "Limousine")
            {

                panel5.Location = new Point(150, 44);
                pnPickSeat.Show();
                btnSeatA16.Hide();
                btnSeatA17.Hide();
                btnSeatA18.Hide();
                btnSeatA19.Hide();
                btnSeatA20.Hide();
                btnSeatA21.Hide();
                btnSeatA22.Hide();
                panel4.Hide();
                label1.Hide();
            }

        }
        private void btnConfirmInfor_Click(object sender, EventArgs e)
        {
            checktype();
            checkSeat(sender, e);
        }


        private void cbkRoundCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkRoundCheck.Checked)
            {

                dtpBackDate.Enabled = true;
            }
            else
            {
                dtpBackDate.Enabled = false;
            }

        }



        private void cmbCoachType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cmbCoachType.Text == "Ghế")
            {
                txtPrice.Text = "400";
            }
            else if (cmbCoachType.Text == "Giường Nằm")
            {
                txtPrice.Text = "550";
            }
            else if (cmbCoachType.Text == "Limousine")
            {
                txtPrice.Text = "700";
            }
        }

        private void txtTotalMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStartLocation_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvFindTrip.Rows.Clear();
            var tripInfLst = infBUS.GetAll();
            // List<TripInf> list = new List<TripInf>();
            foreach (var trip in tripInfLst)
            {
                if (cmbStartLocation.Text == trip.Trip.StartPlace && cmbEndLocation.Text == trip.Trip.ArrivePlace && cmbCoachType.Text == trip.CoachType.TypeName /*&& dtpStartDate. == trip.Trip.StartTime.ToShortDateString()*/)
                {

                    int index = dgvFindTrip.Rows.Add();
                    dgvFindTrip.Rows[index].Cells[1].Value = trip.TripID;
                    dgvFindTrip.Rows[index].Cells[2].Value = trip.Trip.StartTime.ToShortTimeString();
                    dgvFindTrip.Rows[index].Cells[3].Value = trip.Trip.ArriveTime.ToShortTimeString();
                    dgvFindTrip.Rows[index].Cells[4].Value = "";
                }
            }
            if (cmbStartLocation.Text == cmbEndLocation.Text)
                MessageBox.Show("Trung dia diem ! Khong the tim thay chuyen!");
        }
        private void countSeat()
        {
            int count = 0;
            foreach (Control control in panel5.Controls)
            {
                if (control is Button)
                {

                    if (control.BackColor == Color.PaleVioletRed)
                    {

                        count++;
                    }
                }
            }
            foreach (Control control in panel4.Controls)
            {
                if (control is Button)
                {

                    if (control.BackColor == Color.PaleVioletRed)
                    {

                        count++;
                    }
                }
            }
        }

        string temp;
        private void checkSeat(object sender, EventArgs e)
        {
            var ticketlist = ticketInfBUS.GetAll();
            
     
            foreach (DataGridViewRow check in (dgvFindTrip).Rows)
            {
                
                {
                    if ((bool)check.Cells[0].FormattedValue)
                    {
                        foreach (var item in ticketlist)
                        {
                            if (item.TripID == check.Cells[1].Value.ToString())
                            {
                                temp = item.TripID;
                                foreach (Control control in panel4.Controls)
                                {
                                    if (control is Button)
                                    {

                                        if (control.Text == item.Seat)
                                        {

                                            control.BackColor = Color.Gray;
                                        }
                                    }
                                }

                                foreach (Control control in panel5.Controls)
                                {
                                    if(control is Button)
                                    {
                                      
                                        if (control.Text == item.Seat)
                                        {
                                       
                                            control.BackColor = Color.Gray;
                                        }
                                    }
                                }
                                
                            }
                        }
                    }
                }
            }
        }

        private bool CheckData()
        {
            if (txtCusPhoneNumber.Text.ToString() == "" || txtPrice.Text + "" == "" || txtCusName.Text.ToString() == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            else if (ckbRule.Checked == false)
            {               
                MessageBox.Show("Dong y chap nhan dieu khoan");
                return false;
            }
            else { return true; }
            


        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if( CheckData() == true )
            {
               
                var cusinf = new Customer
                {
                    CustomerId = int.Parse(txtCusPhoneNumber.Text),
                    CustomerName = txtCusName.Text,
                };
                
                //foreach (Control control in panel5.Controls)
                //{
                //    if (control is Button)
                //    {

                //        if (control.BackColor == Color.PaleVioletRed)
                //        {

                //            var ticket = new TicketInf
                //            {
                //                Seat = control.Text,
                //            };
                //            ticketInfBUS.InsertUpdate(ticket);
                //        }
                //    }
                //}
                //foreach (Control control in panel4.Controls)
                //{
                //    if (control is Button)
                //    {

                //        if (control.BackColor == Color.PaleVioletRed)
                //        {

                //            var ticket = new TicketInf
                //            {

                //                BillId = 2023003,
                //                TripID = temp,
                //                CustomerId = int.Parse(txtCusPhoneNumber.Text),
                //                Seat = control.Text
                //            };
                //            ticketInfBUS.InsertUpdate(ticket);
                //        }
                //    }
                //}

                cusBUS.InsertUpdate(cusinf);
                MessageBox.Show("Dat ve thanh cong!!!");
            }

        }

        private void ckbRule_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
