using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication3.Models
{
    public interface IGraph
    {
        Chart_data get_Employee_Graph(int id);
        Chart_data get_Stock_Graph();
        Chart_data get_Inventory_Graph();
    }
}
