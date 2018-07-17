using SIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIA.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            IngresosEntities db = new IngresosEntities();
            List<Usuario> lista = db.Usuario.Where(a => a.UserCar == "SISTEMAS").ToList();

            return View(lista);
         }
    }
}