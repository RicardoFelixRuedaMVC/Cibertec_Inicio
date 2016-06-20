using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;


namespace WebDeveloper.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
       
          private ProductData _Product = new ProductData();
           public ActionResult Index()
        {
            var Product = new ProductData();
            return View(Product.GetList());
        }
        public ActionResult Create()
        {
            return View(new Product());

        }
        [HttpPost]
        public ActionResult Create(Product Product)
        {
            if (ModelState.IsValid)
            {

                _Product.Add(Product);
                return RedirectToAction("Index");
            }
            return View();
        }



        public ActionResult Edit(int id)
        {
            var Product = _Product.GetProduct(id);
            if (Product == null)
                RedirectToAction("Index");
            return View(Product);

        }
        [HttpPost]
        public ActionResult Edit(Product Product)
        {
            if (_Product.update(Product) > 0)
                return RedirectToAction("Index");
            return View(Product);
        }



        public ActionResult Delete(int id)
        {

            var Product = _Product.GetProduct(id);
            if (Product == null)
                RedirectToAction("Index");
            return View(Product);
        }
        [HttpPost]
        public ActionResult Delete(Product Product)
        {
            if (_Product.Delete(Product) > 0)
                return RedirectToAction("Index");
            return View(Product);
        }
    }
}