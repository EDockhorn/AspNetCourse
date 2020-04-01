using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Usuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Usuario(User user)
        {
            if (string.IsNullOrEmpty(user.Name))
                ModelState.AddModelError("Name", "Nome não foi preenchido");

            if (user.Password != user.ConfirmPassword)
                ModelState.AddModelError("", "As senhas são diferentes");

            return ModelState.IsValid ? View("Resultado", user) : View();
        }

        public ActionResult Resultado(User user)
        {
            return View(user);
        }
    }
}