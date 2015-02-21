using FactoryManagementSystem.Models;
using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class LoanController : Controller
    {
        //
        // GET: /Loan/
        
        public ActionResult Form(int id)
        {
            return View(id);
        }
        public ActionResult AddLoan(Loan loan)
        {
            //loan.emp_id = 2;
            Database1Entities2 db = new Database1Entities2();
            loan.amount = loan.amount + loan.amount * (int)loan.interest / 100;
            db.Loans.Add(loan);
            db.SaveChanges();
            return RedirectToAction("#");
        }

    }
}
