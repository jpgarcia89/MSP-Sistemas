using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MSP_RegProf.Models;
using MSP_RegProf.Helpers;

namespace MSP_RegProf.Controllers
{
    [Authorize]
    public class ProfesionalesController : Controller
    {
        private MSPEntities db = new MSPEntities();

        // GET: Profesionales
        public ActionResult Index()
        {
            var persona = db.Persona.Include(p => p.Localidad).Include(p => p.Localidad1).Include(p => p.TipoDNI).Include(p => p.TipoEstadoCivil).Include(p => p.TipoSexo).Include(p => p.Pais);
            return View(persona.ToList());
        }

        // POST: Profesionales/BuscaProf/{dni}
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult BuscaProf(string profDni)
        {
            //Implementar Busqueda del Profecional
            List<Persona> personas = new List<Persona>();

            if (!string.IsNullOrEmpty(profDni))
            {
                profDni = profDni.Trim();
                personas.AddRange(db.Persona.Where(p => p.Nombre.Contains(profDni)).ToList());
                personas.AddRange(db.Persona.Where(p => p.Apellido.Contains(profDni)).ToList());
                personas.AddRange(db.Persona.Where(p => p.NroDocumento.Contains(profDni)).ToList());
            }

            return PartialView("_ListadoProf", personas.ToList());
        }

        // GET: Profesionales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Persona.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            ViewBag.LocalidadID = new SelectList(db.Localidad, "ID", "Nombre");
            ViewBag.LocalidadNacimientoID = new SelectList(db.Localidad, "ID", "Nombre");
            ViewBag.TipodniID = new SelectList(db.TipoDNI, "ID", "Nombre");
            ViewBag.EstadoCivilID = new SelectList(db.TipoEstadoCivil, "ID", "Nombre");
            ViewBag.SexoID = new SelectList(db.TipoSexo, "ID", "Nombre");
            ViewBag.NacionalidadID = new SelectList(db.Pais, "ID", "Nombre");
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Apellido,Nombre,TipodniID,NroDocumento,EstadoCivilID,SexoID,FechaNacimiento,LocalidadID,CodigoPostal,DomicilioCalle,DomicilioNumero,DomicilioManzana,DomicilioPiso,DomicilioDepto,CalleReferencia1,CalleReferencia2,BarrioID,TelefonoFijo,TelefonoCelular,Email,LocalidadNacimientoID,NacionalidadID,CUIL,Fallecido,FechaActualizacion,FechaAlta,FechaFallecido")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                persona.FechaAlta = DateTime.Today;
                persona.FechaActualizacion = DateTime.Today;

                db.Persona.Add(persona);
                db.SaveChanges();


                List<Persona> personas = new List<Persona>();
                personas.Add(db.Persona.FirstOrDefault(r => r.ID == persona.ID));


                return Json(new
                {
                    ok = "true",
                    data = this.RenderPartialView("_ListadoProf", personas.ToList())
                });


            }

            ViewBag.LocalidadID = new SelectList(db.Localidad, "ID", "Nombre", persona.LocalidadID);
            ViewBag.LocalidadNacimientoID = new SelectList(db.Localidad, "ID", "Nombre", persona.LocalidadNacimientoID);
            ViewBag.TipodniID = new SelectList(db.TipoDNI, "ID", "Nombre", persona.TipodniID);
            ViewBag.EstadoCivilID = new SelectList(db.TipoEstadoCivil, "ID", "Nombre", persona.EstadoCivilID);
            ViewBag.SexoID = new SelectList(db.TipoSexo, "ID", "Nombre", persona.SexoID);
            ViewBag.NacionalidadID = new SelectList(db.Pais, "ID", "Nombre", persona.NacionalidadID);
            return View(persona);
        }





        // GET: Personas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Persona.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            ViewBag.LocalidadID = new SelectList(db.Localidad, "ID", "Nombre", persona.LocalidadID);
            ViewBag.LocalidadNacimientoID = new SelectList(db.Localidad, "ID", "Nombre", persona.LocalidadNacimientoID);
            ViewBag.TipodniID = new SelectList(db.TipoDNI, "ID", "Nombre", persona.TipodniID);
            ViewBag.EstadoCivilID = new SelectList(db.TipoEstadoCivil, "ID", "Nombre", persona.EstadoCivilID);
            ViewBag.SexoID = new SelectList(db.TipoSexo, "ID", "Nombre", persona.SexoID);
            ViewBag.NacionalidadID = new SelectList(db.Pais, "ID", "Nombre", persona.NacionalidadID);
            return View(persona);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Apellido,Nombre,TipodniID,NroDocumento,EstadoCivilID,SexoID,FechaNacimiento,LocalidadID,CodigoPostal,DomicilioCalle,DomicilioNumero,DomicilioManzana,DomicilioPiso,DomicilioDepto,CalleReferencia1,CalleReferencia2,BarrioID,TelefonoFijo,TelefonoCelular,Email,LocalidadNacimientoID,NacionalidadID,CUIL,Fallecido,FechaActualizacion,FechaAlta,FechaFallecido")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();

                List<Persona> personas = new List<Persona>();
                personas.Add(db.Persona.FirstOrDefault(r => r.ID == persona.ID));


                return Json(new
                {
                    ok = "true",
                    data = this.RenderPartialView("_ListadoProf", personas.ToList())
                });
                //return RedirectToAction("Index");
            }
            ViewBag.LocalidadID = new SelectList(db.Localidad, "ID", "Nombre", persona.LocalidadID);
            ViewBag.LocalidadNacimientoID = new SelectList(db.Localidad, "ID", "Nombre", persona.LocalidadNacimientoID);
            ViewBag.TipodniID = new SelectList(db.TipoDNI, "ID", "Nombre", persona.TipodniID);
            ViewBag.EstadoCivilID = new SelectList(db.TipoEstadoCivil, "ID", "Nombre", persona.EstadoCivilID);
            ViewBag.SexoID = new SelectList(db.TipoSexo, "ID", "Nombre", persona.SexoID);
            ViewBag.NacionalidadID = new SelectList(db.Pais, "ID", "Nombre", persona.NacionalidadID);
            return View(persona);
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Persona.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Persona persona = db.Persona.Find(id);
            db.Persona.Remove(persona);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
