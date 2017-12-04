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
    public class LineaColectivoPorCentroDeSaludController : ApiController
    {
        private Entidades db = new Entidades();

        // GET: api/LineaColectivoPorCentroDeSalud
        public IHttpActionResult GetLineaColectivoPorCentroDeSalud()
        {
            var data = db.LineaColectivoPorCentroDeSalud.Select(r => new {
                r.ID,
                r.LineaColectivoID,
                r.CentroDeSaludID,
                r.Activo
            });

            if (data == null)
            {
                return NotFound();
            }

            return Json(data);
        }

        // GET: api/LineaColectivoPorCentroDeSalud/5
        [ResponseType(typeof(LineaColectivoPorCentroDeSalud))]
        public IHttpActionResult GetLineaColectivoPorCentroDeSalud(int id)
        {
            LineaColectivoPorCentroDeSalud r = db.LineaColectivoPorCentroDeSalud.Find(id);

            if (r == null)
            {
                return NotFound();
            }

            var data = new {
                r.ID,
                r.LineaColectivoID,
                r.CentroDeSaludID,
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

        private bool LineaColectivoPorCentroDeSaludExists(int id)
        {
            return db.LineaColectivoPorCentroDeSalud.Count(e => e.ID == id) > 0;
        }
    }
}