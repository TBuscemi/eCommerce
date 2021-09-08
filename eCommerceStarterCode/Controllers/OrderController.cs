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
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllOders()
        {
            var products = _context.Orders;
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingleOrder(int id)
        {
            var order = _context.Orders.Find(id);
            return Ok(order);

        }

        [HttpPut]
        public IActionResult UpdateOrder([FromBody] Order value)
        {
            Order orderToUpdate = _context.Orders.Find(value.OrderId);
            _context.Update(orderToUpdate);
            _context.SaveChanges();
            return Ok(orderToUpdate);
        }

        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            var orderToDelete = _context.Orders.Find(id);
            _context.Orders.Remove(orderToDelete);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult NewOrder([FromBody] Order value)
        {
            Order newOrder = new Order();
            _context.Orders.Add(newOrder);
            _context.SaveChanges();
            return StatusCode(201, newOrder);
        }
    }
}
