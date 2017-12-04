using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MSP_RegProf.Models;

namespace MSP_RegProf.Controllers
{
    [Authorize]
    public class CentroDeSaludController : Controller
    {
        private MSPEntities db = new MSPEntities();

        // GET: CentroDeSalud
        public ActionResult Index()
        {
            var centroDeSalud = db.CentroDeSalud.Include(c => c.Localidad);
            return View(centroDeSalud.ToList());
        }

        // GET: CentroDeSalud/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroDeSalud centroDeSalud = db.CentroDeSalud.Find(id);
            if (centroDeSalud == null)
            {
                return HttpNotFound();
            }
            return View(centroDeSalud);
        }

        // GET: CentroDeSalud/Create
        public ActionResult Create()
        {
            ViewBag.LocalidadID = new SelectList(db.Localidad, "ID", "Nombre");
            return View();
        }

        // POST: CentroDeSalud/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Latitud,Longitud,Direccion,Telefono,EMail,URLImagenDelCentroDeSalud,LocalidadID,Activo,FechaUltimaActualizacion")] CentroDeSalud centroDeSalud)
        {
            if (ModelState.IsValid)
            {
                db.CentroDeSalud.Add(centroDeSalud);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LocalidadID = new SelectList(db.Localidad, "ID", "Nombre", centroDeSalud.LocalidadID);
            return View(centroDeSalud);
        }

        // GET: CentroDeSalud/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroDeSalud centroDeSalud = db.CentroDeSalud.Find(id);
            if (centroDeSalud == null)
            {
                return HttpNotFound();
            }
            ViewBag.LocalidadID = new SelectList(db.Localidad, "ID", "Nombre", centroDeSalud.LocalidadID);
            ViewBag.DepartamentoID = new SelectList(db.Departamento, "ID", "Nombre", centroDeSalud.Localidad.DepartamentoID);
            return View(centroDeSalud);
        }

        // POST: CentroDeSalud/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Latitud,Longitud,Direccion,Telefono,EMail,URLImagenDelCentroDeSalud,LocalidadID,Activo,FechaUltimaActualizacion")] CentroDeSalud centroDeSalud)
        {
            if (ModelState.IsValid)
            {
                db.Entry(centroDeSalud).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LocalidadID = new SelectList(db.Localidad, "ID", "Nombre", centroDeSalud.LocalidadID);
            return View(centroDeSalud);
        }

        // GET: CentroDeSalud/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroDeSalud centroDeSalud = db.CentroDeSalud.Find(id);
            if (centroDeSalud == null)
            {
                return HttpNotFound();
            }
            return View(centroDeSalud);
        }

        // POST: CentroDeSalud/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            CentroDeSalud centroDeSalud = db.CentroDeSalud.Find(id);
            db.CentroDeSalud.Remove(centroDeSalud);
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





        public ActionResult _EspecialidadesPartial()
        {
            return PartialView();
        }











    }
}
