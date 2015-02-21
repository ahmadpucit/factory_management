using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagementSystem.Models
{
    public interface IinventoryRepo
    {
        List<Inventory> getInventory();
        Inventory edit(int id);
        Inventory edit_inventry(int id,int raw_id,Inventory i);
        void crate_new_inventory(int id, Inventory i);
        string _issue_Inventory(int id, Inventory i);
    }
}
