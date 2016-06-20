using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        //private CategoryData _Category = new CategoryData();
        private CategoryData _Category = new CategoryData();
        public ActionResult Index()
        {
            var Category = new CategoryData();
            return View(Category.GetList());
        }
        public ActionResult Create()
        {
            return View(new Category());
          
        }
        [HttpPost]
        public ActionResult Create(Category Category)
        {
            if (ModelState.IsValid)
            {
                _Category.Add(Category);
                return RedirectToAction("Index");
            }
            return View();
        }



        public ActionResult Edit(int id)
        {
            var Category = _Category.GetCategory(id);
            if (Category == null)
                RedirectToAction("Index");
            return View(Category);

        }
        [HttpPost]
        public ActionResult Edit(Category Category)

        {

            if (_Category.update(Category) > 0)
                return RedirectToAction("Index");
            return View(Category);
        }



        public ActionResult Delete(int id)
        {

            var Category = _Category.GetCategory(id);
            if (Category == null)
                RedirectToAction("Index");
            return View(Category);
        }
        [HttpPost]
        public ActionResult Delete(Category Category)
        {
            if (
                _Category.Delete(Category) > 0)
                return RedirectToAction("Index");
            return View(Category);
        }
    }
}