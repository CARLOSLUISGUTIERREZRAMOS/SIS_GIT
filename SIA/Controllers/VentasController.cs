using SIA.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIA.Controllers
{
    public class VentasController : Controller
    {
        private IngresosEntities db = new IngresosEntities();
        public DateTime dateini;
        public DateTime datefin;
        public int NumReporte;
        public int NumAgente;


        // GET: Ventas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ReportesDeVenta()
        {
            ViewBag.Bool = false;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Busqueda(string fecrep, string reporte, string numagente)
        {
            
            if (!string.IsNullOrEmpty(reporte))
            {
                NumReporte = Int32.Parse(reporte);
            }
            if (!string.IsNullOrEmpty(numagente))
            {
                NumAgente = Int32.Parse(numagente);
            }

            
            if (String.IsNullOrEmpty(fecrep) && String.IsNullOrEmpty(numagente))
            {
                dateini = DateTime.Now.Date;
                datefin = DateTime.Now.Date;
            }
            else if(!String.IsNullOrEmpty(fecrep))
            {
                string[] fini_ffin = fecrep.Split('-');
                var f_ini = fini_ffin[0].Trim();
                var f_fin = fini_ffin[1].Trim();
                dateini = DateTime.Parse(f_ini);
                datefin = DateTime.Parse(f_fin);
            }
             


            using (var db = new IngresosEntities())
            {
                try
                {
                    var query = from VC in db.VentasCabecera
                                join EST in db.EstadoRv on VC.Estado equals EST.Codigo
                                join AGT in db.Agentes on VC.Agente equals AGT.Codigo
                                where
                                (
                                (string.IsNullOrEmpty(fecrep) ? true : VC.FechaReporte >= dateini
                                && VC.FechaReporte <= datefin)
                                )
                                                                                          
                                //VC.FechaReporte >= new DateTime(2017, 1, 1)
                                where 
                                (
                                (string.IsNullOrEmpty(numagente) ? true : VC.Agente == NumAgente)
                                
                                )
                                where
                               (
                               (string.IsNullOrEmpty(reporte) ? true : VC.Agente == NumReporte)

                               )
                                select new VentasCabeceraModel {
                                    Tipo = VC.Tipo,
                                    Estado = EST.Nombre,
                                    Grupo = VC.Grupo,
                                    Localidad = AGT.Localidad,
                                    Agente = VC.Agente,
                                    NombreAgente = AGT.Nombre,
                                    FechaReporte = VC.FechaReporte,
                                    NroTkts = VC.NroTkts,
                                    Tarifa = VC.Tarifa,
                                    IgvTarifa = VC.IgvTarifa,
                                    OtrosIngresos = VC.OtrosIngresos,
                                    OtrosImp = VC.OtrosImp,
                                    Comision = VC.Comision,
                                    IgvComision = VC.IgvComision,
                                    Neto = VC.Contado + VC.Credito,
                                    Contado = VC.Contado,
                                    Credito = VC.Credito,
                                    OtrosCargos = VC.OtrosCargos,
                                    UsuarioReg = VC.UsuarioReg,
                                    SaldoDepo = VC.SaldoDepo,
                                    SaldoFactu = VC.SaldoFactu,
                                    SaldoFinal = VC.SaldoFinal

                                };
                     ViewBag.Bool = true;
                     return View("ReportesDeVenta",query.ToList().OrderBy(g  => g.Grupo));
                }
                catch (Exception e)
                {
                    return null;
                }

            }
            
            //return View("ReportesDeVenta");
        }
        

    }
}