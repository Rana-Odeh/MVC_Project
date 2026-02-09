using Microsoft.AspNetCore.Mvc;
using Project_MVC.data;
using Project_MVC.Models;

namespace Project_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()

        {
            var categories = context.Categories.ToList(); ;
            return View("Index", categories);
        }
        public IActionResult Create()

        {

            return View("Create",new Category());
        }
        [HttpPost]
        public IActionResult Store(Category category)

        {
            if (ModelState.IsValid)
            {
                var Category = context.Categories.Add(category);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View("Create",category);
        }
        public IActionResult Remove(int Id)

        {
          
                var Category = context.Categories.Find(Id);
                context.Categories.Remove(Category);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));;
        }
        public IActionResult Edit(int Id)
        {
            var Category = context.Categories.Find(Id);

            return View("Edit",Category);
        }
        public IActionResult Update(Category category,int Id)
        {

            if (ModelState.IsValid)
            {
                context.Categories.Update(category);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View("Edit", category);

        }

    }

}


