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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace HeThongQuanLyXeKhach
{
    public partial class frmDatVe : Form
    {
        private readonly TripBUS tripBUS = new TripBUS();
        private readonly CoachTypeBUS coachTypeBUS = new CoachTypeBUS();
        List<Button> buttonList = new List<Button>();

        private List<Control> items = new List<Control>();
        public frmDatVe()
        {
            InitializeComponent();
            txtTotalMoney.Enabled = false;
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
            this.cmbStartLocation1.DataSource= listTripBUSS;
            this.cmbStartLocation1.DisplayMember = "StartPlace";
            this.cmbStartLocation1.ValueMember = "TripID";
        }

        private void FillcmbEndLocation(List<Trip> listTripBUSE)
        {
            this.cmbStartLocation1.DataSource = listTripBUSE;
            this.cmbStartLocation1.DisplayMember = "ArrivePlace";
            this.cmbStartLocation1.ValueMember = "TripID";
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
            
            
            
        }

        private void btnSeatA01_Click(object sender, EventArgs e)
        {
            btnChooseASeat(sender, e);
        }


        private void btnChooseASeat(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Gray)
            {
                if (btn.BackColor == Color.LightSkyBlue)
                {
                    btn.BackColor = Color.PaleVioletRed;
                    buttonList.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.LightSkyBlue;
                    buttonList.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Ghế đã có người chọn!!!");
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTotalMoney_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCoachType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedValue = cmbCoachType.SelectedItem.ToString();


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

        private void cmbCoachType_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        private void cmbNumberTicket1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
        }
    }
}
