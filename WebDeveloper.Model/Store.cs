using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Store
    {
        public int id { get; set; }


        [Display(Name = "Code Store:")]
        [Required(ErrorMessage = "This Code Store is required")]
        public string Code { get; set; }


        [Display(Name = "Name Store:")]
        [Required(ErrorMessage = "The Name Store is required")]
        public string Name { get; set; }

       
    }
}
