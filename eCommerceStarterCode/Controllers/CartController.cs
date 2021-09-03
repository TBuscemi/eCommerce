using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Http;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
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

        [HttpPost]
        public IActionResult Post([FromBody]Cart value)
        {
            _context.Carts.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}