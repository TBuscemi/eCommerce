using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Http;

namespace eCommerceStarterCode.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/Cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllCarts()
        {
            var shoppingCarts = _context.Carts;
            return Ok(shoppingCarts);

        }

        [HttpGet("{Id}")]
        public IActionResult GetSingleCart(int Id)
        {
            var shoppingCart = _context.Carts.Find(Id);
            return Ok(shoppingCart);
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteCart(int Id)
        {
            var DeleteCart = _context.Carts.Find(Id);
            _context.Carts.Remove(DeleteCart);
            _context.SaveChanges();
            return Ok();

        }
    }
}