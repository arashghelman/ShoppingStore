//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingStore.Models.DomainModels.DTO.EF
{
    using System;
    
    public partial class usp_SelectProduct_Result
    {
        public int ProductId { get; set; }
        public Nullable<int> ProductCode { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Price { get; set; }
        public byte[] ProductPhoto { get; set; }
    }
}
