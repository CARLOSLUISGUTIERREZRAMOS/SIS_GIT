
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
    public class VentasController : Controller
    {
        private IngresosEntities db = new IngresosEntities();
        public DateTime dateini;
        public DateTime datefin;
        public DateTime p_contable_ini;
        public DateTime p_contable_fin;
        public int NumReporte;
        public int NumAgente;
        public int NumEstado;
        public int condicionaFecha;
        public DateTime today = DateTime.Today;




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
        public ActionResult Busqueda(string pcontable, string fecrep, string reporte, string numagente, string loc, string tventa,string estado)
        {

            var tventa_string = tventa;

            if (!string.IsNullOrEmpty(reporte))
            {
                try
                {
                    //NumReporte = Grupo
                    NumReporte = Int32.Parse(reporte);
                }
                catch (Exception e)
                {
                    ViewBag.ModalTitleHeader = "¡Error en la busqueda!";
                    ViewBag.ModalTipo = "modal-danger";
                    ViewBag.Error = "El numero de reporte ingresado no es valido";
                    ViewBag.ExceptionMsg = e;
                    return View("ReportesDeVenta");
                }
                
            }
            if (!string.IsNullOrEmpty(numagente))
            {
                try
                {
                    NumAgente = Int32.Parse(numagente);
                 
                }
                catch (Exception e)
                {
                    ViewBag.ModalTitleHeader = "¡Error en la busqueda!";
                    ViewBag.ModalTipo = "modal-danger";
                    ViewBag.Error = "El numero de Agente ingresado no es valido";
                    ViewBag.ExceptionMsg = e;
                    return View("ReportesDeVenta");
                }
            }

            if (!string.IsNullOrEmpty(estado))
            {
                try
                {
                    NumEstado = Int32.Parse(estado);

                }
                catch (Exception e)
                {
                    ViewBag.ModalTitleHeader = "¡Error en la busqueda!";
                    ViewBag.ModalTipo = "modal-danger";
                    ViewBag.Error = "El estado ingresado no es valido";
                    ViewBag.ExceptionMsg = e;
                    return View("ReportesDeVenta");
                }
            }

            if (!String.IsNullOrEmpty(pcontable))
            {
             
                string[] dia_mes_anio = pcontable.Split('/');
                var mes = dia_mes_anio[1].Trim();
                var anio = dia_mes_anio[2].Trim();
                var firstDay = DateTime.Parse("01/" + mes + "/" + anio);
                p_contable_ini = new DateTime(firstDay.Year, firstDay.Month, 1);
                p_contable_fin = p_contable_ini.AddMonths(1).AddDays(-1);
                                
            }
            /* Si todos los campos estan vacios establece la fecha actual*/
            if (String.IsNullOrEmpty(fecrep) && String.IsNullOrEmpty(numagente) && String.IsNullOrEmpty(reporte) && String.IsNullOrEmpty(pcontable) && String.IsNullOrEmpty(tventa))
            {
                condicionaFecha = 1;
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
                    condicionaFecha = 2;
                
            }
                        
            using (var db = new IngresosEntities())
            {
                try
                {
                    DateTime firstDayOfMonth = today.AddDays(1 - today.Day);
                    var query = from VC in db.VentasCabecera
                                join EST in db.EstadoRv on VC.Estado equals EST.Codigo
                                join AGT in db.Agentes on VC.Agente equals AGT.Codigo
                                
                                where
                                (
                                (condicionaFecha == 1) ? VC.FechaReporte >= dateini
                                && VC.FechaReporte <= datefin : true
                                )
                                where
                                (
                                (condicionaFecha == 2) ? VC.FechaReporte >= dateini
                                && VC.FechaReporte <= datefin : true
                                )
                                // where
                                //(
                                //(string.IsNullOrEmpty(pcontable) ? true : VC.FechaContable >= p_contable_ini
                                // && VC.FechaContable <= p_contable_fin)
                                //)

                                where
                               (
                               (string.IsNullOrEmpty(pcontable) ? true : VC.FechaContable >= p_contable_ini
                                && VC.FechaContable <= p_contable_fin)
                               )

                                //VC.FechaReporte >= new DateTime(2017, 1, 1)
                                where
                                (
                                (string.IsNullOrEmpty(numagente) ? true : VC.Agente == NumAgente)
                                
                                )
                                where
                               (
                               (string.IsNullOrEmpty(reporte) ? true : VC.Grupo == NumReporte)

                               )
                               where 
                               (
                               (string.IsNullOrEmpty(loc) ? true : AGT.Localidad == loc)
                               )
                                where
                                (
                                (string.IsNullOrEmpty(tventa) ? true : VC.Origen == tventa)
                                )
                                where
                                (
                                (string.IsNullOrEmpty(estado) ? true : EST.Codigo == NumEstado)
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
                     return View("ReportesDeVenta",query.ToList().OrderBy(g  => g.Grupo).Take(1500));
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