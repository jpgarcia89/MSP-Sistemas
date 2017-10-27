﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSP_RegProf.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
        public virtual DbSet<CarreraMatriculada> CarreraMatriculada { get; set; }
        public virtual DbSet<CentroDeSalud> CentroDeSalud { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<EspecialidadPorCentroDeSalud> EspecialidadPorCentroDeSalud { get; set; }
        public virtual DbSet<Horarios> Horarios { get; set; }
        public virtual DbSet<HorariosPorEspecialidadPorCentroDeSalud> HorariosPorEspecialidadPorCentroDeSalud { get; set; }
        public virtual DbSet<LineaColectivo> LineaColectivo { get; set; }
        public virtual DbSet<LineaColectivoPorCentroDeSalud> LineaColectivoPorCentroDeSalud { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Matricula> Matricula { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Organismo> Organismo { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<ProturEncuestador> ProturEncuestador { get; set; }
        public virtual DbSet<ProturEquivalenciasCaps> ProturEquivalenciasCaps { get; set; }
        public virtual DbSet<ProturEquivalenciasDepartamentos> ProturEquivalenciasDepartamentos { get; set; }
        public virtual DbSet<ProturMedios> ProturMedios { get; set; }
        public virtual DbSet<ProturMotivos> ProturMotivos { get; set; }
        public virtual DbSet<ProturObrasSociales> ProturObrasSociales { get; set; }
        public virtual DbSet<ProturPueblosOriginarios> ProturPueblosOriginarios { get; set; }
        public virtual DbSet<ProturRegistros> ProturRegistros { get; set; }
        public virtual DbSet<ProturTipoDeTurno> ProturTipoDeTurno { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<RegistroActualizacionTablas> RegistroActualizacionTablas { get; set; }
        public virtual DbSet<TipoDNI> TipoDNI { get; set; }
        public virtual DbSet<TipoEstadoCivil> TipoEstadoCivil { get; set; }
        public virtual DbSet<TipoEstadoMatricula> TipoEstadoMatricula { get; set; }
        public virtual DbSet<TipoEstadoProfesion> TipoEstadoProfesion { get; set; }
        public virtual DbSet<TipoFormacion> TipoFormacion { get; set; }
        public virtual DbSet<TipoNivelAcademico> TipoNivelAcademico { get; set; }
        public virtual DbSet<TipoSexo> TipoSexo { get; set; }
        public virtual DbSet<Titulo> Titulo { get; set; }
        public virtual DbSet<AsignacionTipo> AsignacionTipo { get; set; }
        public virtual DbSet<SolicitudProtur> SolicitudProtur { get; set; }
        public virtual DbSet<Accion> Accion { get; set; }
        public virtual DbSet<MenuAspNetRoles> MenuAspNetRoles { get; set; }
        public virtual DbSet<MenuAspNetRolesAccion> MenuAspNetRolesAccion { get; set; }
    
        public virtual ObjectResult<GetPermisosPorNombreDeUsuario_Result> GetPermisosPorNombreDeUsuario(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPermisosPorNombreDeUsuario_Result>("GetPermisosPorNombreDeUsuario", userNameParameter);
        }
    }
}
