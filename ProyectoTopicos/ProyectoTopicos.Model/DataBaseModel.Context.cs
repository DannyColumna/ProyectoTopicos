﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTopicos.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TopicosSelectosEntities : DbContext
    {
        public TopicosSelectosEntities()
            : base("name=TopicosSelectosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<CategoriasArticulos> CategoriasArticulos { get; set; }
        public virtual DbSet<RegistroDePerdidas> RegistroDePerdidas { get; set; }
        public virtual DbSet<SubCategoriasArticulos> SubCategoriasArticulos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
