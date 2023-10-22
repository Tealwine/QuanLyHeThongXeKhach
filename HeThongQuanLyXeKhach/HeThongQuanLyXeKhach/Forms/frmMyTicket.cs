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
    public partial class frmMyTicket : Form
    {
        private readonly TripBUS tripBUS = new TripBUS();
        private readonly CoachTypeBUS coachTypeBUS = new CoachTypeBUS();
        private readonly TripInfBUS infBUS = new TripInfBUS();
        private readonly BillBUS billBus = new BillBUS();

        public frmMyTicket()
        {
            InitializeComponent();
        }

        private void frmMyTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vision == false)
            {
                frmStart frmStart = new frmStart();
                frmStart.Show();
            }
           
        }

        private bool FindPhone(string phone)
        {
            if(txtCusPhoneToFind.Text == phone) return true;
            else return false;

        }
        private void txtCusPhoneToFind_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFindMyTicket_Click(object sender, EventArgs e)
        {
            int count = 0;
            billBus.GetAll();
            List<Bill> list = new List<Bill>();
            foreach (Bill bill in billBus.GetAll())
            {
                if (FindPhone(bill.CustomerPhone.ToString()) == true)
                {
                    
                    
                    if (!cmbSeat.Items.Contains(bill.Seat))
                    {
                        // Nếu chưa tồn tại, thì thêm vào combobox
                        cmbSeat.Items.Add(bill.Seat);
                        count++;
                    }
                }
                
                    
            }
            if (cmbSeat.Items != null)
            {
                cmbSeat.SelectedItem = 0;
            }
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin!!!");
            }
               
            else
            {
                cmbSeat.SelectedIndex = 0;
            }
                
        }

      

        private void ShowTicket()
        {
            
            foreach (Bill bill in billBus.GetAll())
            {
                if (bill.CustomerPhone.ToString() == txtCusPhoneToFind.Text && bill.Seat == cmbSeat.Text) 
                {
                    txtMyStartLocation.Text = bill.TripInf.Trip.StartPlace;
                    txtMyDestination.Text = bill.TripInf.Trip.ArrivePlace;
                    txtMyStartDate.Text = bill.TripInf.Trip.StartTime.ToShortDateString();
                    txtMyStartTime.Text = bill.TripInf.Trip.StartTime.ToShortTimeString();
                    txtMyCoachType.Text = bill.TripInf.Coach.CoachType.TypeName;
                    txtMyName.Text = bill.CustomerName;
                    txtMyPhoneNumber.Text = bill.CustomerPhone.ToString();
                    txtMyPay.Text = bill.Total.ToString();
                    txtMyTicketPrice.Text = bill.TripInf.Price.ToString();
                }
            }
        }
        string Nhan;
        bool Nhan2;
        public string message { get { return Nhan; } set { Nhan = value; } }
        public bool vision { get { return Nhan2; } set { Nhan2 = value; } }

        private void cmbSeat_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowTicket();
        }
    
        private void frmMyTicket_Load(object sender, EventArgs e)
        {
        
          
            if (vision == true)
            {
                txtCusPhoneToFind.Text = Nhan.ToString();
                btnFindMyTicket.PerformClick();
              
            }
            
            ShowTicket();
        }

       
    }
}
