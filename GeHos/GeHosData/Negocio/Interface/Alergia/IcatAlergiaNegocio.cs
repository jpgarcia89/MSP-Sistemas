using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utiles.RespuestaGenerica;
using GeHosData.DB;
using GeHosContract.Contrato;

namespace GeHosData
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
