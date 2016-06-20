using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private UserData _User = new UserData();
        public ActionResult Index()
        {
            var User = new UserData();
            return View(User.GetList());
        }

        public ActionResult Create()
        {
            return View(new User());

        }
        [HttpPost]
        public ActionResult Create(User User)
        {
            if (ModelState.IsValid)
            {

                _User.Add(User);
                return RedirectToAction("Index");
            }
            return View();
        }



        public ActionResult Edit(int id)
        {
            var User = _User.GetUser(id);
            if (User == null)
                RedirectToAction("Index");
            return View(User);

        }
        [HttpPost]
        public ActionResult Edit(User User)
        {
            if (_User.update(User) > 0)
                return RedirectToAction("Index");
            return View(User);
        }



        public ActionResult Delete(int id)
        {

            var User = _User.GetUser(id);
            if (User == null)
                RedirectToAction("Index");
            return View(User);
        }
        [HttpPost]
        public ActionResult Delete(User User)
        {
            if (_User.Delete(User) > 0)
                return RedirectToAction("Index");
            return View(User);
        }
    }
}