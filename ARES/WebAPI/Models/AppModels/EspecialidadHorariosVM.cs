using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{

    public class CentroDeSaludEspecialidadHorariosVM
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public List<EspecialidadHorariosVM> EspecialidadHorarios { get; set; }

    }

    public class EspecialidadHorariosVM
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public List<HorariosVM> Horarios { get; set; }

    }

    public class HorariosVM
    {
        //public int ID { get; set; }

        public string HorarioEntrada { get; set; }

        public string HorarioSalida { get; set; }

        public string Dia { get; set; }       

    }
}