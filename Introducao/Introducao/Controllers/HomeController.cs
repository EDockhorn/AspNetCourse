using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string Message()
        {
            return "Johnny Erick Dockhorn";
        }

        public ActionResult Contatos()
        {
            return View();
        }

        public ActionResult Google()
        {
            return View();
        }
    }
}