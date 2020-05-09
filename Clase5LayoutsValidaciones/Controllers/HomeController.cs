using Clase5LayoutsValidaciones.Models;
using Clase5LayoutsValidaciones.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase5LayoutsValidaciones.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexConLayout()
        {
            return View();
        }
        public ActionResult IndexConLayoutYRegiones()
        {
            return View();
        }
        public ActionResult IndexConLayoutAnidado()
        {
            return View();
        }
        public ActionResult IndexConPartial()
        {
            List<Comentario> comentarios = ComentarioServicio.ObtenerListaRandom();

            return View(comentarios);
        }
    }
}