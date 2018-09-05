using SIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIA.Controllers
{
    public class EstadoRvController : Controller
    {

        private IngresosEntities db = new IngresosEntities();

        // GET: EstadoRv
        public ActionResult Index()
        {
            return View();
        }

        //Json Estado ALL

        public JsonResult GetAll()
        {
            using (var db = new IngresosEntities())
            {
                try
                {
                    var query = db.EstadoRv.ToList();
                    return Json(new SelectList(query, "Codigo","Nombre"));
                }
                catch (Exception e)
                {
                    return null;
                }
                
            }
                

        }

        // GET: EstadoRv/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstadoRv/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoRv/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EstadoRv/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstadoRv/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EstadoRv/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstadoRv/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
