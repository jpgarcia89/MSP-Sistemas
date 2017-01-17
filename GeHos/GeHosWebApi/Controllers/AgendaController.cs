﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GeHosWebApi.Models;
using GeHosContract.Contrato;
using GeHosContract.Contratos.Agenda;

namespace GeHosWebApi.Controllers
{
    public class AgendaController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/Agenda
        public IQueryable<AgendaVM> GetcatAgenda()
        {
            return db.Agenda.Select(x => new AgendaVM()
            {
                Activa = x.Activa,
                ID = x.ID,
                CentroDeSaludID = x.EmpleadoEspecialidadCentroDeSalud.CentroDeSaludEspecialidad.CentroDeSaludID,
                EspecialidadID = x.EmpleadoEspecialidadCentroDeSalud.CentroDeSaludEspecialidad.EspecialidadID,
                FechaDesde = x.FechaDesde,
                FechaHasta = x.FechaHasta
            });
        }

        // GET: api/Agenda/5
        [ResponseType(typeof(Agenda))]
        public IHttpActionResult GetcatAgenda(int id)
        {
            Agenda catAgenda = db.Agenda.Find(id);
            if (catAgenda == null)
            {
                return NotFound();
            }

            return Ok(catAgenda);
        }

        // PUT: api/Agenda/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutcatAgenda(int id, Agenda catAgenda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != catAgenda.ID)
            {
                return BadRequest();
            }

            db.Entry(catAgenda).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!catAgendaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Agenda
        [ResponseType(typeof(Agenda))]
        public IHttpActionResult PostcatAgenda(NewAgendaVM NuevaAgendaVM)
        {
            //Validaciones
            //FuncionDeValidacion();


            //Nueva Agenda
            Agenda NuevaAgenda = new Agenda();

            NuevaAgenda.Activa = true;
            NuevaAgenda.FechaDesde = NuevaAgendaVM.fechaDesde;
            NuevaAgenda.FechaHasta = NuevaAgendaVM.fechaHasta;


            //Por cada rango horario creo un nuevo congunto de agendas horario
            foreach (var rangoHorario in NuevaAgendaVM.RangosHorarios)
            {
                AgendaHorario NuevaAgendaHorario = new AgendaHorario();
                //List<DateTime> allDates = new List<DateTime>();

                int Desde = NuevaAgendaVM.fechaDesde.Day;
                int Hasta = NuevaAgendaVM.fechaHasta.Day;               

                for (int i = Desde; i <= Hasta; i++)
                {
                    var diaValido = new DateTime(NuevaAgendaVM.fechaDesde.Year, NuevaAgendaVM.fechaHasta.Month, i);

                    if (rangoHorario.dias.Any(r => r == (int)diaValido.DayOfWeek))
                    {
//                        allDates.Add(diaValido);
                    }                     
                }
            }






            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //db.Agenda.Add(NuevaAgenda);
            //db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = true }, NuevaAgendaVM);
        }

        // DELETE: api/Agenda/5
        [ResponseType(typeof(Agenda))]
        public IHttpActionResult DeletecatAgenda(int id)
        {
            Agenda catAgenda = db.Agenda.Find(id);
            if (catAgenda == null)
            {
                return NotFound();
            }

            db.Agenda.Remove(catAgenda);
            db.SaveChanges();

            return Ok(catAgenda);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool catAgendaExists(int id)
        {
            return db.Agenda.Count(e => e.ID == id) > 0;
        }
    }
}