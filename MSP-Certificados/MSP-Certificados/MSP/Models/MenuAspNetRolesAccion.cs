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
    
    public partial class MenuAspNetRolesAccion
    {
        public int ID { get; set; }
        public int AccionId { get; set; }
        public int MenuAspNetRolesId { get; set; }
    
        public virtual Accion Accion { get; set; }
        public virtual MenuAspNetRoles MenuAspNetRoles { get; set; }
    }
}