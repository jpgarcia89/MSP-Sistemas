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
using GeHosContract.Contratos.Agenda;

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
            AgendaClient ac = new AgendaClient();
            CAgendaVM colAgenda = new CAgendaVM();
            var aux = new ObservableCollection<AgendaVM>(ac.buscarTodas());
            colAgenda.ListaItems = aux;
            return View(colAgenda);
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            int csId = ((CentroDeSaludVM)Session["CSSeleccionado"]).ID;
            CentroDeSaludClient csC = new CentroDeSaludClient();
            EspecialidadClient esC = new EspecialidadClient();
            PersonaClient peC = new PersonaClient();
            AgendaVM nuevaAgenda = new AgendaVM();
            //ViewData["ListaCentroSalud"] = new SelectList(csC.buscarTodos().ToList(), "csId", "csNombre");
            ViewBag.ListaCentroSalud = new SelectList(csC.buscarTodos().ToList(), "ID", "Nombre");
            ViewBag.Especialidad = new SelectList(esC.buscarTodasPorCS(csId).ToList(), "ID", "Nombre");
            return View("Agregar", nuevaAgenda);
        }

        [HttpPost]
        
        public ActionResult Agregar(NewAgendaVM nuevaAgenda)
        {
            //var x = nuevaAgenda;
            //var y = Request.Form["EspecialidadID"];
            AgendaClient ac = new AgendaClient();
            ac.AgregarAgenda(nuevaAgenda);
            return RedirectToAction("Index");
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