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
        [Key]
        public int NewProductID { get; set; }

        [ForeignKey("Seller")]
        [Required]
        public int SellerID { get; set; }
        public Seller Seller { get; set; }

        [ForeignKey("Product")]
        [Required]
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
