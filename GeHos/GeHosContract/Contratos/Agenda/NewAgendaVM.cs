using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeHosContract.Contrato
{
    public class NewAgendaVM
    {
        public int EmpleadoID { get; set; }//ProfesionalID

        public int EspecialidadID { get; set; }

        public int CentroDeSaludID { get; set; }        

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public List<RangoHorarioVM> RangosHorarios { get; set; }


        /// <summary>
        /// Campos a agregar por Marcelo
        /// </summary>
        public int EmpleadoCreaID { get; set; }
        public DateTime FechaCrea { get; set; }

        public int EmpleadoModificaID { get; set; }
        public DateTime FechaModifica { get; set; }
    }

    public class RangoHorarioVM
    {
        public int ID { get; set; }

        public List<int> Dias { get; set; }

        public int AgendaTipoID { get; set; }

        public int DuracionDeTurnos { get; set; }

        [DataType(DataType.Time)]
        public DateTime HoraDesde { get; set; }

        [DataType(DataType.Time)]
        public DateTime HoraHasta { get; set; }

    }
    
}
