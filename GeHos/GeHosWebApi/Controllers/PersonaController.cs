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
    public class PersonaController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/Persona
        public IQueryable<PersonaVM> GetcatPersona()
        {
            //var a = from persona in db.Persona
            //        join enlPerEsp in db.PersonaEspecialidad on persona.perId equals enlPerEsp.perId into groupPerEsp
            //        from res2 in groupPerEsp
            //        select new catPersonaVM()
            //        {
            //            perId = res2.perId,
            //            perApellidoyNombre = persona.perApellidoyNombre
            //        };
            //return a;
            return db.Persona.Select(x => new PersonaVM()
            {
                perId = x.ID,
                perApellidoyNombre = "Generico"
            });
        }

        // GET: api/Persona/5
        [ResponseType(typeof(Persona))]
        public IHttpActionResult GetcatPersona(int id)
        {
            Persona catPersona = db.Persona.Find(id);
            if (catPersona == null)
            {
                return NotFound();
            }

            return Ok(catPersona);
        }

        // PUT: api/Persona/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutcatPersona(int id, Persona catPersona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != catPersona.ID)
            {
                return BadRequest();
            }

            db.Entry(catPersona).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!catPersonaExists(id))
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

        // POST: api/Persona
        [ResponseType(typeof(Persona))]
        public IHttpActionResult PostcatPersona(Persona catPersona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Persona.Add(catPersona);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = catPersona.ID }, catPersona);
        }

        // DELETE: api/Persona/5
        [ResponseType(typeof(Persona))]
        public IHttpActionResult DeletecatPersona(int id)
        {
            Persona catPersona = db.Persona.Find(id);
            if (catPersona == null)
            {
                return NotFound();
            }

            db.Persona.Remove(catPersona);
            db.SaveChanges();

            return Ok(catPersona);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool catPersonaExists(int id)
        {
            return db.Persona.Count(e => e.ID == id) > 0;
        }
    }
}