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
    public class CentroDeSaludController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/CentroDeSalud
        public IQueryable<CentroDeSaludVM> GetcatCentroDeSalud()
        {
            return db.CentroDeSalud.Select(x=>new CentroDeSaludVM()
            {
                ID=x.ID,
                Codigo=x.Codigo,
                Nombre=x.Nombre
            });
        }

        // GET: api/CentroDeSalud/5
        [ResponseType(typeof(CentroDeSalud))]
        public IHttpActionResult GetcatCentroDeSalud(int id)
        {
            CentroDeSalud catCentroDeSalud = db.CentroDeSalud.Find(id);
            if (catCentroDeSalud == null)
            {
                return NotFound();
            }

            return Ok(catCentroDeSalud);
        }

        // PUT: api/CentroDeSalud/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutcatCentroDeSalud(int id, CentroDeSalud catCentroDeSalud)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != catCentroDeSalud.ID)
            {
                return BadRequest();
            }

            db.Entry(catCentroDeSalud).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!catCentroDeSaludExists(id))
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

        // POST: api/CentroDeSalud
        [ResponseType(typeof(CentroDeSalud))]
        public IHttpActionResult PostcatCentroDeSalud(CentroDeSalud catCentroDeSalud)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CentroDeSalud.Add(catCentroDeSalud);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = catCentroDeSalud.ID }, catCentroDeSalud);
        }

        // DELETE: api/CentroDeSalud/5
        [ResponseType(typeof(CentroDeSalud))]
        public IHttpActionResult DeletecatCentroDeSalud(int id)
        {
            CentroDeSalud catCentroDeSalud = db.CentroDeSalud.Find(id);
            if (catCentroDeSalud == null)
            {
                return NotFound();
            }

            db.CentroDeSalud.Remove(catCentroDeSalud);
            db.SaveChanges();

            return Ok(catCentroDeSalud);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool catCentroDeSaludExists(int id)
        {
            return db.CentroDeSalud.Count(e => e.ID == id) > 0;
        }
    }
}