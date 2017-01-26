﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GeHosWebApi.Models;
using GeHosContract.Contrato;
using System.Web.Http.Results;
//using System.Web.Mvc;

namespace GeHosWebApi.Controllers
{
    public class EspecialidadController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/Especialidad
        public IQueryable<EspecialidadVM> GetcatEspecialidad()
        {
            return db.Especialidad.Select(x => new EspecialidadVM()
            {
                ID = x.ID,
                Nombre = x.Nombre
            });
        }

        // GET: api/Especialidad/5
        [ResponseType(typeof(Especialidad))]
        public IHttpActionResult GetcatEspecialidad(short id)
        {
            Especialidad catEspecialidad = db.Especialidad.Find(id);
            if (catEspecialidad == null)
            {
                return NotFound();
            }

            return Ok(catEspecialidad);
        }

        // PUT: api/Especialidad/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutcatEspecialidad(short id, Especialidad catEspecialidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != catEspecialidad.ID)
            {
                return BadRequest();
            }

            db.Entry(catEspecialidad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!catEspecialidadExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Especialidad
        [ResponseType(typeof(Especialidad))]
        public IHttpActionResult PostcatEspecialidad(Especialidad catEspecialidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Especialidad.Add(catEspecialidad);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = catEspecialidad.ID }, catEspecialidad);
        }

        // DELETE: api/Especialidad/5
        [ResponseType(typeof(Especialidad))]
        public IHttpActionResult DeletecatEspecialidad(short id)
        {
            Especialidad catEspecialidad = db.Especialidad.Find(id);
            if (catEspecialidad == null)
            {
                return NotFound();
            }

            db.Especialidad.Remove(catEspecialidad);
            db.SaveChanges();

            return Ok(catEspecialidad);
        }


        // GET: api/Especialidad/GetEspecialidadPorCentroSalud/5
        public List<EspecialidadVM> GetEspecialidadesPorCentroSalud(int id)
        {
            //var x = from a in db.Especialidad
            //        join b in db.CentroDeSaludEspecialidad on a.ID equals b.EspecialidadID
            //        where b.CentroDeSaludID == id
            var x = db.GetEspecialidadesPorCentroDeSalud(id).Select(r => new EspecialidadVM()
                    {
                        ID = r.ID,
                        Nombre = r.Nombre
                    }).OrderBy(r=> r.Nombre).ToList();




            //return db.Especialidad.Select(x => new EspecialidadVM()
            //{
            //    ID = x.ID,
            //    Nombre = x.Nombre
            //});

            

            return x;
        }




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool catEspecialidadExists(short id)
        {
            return db.Especialidad.Count(e => e.ID == id) > 0;
        }



        [HttpGet]
        [Route("api/Especialidad/GetEspecialidadesPorEspecialistaPorCentroDeSalud/{empId}/{csId}")]        
        public JsonResult<List<EspecialidadVM>> GetEspecialidadesPorEspecialistaPorCentroDeSalud(int empId, int csId)//List<EspecialistaVM>
        {
            var x = db.GetEspecialidadesPorEspecialistaPorCentroDeSalud(empId, csId).Select(r => new EspecialidadVM()
            {
                ID = r.ID,
                Nombre = r.Nombre
            }).OrderBy(r => r.Nombre).ToList();

            return Json(x);
        }
    }
}