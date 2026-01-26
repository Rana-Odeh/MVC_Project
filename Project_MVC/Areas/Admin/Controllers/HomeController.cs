using Microsoft.AspNetCore.Mvc;

namespace Project_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
