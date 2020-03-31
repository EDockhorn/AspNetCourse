using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class ContatosController : Controller
    {
        // GET: Contatos
        public ActionResult Index()
        {
            var contatos = new Contatos();
            ViewBag.ID = 1;
            ViewBag.Name = "Geisa";
            ViewBag.Type = "TETSE";


            return View(contatos);
        }

        [HttpGet]
        public ActionResult ListaViewBag(int id, string name, string type)
        {
            ViewBag.ID = id;
            ViewBag.Name = name;
            ViewBag.Type = type;

            return View();
        }

        [HttpGet]
        public ActionResult ListagemTipada(int id, string name, string type)
        {
            var contatos = new Contatos()
            {
                ID = id,
                NameContact = name,
                DescriptionContact = type
            };


            return View(contatos);
        }
    }
}