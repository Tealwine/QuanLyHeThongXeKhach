using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TicketInfBUS
    {
        XeKhachModel context = new XeKhachModel();
        public List<TicketInf> GetAll()
        {
            return context.TicketInfs.ToList();
        }
        public void InsertUpdate(TicketInf ticketInf)
        {
            context.TicketInfs.AddOrUpdate(ticketInf);
            context.SaveChanges();
        }
    }
}
