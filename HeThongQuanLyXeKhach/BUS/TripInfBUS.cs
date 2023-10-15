using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TripInfBUS
    {
        XeKhachModel context = new XeKhachModel();
        public List<TripInf> GetAll()
        {
            return context.TripInfs.ToList();
        }

        public void InsertUpdate(TripInf tripInf)
        {
            context.TripInfs.AddOrUpdate(tripInf);
            context.SaveChanges();
        }
        public void DeleteInfTrip(TripInf tripInf)
        {
            context.TripInfs.Remove(tripInf);
            context.SaveChanges();
        }
    }
}
