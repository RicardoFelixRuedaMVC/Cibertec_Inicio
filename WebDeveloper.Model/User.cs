
using System.ComponentModel.DataAnnotations;
namespace WebDeveloper.Model
{
    public class User
    {
        public int id { get; set; }


        [Display(Name = "User Name:")]
        [Required(ErrorMessage = "This user name is required")]
        public string UserName { get; set; }


        [Display(Name = "Password:")]
        [Required(ErrorMessage = "The Password is required")]
        public string Password { get; set; }

        [Display(Name = "State:")]
        [Required(ErrorMessage = "The State is required")]
        public bool State { get; set; }
    }
}
