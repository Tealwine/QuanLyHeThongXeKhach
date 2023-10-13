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


        public frmDatVe()
        {
            InitializeComponent();
            txtTotalMoney.Enabled = false;
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
    }
}
