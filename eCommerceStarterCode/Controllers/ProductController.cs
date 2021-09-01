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
    }
}

    //        // GET api/product
    //        [HttpGet]      
    //        public IActionResult GetAllProduct() 
    //        {
    //            // get all products
    //            var productID = _context.UserLogins;
    //            return Ok(productID);
    //        }
    // POST api/addnewproduct
