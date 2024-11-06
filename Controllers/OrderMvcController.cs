using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderApp.Data;
using OrderApp.Models;
using System.Threading.Tasks;

namespace OrderApp.Controllers
{
    [Route("OrderMvc")] // Основной маршрут для контроллера 
    public class OrderMvcController : Controller
    {
        private readonly OrderDbContext _context;

        public OrderMvcController(OrderDbContext context)
        {
            _context = context;
        }
                
        // Метод для отображения списка заказов 
        [HttpGet("")]

        public async Task<IActionResult> Index()
        {
            try
            {
                var orders = await _context.Orders.ToListAsync();
                return View(orders);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при доступе к базе данных: {ex.Message}");
                return View(new List<Order>()); // Временное решение: вернуть пустой список при ошибке 
            }
        }
       
        // Метод для отображения формы создания нового заказа 
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        // Метод для обработки данных из формы создания заказа 
        [HttpPost("Create")]
        public async Task<IActionResult> Create(Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderNumber = DateTime.Now.ToString("yyMMdd") + "-" + new Random().Next(1000, 9999);
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
                        
            return View(order);
        }

        // Метод для отображения деталей заказа 
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
    }
}
