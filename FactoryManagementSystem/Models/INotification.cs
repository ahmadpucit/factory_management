using FactoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication3.Models
{
    public interface INotification
    {
        void delete_notification(int id);
        Notification get_notification(int id);
        void edit_notification(int id,Notification n);
    }
}
