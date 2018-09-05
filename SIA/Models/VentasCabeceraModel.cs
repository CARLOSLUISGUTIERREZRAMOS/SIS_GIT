using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIA.Models
{
    public class VentasCabeceraModel
    {
      
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public int Grupo { get; set; }
        [Display(Name = "Loc")]
        public string Localidad { get; set; }
        public Nullable<int> Agente { get; set; }
        [Display(Name ="Nombre")]
        public string NombreAgente { get; set; }
        [Display(Name = "Fec Rep")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaReporte { get; set; }
        [Display(Name = "Tkts")]
        public Nullable<int> NroTkts { get; set; }
        public Nullable<decimal> Tarifa { get; set; }
        [Display(Name = "IGV")]
        public Nullable<decimal> IgvTarifa { get; set; }
        [Display(Name = "Otros Ing.")]
        public Nullable<decimal> OtrosIngresos { get; set; }
        [Display(Name = "Otros Imp.")]
        public Nullable<decimal> OtrosImp { get; set; }
        [Display(Name = "Comm")]
        public Nullable<decimal> Comision { get; set; }
        [Display(Name = "IGV Com")]
        public Nullable<decimal> IgvComision { get; set; }
        [Display(Name = "Neto")]
        public Nullable<decimal> Neto { get; set; }
        public Nullable<decimal> Contado { get; set; }
        public Nullable<decimal> Credito { get; set; }
        [Display(Name = "Cta Cje")]
        public Nullable<decimal> OtrosCargos { get; set; }
        [Display(Name = "Usuario")]
        public string UsuarioReg { get; set; }
        [Display(Name = "Saldo ")]
        public Nullable<decimal> SaldoDepo { get; set; }
        public Nullable<decimal> SaldoFactu { get; set; }
        public Nullable<decimal> SaldoFinal { get; set; }
        public string Remark { get; set; }

    }
}