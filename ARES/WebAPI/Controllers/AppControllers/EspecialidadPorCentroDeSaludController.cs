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

namespace WebAPI.Controllers
{
    public class EspecialidadPorCentroDeSaludController : ApiController
    {
        private Entidades db = new Entidades();

        // GET: api/EspecialidadPorCentroDeSaluds
        public IHttpActionResult GetEspecialidadPorCentroDeSalud()
        {
            var data = db.EspecialidadPorCentroDeSalud.Select(r => new {
                r.ID,
                r.CentroDeSaludID,
                r.EspecialidadID,
                r.Activo
            });

            if (data == null)
            {
                return NotFound();
            }

            return Json(data);
        }

        // GET: api/EspecialidadPorCentroDeSaluds/5
        [ResponseType(typeof(EspecialidadPorCentroDeSalud))]
        public IHttpActionResult GetEspecialidadPorCentroDeSalud(int id)
        {
            EspecialidadPorCentroDeSalud r = db.EspecialidadPorCentroDeSalud.Find(id);

            if (r == null)
            {
                return NotFound();
            }

            var data = new {
                r.ID,
                r.CentroDeSaludID,
                r.EspecialidadID,
                r.Activo
            };

            if (data == null)
            {
                return NotFound();
            }

            return Json(data);
        }

      
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EspecialidadPorCentroDeSaludExists(int id)
        {
            return db.EspecialidadPorCentroDeSalud.Count(e => e.ID == id) > 0;
        }
    }
}