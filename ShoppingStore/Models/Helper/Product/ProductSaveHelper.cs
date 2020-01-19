using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.Helper.Product
{
    public class ProductSaveHelper
    {
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public byte[] ProductPhoto { get; set; }
    }
}
