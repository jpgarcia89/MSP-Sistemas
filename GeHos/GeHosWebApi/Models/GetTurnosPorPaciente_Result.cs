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
    
    public partial class GetTurnosPorPaciente_Result
    {
        public long ID { get; set; }
        public Nullable<long> PacienteID { get; set; }
        public int AgendaHorarioID { get; set; }
        public System.DateTime FechaTurno { get; set; }
        public byte TurnoEstadoID { get; set; }
        public string EstadoTurno { get; set; }
        public byte TurnoEstadoAdmisionID { get; set; }
        public string EstadoAdmision { get; set; }
        public Nullable<bool> EsSobreturno { get; set; }
        public Nullable<System.DateTime> FechaAdmision { get; set; }
        public Nullable<System.DateTime> FechaInicioAtencion { get; set; }
        public Nullable<System.DateTime> FechaFinAtencion { get; set; }
        public Nullable<bool> EsPrioritario { get; set; }
        public Nullable<int> BloqueoMasivoID { get; set; }
        public Nullable<bool> EsProgramado { get; set; }
        public Nullable<int> CentroDeSaludID { get; set; }
        public string CentroDeSalud { get; set; }
        public Nullable<int> EspecialidadID { get; set; }
        public string Especialidad { get; set; }
        public int EmpleadoID { get; set; }
        public string Especialista { get; set; }
    }
}
