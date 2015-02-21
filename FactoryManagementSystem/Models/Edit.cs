using FactoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Edit:IEdit
    {
        Database1Entities2 db = new Database1Entities2();
        public void edit_Employee(int id,int amount)
        {
            Employee emp = db.Employees.Find(id);
            emp.salary = amount;
            db.SaveChanges();
        }
        public void edit_Stock_unit(int id, int amount)
        {
            Stock s = db.Stocks.Find(id);
            s.unit_price = amount;
            db.SaveChanges();
        }
        public void edit_Stock_quantity(int id, int amount)
        {
            Stock s = db.Stocks.Find(id);
            s.quantity = amount;
            db.SaveChanges();

        }
        public void edit_Inventory_unit(int id, int amount)
        {
            Inventory i = db.Inventories.Find(id);
            i.unit_price = amount;
            db.SaveChanges();
        }
        public void edit_Inventory_quantity(int id, int amount)
        {
            Inventory i = db.Inventories.Find(id);
            i.quantity = amount;
            db.SaveChanges();
        }
    }
}