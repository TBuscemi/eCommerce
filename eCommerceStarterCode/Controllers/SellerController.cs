using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/Seller")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public SellerController(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
