using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagementSystem.Models
{
    public interface IStockRepo
    {
        List<Stock> getStock();
        Stock edit(int id);
        Stock edit_stock(int id, int p_id, Stock edited);
        void addnewStock(int p_id, Stock newStock);
    }
}
