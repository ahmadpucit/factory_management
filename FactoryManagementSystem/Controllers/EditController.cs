using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class EditController : Controller
    {
        //
        // GET: /Edit/
        IDetails details;
        IEdit edit;
        public EditController(IDetails temp,IEdit temp1)
        {
            details = temp;
            edit = temp1;
        }
        public ActionResult Employee()
        {
            return View(details.getEmployee_List());
        }
        public ActionResult Inventory()
        {
            return View(details.getInventory_List());
        }
        public ActionResult Stock()
        {
            return View(details.getStock_List());
        }
        public ActionResult Inventory_unit(int id)
        {
            int amount = Int32.Parse(Request["amount"]);
            edit.edit_Inventory_unit(id, amount);
            return RedirectToAction("Inventory");
            
        }
        public ActionResult Stock_unit(int id)
        {
            int amount = Int32.Parse(Request["amount"]);
            edit.edit_Stock_unit(id, amount);
            return RedirectToAction("Stock");
        }
        public ActionResult Inventory_quantity(int id)
        {
            int amount = Int32.Parse(Request["amount"]);
            edit.edit_Inventory_quantity(id, amount);
            return RedirectToAction("Inventory");
        }
        public ActionResult Stock_quantity(int id)
        {
            int amount = Int32.Parse(Request["amount"]);
            edit.edit_Stock_quantity(id, amount);
            return RedirectToAction("Stock");
        }
        public ActionResult Employee_Do(int id)
        {
            int amount=Int32.Parse(Request["amount"]);
            edit.edit_Employee(id,amount);
            return RedirectToAction("Employee");
        }

    }
}
