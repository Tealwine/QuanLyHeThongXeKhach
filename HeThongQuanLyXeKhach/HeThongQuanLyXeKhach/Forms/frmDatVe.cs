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
                if (!cmbEndLocation.Items.Contains(item.ArrivePlace) )
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

        private void cmbCoachType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedValue = cmbCoachType.SelectedItem.ToString();



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

    
        private void cbkRoundCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(cbkRoundCheck.Checked)
            {
            
                dtpBackDate.Enabled = true;
            }
            else
            { 
                dtpBackDate.Enabled=false;
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
            List<TripInf> list = new List<TripInf>();
            foreach (TripInf trip in list)
            {
                if (cmbStartLocation.Text == trip.Trip.StartPlace && cmbEndLocation.Text == trip.Trip.ArrivePlace && cmbCoachType.Text == trip.CoachType.TypeName)
                {

                }
            }
        }
    }
}
