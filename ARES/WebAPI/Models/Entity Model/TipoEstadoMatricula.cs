//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models.Entity_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoEstadoMatricula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoEstadoMatricula()
        {
            this.Matricula = new HashSet<Matricula>();
        }
    
        public byte ID { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitada { get; set; }
        public bool PermiteCambio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matricula> Matricula { get; set; }
    }
}
