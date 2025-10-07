using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ItemsController : Controller
    {
        private readonly WebAppContext _context;

        public ItemsController(WebAppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var items =await _context.Items.ToListAsync();
            return View(items);
        }

        public IActionResult create()
        {
            return View();
        }
        
    }
}
