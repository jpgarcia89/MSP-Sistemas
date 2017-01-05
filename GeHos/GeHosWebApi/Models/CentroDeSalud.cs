//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CentroDeSalud
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CentroDeSalud()
        {
            this.CentroDeSaludConsultorio = new HashSet<CentroDeSaludConsultorio>();
            this.EmpleadoEspecialidadCentroDeSalud = new HashSet<EmpleadoEspecialidadCentroDeSalud>();
            this.Paciente = new HashSet<Paciente>();
        }
    
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> DepartamentoID { get; set; }
        public string Latitud { get; set; }
        public string Director { get; set; }
        public string Tipologia { get; set; }
        public string Telefono { get; set; }
        public string Longitud { get; set; }
        public string Domicilio { get; set; }
        public Nullable<int> Publico { get; set; }
        public Nullable<int> ZonaID { get; set; }
        public string CodBioestadistica { get; set; }
        public string CodRemediar { get; set; }
        public Nullable<int> CantVivienda { get; set; }
        public Nullable<int> CantVaron { get; set; }
        public Nullable<int> CantMujeres { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<short> AdministradorID { get; set; }
        public byte[] Password { get; set; }
        public Nullable<bool> RequiereHc { get; set; }
        public Nullable<bool> CargaDatosTurnosPasado { get; set; }
    
        public virtual Departamento Departamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CentroDeSaludConsultorio> CentroDeSaludConsultorio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoEspecialidadCentroDeSalud> EmpleadoEspecialidadCentroDeSalud { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paciente> Paciente { get; set; }
    }
}
