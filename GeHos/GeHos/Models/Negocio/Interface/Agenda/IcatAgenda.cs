using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeHos.Models.DB;
using Utiles.RespuestaGenerica;

namespace GeHos.Models
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