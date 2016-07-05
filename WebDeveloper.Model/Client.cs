using System;
using System.ComponentModel.DataAnnotations;
using WebDeveloper.Resources;
namespace WebDeveloper.Model
{
    public class Client
    {
        //[Display(Name = "ID", ResourceType = typeof(Resource))]
        public int id { get; set; }
               
        [Display(Name = "Client_Name", ResourceType = typeof(Resource))]
        [Required(ErrorMessage ="This field is required")]
        public string Name { get; set; }

        
        [Display(Name = "Client_LastName",ResourceType = typeof(Resource))]
        [Required(ErrorMessage = "The Last Name is required")]
        public string LastName { get; set; }

        public DateTime? DateCreation { get; set; }
    }


}

