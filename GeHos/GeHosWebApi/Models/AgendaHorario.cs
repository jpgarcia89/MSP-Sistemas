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
    
    public partial class AgendaHorario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgendaHorario()
        {
            this.Turno = new HashSet<Turno>();
        }
    
        public int ID { get; set; }
        public int AgendaID { get; set; }
        public System.DateTime Dia { get; set; }
        public System.TimeSpan HoraDesde { get; set; }
        public System.TimeSpan HoraHasta { get; set; }
        public bool Activa { get; set; }
        public int AgendaTipoID { get; set; }
        public int CantidadDeTurnos { get; set; }
    
        public virtual Agenda Agenda { get; set; }
        public virtual AgendaTipo AgendaTipo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turno> Turno { get; set; }
    }
}