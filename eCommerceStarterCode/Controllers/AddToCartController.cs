using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/AddToCart")]
    [ApiController]
    public class AddToCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AddToCartController(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
