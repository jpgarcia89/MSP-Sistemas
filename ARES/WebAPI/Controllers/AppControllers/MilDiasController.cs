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
            try
            {
                if (string.IsNullOrEmpty(data.Mensaje))
                {
                    data.Mensaje = "yeya fuhrer?";
                }
                //Console.WriteLine(data.DNI + " " + data.Mensaje);
                Debug.WriteLine("|||||||| DNI:"+data.DNI + "  -- Carrier: " + data.Carrier + "  -- MSJ: " + data.Mensaje);
                return Json(true);

            }
            catch (Exception)
            {
                
                return Json(false);
            }           
            
        }

    }

    public class SMS
    {
        public string Mensaje { get; set; }

        public Int32 Telefono { get; set; }

        public string DNI { get; set; }

        public string Carrier { get; set; }
    }

}
