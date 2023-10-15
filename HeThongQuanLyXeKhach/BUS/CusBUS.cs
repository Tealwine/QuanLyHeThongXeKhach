using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CusBUS
    {
        XeKhachModel context = new XeKhachModel();
        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }
        public void InsertUpdate(Customer customer)
        {
            context.Customers.AddOrUpdate(customer);
            context.SaveChanges();
        }
    }
}
