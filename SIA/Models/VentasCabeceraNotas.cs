//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VentasCabeceraNotas
    {
        public int Grupo { get; set; }
        public int Codigo { get; set; }
        public string Nota { get; set; }
        public string UsuarioReg { get; set; }
        public Nullable<System.DateTime> FechaReg { get; set; }
        public string systemuser { get; set; }
        public string systempc { get; set; }
    
        public virtual VentasCabecera VentasCabecera { get; set; }
    }
}
