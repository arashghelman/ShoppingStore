using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.Helper.Product
{
    public class ProductSelectHelper
    {
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public byte[] ProductPhoto { get; set; }
    }
}
