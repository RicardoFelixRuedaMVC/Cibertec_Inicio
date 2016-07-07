using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
   public class LoginViewModel
    {

        public int id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password{ get; set; }
        public bool RememberMe { get; set; }
    }
}
