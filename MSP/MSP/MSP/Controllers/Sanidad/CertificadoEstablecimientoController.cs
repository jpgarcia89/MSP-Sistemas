using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MSP.Models;

namespace MSP.Controllers.Sanidad
{
    public class CertificadoEstablecimientoController : Controller
    {
        private MSPEntities db = new MSPEntities();

        // GET: CertificadoEstablecimiento
        public ActionResult Index()
        {
            var certificadoEstablecimiento = db.CertificadoEstablecimiento.Include(c => c.AspNetUsers).Include(c => c.TipoCertificadoEstablecimiento);
            return View(certificadoEstablecimiento.ToList());
        }

        // GET: CertificadoEstablecimiento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CertificadoEstablecimiento certificadoEstablecimiento = db.CertificadoEstablecimiento.Find(id);
            if (certificadoEstablecimiento == null)
            {
                return HttpNotFound();
            }
            return View(certificadoEstablecimiento);
        }

        // GET: CertificadoEstablecimiento/Create
        public ActionResult Create()
        {
            ViewBag.IdUsuarioAlta = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.IdTipoEstablecimiento = new SelectList(db.TipoCertificadoEstablecimiento, "ID", "Denominacion");
            return View();
        }

        // POST: CertificadoEstablecimiento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IdTipoEstablecimiento,Denominacion,FechaAlta,IdUsuarioAlta,Activo,Domicilio,DomicilioDepto,Firma,FirmaDireccion,FirmaDepto")] CertificadoEstablecimiento certificadoEstablecimiento)
        {
            if (ModelState.IsValid)
            {
                db.CertificadoEstablecimiento.Add(certificadoEstablecimiento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdUsuarioAlta = new SelectList(db.AspNetUsers, "Id", "Email", certificadoEstablecimiento.IdUsuarioAlta);
            ViewBag.IdTipoEstablecimiento = new SelectList(db.TipoCertificadoEstablecimiento, "ID", "Denominacion", certificadoEstablecimiento.IdTipoEstablecimiento);
            return View(certificadoEstablecimiento);
        }

        // GET: CertificadoEstablecimiento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CertificadoEstablecimiento certificadoEstablecimiento = db.CertificadoEstablecimiento.Find(id);
            if (certificadoEstablecimiento == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdUsuarioAlta = new SelectList(db.AspNetUsers, "Id", "Email", certificadoEstablecimiento.IdUsuarioAlta);
            ViewBag.IdTipoEstablecimiento = new SelectList(db.TipoCertificadoEstablecimiento, "ID", "Denominacion", certificadoEstablecimiento.IdTipoEstablecimiento);
            return View(certificadoEstablecimiento);
        }

        // POST: CertificadoEstablecimiento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IdTipoEstablecimiento,Denominacion,FechaAlta,IdUsuarioAlta,Activo,Domicilio,DomicilioDepto,Firma,FirmaDireccion,FirmaDepto")] CertificadoEstablecimiento certificadoEstablecimiento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(certificadoEstablecimiento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdUsuarioAlta = new SelectList(db.AspNetUsers, "Id", "Email", certificadoEstablecimiento.IdUsuarioAlta);
            ViewBag.IdTipoEstablecimiento = new SelectList(db.TipoCertificadoEstablecimiento, "ID", "Denominacion", certificadoEstablecimiento.IdTipoEstablecimiento);
            return View(certificadoEstablecimiento);
        }

        // GET: CertificadoEstablecimiento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CertificadoEstablecimiento certificadoEstablecimiento = db.CertificadoEstablecimiento.Find(id);
            if (certificadoEstablecimiento == null)
            {
                return HttpNotFound();
            }
            return View(certificadoEstablecimiento);
        }

        // POST: CertificadoEstablecimiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CertificadoEstablecimiento certificadoEstablecimiento = db.CertificadoEstablecimiento.Find(id);
            db.CertificadoEstablecimiento.Remove(certificadoEstablecimiento);
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
