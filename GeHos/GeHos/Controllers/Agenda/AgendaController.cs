using GeHosContract.Contrato;
using GeHos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeHosWebApi;
using System.ComponentModel.DataAnnotations;


namespace GeHos.Controllers
{
    [Authorize]
    public class AgendaController : Controller
    {
        public AgendaController()
        {
        }

        public ActionResult Index()
        {
            //AgendaClient ac = new AgendaClient();
            //CAgendaVM colAgenda = new CAgendaVM();
            //var aux = new ObservableCollection<AgendaVM>(ac.buscarTodas());
            //colAgenda.ListaItems = aux;

            if (ViewData["ListaEspecialistas"] == null)
            {
                int csId = ((CentroDeSaludVM)Session["CSSeleccionado"]).ID;
                EmpleadoClient empC = new EmpleadoClient();
                var ListaEspecialistas = empC.GetEspecialistasPorCentroDeSalud(csId);
                ListaEspecialistas.Insert(0, new EspecialistaVM() { EmpleadoID = 0, NombreCompleto = "Seleccionar..." });
                ViewData["ListaEspecialistas"] = new SelectList(ListaEspecialistas, "EmpleadoID", "NombreCompleto");
            }



            return View();//colAgenda
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            int csId = ((CentroDeSaludVM)Session["CSSeleccionado"]).ID;


            TipoAgendaDeProfesionalesClient tAgC = new TipoAgendaDeProfesionalesClient();
            ViewData["ListaTipoAgendaDeProfesionales"] = new SelectList(tAgC.buscarTodas().ToList(), "ID", "Nombre");// as IEnumerable<EspecialistaVM>  as IEnumerable<EspecialidadVM>                        

            if (ViewData["ListaEspecialistas"] == null)
            {
                EmpleadoClient empC = new EmpleadoClient();
                var ListaEspecialistas = empC.GetEspecialistasPorCentroDeSalud(csId);
                ListaEspecialistas.Insert(0, new EspecialistaVM() { EmpleadoID = 0, NombreCompleto = "Seleccionar..." });
                ViewData["ListaEspecialistas"] = new SelectList(ListaEspecialistas, "EmpleadoID", "NombreCompleto");
            }


            //EspecialidadClient esC = new EspecialidadClient();
            List<SelectListItem> ListaEspecialidad = new List<SelectListItem>();
            ListaEspecialidad.Add(new SelectListItem() { Text = "Seleccionar...", Value = "0" });
            ViewData["ListaEspecialidad"] = new SelectList(ListaEspecialidad, "Value", "Text");//esC.GetEspecialidadPorCentroSalud(csId), "ID", "Nombre"



            return View("Agregar");
        }

        [HttpPost]
        public ActionResult Agregar(NewAgendaVM nuevaAgenda)
        {
            //nuevaAgenda.EmpleadoCreaID = User.GetId();

            AgendaClient ac = new AgendaClient();
            ac.AgregarAgenda(nuevaAgenda);
            //return RedirectToAction("Index");
            //return Json(new{ ok= true});
            return Json(Url.Action("Index", "Agenda"));
        }

        [HttpGet]
        public ActionResult Modificar(int? id)
        {
            AgendaClient ac = new AgendaClient();
            CentroDeSaludClient csC = new CentroDeSaludClient();
            EspecialidadClient esC = new EspecialidadClient();
            PersonaClient peC = new PersonaClient();
            AgendaVM objModificar = new AgendaVM();
            ViewBag.ListaCentroSalud = new SelectList(csC.buscarTodos().ToList(), "ID", "Nombre");
            ViewBag.Especialidad = new SelectList(esC.buscarTodas().ToList(), "ID", "Nombre");
            objModificar = ac.buscarAgenda(id.Value);
            return View("Modificar", objModificar);
        }



    }
}