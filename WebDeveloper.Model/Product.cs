using System.ComponentModel.DataAnnotations;
using System;
using WebDeveloper.Resources;
namespace WebDeveloper.Model
{
  public class Product
    {
        public int id { get; set; }


        [Display(Name = "Product_Description", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "This Description Product is required")]
        public string Description { get; set; }


        [Display(Name = "Product_Price", ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "The price Product is required")]
        public double Price { get; set; }

        [Display(Name = "Product_DateCreation", ResourceType = typeof(Resource))]
        public DateTime? DateCreation { get; set; }
    }
}
