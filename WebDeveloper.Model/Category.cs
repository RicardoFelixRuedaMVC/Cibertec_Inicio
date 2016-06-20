using System.ComponentModel.DataAnnotations;
namespace WebDeveloper.Model
{
    public class Category
    {
        public int id { get; set; }


        [Display(Name = "Category Name:")]
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }


        [Display(Name = "state:")]
        [Required(ErrorMessage = "The state is required")]
        public bool state { get; set; }
    }
}
