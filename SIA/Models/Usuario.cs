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
    using System.ComponentModel.DataAnnotations;
    
    public partial class Usuario
    {
        [Required]
        [Display(Name = "USUARIO")]
        public string IdUsuario { get; set; }
        public Nullable<bool> Inactivo { get; set; }
        public Nullable<short> IdTipo { get; set; }
        public string UserNombre { get; set; }
        public string UserClave { get; set; }
        [Required]  
        [Display(Name = "CONSTRASEÑA")]
        public string UserPass { get; set; }
        public Nullable<System.DateTime> UserFecha { get; set; }
        public string UserLoc { get; set; }
        public Nullable<int> UserAge { get; set; }
        public string UserNom { get; set; }
        public string UserApe { get; set; }
        public string UserCar { get; set; }
        public string UserAre { get; set; }
        public Nullable<bool> LockLoc { get; set; }
        public Nullable<bool> LockAge { get; set; }
        public string UsuarioReg { get; set; }
        public Nullable<System.DateTime> FechaReg { get; set; }
        public string UsuarioMod { get; set; }
        public Nullable<System.DateTime> FechaMod { get; set; }
        public string Notas { get; set; }
        public string Clave { get; set; }
        public Nullable<int> IdTipoUsuario { get; set; }
        public bool swAcceso { get; set; }
        public string MensajeError { get; set; }
    }
}
