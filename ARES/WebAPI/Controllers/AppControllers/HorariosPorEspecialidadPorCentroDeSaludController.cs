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
    public class HorariosPorEspecialidadPorCentroDeSaludController : ApiController
    {
        private Entidades db = new Entidades();

        // GET: api/HorariosPorEspecialidadPorCentroDeSalud
        public IHttpActionResult GetHorariosPorEspecialidadPorCentroDeSalud()
        {
            var data = db.HorariosPorEspecialidadPorCentroDeSalud.Select(r => new {
                r.ID,
                r.HorarioIDEntrada,
                r.HorarioIDSalida,
                r.EspecialidadPorCentroDeSaludID,
                r.Dia,
                r.Activo
            });

            if (data == null)
            {
                return NotFound();
            }

            return Json(data);

        }

        // GET: api/HorariosPorEspecialidadPorCentroDeSalud/5
        [ResponseType(typeof(HorariosPorEspecialidadPorCentroDeSalud))]
        public IHttpActionResult GetHorariosPorEspecialidadPorCentroDeSalud(int id)
        {
            HorariosPorEspecialidadPorCentroDeSalud r = db.HorariosPorEspecialidadPorCentroDeSalud.Find(id);

            if (r == null)
            {
                return NotFound();
            }

            var data = new {
                r.ID,
                r.HorarioIDEntrada,
                r.HorarioIDSalida,
                r.EspecialidadPorCentroDeSaludID,
                r.Dia,
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

        private bool HorariosPorEspecialidadPorCentroDeSaludExists(int id)
        {
            return db.HorariosPorEspecialidadPorCentroDeSalud.Count(e => e.ID == id) > 0;
        }
    }
}