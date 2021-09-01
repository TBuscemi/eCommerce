using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Buyer  
    {
        public int BuyerID { get; set; }

        [ForeignKey("User")]
        [Required]
        public int UserID { get; set; }
        public User User { get; set; }
    }
}


