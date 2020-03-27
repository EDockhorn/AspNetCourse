using Introducao.Models;
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
            var pessoa = new Pessoa()
            {
                ID = 1,
                Name = "Johnny Erick Dockhorn",
                Type = "Administrador"
            };

            
            ViewBag.ID = pessoa.ID;
            ViewBag.Name = pessoa.Name;
            ViewBag.Type = pessoa.Type;

            return View(pessoa);
        }
        public ActionResult Contatos()
        {
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
        public ActionResult Lista(int id, string name, string type)
        {
            ViewBag.ID = id;
            ViewBag.Name = name;
            ViewBag.Type = type;

            return View();
        }
        [HttpGet]
        public ActionResult Listar(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}