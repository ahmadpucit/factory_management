using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication3.Models
{
    public interface IEdit
    {
        void edit_Employee(int id,int amount);
        void edit_Stock_unit(int id, int amount);
        void edit_Stock_quantity(int id, int amount);
        void edit_Inventory_unit(int id, int amount);
        void edit_Inventory_quantity(int id, int amount);
    }
}
