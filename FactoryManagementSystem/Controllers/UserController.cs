using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FactoryManagementSystem.Models;

namespace FactoryManagementSystem.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }

        public String get_login()
        {
            String username = (String) Request["username"];
            String pass = Request["password"];
            Database1Entities2 db = new Database1Entities2();
            Admin admin;
            try
            {
                admin = db.Admins.First(x => x.name == username && x.password == pass);
            }
            catch
            {
                admin = null;
            }
            if (admin != null)
            {
                return "found";
            }
            else
            {
                return "not";
            }
        }
        public ActionResult profile()
        {
            return View();
        }
    }
}
