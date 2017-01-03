using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utiles.RespuestaGenerica;
using GeHosData.DB;
using GeHosContract.Contrato;

namespace GeHosData
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