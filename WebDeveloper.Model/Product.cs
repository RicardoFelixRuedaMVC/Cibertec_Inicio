using System.ComponentModel.DataAnnotations;
using System;
namespace WebDeveloper.Model
{
  public class Product
    {
        public int id { get; set; }


        [Display(Name = "Code Product:")]
        [Required(ErrorMessage = "This Code Product is required")]
        public string Code { get; set; }


        [Display(Name = "Name Product:")]
        [Required(ErrorMessage = "The Name Product is required")]
        public string Name { get; set; }

        [Display(Name = "Date Expired:")]
        [Required(ErrorMessage = "The Date Expired is required")]
        public DateTime DateExpired { get; set; }


       
    }
}
