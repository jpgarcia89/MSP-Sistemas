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
    
    public partial class Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menu()
        {
            this.Menu1 = new HashSet<Menu>();
        }
    
        public int ID { get; set; }
        public Nullable<int> PadreID { get; set; }
        public string Nombre { get; set; }
        public Nullable<byte> Orden { get; set; }
        public string Icono { get; set; }
        public string Accion { get; set; }
        public string Controlador { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> mnuId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menu1 { get; set; }
        public virtual Menu Menu2 { get; set; }
    }
}
