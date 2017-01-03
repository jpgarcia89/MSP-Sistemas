/************************************************************************************************************
 * Descripción: Interfaz Entidad catAlergia.
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
    interface IcatAlergia : INegocio<catAlergia>
    {
		    catAlergiaVM TraerEntidad(object entidad);          

         CcatAlergiaVM TraerEntidades(object parametros);  

			RespuestaGenerica AgregarEntidad(object entidad);  

			RespuestaGenerica ActualizarEntidad(object entidad);

			RespuestaGenerica RemoverEntidad(object entidad);   

		}
}
