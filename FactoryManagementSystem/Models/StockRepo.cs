using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryManagementSystem.Models
{
    public class StockRepo:IStockRepo
    {
        Database1Entities2 db = new Database1Entities2();
        public List<Stock> getStock()
        {
            return db.Stocks.ToList();
        }
        public Stock edit(int id)
        {
            return db.Stocks.Find(id);
        }
        public Stock edit_stock(int id, int p_id, Stock edited)
        {
            Stock to_edit = db.Stocks.Find(id);
            to_edit.pid = p_id;
            to_edit.quantity = edited.quantity;
            to_edit.unit_price = edited.unit_price;
            db.SaveChanges();
            return to_edit;
        }
        public void addnewStock(int p_id, Stock newStock)
        {
            Stock s;
            try
            {
                s = db.Stocks.First(x => x.pid == p_id);
            }
            catch
            {
                s = null;
            }
            if (s != null)
            {
                s.quantity += newStock.quantity;
                s.unit_price = newStock.unit_price;
                db.SaveChanges();
            }
            else
            {
                newStock.pid = p_id;
                db.Stocks.Add(newStock);
            }
        }
    }
}