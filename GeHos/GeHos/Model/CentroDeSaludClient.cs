using GeHosContract.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace GeHos.Model
{
    public class CentroDeSaludClient
    {
        private string BASE_URL = "http://localhost:1338/api/";

        public IEnumerable<CentroDeSaludVM> buscarTodos()
        {
            try
            {
                HttpClient cliente = new HttpClient();
                cliente.BaseAddress = new Uri(BASE_URL);
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage respuesta = cliente.GetAsync("CentroDeSalud").Result;
                if (respuesta.IsSuccessStatusCode)
                {
                    return respuesta.Content.ReadAsAsync<IEnumerable<CentroDeSaludVM>>().Result;
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