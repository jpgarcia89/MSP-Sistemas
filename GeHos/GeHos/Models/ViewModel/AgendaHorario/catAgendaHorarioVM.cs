/************************************************************************************************************
 * Descripción: Clase catAgendaHorarioVM.
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
    public class catAgendaHorarioVM : ContratoBase
    {
        #region Atributos
        int AaghId;
        string AaghDiaSemana;
        string AaghHoraInicio;
        string AaghMinutoInicio;
        string AaghHoraFin;
        string AaghMinutoFin;
        DateTime AaghVigenciaDesde;
        DateTime AaghVigenciaHasta;
        int AagId;
        bool AaghActivo;
        int? AaghCantTurnos;
        int? AaghSobreturnos;
        short AaghTipoAgenda;
        #endregion Atributos

        #region Propiedades - Get/Set

         public int aghId
         {
             get { return AaghId; }
             set { AaghId = value; }
         }
         public string aghDiaSemana
         {
             get { return AaghDiaSemana; }
             set { AaghDiaSemana = value; }
         }
         public string aghHoraInicio
         {
             get { return AaghHoraInicio; }
             set { AaghHoraInicio = value; }
         }
         public string aghMinutoInicio
         {
             get { return AaghMinutoInicio; }
             set { AaghMinutoInicio = value; }
         }
         public string aghHoraFin
         {
             get { return AaghHoraFin; }
             set { AaghHoraFin = value; }
         }
         public string aghMinutoFin
         {
             get { return AaghMinutoFin; }
             set { AaghMinutoFin = value; }
         }
         public DateTime aghVigenciaDesde
         {
             get { return AaghVigenciaDesde; }
             set { AaghVigenciaDesde = value; }
         }
         public DateTime aghVigenciaHasta
         {
             get { return AaghVigenciaHasta; }
             set { AaghVigenciaHasta = value; }
         }
         public int agId
         {
             get { return AagId; }
             set { AagId = value; }
         }
         public bool aghActivo
         {
             get { return AaghActivo; }
             set { AaghActivo = value; }
         }
         public int? aghCantTurnos
         {
             get { return AaghCantTurnos; }
             set { AaghCantTurnos = value; }
         }
         public int? aghSobreturnos
         {
             get { return AaghSobreturnos; }
             set { AaghSobreturnos = value; }
         }
         public short aghTipoAgenda
         {
             get { return AaghTipoAgenda; }
             set { AaghTipoAgenda = value; }
         }

        #endregion Propiedaddes - Get/Set

    }
}
