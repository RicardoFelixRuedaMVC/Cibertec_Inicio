using System.ComponentModel.DataAnnotations;
using System;
namespace WebDeveloper.Model
{
  public class Product
    {
        public int id { get; set; }


        [Display(Name = "Description Product:")]
        [Required(ErrorMessage = "This Description Product is required")]
        public string Description { get; set; }


        [Display(Name = "Price Product:")]
        [Required(ErrorMessage = "The price Product is required")]
        public double Price { get; set; }

        public DateTime? DateCreation { get; set; }
    }
}
