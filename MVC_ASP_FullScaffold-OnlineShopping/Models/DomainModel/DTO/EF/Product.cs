//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_ASP_FullScaffold_OnlineShopping.Models.DomainModel.DTO.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductID { get; set; }
        public Nullable<int> ProductCode { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public byte[] Picture { get; set; }
        public string Descriptions { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
