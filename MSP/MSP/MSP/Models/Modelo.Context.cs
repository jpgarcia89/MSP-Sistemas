﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSP.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MSPEntities : DbContext
    {
        public MSPEntities()
            : base("name=MSPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Certificado> Certificado { get; set; }
        public virtual DbSet<CertificadoEstablecimiento> CertificadoEstablecimiento { get; set; }
        public virtual DbSet<TipoCertificado> TipoCertificado { get; set; }
        public virtual DbSet<TipoCertificadoEstablecimiento> TipoCertificadoEstablecimiento { get; set; }
        public virtual DbSet<CertificadoEstablecimentoItem> CertificadoEstablecimentoItem { get; set; }
    }
}