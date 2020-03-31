using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                ID = 1,
                Name = "Johnny Erick Dockhorn",
                Type = "Administrador"
            };

            ViewData["ID"] = 10;
            ViewData["Name"] = "Erick";
            ViewData["Type"] = "Descrição";


            return View();
        }
        public ActionResult Contatos()
        {

            ViewBag.ID = "30";
            ViewBag.Name = "Geisa Santos Dockhorn";
            ViewBag.Type = "Tecnologia";

            return View();
        }

        public ActionResult Google()
        {
            return View();
        }

        public ActionResult Adm()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Store()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ListaViewData(int id, string name, string type)
        {
            ViewData["ID"] = id;
            ViewData["Name"] = name;
            ViewData["Type"] = type;

            return View();
        }

        [HttpGet]
        public ActionResult ListaViewBag(int id, string name, string type)
        {
            ViewBag.ID = id;
            ViewBag.Name = name;
            ViewBag.Type = type;

            return View();
        }

    }
}