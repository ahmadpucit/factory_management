//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FactoryManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Loans = new HashSet<Loan>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string cnic { get; set; }
        public string dob { get; set; }
        public int salary { get; set; }
        public string designation { get; set; }
        public double tax { get; set; }
        public string join_date { get; set; }
    
        public virtual ICollection<Loan> Loans { get; set; }
    }
}
