using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CoachBUS
    {
        XeKhachModel context = new XeKhachModel();
        public List<Coach> GetAll()
        {
            return context.Coaches.ToList();
        }
        public List<Coach> GetAllType()
        {
            return context.Coaches.Include("CoachType").ToList();
        }
        public void InsertUpdate(Coach coach)
        {
            context.Coaches.AddOrUpdate(coach);
            context.SaveChanges();
        }
        public void DeleteCoach(Coach coach)
        {
            context.Coaches.Remove(coach);
            context.SaveChanges();
        }
    }
}
