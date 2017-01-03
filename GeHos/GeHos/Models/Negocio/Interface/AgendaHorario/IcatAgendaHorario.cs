/************************************************************************************************************
 * Descripción: Interfaz Entidad catAgendaHorario.
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
using System.Linq;
using System.Web;
using GeHos.Models.DB;
using Utiles.RespuestaGenerica;

namespace GeHos.Models
{
    interface IcatAgendaHorario : INegocio<catAgendaHorario>
    {
		    catAgendaHorarioVM TraerEntidad(object entidad);          

         CcatAgendaHorarioVM TraerEntidades(object parametros);  

			RespuestaGenerica AgregarEntidad(object entidad);  

			RespuestaGenerica ActualizarEntidad(object entidad);

			RespuestaGenerica RemoverEntidad(object entidad);   

		}
}
