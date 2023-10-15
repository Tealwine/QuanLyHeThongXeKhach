using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TripBUS
    {
        XeKhachModel context = new XeKhachModel();
        public List<Trip> GetAll()
        {
            return context.Trips.ToList();
        }
        public void InsertUpdate(Trip trip)
        {
            context.Trips.AddOrUpdate(trip);
            context.SaveChanges();
        }
        public void DeleteTrip(Trip trip)
        {
            context.Trips.Remove(trip);
            context.SaveChanges();
        }
    }
}
