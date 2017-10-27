using System;
using System.Collections.Generic;
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
                if (string.IsNullOrEmpty(data.mensaje))
                {
                    data.mensaje = "yeya fuhrer?";
                }

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
        public string mensaje { get; set; }
    }

}
