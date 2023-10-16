using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LogInAccountBUS
    {
        XeKhachModel context = new XeKhachModel();
        public List<LogInAccount> GetAll()
        {
            return context.LogInAccounts.ToList();
        }

        public LogInAccount GetAccountLogged(string userId)
        {
            return context.LogInAccounts.FirstOrDefault(a=>a.UserId == userId);
        }

        
    }
}
