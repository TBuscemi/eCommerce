using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Product
    {
        public int ProductID { get; set; } 
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public string ProductThumbnail { get; set; }
        public string ProductReview { get; set; }
        public int ProductRating { get; set; }
        public string ProductCategory { get; set; }
    }
}
