using FactoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication3.Models
{
    public interface IDetails
    {
        List<Employee> getEmployee_List();
        List<Inventory> getInventory_List();
        List<Stock> getStock_List();
        List<Loan> getLoan_List();
    }
}
