using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_MVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Minimum length is 3 characters")]
        [MaxLength(10, ErrorMessage = "Minimum length is 3 characters")]
        public string Name { get; set; }
        [Range(0,1000)]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string? Image {  get; set; }
        public int Rate { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }




    }
}
