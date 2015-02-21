using FactoryManagementSystem.Models;
using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class NotificationController : Controller
    {
        //
        // GET: /Notification/
        DataAccountsEntities db = new DataAccountsEntities();
        Notification_class n_c;
        public NotificationController(Notification_class n)
        {
            n_c = n;
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Viewall()
        {
            //db.Notifications.Find(1).date.tos
            return View(db.Notifications.ToList());
        }
        public ActionResult Edit(int id)
        {
            Notification n = n_c.get_notification(id);
            return View(n);
        }
        public ActionResult EditDone(int id,Notification n)
        {
            n_c.edit_notification(id, n);
            return RedirectToAction("Viewall");
        }
        public ActionResult Delete(int id)
        {
            n_c.delete_notification(id);
            return RedirectToAction("Viewall");
        }

    }
}
