using Microsoft.ApplicationInsights.Extensibility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebAPI.Controllers.AppControllers
{
    [RoutePrefix("api/MilDias")]
    public class MilDiasController : ApiController
    {

        [Route("Prueba")]
        [ResponseType(typeof(Boolean))]
        public IHttpActionResult PostPrueba(SMS data)
        {
#if DEBUG
            TelemetryConfiguration.Active.DisableTelemetry = true;
#endif

            try
            {
                if (string.IsNullOrEmpty(data.Mensaje))
                {
                    data.Mensaje = "yeya fuhrer?";
                }
                //Console.WriteLine(data.DNI + " " + data.Mensaje);
                Debug.WriteLine("DATOS:{ DNI:" + data.DNI + "  -- Carrier: " + data.Carrier + "  -- MSJ: " + data.Mensaje + "}");

                return Json(true);

            }
            catch (Exception)
            {

                return Json(false);
            }

        }

    }

    //public class SMS
    //{
    //    public string Mensaje { get; set; }

    //    public Int32 Telefono { get; set; }

    //    public string DNI { get; set; }

    //    public string Carrier { get; set; }
    //}

    public class SMS
    {
        public string Mensaje { get; set; }
        public string ID_Instancia { get; set; }
        public bool Es_Control { get; set; }

        public int Mes { get; set; }
    }

}
