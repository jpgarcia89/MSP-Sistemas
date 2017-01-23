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
    public class TipoAgendaDeProfesionalesController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/TipoAgendaDeProfesionales
        public IQueryable<TipoAgendaDeProfesionalesVM> GetTipoAgendaDeProfesionales()
        {
            return db.TipoAgendaDeProfesionales.Where(r=>r.Activa).Select(r => new TipoAgendaDeProfesionalesVM()
            {
                ID = r.ID,
                Nombre = r.Nombre
            });
        }

        // GET: api/TipoAgendaDeProfesionales/5
        [ResponseType(typeof(TipoAgendaDeProfesionales))]
        public IHttpActionResult GetTipoAgendaDeProfesionales(byte id)
        {
            TipoAgendaDeProfesionales tipoAgendaDeProfesionales = db.TipoAgendaDeProfesionales.Find(id);
            if (tipoAgendaDeProfesionales == null)
            {
                return NotFound();
            }

            return Ok(tipoAgendaDeProfesionales);
        }

        // PUT: api/TipoAgendaDeProfesionales/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipoAgendaDeProfesionales(byte id, TipoAgendaDeProfesionales tipoAgendaDeProfesionales)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoAgendaDeProfesionales.ID)
            {
                return BadRequest();
            }

            db.Entry(tipoAgendaDeProfesionales).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoAgendaDeProfesionalesExists(id))
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

        // POST: api/TipoAgendaDeProfesionales
        [ResponseType(typeof(TipoAgendaDeProfesionales))]
        public IHttpActionResult PostTipoAgendaDeProfesionales(TipoAgendaDeProfesionales tipoAgendaDeProfesionales)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoAgendaDeProfesionales.Add(tipoAgendaDeProfesionales);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipoAgendaDeProfesionales.ID }, tipoAgendaDeProfesionales);
        }

        // DELETE: api/TipoAgendaDeProfesionales/5
        [ResponseType(typeof(TipoAgendaDeProfesionales))]
        public IHttpActionResult DeleteTipoAgendaDeProfesionales(byte id)
        {
            TipoAgendaDeProfesionales tipoAgendaDeProfesionales = db.TipoAgendaDeProfesionales.Find(id);
            if (tipoAgendaDeProfesionales == null)
            {
                return NotFound();
            }

            db.TipoAgendaDeProfesionales.Remove(tipoAgendaDeProfesionales);
            db.SaveChanges();

            return Ok(tipoAgendaDeProfesionales);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoAgendaDeProfesionalesExists(byte id)
        {
            return db.TipoAgendaDeProfesionales.Count(e => e.ID == id) > 0;
        }
    }
}