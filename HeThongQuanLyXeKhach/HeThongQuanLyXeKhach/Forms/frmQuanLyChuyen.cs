﻿using BUS;
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
    public partial class frmQuanLyChuyen : Form
    {
        private readonly TripBUS tripBUS = new TripBUS();
        private readonly TripInfBUS infBUS = new TripInfBUS();
        private readonly CoachTypeBUS coachTypeBUS = new CoachTypeBUS();
        public frmQuanLyChuyen()
        {
            InitializeComponent();
        }

        private void FillComboboxType(List<CoachType>coachTypes)
        {
            this.cmbLoaiXe.DataSource = coachTypes;
            this.cmbLoaiXe.DisplayMember = "TypeName";
            this.cmbLoaiXe.ValueMember = "TypeId";
        }

        private void BindGrid(List<TripInf> tripInfs)
        {
            dgvTrip.Rows.Clear();
            foreach (var item in tripInfs)
            {
                int index = dgvTrip.Rows.Add();
                dgvTrip.Rows[index].Cells[0].Value = item.TripID;
                dgvTrip.Rows[index].Cells[1].Value = item.CoachType.TypeName;
                string connect = item.Trip.StartPlace.ToString() + "-" + item.Trip.ArrivePlace.ToString();
                dgvTrip.Rows[index].Cells[2].Value = connect;
                dgvTrip.Rows[index].Cells[3].Value = item.Trip.StartTime.ToShortTimeString();
                dgvTrip.Rows[index].Cells[4].Value = item.Trip.ArriveTime.ToShortTimeString();
                dgvTrip.Rows[index].Cells[5].Value = item.Trip.StartTime.ToShortDateString();
                dgvTrip.Rows[index].Cells[6].Value = item.Trip.ArriveTime.ToShortDateString();
                dgvTrip.Rows[index].Cells[7].Value = item.Price;

            }
        }

        private void frmQuanLyChuyen_Load(object sender, EventArgs e)
        {
            try
            {
                var tripLst = tripBUS.GetAll();
                var tripInfLst = infBUS.GetAll();
                var typeLst = coachTypeBUS.GetAll();
                FillComboboxType(typeLst);
                BindGrid(tripInfLst);
            }
            catch 
            {
            }
        }

        private void dgvTrip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || dgvTrip.Rows[index].Cells[0].Value == null) return;
            txtTripId.Text = dgvTrip.Rows[index].Cells[0].Value.ToString();
            cmbLoaiXe.Text = dgvTrip.Rows[index].Cells[1].Value.ToString();
            string di = dgvTrip.Rows[index].Cells[3].Value.ToString() +" "+ dgvTrip.Rows[index].Cells[5].Value.ToString();
            string den = dgvTrip.Rows[index].Cells[4].Value.ToString() + " " + dgvTrip.Rows[index].Cells[6].Value.ToString();
            dtStart.Value = DateTime.Parse(di);
            dtArrive.Value = DateTime.Parse(den);
            txtPrice.Text = dgvTrip.Rows[index].Cells[7].Value.ToString();
        }

        private void ClearControl()
        {
            txtTripId.Text = "";
            txtPrice.Text = "";
            dtStart.Value = DateTime.Now;
            dtArrive.Value = DateTime.Now;
            txtArrive.Text = "";
            txtStart.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private bool CheckData()
        {
            if (txtTripId.Text.ToString() == "" || txtPrice.Text+"" == "" || txtStart.Text.ToString() == "" || txtArrive.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            else if(dtStart.Value == dtArrive.Value)
            {
                MessageBox.Show("Thời gian đến và thời gian đi phải khác nhau");
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckData())
                {
                    var tripLst = tripBUS.GetAll();
                    var infLst = infBUS.GetAll();
                    var loaiLst = coachTypeBUS.GetAll();
                    var loai = loaiLst.FirstOrDefault(l=>l.TypeName == cmbLoaiXe.Text);

                    string ma = txtTripId.Text;
                    DateTime startTime = dtStart.Value;
                    DateTime arriveTime = dtArrive.Value;
                    string startPoint = txtStart.Text.ToString();
                    string arrivePoint = txtArrive.Text.ToString();
                    int price = Convert.ToInt32(txtPrice.Text);

                    var trip = new Trip
                    {
                        TripID = ma,
                        StartTime = startTime,
                        ArriveTime = arriveTime,
                        StartPlace = startPoint,
                        ArrivePlace = arrivePoint
                    };
                    tripBUS.InsertUpdate(trip);
                    var tripInf = new TripInf
                    {
                        TripID = ma,
                        TypeId = loai.TypeId,
                        Price = price
                    };
                    infBUS.InsertUpdate(tripInf);
                    BindGrid(infBUS.GetAll());
                    MessageBox.Show("Cập nhật thành công");
                    
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var lstTrip = tripBUS.GetAll();
                var lstInf = infBUS.GetAll();

                var trip = lstTrip.FirstOrDefault(t => t.TripID == txtTripId.Text);
                var tripInf = lstInf.FirstOrDefault(t=>t.TripID == txtTripId.Text);
                if(trip != null)
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        infBUS.DeleteInfTrip(tripInf);
                        tripBUS.DeleteTrip(trip);
                        frmQuanLyChuyen_Load(sender, e);
                        MessageBox.Show("Xóa chuyến thành công");
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
