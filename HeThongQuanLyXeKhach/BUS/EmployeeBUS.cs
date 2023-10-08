using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeeBUS
    {
        XeKhachModel context = new XeKhachModel();
        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }
        public void InsertUpdate(Employee employee)
        {
            context.Employees.AddOrUpdate(employee);
            context.SaveChanges();
        }
        public void DeleteEmployee(Employee employee)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
        }
    }
}
