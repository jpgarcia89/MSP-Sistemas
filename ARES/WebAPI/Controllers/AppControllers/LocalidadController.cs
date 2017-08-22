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
using WebAPI.Models.Entity_Model;

namespace WebAPI.Controllers.AppControllers
{
    [RoutePrefix("api/Localidad")]
    public class LocalidadController : ApiController
    {
        private Entidades db = new Entidades();


        // PUT: api/Localidad/Departamento/5
        [Route("Departamento/{id}")]
        public IHttpActionResult GetLocalidadByDepto(short id)
        {
            var data = db.Localidad.Where(r => r.DepartamentoID == id).Select(r => new
            {
                ID = r.ID,
                DepartamentoID = r.DepartamentoID,
                Nombre = r.Nombre
            }).ToList();
            if (data == null)
            {
                return NotFound();
            }

            return Json(data);
        }


        // GET: api/Localidad
        public IHttpActionResult GetLocalidad()
        {
            var data = db.Localidad.Select(r => new
            {
                ID = r.ID,
                DepartamentoID = r.DepartamentoID,
                Nombre = r.Nombre
            }).ToList();


            return Json(data);
        }

        // GET: api/Localidad/5
        [ResponseType(typeof(Localidad))]
        public IHttpActionResult GetLocalidad(short id)
        {
            Localidad localidad = db.Localidad.Find(id);
            if (localidad == null)
            {
                return NotFound();
            }

            return Ok(localidad);
        }

        // PUT: api/Localidad/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutLocalidad(short id, Localidad localidad)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != localidad.ID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(localidad).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LocalidadExists(id))
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

        //// POST: api/Localidad
        //[ResponseType(typeof(Localidad))]
        //public IHttpActionResult PostLocalidad(Localidad localidad)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Localidad.Add(localidad);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = localidad.ID }, localidad);
        //}

        //// DELETE: api/Localidad/5
        //[ResponseType(typeof(Localidad))]
        //public IHttpActionResult DeleteLocalidad(short id)
        //{
        //    Localidad localidad = db.Localidad.Find(id);
        //    if (localidad == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Localidad.Remove(localidad);
        //    db.SaveChanges();

        //    return Ok(localidad);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LocalidadExists(short id)
        {
            return db.Localidad.Count(e => e.ID == id) > 0;
        }
    }
}