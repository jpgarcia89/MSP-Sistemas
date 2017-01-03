using GeHosContract.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace GeHos.Model
{
    public class EspecialidadClient
    {
        private string BASE_URL = "http://localhost:1338/api/";

        public IEnumerable<EspecialidadVM> buscarTodas()
        {
            try
            {
                HttpClient cliente = new HttpClient();
                cliente.BaseAddress = new Uri(BASE_URL);
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage respuesta = cliente.GetAsync("Especialidad").Result;
                if (respuesta.IsSuccessStatusCode)
                {
                    return respuesta.Content.ReadAsAsync<IEnumerable<EspecialidadVM>>().Result;
                }
                return null;
            }
            catch (Exception es)
            {

                return null;
            }
        }
    }
}