//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace GeHos.Model
//{
//    public class TipoAgendaDeProfesionalesClient
//    {
//    }
//}
using GeHos.Helpers;
using GeHosContract.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace GeHos.Model
{
    public class TipoAgendaDeProfesionalesClient
    {
        //private string BASE_URL = "http://localhost:1338/api/";

        public IEnumerable<TipoAgendaDeProfesionalesVM> buscarTodas()
        {
            try
            {
                HttpClient cliente = new HttpClient();
                cliente.BaseAddress = new Uri(GlobalVariables.BASE_URL);
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage respuesta = cliente.GetAsync("TipoAgendaDeProfesionales").Result;
                if (respuesta.IsSuccessStatusCode)
                {
                    return respuesta.Content.ReadAsAsync<IEnumerable<TipoAgendaDeProfesionalesVM>>().Result;
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

