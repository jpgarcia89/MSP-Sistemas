/************************************************************************************************************
 * Descripción: Clase catAlergiaVM.
 * Observaciones: 
 * Creado por: MC.
 * Historial de Revisiones:
 * -----------------------------------------------------------------------------------------------
 * Fecha        Evento / Método Autor   Descripción
 * -----------------------------------------------------------------------------------------------
 * 07/12/2016					Implementación inicial.
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

namespace GeHos.Models
{
    public class catAlergiaVM : ContratoBase
    {
        #region Atributos
        short AalId;
        string AalNombre;
        bool AalEsMedicamento;
        #endregion Atributos

        #region Propiedades - Get/Set

         public short alId
         {
             get { return AalId; }
             set { AalId = value; }
         }
         public string alNombre
         {
             get { return AalNombre; }
             set { AalNombre = value; }
         }
         public bool alEsMedicamento
         {
             get { return AalEsMedicamento; }
             set { AalEsMedicamento = value; }
         }

        #endregion Propiedaddes - Get/Set

    }
}
