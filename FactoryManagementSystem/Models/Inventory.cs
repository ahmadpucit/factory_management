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
    
    public partial class Inventory
    {
        public int Id { get; set; }
        public int Iid { get; set; }
        public int quantity { get; set; }
        public int unit_price { get; set; }
    
        public virtual RawMaterial RawMaterial { get; set; }
    }
}
