//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Organismo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organismo()
        {
            this.Matricula = new HashSet<Matricula>();
        }
    
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public byte ProvinciaID { get; set; }
        public int id_access { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matricula> Matricula { get; set; }
        public virtual Provincia Provincia { get; set; }
    }
}
