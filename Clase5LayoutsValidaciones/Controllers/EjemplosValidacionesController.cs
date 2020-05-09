using Clase5LayoutsValidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase5LayoutsValidaciones.Controllers
{
    public class EjemplosValidacionesController : Controller
    {
        // GET: EjemplosValidaciones
        public ActionResult AltaUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AltaUsuario(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return View(usuario);
            }
            return View();
        }
    }
}