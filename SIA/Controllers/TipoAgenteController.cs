using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Net;
using System.Data.Entity.Core.Objects;
using System.Web.Mvc;
using SIA.Models;
namespace SIA.Controllers
{
    public class TipoAgenteController : Controller
    {

        private IngresosEntities db = new IngresosEntities();
        // GET: TipoAgente
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAll()
        {

            using ( var db = this.db)
            {
                try
                {
                    var query = db.TipoAgente.ToList();
                    return Json(new SelectList(query, "IdTipo", "Nombre"));
                }
                catch(Exception e)
                {
                    return null;
                }


            }

        }
    }
}