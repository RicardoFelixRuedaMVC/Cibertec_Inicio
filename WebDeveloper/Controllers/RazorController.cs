using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.ActionFilters;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [LogActionFilter]
    [RoutePrefix("Razor")]
    public class RazorController : Controller
    {
        // GET: Razor

           
        public ActionResult Index()
        {
            var client = new Client()
            {
                id = 1,
                Name = "Carlos",
                LastName = "Perez",
                DateCreation = DateTime.Today
                
            };
            return View(client);
        }
        public ActionResult Product()
        {

            var productData = new DataAccess.ProductData();
            return View(productData.GetFakeProducts());
        }


       
        [Route("Entry/{date:DateTime}")]
        public ActionResult EntryDate(DateTime date)
        {

            ViewBag.Date = date; 
            return View();
        }

        [Route("Entry/{id:int}")]
        public string EntryId(int id)
        {

            return id.ToString();

        }
    }
}