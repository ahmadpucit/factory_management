using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class DetailController : Controller
    {

        //
        // GET: /Detail/
        IDetails detail;
        public DetailController(IDetails det)
        {
            detail = det;
        }
        public ActionResult EmployeeD()
        {
            return View(detail.getEmployee_List());
        }
        public ActionResult StockD()
        {
            
            return View(detail.getStock_List());
        }
        public ActionResult InventoryD()
        {
            return View(detail.getInventory_List());
        }
        public ActionResult LoanD()
        {
            return View(detail.getLoan_List());
        }
    }
}
