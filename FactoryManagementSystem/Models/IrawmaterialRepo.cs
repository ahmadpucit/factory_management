using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagementSystem.Models
{
    public interface IrawmaterialRepo
    {
        List<RawMaterial> getRawMaterial();
        List<RawMaterial> edit();
        RawMaterial create_new(String name);

    }
}
