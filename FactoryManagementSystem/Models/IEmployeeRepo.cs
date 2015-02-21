using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagementSystem.Models
{
    public interface IEmployeeRepo
    {
        List<Employee> getAllEmployees();
        void AddNew(Employee e);
        void delete(int id);
        Employee edit(int id);
        void edit_record(int id,Employee emp);
    }
}
