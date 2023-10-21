using BUS;
using DAL;
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

namespace HeThongQuanLyXeKhach
{
    public partial class frmThuVaChi : Form
    {
        private readonly BillBUS billBUS = new BillBUS();
        public frmThuVaChi()
        {
            InitializeComponent();
        }

       
        private void frmThuVaChi_Load(object sender, EventArgs e)
        {
            var list = billBUS.GetAll();
            List<ThongKe> reportData = new List<ThongKe>();


            var tam = list.GroupBy(d => d.InvoiceDate).ToList();

            foreach (var item in tam)
            {
                reportData.Add(new ThongKe
                {
                    month = item.Key.ToShortDateString(),
                    income = item.Sum(t => t.Total)
                });
            }


            rptThongKeNgay.LocalReport.ReportPath = "rptThongKe.rdlc";
            var source = new ReportDataSource("DataSet1", reportData);
            rptThongKeNgay.LocalReport.DataSources.Clear();
            rptThongKeNgay.LocalReport.DataSources.Add(source);
            this.rptThongKeNgay.RefreshReport();
        }

        private void cmbThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbThongKe.Text == "Tháng")
                {
                    var list = billBUS.GetAll();


                    var reportData = list.GroupBy(bill => new { bill.InvoiceDate.Month, bill.InvoiceDate.Year })
                     .Select(group => new ThongKe
                     {
                         month = group.Key.Month.ToString() + "/" + group.Key.Year.ToString(),
                         income = group.Sum(bill => bill.Total)
                     })
                     .ToList();



                    rptThongKeNgay.LocalReport.ReportPath = "rptThongKe.rdlc";
                    var source = new ReportDataSource("DataSet1", reportData);
                    rptThongKeNgay.LocalReport.DataSources.Clear();
                    rptThongKeNgay.LocalReport.DataSources.Add(source);
                    this.rptThongKeNgay.RefreshReport();
                }
                else if(cmbThongKe.Text == "Năm")
                {
                    var list = billBUS.GetAll();
                    
                    var reportData = list.GroupBy(bill => bill.InvoiceDate.Year)
                     .Select(group => new ThongKe
                     {
                         month = group.Key.ToString(),
                         income = group.Sum(bill => bill.Total)
                     })
                     .ToList();



                    rptThongKeNgay.LocalReport.ReportPath = "rptThongKe.rdlc";
                    var source = new ReportDataSource("DataSet1", reportData);
                    rptThongKeNgay.LocalReport.DataSources.Clear();
                    rptThongKeNgay.LocalReport.DataSources.Add(source);
                    this.rptThongKeNgay.RefreshReport();
                }
                else if( cmbThongKe.Text == "Ngày")
                {
                    frmThuVaChi_Load(sender, e);
                }

            }
            catch 
            {
            }
        }
    }
}
