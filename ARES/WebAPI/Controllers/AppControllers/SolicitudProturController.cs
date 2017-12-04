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
        

        // POST: api/SolicitudProtur
        [Route("Solicitud")]
        [ResponseType(typeof(SolicitudProtur))]
        public IHttpActionResult PostSolicitudProtur(SolicitudProtur solicitudProtur)
        {
            solicitudProtur.Fecha = DateTime.Now;

            db.SolicitudProtur.Add(solicitudProtur);

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                var x = e.InnerException.Message;
                return Json(new { ok = 0});

                //InnerException = {"An error occurred while updating the entries. See the inner exception for details."}
            }

            return Json(new { ok = 1, NuevoID = solicitudProtur.ID });
        }


        [Route("Registro")]
        //[ResponseType(typeof(RegistroProtur))]
        public IHttpActionResult PostRegistroProtur(List<ProturRegistros> RegistroProtur)//RegistroProtur
        {

            var x = new DateTime(1504622796888);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {



                var cantRegistros = RegistroProtur.Count;
                var cantInsertados = 0;

                foreach (var reg in RegistroProtur)
                {
                    if (!db.ProturRegistros.Where(r => r.CS == reg.CS && r.TS == reg.TS).Any())
                    {
                        db.ProturRegistros.Add(reg);
                        cantInsertados++;
                    }
                }

                db.SaveChanges();

                return Json(new
                {
                    ok = 1,
                    cantRegistros = cantRegistros,
                    cantInsertados = cantInsertados
                });

            }

            catch (Exception e)
            {

                throw e;
            }
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