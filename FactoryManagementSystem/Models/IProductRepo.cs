using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagementSystem.Models
{
    public interface IProductRepo
    {
        List<Product> getProduct();
        Product create_new(String name);
    }
}
