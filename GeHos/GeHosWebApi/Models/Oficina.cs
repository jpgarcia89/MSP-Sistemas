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
    
    public partial class Oficina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oficina()
        {
            this.EmpleadoPlantaPermanente = new HashSet<EmpleadoPlantaPermanente>();
        }
    
        public short ID { get; set; }
        public short Codigo { get; set; }
        public string Nombre { get; set; }
        public Nullable<byte> ReparticionID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoPlantaPermanente> EmpleadoPlantaPermanente { get; set; }
        public virtual Reparticion Reparticion { get; set; }
    }
}
