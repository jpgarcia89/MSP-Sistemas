using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utiles.RespuestaGenerica;
using GeHosWebApi.Models;
using GeHosContract.Contrato;

namespace GeHosWebApi
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
