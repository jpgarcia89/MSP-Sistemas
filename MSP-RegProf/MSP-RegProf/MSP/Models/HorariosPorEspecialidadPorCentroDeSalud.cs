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
    
    public partial class HorariosPorEspecialidadPorCentroDeSalud
    {
        public int ID { get; set; }
        public short HorarioIDEntrada { get; set; }
        public short HorarioIDSalida { get; set; }
        public int EspecialidadPorCentroDeSaludID { get; set; }
        public byte Dia { get; set; }
        public bool Activo { get; set; }
    
        public virtual EspecialidadPorCentroDeSalud EspecialidadPorCentroDeSalud { get; set; }
        public virtual Horarios Horarios { get; set; }
        public virtual Horarios Horarios1 { get; set; }
    }
}