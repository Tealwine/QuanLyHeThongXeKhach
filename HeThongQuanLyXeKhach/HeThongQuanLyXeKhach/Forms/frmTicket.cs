using BUS;
using DAL;
using DAL.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyXeKhach.Forms
{
    public partial class frmTicket : Form
    {
        private readonly BillBUS billBUS = new BillBUS();
        private readonly CoachBUS coachBUS = new CoachBUS();
        private readonly TripInfBUS tripInfBUS = new TripInfBUS();


        public frmTicket()
        {
            InitializeComponent();
        }

        private List<Ticket> swapList(List<Bill> list)
        {
            var listBill = billBUS.GetAll();
            List<Ticket> reportData = new List<Ticket>();
            foreach (var item in listBill)
            {
                Ticket temp = new Ticket();
                temp.MaVe = item.BillId;
                temp.TenKH = item.CustomerName;
                temp.SDT = item.CustomerPhone;
                temp.Tuyen = string.Concat(item.TripInf.Trip.StartPlace, "-", item.TripInf.Trip.ArrivePlace);
                temp.GiaVe = item.TripInf.Price;
                temp.SoXe = item.TripInf.Coach.CoachPlate;
                temp.Ghe = item.Seat;
                temp.GioKH = item.TripInf.Trip.StartTime.ToShortTimeString();
                temp.NgayKH = item.TripInf.Trip.StartTime.ToShortDateString();
                reportData.Add(temp);
            }
            return reportData;
        }

        private void BindGrid(List<Bill> listBill)
        {
            
            List<Ticket> reportData = swapList(listBill);
            
            dgvTicket.Rows.Clear();
            foreach (var item in reportData)
            {
               
                int index = dgvTicket.Rows.Add();
                dgvTicket.Rows[index].Cells[0].Value = item.MaVe;
                dgvTicket.Rows[index].Cells[1].Value = item.TenKH;
                dgvTicket.Rows[index].Cells[2].Value = item.SDT;
                dgvTicket.Rows[index].Cells[3].Value = item.Tuyen;
                dgvTicket.Rows[index].Cells[4].Value = item.GiaVe;
                dgvTicket.Rows[index].Cells[5].Value = item.SoXe;
                dgvTicket.Rows[index].Cells[6].Value = item.Ghe;
                dgvTicket.Rows[index].Cells[7].Value = item.GioKH;
                dgvTicket.Rows[index].Cells[8].Value = item.NgayKH;

            }

        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            var bill = billBUS.GetAll();
            BindGrid(bill);

        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index == -1 || dgvTicket.Rows[index].Cells[0].Value == null) return;

                var ticket = billBUS.GetAll().FirstOrDefault(t => t.BillId == Convert.ToInt32(dgvTicket.Rows[index].Cells[0].Value));
                var xe = coachBUS.GetAll().FirstOrDefault(x => x.CoachId == ticket.CoachId);

                ReportParameter[] para = new ReportParameter[]
                {
                
                new ReportParameter("pMaVe",dgvTicket.Rows[index].Cells[0].Value.ToString()),
                new ReportParameter("pTenKH",dgvTicket.Rows[index].Cells[1].Value.ToString()),
                new ReportParameter("pSDT",dgvTicket.Rows[index].Cells[2].Value.ToString()),
                new ReportParameter("pXe",dgvTicket.Rows[index].Cells[5].Value.ToString()),
                new ReportParameter("pGhe",dgvTicket.Rows[index].Cells[6].Value.ToString()),
                new ReportParameter("pNgay",dgvTicket.Rows[index].Cells[8].Value.ToString()),
                new ReportParameter("pGio",dgvTicket.Rows[index].Cells[7].Value.ToString()),
                new ReportParameter("pTuyen",dgvTicket.Rows[index].Cells[3].Value.ToString()),
                new ReportParameter("pGia",dgvTicket.Rows[index].Cells[4].Value.ToString()),

                };
                rptVeXe.LocalReport.ReportPath = "rptTicket.rdlc";
                rptVeXe.LocalReport.SetParameters(para);


                rptVeXe.RefreshReport();
            }
            catch 
            {

            }

        }


    }
}
