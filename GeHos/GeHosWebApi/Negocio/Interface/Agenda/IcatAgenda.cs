using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utiles.RespuestaGenerica;
using GeHosWebApi.Models;
using GeHosContract.Contrato;

namespace GeHosWebApi
{
    interface IcatAgenda : INegocio<catAgenda>
    {
        catAgendaVM TraerEntidad(object entidad);

        CcatAgendaVM TraerEntidades(object parametros);

        RespuestaGenerica AgregarEntidad(object entidad);

        RespuestaGenerica ActualizarEntidad(object entidad);

        RespuestaGenerica RemoverEntidad(object entidad);
    }
}