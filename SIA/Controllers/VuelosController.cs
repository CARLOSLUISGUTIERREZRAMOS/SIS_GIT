using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIA.Controllers
{
    public class VuelosController : Controller
    {
        // GET: Vuelos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaVuelos()
        {
            return View();
        }
    }
}