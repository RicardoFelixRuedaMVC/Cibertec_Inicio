using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;


namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        //private ClientData _client = new ClientData();
        // GET: Client
       //private ClientData _client;
        private IDataAccess<Client> _client;

        public ClientController(IDataAccess<Client> client)
        {
            _client = client;
        }
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
          var client = _client.GetClient(id);
            if (client == null)
                RedirectToAction("Index");
            return View(client);

        }
        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (_client.update(client) > 0)
                return RedirectToAction("Index");
            return View(client);
        }



        public ActionResult Delete(int id)
        {
            
            var client = _client.GetClient(id);
            if (client == null)
               RedirectToAction("Index");
             return View(client);
        }
        [HttpPost]
        public ActionResult Delete(Client client)
        {
            if (_client.Delete(client)>0)
                return RedirectToAction("Index");
            return View(client);
        }


    }
}