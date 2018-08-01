using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Data.Entity.Core.Objects;
using System.Web.Mvc;
using SIA.Models;

namespace SIA.Controllers
{
    public class AgentesController : Controller
    {
        private IngresosEntities db = new IngresosEntities();

        // GET: Agentes
        //public ActionResult Index()
        //{
        //    return View(db.Agentes.ToList()); CLGR_01/16/1989
        //}

        public ActionResult Index()
        {
            
            using (var db = new IngresosEntities())
            {
                
                try
                {
                    var informacion = from AG in db.Agentes
                                      join TA in db.TipoAgente on AG.TipoAgente equals TA.IdTipo
                                      join TAGC in db.TipoAgencia on AG.TipoAgencia equals TAGC.Codigo
                                      join AGTM in db.AgentesMaster on AG.CodigoMaster equals AGTM.CodigoMaster
                                      where AG.Estado == "A"
                                      select new AgentesModel
                                      {
                                          Codigo = AG.Codigo,
                                          CodigoRes = AG.CodigoRes,
                                          CodigoInt = AG.CodigoInt,
                                          NombreAgenteMaster = AGTM.Nombre,
                                          NombreTipoAgencia = TAGC.Nombre,
                                          Nombre = AG.Nombre,
                                          NombreTipoAgente = TA.Nombre,
                                          Direccion = AG.Direccion,
                                          Localidad = AG.Localidad,
                                          RazonSocial = AG.RazonSocial,
                                          Ruc = AG.Ruc,
                                          Telefono1 = AG.Telefono1
                                      };
                    //String valor =  informacion.FirstOrDefault().ToString();
                    return View(informacion.ToList().Take(10).OrderByDescending(ag => ag.Codigo));

                }
                catch (Exception e)
                {
                    return null;
                }

            }
            
        }

        // GET: Agentes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agentes agentes = db.Agentes.Find(id);
            if (agentes == null)
            {
                return HttpNotFound();
            }
            return View(agentes);
        }

        // GET: Agentes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agentes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,CodigoRes,CodigoInt,CodigoMaster,RazonSocial,Nombre,Situacion,Tipo,Ruc,TipoAgencia,TipoAgente,Direccion,Localidad,Ciudad,Pais,Frecuencia,Contacto,Telefono1,Telefono2,Fax,email,Notas,Estado,UsuarioReg,FechaReg,UsuarioMod,FechaMod,SysPC,Grupo1,Clase,CtaBancaria,flag,Tour_code,canEmi,AutoCrear")] Agentes agentes)
        {
            if (ModelState.IsValid)
            {
                db.Agentes.Add(agentes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agentes);
        }

        // GET: Agentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agentes agentes = db.Agentes.Find(id);
            if (agentes == null)
            {
                return HttpNotFound();
            }
            return View(agentes);
        }

        // POST: Agentes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,CodigoRes,CodigoInt,CodigoMaster,RazonSocial,Nombre,Situacion,Tipo,Ruc,TipoAgencia,TipoAgente,Direccion,Localidad,Ciudad,Pais,Frecuencia,Contacto,Telefono1,Telefono2,Fax,email,Notas,Estado,UsuarioReg,FechaReg,UsuarioMod,FechaMod,SysPC,Grupo1,Clase,CtaBancaria,flag,Tour_code,canEmi,AutoCrear")] Agentes agentes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agentes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agentes);
        }

        // GET: Agentes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agentes agentes = db.Agentes.Find(id);
            if (agentes == null)
            {
                return HttpNotFound();
            }
            return View(agentes);
        }

        // POST: Agentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Agentes agentes = db.Agentes.Find(id);
            db.Agentes.Remove(agentes);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
