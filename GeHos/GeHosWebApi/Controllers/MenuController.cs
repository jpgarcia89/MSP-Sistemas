using System;
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

namespace GeHosWebApi.Controllers
{
    public class MenuController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/Menu
        public IQueryable<MenuVM> GetMenu()
        {
            var datos = db.Menu.Select(x => new MenuVM()
            {
                ID = x.ID,
                PadreID = x.PadreID,
                Nombre = x.Nombre,
                Orden = x.Orden,
                Icono = x.Icono,
                Accion = x.Accion,
                Controlador = x.Controlador,
                Activo = x.Activo,
                FechaAlta = x.FechaAlta,
                mnuId = x.mnuId
            });

            return datos;
        }

        //// GET: api/Agenda/5
        //[ResponseType(typeof(Agenda))]
        //public IHttpActionResult GetcatAgenda(int id)
        //{
        //    Agenda catAgenda = db.Agenda.Find(id);
        //    if (catAgenda == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(catAgenda);
        //}

        //// PUT: api/Agenda/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutcatAgenda(int id, Agenda catAgenda)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != catAgenda.ID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(catAgenda).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!catAgendaExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Agenda
        //[ResponseType(typeof(Agenda))]
        //public IHttpActionResult PostcatAgenda(Agenda catAgenda)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Agenda.Add(catAgenda);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = catAgenda.ID }, catAgenda);
        //}

        //// DELETE: api/Agenda/5
        //[ResponseType(typeof(Agenda))]
        //public IHttpActionResult DeletecatAgenda(int id)
        //{
        //    Agenda catAgenda = db.Agenda.Find(id);
        //    if (catAgenda == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Agenda.Remove(catAgenda);
        //    db.SaveChanges();

        //    return Ok(catAgenda);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        
    }
}