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
    public class HorariosController : ApiController
    {
        private Entidades db = new Entidades();

        // GET: api/Horarios
        public IHttpActionResult GetHorarios()
        {
            var data = db.Horarios.Select(r => new {
                r.ID,
                r.Hora,
                r.Activo
            });

            if (data == null)
            {
                return NotFound();
            }

            return Json(data);
        }

        // GET: api/Horarios/5
        [ResponseType(typeof(Horarios))]
        public IHttpActionResult GetHorarios(short id)
        {
            Horarios r = db.Horarios.Find(id);

            if (r == null)
            {
                return NotFound();
            }

            var data = new {
                r.ID,
                r.Hora,
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

        private bool HorariosExists(short id)
        {
            return db.Horarios.Count(e => e.ID == id) > 0;
        }
    }
}