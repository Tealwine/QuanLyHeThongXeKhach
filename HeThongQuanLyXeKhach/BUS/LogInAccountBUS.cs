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

        public LogInAccount GetAccountAdmin()
        {
            LogInAccount logIn = null;
            foreach (var log in context.LogInAccounts.ToList())
            {
                if (log.UserId == "admin")
                {
                    logIn = log;
                    break;
                }
            }
            return logIn;
        }

        public LogInAccount GetAccountNhanvien()
        {
            LogInAccount logIn = null;
            foreach (var log in context.LogInAccounts.ToList())
            {
                if (log.UserId == "nhanvien")
                {
                    logIn = log;
                    break;
                }
            }
            return logIn;
        }
    }
}
