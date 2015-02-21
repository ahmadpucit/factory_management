using FactoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Notification_class:INotification
    {
        DataAccountsEntities db = new DataAccountsEntities();
        public void delete_notification(int id)
        {
            Notification n = db.Notifications.Find(id);
            db.Notifications.Remove(n);
            db.SaveChanges();

        }
        public Notification get_notification(int id)
        {
            Notification n = db.Notifications.Find(id);
            return n;
        }
        public void edit_notification(int id,Notification n)
        {
            Notification temp = db.Notifications.Find(id);
            temp.amount = n.amount;
            temp.type = n.type;
            db.SaveChanges();
        }
    }

}