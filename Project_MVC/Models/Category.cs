using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Project_MVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Minimum length is 2 characters")]
        public string Name { get; set; }
   
        public List<Product> Products { get; set; }

    }
}
