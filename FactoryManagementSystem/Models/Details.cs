using FactoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Details:IDetails
    {
        Database1Entities2 bd = new Database1Entities2();
        public List<Employee> getEmployee_List()
        {
            return bd.Employees.ToList();
        }
        public List<Inventory> getInventory_List()
        {
            return bd.Inventories.ToList();
        }
        public List<Stock> getStock_List()
        {
            return bd.Stocks.ToList();
        }
        public List<Loan> getLoan_List()
        {
            return bd.Loans.ToList();
        }

    }
}