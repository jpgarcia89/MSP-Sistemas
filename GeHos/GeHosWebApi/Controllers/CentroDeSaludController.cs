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
using Microsoft.AspNet.Identity;

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
        [ResponseType(typeof(CentroDeSaludVM))]
        public IHttpActionResult GetcatCentroDeSalud(int id)
        {
            CentroDeSaludVM catCentroDeSalud = db.CentroDeSalud.Where(r => r.ID == id).Select(r => new CentroDeSaludVM() {
                ID=r.ID,
                Nombre =r.Nombre                
            }).FirstOrDefault();
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


        // GET: api/CentroDeSalud/GetCentroDeSaludPorUsuario/1
        public IQueryable<CentroDeSaludVM> GetCentroDeSaludPorUsuario(int id)
        {
            int lol = db.Empleado.Where(z => z.AspNetUsersID == id).Select(y => y.ID).FirstOrDefault();
            var x = from a in db.CentroDeSalud
                    join b in db.CentroDeSaludEspecialidad on a.ID equals b.CentroDeSaludID
                    join c in db.EmpleadoEspecialidadCentroDeSalud on b.ID equals c.CentroDeSaludEspecialidadID
                    where c.EmpleadoID == lol
                    group a by new
                    {
                        a.ID,
                        a.Nombre
                    } into gCS
                    select new CentroDeSaludVM()
                    {
                        ID = gCS.Key.ID,
                        Nombre = gCS.Key.Nombre
                    };

            return x;
        }
    }
}