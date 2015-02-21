using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class GraphController : Controller
    {
        //
        // GET: /Graph/
        IGraph ui;
        public GraphController(IGraph gr)
        {
            ui = gr;
        }
        public ActionResult Employee()
        {
            return View();
        }
        public ActionResult Employee_Graph(int id)
        {
            Chart_data cd = ui.get_Employee_Graph(id);
            return View(JavaScriptConvert.SerializeObject(cd));
        }

    }
}
