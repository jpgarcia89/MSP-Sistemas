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
    
    public partial class Resolucion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resolucion()
        {
            this.GradosDesignacion = new HashSet<GradosDesignacion>();
        }
    
        public long ID { get; set; }
        public Nullable<short> Numero { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public string Considerando { get; set; }
        public string Resuelve { get; set; }
        public string EnlaceArchivo { get; set; }
        public bool EsImportante { get; set; }
        public Nullable<System.DateTime> NotificacionVencimiento { get; set; }
        public Nullable<short> NotificacionDiaInicio { get; set; }
        public Nullable<int> TipoNormaLegalID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GradosDesignacion> GradosDesignacion { get; set; }
        public virtual TipoNormaLegal TipoNormaLegal { get; set; }
    }
}