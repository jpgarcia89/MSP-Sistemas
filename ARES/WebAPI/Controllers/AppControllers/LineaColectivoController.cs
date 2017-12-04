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
    public class LineaColectivoController : ApiController
    {
        private Entidades db = new Entidades();

        // GET: api/LineaColectivo
        public IHttpActionResult GetLineaColectivo()
        {
            var data = db.LineaColectivo.Select(r => new {
                r.ID,
                r.Numero,
                r.Activo
            });

            if (data == null)
            {
                return NotFound();
            }

            return Json(data);
        }

        // GET: api/LineaColectivo/5
        [ResponseType(typeof(LineaColectivo))]
        public IHttpActionResult GetLineaColectivo(short id)
        {
            LineaColectivo r = db.LineaColectivo.Find(id);

            if (r == null)
            {
                return NotFound();
            }

            var data =  new {
                r.ID,
                r.Numero,
                r.Activo
            };

            

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

        private bool LineaColectivoExists(short id)
        {
            return db.LineaColectivo.Count(e => e.ID == id) > 0;
        }
    }
}