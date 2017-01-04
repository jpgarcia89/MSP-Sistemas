﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeHosWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<AgendaHorario> AgendaHorario { get; set; }
        public virtual DbSet<AgendaTipo> AgendaTipo { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<CentroDeSalud> CentroDeSalud { get; set; }
        public virtual DbSet<CentroDeSaludConsultorio> CentroDeSaludConsultorio { get; set; }
        public virtual DbSet<CuentaEscritural> CuentaEscritural { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<EmpleadoContratado> EmpleadoContratado { get; set; }
        public virtual DbSet<EmpleadoEspecialidadCentroDeSalud> EmpleadoEspecialidadCentroDeSalud { get; set; }
        public virtual DbSet<EmpleadoPlantaPermanente> EmpleadoPlantaPermanente { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Fuente> Fuente { get; set; }
        public virtual DbSet<GrupoSanguineo> GrupoSanguineo { get; set; }
        public virtual DbSet<InstitucionContable> InstitucionContable { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<ObraSocial> ObraSocial { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
        public virtual DbSet<TurnoEstado> TurnoEstado { get; set; }
        public virtual DbSet<TurnoEstadoAdmision> TurnoEstadoAdmision { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<TipoDNI> TipoDNI { get; set; }
    }
}
