using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FactoryManagementSystem.Models;
namespace FactoryManagementSystem.Models
{
    public class InventoryRepo :IinventoryRepo
    {
        public List<Inventory> getInventory()
        {
            using (Database1Entities2 db = new Database1Entities2())
            {
                return db.Inventories.ToList();
            }
        }
        public Inventory edit(int id)
        {
            Database1Entities2 db = new Database1Entities2();
            return db.Inventories.Find(id);
        }
        public Inventory edit_inventry(int id,int raw_id,Inventory i)
        {
            Database1Entities2 db = new Database1Entities2();
            Inventory record = db.Inventories.Find(id);
            record.Iid = raw_id;
            record.quantity = i.quantity;
            record.unit_price = i.unit_price ;
            db.SaveChanges();
            return record ;

        }
        public void crate_new_inventory(int id,Inventory i)
        {
            Database1Entities2 db = new Database1Entities2();
            Inventory s;
            try
            {
                s = db.Inventories.First(x => x.Iid == id);
            }
            catch
            {
                s = null;
            }
            if (s != null)
            {
                s.quantity += i.quantity;
                s.unit_price = i.unit_price;
                db.SaveChanges();
            }
            else
            {
                s = new Inventory();
                s.Iid = id;
                s.quantity = i.quantity;
                s.unit_price = i.unit_price;
                db.Inventories.Add(s);
            }
        }
        public string _issue_Inventory(int id, Inventory i)
        {
            Database1Entities2 db = new Database1Entities2();
            Inventory s;
            s = db.Inventories.First(x => x.Iid == id);
            int a =(int) s.quantity;
            int b =(int) i.quantity;
            if (a-b < 0)
            {
                
                return "error";
            }
            s.quantity -= i.quantity;
            db.SaveChanges();
            return "done";
        }
    }
}