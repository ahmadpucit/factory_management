using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryManagementSystem.Models
{
    public class ProductRepo:IProductRepo
    {
        public List<Product> getProduct()
        {
            Database1Entities2 db = new Database1Entities2();
            return db.Products.ToList();
        }
        public Product create_new(String name)
        {
            Database1Entities2 db = new Database1Entities2();
            Product p = new Product();
            p.name = name;
            db.Products.Add(p);
            db.SaveChanges();
            return db.Products.First(x => x.name == name);
        }

    }
}