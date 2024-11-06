//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using OrderApp.Data;
//using OrderApp.Models;
//using System;
//using System.Threading.Tasks;

//namespace OrderApp.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class OrdersController : ControllerBase
//    {
//        private readonly OrderDbContext _context;

//        public OrdersController(OrderDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetOrders()
//        {
//            var orders = await _context.Orders.ToListAsync();
//            return Ok(orders);
//        }

//        [HttpPost]
//        public async Task<IActionResult> CreateOrder([FromBody] Order order)
//        {
//            order.OrderNumber = Guid.NewGuid().ToString();
//            _context.Orders.Add(order);
//            await _context.SaveChangesAsync();
//            return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, order);
//        }
//    }
//}
