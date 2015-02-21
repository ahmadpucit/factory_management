using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FactoryManagementSystem.Models;

namespace FactoryManagementSystem.Controllers
{
    public class EmployeesController : Controller
    {

        IEmployeeRepo Iemp;
        public EmployeesController(IEmployeeRepo ie)
        {
            Iemp = ie;
        }
        //
        // GET: /Employes/
      
        public ActionResult Index()
        {
            return View(Iemp.getAllEmployees());
        }
        public ActionResult AddNew()
        {
            return View();
        }
        [HttpPost]
        public ActionResult add_new()
        {
            
            Employee e = new Employee();
            e.cnic     = Request["cnic"] ;
            e.designation = Request["designation"];
            e.dob = Request["dob"];
            e.join_date = Request["join_date"];
            e.name = Request["name"];
            e.salary = Int32.Parse(Request["salary"]);
            e.tax = Int32.Parse(Request["tax"]);
            Iemp.AddNew(e);
           
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            Iemp.delete(id);
           
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
           
            return View(Iemp.edit(id));
        }
        public ActionResult edit_record(int id)
        {
           
            Employee e = new Employee();
            e.cnic = Request["cnic"];
            e.designation = Request["designation"];
            e.dob = Request["dob"];
            e.join_date = Request["join_date"];
            e.name = Request["name"];
            e.salary = Int32.Parse(Request["salary"]);
            e.tax = Int32.Parse(Request["tax"]);
            Iemp.edit_record(id, e);
            return RedirectToAction("Index");
        }


    }
}
