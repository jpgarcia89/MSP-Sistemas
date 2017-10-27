//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSP_Certificados.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Certificado
    {
        public int ID { get; set; }
        public int IdEstablecimiento { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public System.DateTime FechaDesde { get; set; }
        public System.DateTime FechaHasta { get; set; }
        public string NroExpediente { get; set; }
        public int IdCertificadoTipo { get; set; }
        public string IdUsuarioEmite { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual CertificadoEstablecimiento CertificadoEstablecimiento { get; set; }
        public virtual TipoCertificado TipoCertificado { get; set; }
    }
}
