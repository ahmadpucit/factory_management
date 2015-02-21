using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FactoryManagementSystem.Models;
namespace FactoryManagementSystem.Controllers
{
    public class StockController : Controller
    {
        IStockRepo IStock;
        IProductRepo IProd;
        public StockController(IStockRepo Is, IProductRepo Ip)
        {
            IStock = Is;
            IProd = Ip;
        }
        //
        // GET: /Stock/
        Database1Entities2 db = new Database1Entities2();
        public ActionResult Index()
        {

            ViewBag.Stocks = IStock.getStock();
            ViewBag.Products =IProd.getProduct();
            return View();
        }
        public ActionResult Edit(int id)
        {

            ViewBag.Stock = IStock.edit(id);
            ViewBag.Products = IProd.getProduct();
            return View();
        }
        public ActionResult AddNew()
        {
            return View(IProd.getProduct());
        }
        [HttpPost]
        public ActionResult edit_record(int id)
        {
            int p_id = -1;
            String product_select = Request["product_name"];
            if (product_select == "new")
            {
                Product a = IProd.create_new(Request["new_product_name"]);
                p_id = a.Id;
            }
            else
            {
                p_id = Int32.Parse(product_select);
            }
            Stock edited = new Stock();
            edited.quantity = Int32.Parse(Request["quantity"]);
            edited.quantity = Int32.Parse(Request["unit_price"]);
            IStock.edit_stock(id,p_id,edited);
            
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult add_new()
        {
            int p_id = -1;
            String product_select = Request["product_name"];
            if (product_select == "new")
            {
                Product a = IProd.create_new(Request["new_product_name"]);
                p_id = a.Id;
            }
            else
            {
                p_id = Int32.Parse(product_select);
            }
            Stock new_stock = new Stock();
            new_stock.quantity = Int32.Parse(Request["quantity"]);
            new_stock.quantity = Int32.Parse(Request["unit_price"]);
            IStock.addnewStock(p_id,new_stock);
            
            return RedirectToAction("Index");
        }
    }
}
