/************************************************************************************************************
 * Descripción: Clase Contrato catAgendaVM.
 * Observaciones: 
 * Creado por: mc.
 * Historial de Revisiones:
 * -----------------------------------------------------------------------------------------------
 * Fecha        Evento / Método Autor   Descripción
 * -----------------------------------------------------------------------------------------------
 * 05/12/2016					Implementación inicial.
 * -----------------------------------------------------------------------------------------------
*/
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Utiles.ContratoBase;

namespace GeHosContract.Contrato
{
    public class catAgendaVM : ContratoBase
    {
        #region Atributos
        int Aid;
        int AagId;
        int? AperId;
        string AperApellidoNombre;
        int? AconId;
        int AcsId;
        string AcsNombre;
        short AespId;
        string AespNombre;
        short AagDuracion;
        short AagSobreturnos;
        bool AagActivo;
        short AagEstado;
        #endregion Atributos

        #region Propiedades - Get/Set
        public int Id
        {
            get { return Aid; }
            set { Aid = value; }
        }
        [ScaffoldColumn(false)]
        public int agId
        {
            get { return AagId; }
            set { AagId = value; }
        }
        [ScaffoldColumn(false)]
        public int? perId
        {
            get { return AperId; }
            set { AperId = value; }
        }
        [ScaffoldColumn(true)]
        [DisplayName("Especialista")]
        public string perApellidoNombre
        {
            get { return AperApellidoNombre; }
            set { AperApellidoNombre = value; }
        }
        [ScaffoldColumn(false)]
        public int? conId
        {
            get { return AconId; }
            set { AconId = value; }
        }
        [ScaffoldColumn(false)]
        public int csId
        {
            get { return AcsId; }
            set { AcsId = value; }
        }
        [DisplayName("Centro de Salud")]
        [ScaffoldColumn(true)]
        public string csNombre
        {
            get { return AcsNombre; }
            set { AcsNombre = value; }
        }
        [ScaffoldColumn(false)]
        public short espId
        {
            get { return AespId; }
            set { AespId = value; }
        }
        [DisplayName("Especialidad")]
        [ScaffoldColumn(true)]
        public string espNombre
        {
            get { return AespNombre; }
            set { AespNombre = value; }
        }
        [DisplayName("Duración")]
        [ScaffoldColumn(true)]
        public short agDuracion
        {
            get { return AagDuracion; }
            set { AagDuracion = value; }
        }
        [ScaffoldColumn(false)]
        public short agSobreturnos
        {
            get { return AagSobreturnos; }
            set { AagSobreturnos = value; }
        }
        [ScaffoldColumn(false)]
        public bool agActivo
        {
            get { return AagActivo; }
            set { AagActivo = value; }
        }
        [ScaffoldColumn(false)]
        public short agEstado
        {
            get { return AagEstado; }
            set { AagEstado = value; }
        }

        #endregion Propiedaddes - Get/Set

    }
}
