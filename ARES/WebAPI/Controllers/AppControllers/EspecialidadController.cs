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
    public class EspecialidadController : ApiController
    {
        private Entidades db = new Entidades();

        // GET: api/Especialidad
        public IHttpActionResult GetEspecialidad()
        {
            var data = db.Especialidad.Select(r => new {
                r.ID,
                r.Nombre
            });

            if (data == null)
            {
                return NotFound();
            }

            return Json(data);
        }

        // GET: api/Especialidad/5
        [ResponseType(typeof(Especialidad))]
        public IHttpActionResult GetEspecialidad(short id)
        {
            Especialidad r = db.Especialidad.Find(id);

            if (r == null)
            {
                return NotFound();
            }

            var data = new {
                r.ID,
                r.Nombre
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

        private bool EspecialidadExists(short id)
        {
            return db.Especialidad.Count(e => e.ID == id) > 0;
        }
    }
}