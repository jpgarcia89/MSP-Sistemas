﻿using GeHosContract.Contrato;
using GeHos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeHosWebApi;

namespace GeHos.Controllers
{
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
            CentroDeSaludClient csC = new CentroDeSaludClient();
            EspecialidadClient esC = new EspecialidadClient();
            PersonaClient peC = new PersonaClient();
            AgendaVM nuevaAgenda = new AgendaVM();
            //ViewData["ListaCentroSalud"] = new SelectList(csC.buscarTodos().ToList(), "csId", "csNombre");
            ViewBag.ListaCentroSalud = new SelectList(csC.buscarTodos().ToList(), "ID", "Nombre");
            ViewBag.Especialidad = new SelectList(esC.buscarTodas().ToList(), "ID", "Nombre");
            return View("Agregar", nuevaAgenda);
        }

        [HttpPost]
        public ActionResult Agregar(AgendaVM agendaVM)
        {
            AgendaClient ac = new AgendaClient();
            ac.AgregarAgenda(agendaVM);
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