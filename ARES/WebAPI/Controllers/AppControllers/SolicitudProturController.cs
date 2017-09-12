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
using WebAPI.Models;
using WebAPI.Models.Entity_Model;

namespace WebAPI.Controllers.AppControllers
{
    [RoutePrefix("api/Protur")]
    public class SolicitudProturController : ApiController
    {
        private Entidades db = new Entidades();

        // GET: api/SolicitudProtur
        //public IQueryable<SolicitudProtur> GetSolicitudProtur()
        //{
        //    return db.SolicitudProtur;
        //}

        // GET: api/SolicitudProtur/5
        //[ResponseType(typeof(SolicitudProtur))]
        //public IHttpActionResult GetSolicitudProtur(int id)
        //{
        //    SolicitudProtur solicitudProtur = db.SolicitudProtur.Find(id);
        //    if (solicitudProtur == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(solicitudProtur);
        //}

        // PUT: api/SolicitudProtur/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutSolicitudProtur(int id, SolicitudProtur solicitudProtur)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != solicitudProtur.ID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(solicitudProtur).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SolicitudProturExists(id))
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

        // POST: api/SolicitudProtur
        [Route("Solicitud")]
        [ResponseType(typeof(SolicitudProtur))]
        public IHttpActionResult PostSolicitudProtur(SolicitudProtur solicitudProtur)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SolicitudProtur.Add(solicitudProtur);
            //db.SaveChanges();

            return Json(new {ok=1, NuevoID=solicitudProtur.ID });

            //return CreatedAtRoute("DefaultApi", new { id = solicitudProtur.ID }, solicitudProtur);
            //return CreatedAtRoute("DefaultApi", new { id = 1 }, solicitudProtur);
        }


        [Route("Registro")]
        [ResponseType(typeof(RegistroProtur))]
        public IHttpActionResult PostRegistroProtur(List<RegistroProtur> RegistroProtur)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            


            //db.SaveChanges();

            //return CreatedAtRoute("DefaultApi", new { id = solicitudProtur.ID }, solicitudProtur);
            //return CreatedAtRoute("DefaultApi", new { id = 1 }, registro);
            return Json(new { ok = 1 });
        }

        // DELETE: api/SolicitudProtur/5
        //[ResponseType(typeof(SolicitudProtur))]
        //public IHttpActionResult DeleteSolicitudProtur(int id)
        //{
        //    SolicitudProtur solicitudProtur = db.SolicitudProtur.Find(id);
        //    if (solicitudProtur == null)
        //    {
        //        return NotFound();
        //    }

        //    db.SolicitudProtur.Remove(solicitudProtur);
        //    db.SaveChanges();

        //    return Ok(solicitudProtur);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SolicitudProturExists(int id)
        {
            return db.SolicitudProtur.Count(e => e.ID == id) > 0;
        }
    }
}