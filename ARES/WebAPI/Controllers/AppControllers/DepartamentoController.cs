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
    public class DepartamentoController : ApiController
    {
        private Entidades db = new Entidades();

        // GET: api/Departamento
        public IHttpActionResult GetDepartamento()
        {

            var data = db.Departamento.Where(r=>r.Zona!=null).Select(r => new {
                ID = r.ID,
                Nombre = r.Nombre,
                Zona = r.Zona
            }).OrderBy(r=>r.Zona);


            return Json(data);
        }

        // GET: api/Departamento/5
        [ResponseType(typeof(Departamento))]
        public IHttpActionResult GetDepartamento(short id)
        {
            Departamento departamento = db.Departamento.Find(id);
            if (departamento == null)
            {
                return NotFound();
            }

            return Ok(departamento);
        }

        //// PUT: api/Departamento/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutDepartamento(short id, Departamento departamento)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != departamento.ID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(departamento).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!DepartamentoExists(id))
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

        //// POST: api/Departamento
        //[ResponseType(typeof(Departamento))]
        //public IHttpActionResult PostDepartamento(Departamento departamento)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Departamento.Add(departamento);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = departamento.ID }, departamento);
        //}

        //// DELETE: api/Departamento/5
        //[ResponseType(typeof(Departamento))]
        //public IHttpActionResult DeleteDepartamento(short id)
        //{
        //    Departamento departamento = db.Departamento.Find(id);
        //    if (departamento == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Departamento.Remove(departamento);
        //    db.SaveChanges();

        //    return Ok(departamento);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DepartamentoExists(short id)
        {
            return db.Departamento.Count(e => e.ID == id) > 0;
        }
    }
}