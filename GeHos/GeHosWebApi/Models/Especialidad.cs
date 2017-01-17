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
    
    public partial class Especialidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Especialidad()
        {
            this.Agenda = new HashSet<Agenda>();
            this.CentroDeSaludEspecialidad = new HashSet<CentroDeSaludEspecialidad>();
            this.EmpleadoEspecialidad = new HashSet<EmpleadoEspecialidad>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Nullable<short> IdPadre { get; set; }
        public string Codigo { get; set; }
        public string DescripcionPlanilla { get; set; }
        public string Abreviatura { get; set; }
        public int IdMHO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agenda> Agenda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CentroDeSaludEspecialidad> CentroDeSaludEspecialidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoEspecialidad> EmpleadoEspecialidad { get; set; }
    }
}
