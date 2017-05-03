//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class CertificadoEstablecimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CertificadoEstablecimiento()
        {
            this.Certificado = new HashSet<Certificado>();
        }

        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [ScaffoldColumn(true)]
        [DisplayName("Tipo de Establecimiento")]
        [Required()]
        public int IdTipoEstablecimiento { get; set; }

        [ScaffoldColumn(true)]
        [DisplayName("Denominacion")]
        [Required(AllowEmptyStrings = false)]
        public string Denominacion { get; set; }

        [ScaffoldColumn(false)]
        [Required()]
        public System.DateTime FechaAlta { get; set; }

        [ScaffoldColumn(false)]
        public string IdUsuarioAlta { get; set; }

        [ScaffoldColumn(true)]
        [DisplayName("Activo")]
        public bool Activo { get; set; }

        [ScaffoldColumn(true)]
        [DisplayName("Domicilio del Establecimiento")]
        public string Domicilio { get; set; }

        [ScaffoldColumn(true)]
        [DisplayName("Depto del Establecimiento")]
        public string DomicilioDepto { get; set; }

        [ScaffoldColumn(true)]
        [DisplayName("Firma")]
        [Required(AllowEmptyStrings = false)]
        public string Firma { get; set; }

        [ScaffoldColumn(true)]
        [DisplayName("Direccion de la Firma")]
        public string FirmaDireccion { get; set; }

        [ScaffoldColumn(true)]
        [DisplayName("Depto de la Firma")]
        public string FirmaDepto { get; set; }

        [ScaffoldColumn(true)]
        [DisplayName("DNI de la Firma")]
        public string FirmaDni { get; set; }
        

        public virtual AspNetUsers AspNetUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Certificado> Certificado { get; set; }
        public virtual TipoCertificadoEstablecimiento TipoCertificadoEstablecimiento { get; set; }
    }
}
