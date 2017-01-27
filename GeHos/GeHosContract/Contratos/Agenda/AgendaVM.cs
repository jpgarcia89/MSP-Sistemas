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
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Utiles.ContratoBase;

namespace GeHosContract.Contrato
{
    public class AgendaVM
    {
        #region Atributos
        int AID;
        int AEmpleadoEspecialidadCentroDeSaludID;
        int ACentroDeSaludID;
        string ACentroDeSaludNombre;
        int AEspecialidadID;
        string AEspecialidadNombre;
        bool AActiva;
        DateTime AFechaDesde;
        DateTime AFechaHasta;
        #endregion Atributos

        #region Propiedades - Get/Set
        [ScaffoldColumn(false)]
        public int ID
        {
            get { return AID; }
            set { AID = value; }
        }

        [ScaffoldColumn(false)]
        public int EmpleadoEspecialidadCentroDeSaludID
        {
            get { return AEmpleadoEspecialidadCentroDeSaludID; }
            set { AEmpleadoEspecialidadCentroDeSaludID = value; }
        }

        [ScaffoldColumn(false)]
        public int CentroDeSaludID
        {
            get { return ACentroDeSaludID; }
            set { ACentroDeSaludID = value; }
        }

        [DisplayName("Centro de Salud")]
        [ScaffoldColumn(true)]
        public string CentroDeSaludNombre
        {
            get { return ACentroDeSaludNombre; }
            set { ACentroDeSaludNombre = value; }
        }

        [ScaffoldColumn(false)]
        public int EspecialidadID
        {
            get { return AEspecialidadID; }
            set { AEspecialidadID = value; }
        }

        [DisplayName("Especialidad")]
        [ScaffoldColumn(true)]
        public string EspecialidadNombre
        {
            get { return AEspecialidadNombre; }
            set { AEspecialidadNombre = value; }
        }
                
        [ScaffoldColumn(false)]
        public bool Activa
        {
            get { return AActiva; }
            set { AActiva = value; }
        }

        [ScaffoldColumn(true)]
        [DisplayName("Desde")]
        public DateTime FechaDesde
        {
            get { return AFechaDesde; }
            set { AFechaDesde = value; }
        }

        [ScaffoldColumn(true)]
        [DisplayName("Hasta")]
        public DateTime FechaHasta
        {
            get { return AFechaHasta; }
            set { AFechaHasta = value; }
        }

        #endregion Propiedaddes - Get/Set

    }
}
