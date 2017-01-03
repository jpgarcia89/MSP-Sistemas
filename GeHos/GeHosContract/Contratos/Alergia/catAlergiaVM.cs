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
using Utiles.ContratoBase;

namespace GeHosContract.Contrato
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
