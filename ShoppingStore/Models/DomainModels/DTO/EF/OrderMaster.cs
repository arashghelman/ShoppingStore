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
    using System.Collections.Generic;
    
    public partial class OrderMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderMaster()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int OrderId { get; set; }
        public int SalespersonId { get; set; }
        public int CustomerId { get; set; }
        public int OrderCode { get; set; }
        public System.DateTime OrderDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Person Person { get; set; }
        public virtual Person Person1 { get; set; }
    }
}
