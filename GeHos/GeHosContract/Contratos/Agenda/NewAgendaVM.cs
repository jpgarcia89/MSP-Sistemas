using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeHosContract.Contratos.Agenda
{
    public class NewAgendaVM
    {
        public int ProfesionalID { get; set; }

        public int EspecialidadID { get; set; }

        public DateTime fechaDesde { get; set; }

        public DateTime fechaHasta { get; set; }

        public List<RangoHorarioVM> RangosHorarios { get; set; }
    }

    public class RangoHorarioVM
    {
        public int ID { get; set; }

        public List<int> dias { get; set; }

        [DataType(DataType.Time)]
        public DateTime horaDesde { get; set; }

        [DataType(DataType.Time)]
        public DateTime horaHasta { get; set; }

    }
    
}
