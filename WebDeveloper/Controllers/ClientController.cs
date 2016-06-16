using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;


namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        private ClientData _client = new ClientData();
        // GET: Client
        public ActionResult Index()
        {
            var client = new ClientData();
            return View(client.GetList());
        }
        public ActionResult Create()
        {
            return View(new Client());

        }
        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {

                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(new Client());

        }
        [HttpPost]
        public ActionResult Edit()
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            return View(new Client());

        }
        [HttpPost]
        public ActionResult Delete(Client client)
        {
            if (ModelState.IsValid)
            {

                _client.Delete(client);
                return RedirectToAction("Index");
            }
            return View();
        }


    }
}