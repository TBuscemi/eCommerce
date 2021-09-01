using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class SellerUpdateProduct
    {
        public int NewProductID { get; set; }

        [ForeignKey("Seller")]
        [Required]
        public int SellerID { get; }
        public Seller Seller { get; set; }

        [ForeignKey("Product")]
        [Required]
        public int ProductID { get; }
        public Product Product { get; set; }


    }
}
