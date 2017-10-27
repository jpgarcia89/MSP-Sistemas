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
    
    public partial class CentroDeSalud
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CentroDeSalud()
        {
            this.EspecialidadPorCentroDeSalud = new HashSet<EspecialidadPorCentroDeSalud>();
            this.LineaColectivoPorCentroDeSalud = new HashSet<LineaColectivoPorCentroDeSalud>();
        }
    
        public short ID { get; set; }
        public string Nombre { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string EMail { get; set; }
        public string URLImagenDelCentroDeSalud { get; set; }
        public short LocalidadID { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaUltimaActualizacion { get; set; }
    
        public virtual Localidad Localidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EspecialidadPorCentroDeSalud> EspecialidadPorCentroDeSalud { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineaColectivoPorCentroDeSalud> LineaColectivoPorCentroDeSalud { get; set; }
    }
}
