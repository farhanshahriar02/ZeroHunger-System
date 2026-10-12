using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL.Repository
{
    public class EmployeeRepository
    {
        ZeroHungerDbContext db;

        public EmployeeRepository (ZeroHungerDbContext db)
        {
            this.db = db;
        }

        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }
        public Employee Get(int id)
        {
                        
            return db.Employees.Find(id);
        }

        public bool Create(Employee r)
        {
            db.Employees.Add(r);
            return db.SaveChanges() > 0;

        }
        public bool Update(Employee r)
        {

            var exobj = Get(r.EmployeeId);

            exobj.Name = r.Name;
            exobj.Email = r.Email;
            exobj.Address = r.Address;
            exobj.ContactNo = r.ContactNo;

            return db.SaveChanges() > 0;

        }

        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.Employees.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Employee> Search(string name)
        {
            return db.Employees
                     .Where(x => x.Name.Contains(name))
                     .ToList();
        }
    }
}
