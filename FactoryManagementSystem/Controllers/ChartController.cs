using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class ChartController : Controller
    {
        //
        // GET: /Chart/
        IGraph ui;
        public ChartController(IGraph temp)
        {
            ui = temp;
        }
        public ActionResult Employee()
        {
            return View();
        }
        public ActionResult Employee_Chart(int id)
        {
            Chart_data cd = ui.get_Employee_Graph(id);
            return View(JavaScriptConvert.SerializeObject(cd));
        }
        public ActionResult Stock()
        {
            Chart_data cd = ui.get_Stock_Graph();
            return View(JavaScriptConvert.SerializeObject(cd));
        }
        public ActionResult Inventory()
        {
            Chart_data cd = ui.get_Inventory_Graph();
            return View(JavaScriptConvert.SerializeObject(cd));
        }
       

    }
}
