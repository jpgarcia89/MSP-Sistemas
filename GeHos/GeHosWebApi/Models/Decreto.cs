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
    
    public partial class Decreto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Decreto()
        {
            this.GradosDesignacion = new HashSet<GradosDesignacion>();
        }
    
        public long ID { get; set; }
        public Nullable<short> Numero { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public string Considerando { get; set; }
        public string Resuelve { get; set; }
        public string EnlaceArchivo { get; set; }
        public bool EsAcuerdo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GradosDesignacion> GradosDesignacion { get; set; }
    }
}