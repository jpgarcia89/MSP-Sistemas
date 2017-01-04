using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using GeHosContract.Contrato;
using System.Threading.Tasks;

namespace GeHos.Model
{
    public class MenuClient
    {
        private string BASE_URL = "http://localhost:1338/api/";

        public IEnumerable<MenuVM> buscarTodos()//IEnumerable<MenuVM>
        {
            try
            {
                HttpClient cliente = new HttpClient();
                cliente.BaseAddress = new Uri(BASE_URL);
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage respuesta = cliente.GetAsync("Menu").Result;
                if (respuesta.IsSuccessStatusCode)
                {
                    return respuesta.Content.ReadAsAsync<IEnumerable<MenuVM>>().Result;
                }
                return null;
            }
            catch (Exception es)
            {

                return null;
            }
        }

        //public AgendaVM buscarAgenda(int id)
        //{
        //    try
        //    {
        //        HttpClient cliente = new HttpClient();
        //        cliente.BaseAddress = new Uri(BASE_URL);
        //        cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        HttpResponseMessage respuesta = cliente.GetAsync("Agenda/" + id).Result;
        //        if (respuesta.IsSuccessStatusCode)
        //        {
        //            return respuesta.Content.ReadAsAsync<AgendaVM>().Result;
        //        }
        //        return null;
        //    }
        //    catch (Exception es)
        //    {

        //        return null;
        //    }
        //}

        //public bool AgregarAgenda(AgendaVM objAgenda)
        //{
        //    try
        //    {
        //        HttpClient cliente = new HttpClient();
        //        cliente.BaseAddress = new Uri(BASE_URL);
        //        cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        HttpResponseMessage respuesta = cliente.PostAsJsonAsync("Agenda", objAgenda).Result;
        //        return respuesta.IsSuccessStatusCode;
        //    }
        //    catch (Exception es)
        //    {

        //        return false;
        //    }
        //}

        //public bool ModificarAgenda(AgendaVM objAgenda)
        //{
        //    try
        //    {
        //        HttpClient cliente = new HttpClient();
        //        cliente.BaseAddress = new Uri(BASE_URL);
        //        cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        HttpResponseMessage respuesta = cliente.PutAsJsonAsync("Agenda/" + objAgenda.ID, objAgenda).Result;
        //        return respuesta.IsSuccessStatusCode;
        //    }
        //    catch (Exception es)
        //    {

        //        return false;
        //    }
        //}

        //public bool BorrarAgenda(int id)
        //{
        //    try
        //    {
        //        HttpClient cliente = new HttpClient();
        //        cliente.BaseAddress = new Uri(BASE_URL);
        //        cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        HttpResponseMessage respuesta = cliente.DeleteAsync("Agenda/" + id).Result;
        //        return respuesta.IsSuccessStatusCode;
        //    }
        //    catch (Exception es)
        //    {

        //        return false;
        //    }
        //}
    }
}