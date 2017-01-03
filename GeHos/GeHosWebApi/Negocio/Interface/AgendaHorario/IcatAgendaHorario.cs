using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utiles.RespuestaGenerica;
using GeHosWebApi.Models;
using GeHosContract.Contrato;

namespace GeHosWebApi
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
