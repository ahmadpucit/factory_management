using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using MvcApplication3.Models;
using FactoryManagementSystem.Models;

namespace MvcApplication3.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Home/
        DataAccountsEntities db = new DataAccountsEntities();
        
        public ActionResult Index()
        {
            check_salary();
            Main_index my_main = new Main_index();
            List<Notification> ll = db.Notifications.ToList();
            return View(ll);
        }
        public ActionResult Chart(int id=2)
        {
            Main_index my_main = new Main_index();
            List<Notification> ll = db.Notifications.ToList();
            my_main.set_difference(id, db);
            return View(my_main);
        }
        public ActionResult AddNotification(Notification n)
        {
            n.date = System.DateTime.Now;
            if(Request["optionsRadios"].Equals("1"))
            {
                n.amount = n.amount * (-1);
            }
            db.Notifications.Add(n);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public void check_salary()
        {
            Boolean check = false;
            List<Salary> sal = db.Salaries.ToList();
            foreach(Salary x in sal)
            {
                if(x.date.Month==DateTime.Now.Month)
                {
                    check= true;
                }
            }
            if(check==false)
            {
                Database1Entities2 export=new Database1Entities2();
                Salary s = new Salary();
                s.date = DateTime.Now;
                var query = from n in export.Employees select n.salary;
                s.total =(int) query.DefaultIfEmpty(0).Sum();
                db.Salaries.Add(s);
                db.SaveChanges();
                Notification note = new Notification();
                note.amount = s.total*-1;
                note.date = DateTime.Now;
                note.type = "Salary of month: " + DateTime.Now.Month + " / " + DateTime.Now.Year;
                db.Notifications.Add(note);
                db.SaveChanges();
            }
        }
        

    }
}
