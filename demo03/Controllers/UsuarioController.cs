using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo03.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        semana13Entities db = new semana13Entities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Validar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Validar(string user,string password)
        {
            Usuario us = db.Usuario.FirstOrDefault(d => d.usuario_u == user & d.clave_u == password);
            if (us!=null)
            {
                return RedirectToAction("Index", "Empleadoes");

            }
            else
            {
                return RedirectToAction("NoHallado", "Usuario");
            }
        }
        public ActionResult NoHallado()
        {
            ViewBag.Error = "No se encontro el usuario con estos datos";
            return View();
        }

    }
}