using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStore.Models.Helper.Order
{
    public class OrderMasterSelectHelper
    {
        public int OrderCode { get; set; }
        public DateTime OrderDate { get; set; }
        public string SalespersonName { get; set; }
        public string SalespersonCompany { get; set; }
        public string SalespersonAddress { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCompany { get; set; }
        public string CustomerAddress { get; set; }
        public int NumberOfOrderedProducts { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
