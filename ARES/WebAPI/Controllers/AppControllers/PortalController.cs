﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPI.Controllers.AppControllers
{
    [RoutePrefix("api/Portal")]
    public class PortalController : ApiController
    {

        [Route("Noticias")]
        public async Task<IHttpActionResult> GetNoticia()
        
           {
            var client = new HttpClient();
            //var content = new StringContent(JsonConvert.SerializeObject(new Product { query = encryptingIT, empImg = false }));
            //content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            try
            {
                var response = await client.GetAsync("http://sanjuan.gov.ar/gen/gobierno/app/noticias/salud/c/index.json");//, content

                var value = await response.Content.ReadAsStringAsync();

                value = "[" + value + "]";

                value =  Regex.Replace(value, "(?i)<a[^>]*>", "");//Esta instruccion quita los tags "<a>" del html en la noticia 

                var list = JsonConvert.DeserializeObject<List<object>>(value);

                return Json(list);
            }
            catch (Exception ex)
            {

                throw ex;
            }


           
        }


    }
}
