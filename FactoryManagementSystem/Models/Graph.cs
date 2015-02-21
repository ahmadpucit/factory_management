using FactoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Graph:IGraph
    {
        DataAccountsEntities db = new DataAccountsEntities();
        Database1Entities2 export = new Database1Entities2();
        public Chart_data get_Employee_Graph(int id)
        {
            Chart_data data = new Chart_data();
            if(id == 0)
            {
                
                DateTime my = System.DateTime.Now;
                //List<String> label = new List<String>();// { my.AddDays(-6).ToString("dd/mm/yy"), my.AddDays(-5).ToString("dd/mm/yy"), my.AddDays(-4).ToString("dd/mm/yy"), my.AddDays(-3).ToString("dd/mm/yy"), my.AddDays(-2).ToString("dd/mm/yy"), my.AddDays(-1).ToString("dd/mm/yy"), my.AddDays(0).ToString("dd/mm/yy") };
                // set_label(label);
                Data_set my_set = new Data_set(0);
                for (int i = -6; i <= 0; i++)
                {
                    DateTime curr = my.AddMonths(i);

                    var scoreQuery = from n in db.Salaries where DateTime.Compare(n.date, curr) <= 0 select n.total;
                    int sum = 0;
                    sum = scoreQuery.DefaultIfEmpty(0).Sum();
                    my_set.data.Add(sum);
                    data.labels.Add(my.AddMonths(i).ToString("MM/yyyy"));
                }
                data.datasets.Add(my_set);
                
            }
            else if (id == 1)
            {
                DateTime my = System.DateTime.Now;
                
                Data_set my_set = new Data_set(0);
                for (int i = -6; i <= 0; i++)
                {
                    DateTime curr = my.AddYears(i);

                    var scoreQuery = from n in db.Salaries where DateTime.Compare(n.date, curr) <= 0 select n.total;
                    int sum = 0;
                    sum = scoreQuery.DefaultIfEmpty(0).Sum();
                    my_set.data.Add(sum);
                    data.labels.Add(my.AddYears(i).ToString("yyyy"));
                }
                data.datasets.Add(my_set);
                
            }
            return data;

        }
        public Chart_data get_Stock_Graph()
        {
            Chart_data data = new Chart_data();
            Data_set ds = new Data_set(0);
            Data_set ds1 = new Data_set(1);
            List<Product> pros=export.Products.ToList();
            foreach (Product x in pros)
            {
                var scoreQuery = from n in export.Stocks where n.pid == x.Id select n.unit_price;
                var scoreQuery1 = from n in export.Stocks where n.pid == x.Id select n.quantity;
                int sum = 0;
                sum = scoreQuery.DefaultIfEmpty(0).Sum();
                int sum1 = 0;
                sum1 = scoreQuery1.DefaultIfEmpty(0).Sum();
                data.labels.Add(x.name);
                ds.data.Add(sum);
                ds1.data.Add(sum1);
            }
            data.datasets.Add(ds);
            data.datasets.Add(ds1);
            return data;
        }
        public Chart_data get_Inventory_Graph()
        {
            Chart_data data = new Chart_data();
            Data_set ds = new Data_set(0);
            Data_set ds1 = new Data_set(1);
            List<RawMaterial> pros = export.RawMaterials.ToList();
            foreach (RawMaterial x in pros)
            {
                var scoreQuery = from n in export.Inventories where n.Iid == x.Id select n.unit_price;
                var scoreQuery1 = from n in export.Inventories where n.Iid== x.Id select n.quantity;
                int sum = 0;
                sum = scoreQuery.DefaultIfEmpty(0).Sum();
                int sum1 = 0;
                sum1 = scoreQuery1.DefaultIfEmpty(0).Sum();
                data.labels.Add(x.name);
                ds.data.Add(sum);
                ds1.data.Add(sum1);
            }
            data.datasets.Add(ds);
            data.datasets.Add(ds1);
            return data;
        }
    }
}