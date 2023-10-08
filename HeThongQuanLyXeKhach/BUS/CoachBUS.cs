using DAL.Models;
using System;
using System.Collections.Generic;
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
    }
}
