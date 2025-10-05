using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name="keyboard" };
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            return Content("id= " + id);
        }
    }
}
