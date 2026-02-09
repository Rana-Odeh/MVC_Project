using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_MVC.data;
using Project_MVC.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Project_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var Products = context.Products.Include(p=>p.Category).ToList();

            return View("Index",Products);
        }
        public IActionResult Create()
        {
            // ViewData["Categories"] = context.Categories.ToList();
            ViewBag.Categories = context.Categories.ToList();
            return View("Create", new Product { });
        }
        public IActionResult Store(Product Product, IFormFile Image)

        {
            if (Image != null && Image.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString();
                fileName += Path.GetExtension(Image.FileName);
                var filePath = Path.Combine( Directory.GetCurrentDirectory(),  @"wwwroot\css\images\",fileName);
                using (var stream = System.IO.File.Create(filePath))
                {
                    Image.CopyTo(stream);
                }
                Product.Image = fileName;
                context.Products.Add(Product);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return Content("Ok");
        }
        public IActionResult Remove(int Id)

        {
            var Product = context.Products.Find(Id);
            context.Products.Remove(Product);
            context.SaveChanges();
            return RedirectToAction(nameof(Index)); ;
        }
     

    }
}

