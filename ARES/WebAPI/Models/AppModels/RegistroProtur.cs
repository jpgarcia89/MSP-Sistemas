using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class RegistroProtur
    {   
        /////////////////////////////
        //datos del centro de salud//
        /////////////////////////////
        
        //timestamp
        public long TS { get; set; }

        //centro de salud que carga
        public string CS { get; set; }

        //protur que carga
        public string PT { get; set; }

        //fecha de gestion del turno
        public DateTime DC { get; set; }


        ///////////////////////
        //datos del paciente//
        //////////////////////

        //nombre del paciente
        public string PN { get; set; }

        //sexo del paciente
        public string SP { get; set; }

        //fecha de nacimiento del paciente
        public DateTime NP { get; set; }

        //edad del paciente
        public string EP { get; set; }

        //DNI del paciente
        public string DP { get; set; }

        //pueblo originario del paciente
        public string PO { get; set; }

        //obra social del paciente
        public string OS { get; set; }

        //teléfono del paciente
        public string TP { get; set; }

        //Departamento del paciente
        public string PD { get; set; }

        //domicilio del paciente
        public string DO { get; set; }


        //////////////////////////////
        //datos del origen del turno//
        //////////////////////////////

        //especialidad que solicita
        public string ET { get; set; }

        //tipo de turno
        public string TT { get; set; }

        //medio de la solicitud
        public string MT { get; set; }

        //centro de salud de donde viene
        public string CT { get; set; }
        
        //turno atendido
        public string TA { get; set; }

        //datos de estado del turno
        //programado
        public string PE { get; set; }

        //caps donde se programa
        public string PC { get; set; }

        //fecha en la que se programa
        public DateTime FP { get; set; }

        //motivo por el que no se programa
        public string PM { get; set; }


        public string _id { get; set; }
        

    }
}