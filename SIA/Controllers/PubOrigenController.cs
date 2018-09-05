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
    public class PubOrigenController : Controller
    {

        private IngresosEntities db = new IngresosEntities();
        
        // GET: PubOrigen
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAll()
        {
            using (var db = new IngresosEntities())
            {
                try
                {
                    var query = db.PubOrigen.ToList();
                    return Json(new SelectList(query, "IdOrigen", "NomOrigen"));
                }
                catch (Exception e)
                {
                    return null;
                }


            }
        }
    }
}