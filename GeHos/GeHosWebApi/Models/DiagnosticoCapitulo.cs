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
    
    public partial class DiagnosticoCapitulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiagnosticoCapitulo()
        {
            this.DiagnosticoSubCapitulo = new HashSet<DiagnosticoSubCapitulo>();
        }
    
        public int ID { get; set; }
        public string CodigoInicial { get; set; }
        public string CodigoFinal { get; set; }
        public string Descripcion { get; set; }
        public byte DiagnosticoAgrupamientoID { get; set; }
    
        public virtual DiagnosticoAgrupamiento DiagnosticoAgrupamiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiagnosticoSubCapitulo> DiagnosticoSubCapitulo { get; set; }
    }
}
