using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class AddToCart
    {
        public int ItemID { get; set; }

        [ForeignKey("Cart")]
        [Required]
        public int CartID { get; set; }
        public Cart Cart { get; set; }

        [ForeignKey("Product")]
        [Required]
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
