/************************************************************************************************************
 * Descripción: Clase catPersonaVM.
 * Observaciones: 
 * Creado por: MC.
 * Historial de Revisiones:
 * -----------------------------------------------------------------------------------------------
 * Fecha        Evento / Método Autor   Descripción
 * -----------------------------------------------------------------------------------------------
 * 28/12/2016					Implementación inicial.
 * -----------------------------------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Utiles.ContratoBase;

namespace GeHosContract.Contrato
{
    public class EspecialistaVM 
    {
        #region Atributos
        private int AEmpleadoID;
        private string ANombre;
        private string AAperllido;
        private string ANombreCompleto;

        public string NombreCompleto
        {
            get { return ANombreCompleto; }
            set { ANombreCompleto = value; }
        }


        #endregion Atributos



        #region Propiedades - Get/Set
        public int EmpleadoID
        {
            get { return AEmpleadoID; }
            set { AEmpleadoID = value; }
        }

        public string Nombre
        {
            get { return ANombre; }
            set { ANombre = value; }
        }
        #endregion Propiedaddes - Get/Set

        public string Aperllido
        {
            get { return AAperllido; }
            set { AAperllido = value; }
        }
    }
}
