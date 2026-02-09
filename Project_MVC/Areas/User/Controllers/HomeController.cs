using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_MVC.data;

namespace Project_MVC.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();

            return View("Index", categories);
        }
        public IActionResult Products(int categoryId)
        {
            var products = context.Products
                .Where(p => p.CategoryId == categoryId)
                .ToList();

            return View(products);
        }
    }
}
