using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryManagementSystem.Models
{
    public class EmployeeRepo:IEmployeeRepo
    {
      
        public List<Employee> getAllEmployees()
        {
            Database1Entities2 db = new Database1Entities2();
            return db.Employees.ToList();
            
        }
        public void AddNew(Employee e)
        {
            Database1Entities2 db = new Database1Entities2();
            db.Employees.Add(e);
            db.SaveChanges();
        }
        public void delete(int id)
        {
            Database1Entities2 db = new Database1Entities2();
            Employee e = db.Employees.Find(id);
            db.Employees.Remove(e);
            db.SaveChanges();
        }
        public Employee edit(int id)
        {
            Database1Entities2 db = new Database1Entities2();
            Employee e = db.Employees.Find(id);
            return e;
        }
        public void edit_record(int id, Employee emp)
        {
            Database1Entities2 db = new Database1Entities2();
            
            Employee e = db.Employees.Find(id);
            e.cnic = emp.cnic;
            e.designation = emp.designation;
            e.dob = emp.dob;
            e.join_date = emp.join_date;
            e.name = emp.name;
            e.salary = emp.salary;
            e.tax = emp.tax;
            db.SaveChanges();
        }
    }
}