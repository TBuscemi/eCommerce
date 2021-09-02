using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace eCommerceStarterCode.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products;
            return Ok(products);
        }

        [HttpGet("{Id}")]
        public IActionResult GetSingleProduct(int Id)
        {
            var product = _context.Products.Find(Id);
            return Ok(product);
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteProduct(int Id)
        {
            var productToDelete = _context.Products.Find(Id);
            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
            return Ok();
        }
    }
}
