using Microsoft.AspNetCore.Mvc;

namespace Project_MVC.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
