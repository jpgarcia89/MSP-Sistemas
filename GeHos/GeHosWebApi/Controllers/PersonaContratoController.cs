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

namespace GeHosWebApi.Controllers
{
    public class PersonaContratoController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/PersonaContrato
        public IQueryable<EmpleadoContratado> GetcatPersonaContratados()
        {
            return db.EmpleadoContratado;
        }

        // GET: api/PersonaContrato/5
        [ResponseType(typeof(EmpleadoContratado))]
        public IHttpActionResult GetcatPersonaContratados(int id)
        {
            EmpleadoContratado catPersonaContratados = db.EmpleadoContratado.Find(id);
            if (catPersonaContratados == null)
            {
                return NotFound();
            }

            return Ok(catPersonaContratados);
        }

        // PUT: api/PersonaContrato/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutcatPersonaContratados(int id, EmpleadoContratado catPersonaContratados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != catPersonaContratados.ID)
            {
                return BadRequest();
            }

            db.Entry(catPersonaContratados).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!catPersonaContratadosExists(id))
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

        // POST: api/PersonaContrato
        [ResponseType(typeof(EmpleadoContratado))]
        public IHttpActionResult PostcatPersonaContratados(EmpleadoContratado catPersonaContratados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EmpleadoContratado.Add(catPersonaContratados);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = catPersonaContratados.ID }, catPersonaContratados);
        }

        // DELETE: api/PersonaContrato/5
        [ResponseType(typeof(EmpleadoContratado))]
        public IHttpActionResult DeletecatPersonaContratados(int id)
        {
            EmpleadoContratado catPersonaContratados = db.EmpleadoContratado.Find(id);
            if (catPersonaContratados == null)
            {
                return NotFound();
            }

            db.EmpleadoContratado.Remove(catPersonaContratados);
            db.SaveChanges();

            return Ok(catPersonaContratados);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool catPersonaContratadosExists(int id)
        {
            return db.EmpleadoContratado.Count(e => e.ID == id) > 0;
        }
    }
}