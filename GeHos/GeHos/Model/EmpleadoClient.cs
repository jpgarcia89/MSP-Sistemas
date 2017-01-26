using GeHosContract.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;


namespace GeHos.Model
{
    public class EmpleadoClient
    {
        public List<EspecialistaVM> GetEspecialistasPorCentroDeSalud(int id)
        {
            try
            {
                HttpClient cliente = new HttpClient();
                cliente.BaseAddress = new Uri(Helpers.GlobalVariables.BASE_URL);
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage respuesta = cliente.GetAsync("Empleado/GetEspecialistasPorCentroDeSalud/" + id).Result;
                if (respuesta.IsSuccessStatusCode)
                {
                    return respuesta.Content.ReadAsAsync<List<EspecialistaVM>>().Result;
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