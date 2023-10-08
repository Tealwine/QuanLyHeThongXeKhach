using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CoachTypeBUS
    {
        XeKhachModel context = new XeKhachModel();
        public List<CoachType> GetAll()
        {
            return context.CoachTypes.ToList();
        }
    }
}
