﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IngresosEntities : DbContext
    {
        public IngresosEntities()
            : base("name=IngresosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Agentes> Agentes { get; set; }
        public virtual DbSet<AgentesCuentas> AgentesCuentas { get; set; }
        public virtual DbSet<AgentesMaster> AgentesMaster { get; set; }
        public virtual DbSet<AgentesTarjetas> AgentesTarjetas { get; set; }
        public virtual DbSet<AgentesTmp> AgentesTmp { get; set; }
        public virtual DbSet<TipoAgencia> TipoAgencia { get; set; }
        public virtual DbSet<TipoAgente> TipoAgente { get; set; }
        public virtual DbSet<Vuelos> Vuelos { get; set; }
        public virtual DbSet<VentasBoletos> VentasBoletos { get; set; }
        public virtual DbSet<VentasCabecera> VentasCabecera { get; set; }
        public virtual DbSet<VentasCabecera_Log> VentasCabecera_Log { get; set; }
        public virtual DbSet<VentasCabeceraNotas> VentasCabeceraNotas { get; set; }
        public virtual DbSet<VentasCabeceraTotales> VentasCabeceraTotales { get; set; }
    }
}
