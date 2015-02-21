using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FactoryManagementSystem.Models;
namespace FactoryManagementSystem.Controllers
{
    public class InventoryController : Controller
    {
        //
        // GET: /Inventory/
       
        Database1Entities2 db = new Database1Entities2();
        IinventoryRepo Irep;
        IrawmaterialRepo rawRep;
        public InventoryController(IinventoryRepo inventry, IrawmaterialRepo raw)
        {
            Irep = inventry;
            rawRep = raw;
        }
        public ActionResult Index()
        {
            ViewBag.Inventories = Irep.getInventory();
            ViewBag.RawMaterials = rawRep.getRawMaterial();
            return View();
        }
        public ActionResult Edit(int id)
        {

            ViewBag.Inventory = Irep.edit(id);
            ViewBag.RawMaterials = rawRep.edit();
            return View();
        }
        public ActionResult AddNew()
        {
            ViewBag.rawMaterials = rawRep.getRawMaterial();
            return View();
        }

        [HttpPost]
        public ActionResult edit_record(int id)
        {
            int p_id = -1;
            String product_select = Request["raw_material_name"];
            if (product_select == "new")
            {
                RawMaterial a = rawRep.create_new(Request["new_raw_material_name"]);
                p_id = a.Id;
            }
            else
            {
                p_id = Int32.Parse(product_select);
            }
            Inventory record = new Inventory();
            record.quantity = Int32.Parse(Request["quantity"]);
            record.unit_price = Int32.Parse(Request["unit_price"]);
            Irep.edit_inventry(id,p_id,record);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult add_new()
        {
            int p_id = -1;
            String product_select = Request["raw_material_name"];
            if (product_select == "new")
            {
                RawMaterial a = rawRep.create_new(Request["new_raw_material_name"]);
                p_id = a.Id;
            }
            else
            {
                p_id = Int32.Parse(product_select);
            }
            Inventory s = new Inventory();
            
            s.quantity = Int32.Parse(Request["quantity"]);
            s.unit_price = Int32.Parse(Request["unit_price"]);
            Irep.crate_new_inventory(p_id, s);

            return RedirectToAction("Index");
        }
        public ActionResult issue_Inventory()
        {
            ViewBag.rawMaterials = rawRep.getRawMaterial();
            return View();
           
        }
        [HttpPost]
        public string _issue_Inventory()
        {
            string product_select = Request["raw_name"];
            int p_id = Int32.Parse(product_select);
            Inventory s = new Inventory();
            s.quantity = Int32.Parse(Request["raw_quantity"]);
            string response = Irep._issue_Inventory(p_id, s);
            if (response.Equals("done"))
            {
                return "done";
            }
            else
            {
                return "error";
            }
        }
    }
}
