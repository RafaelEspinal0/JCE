﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JCE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JCEEntities : DbContext
    {
        public JCEEntities()
            : base("name=JCEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cedula> cedula { get; set; }
        public virtual DbSet<Colegio> Colegio { get; set; }
        public virtual DbSet<municipio> municipio { get; set; }
        public virtual DbSet<nacionalidad> nacionalidad { get; set; }
        public virtual DbSet<ocupacion> ocupacion { get; set; }
        public virtual DbSet<provincia> provincia { get; set; }
        public virtual DbSet<recinto> recinto { get; set; }
        public virtual DbSet<sector> sector { get; set; }
    }
}
