using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class AddToCart
    {
        public int ItemID { get; set; }
        public int CartID { get; }
        public int ProductID { get; }

    }
}
