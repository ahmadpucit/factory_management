using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryManagementSystem.Models
{
    public class rawMaterialRepo: IrawmaterialRepo
    {
        public List<RawMaterial> getRawMaterial()
        {
            using (Database1Entities2 db = new Database1Entities2())
            {
                return db.RawMaterials.ToList();
            }
        }
        public List<RawMaterial> edit()
        {
            Database1Entities2 db = new Database1Entities2();
            return db.RawMaterials.ToList();

        }

        public RawMaterial create_new(String name)
        {
            Database1Entities2 db = new Database1Entities2();
            RawMaterial a = new RawMaterial();
            a.name = name;
            db.RawMaterials.Add(a);
            return db.RawMaterials.First(x => x.name == name);

        }
    }
}