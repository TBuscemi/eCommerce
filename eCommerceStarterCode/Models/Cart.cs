using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int CustomerID { get; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }

    }
}
