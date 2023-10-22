using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillBUS
    {
        XeKhachModel context = new XeKhachModel();
        public List<Bill> GetAll()
        {
            return context.Bills.ToList();
        }
        public void InsertUpdate(Bill bill)
        {
            context.Bills.AddOrUpdate(bill);
            context.SaveChanges();
        }
        public Bill FindById(string CustomerPhone)
        {
            return context.Bills.FirstOrDefault(emp => emp.CustomerPhone == CustomerPhone);
        }

        public Bill GetTicketDetail(int maVe)
        {

            return context.Bills.FirstOrDefault(t => t.BillId == maVe);
             
        }

    }
}
