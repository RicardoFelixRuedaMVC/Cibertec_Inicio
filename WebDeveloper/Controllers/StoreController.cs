using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;
namespace WebDeveloper.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        private StoreData _Store = new StoreData();
        public ActionResult Index()
        {
            var Store = new StoreData();
            return View(Store.GetList());
        }

        public ActionResult Create()
        {
            return View(new Store());

        }
        [HttpPost]
        public ActionResult Create(Store Store)
        {
            if (ModelState.IsValid)
            {

                _Store.Add(Store);
                return RedirectToAction("Index");
            }
            return View();
        }



        public ActionResult Edit(int id)
        {
            var Store = _Store.GetStore(id);
            if (Store == null)
                RedirectToAction("Index");
            return View(Store);

        }
        [HttpPost]
        public ActionResult Edit(Store Store)
        {
            if (_Store.update(Store) > 0)
                return RedirectToAction("Index");
            return View(Store);
        }



        public ActionResult Delete(int id)
        {

            var Store = _Store.GetStore(id);
            if (Store == null)
                RedirectToAction("Index");
            return View(Store);
        }
        [HttpPost]
        public ActionResult Delete(Store Store)
        {
            if (_Store.Delete(Store) > 0)
                return RedirectToAction("Index");
            return View(Store);
        }
    }
}