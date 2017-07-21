using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MSP_RegProf.Models
{
    [MetadataType(typeof(MatriculaMetadata))]
    public partial class Matricula
    {
    }

    public class MatriculaMetadata
    {
        /// <summary>
        /// Valida Datos Personales
        /// </summary>
                
        public Nullable<bool> Revalido
        {
            get { return Revalido ?? false; }
            set { Revalido = value; }
        }



        /// <summary>
        /// Sin Validar
        /// </summary>
        public int ID { get; set; }
        public int PersonaID { get; set; }
        public int TituloID { get; set; }
        public int OrganismoID { get; set; }
        
        public Nullable<System.DateTime> FechaDiploma { get; set; }
        public string ObservacionDiploma { get; set; }
        public Nullable<System.DateTime> FechaInscripcion { get; set; }
        public int NroMatricula { get; set; }
        public string Folio { get; set; }
        public string libro { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
        public bool Habilitada { get; set; }
        public byte TipoEstadoMatriculaID { get; set; }
        public bool Retirado { get; set; }
        public Nullable<System.DateTime> FechaRetiro { get; set; }
        public string ObservacionMatricula { get; set; }
        public bool TieneAnalitico { get; set; }
        public bool TieneTitulo { get; set; }

        public virtual Organismo Organismo { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual TipoEstadoMatricula TipoEstadoMatricula { get; set; }
        public virtual Titulo Titulo { get; set; }

    }
}