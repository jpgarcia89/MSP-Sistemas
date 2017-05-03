using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MSP.Models;
using Microsoft.AspNet.Identity;

namespace MSP.Controllers.Sanidad
{
    public class CertificadoController : Controller
    {
        private MSPEntities db = new MSPEntities();

        // GET: Certificadoes
        public ActionResult Index()
        {
            var certificado = db.Certificado.Include(c => c.AspNetUsers).Include(c => c.CertificadoEstablecimiento).Include(c => c.TipoCertificado);
            return View(certificado.ToList());
        }

        // GET: Certificadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Certificado certificado = db.Certificado.Find(id);
            if (certificado == null)
            {
                return HttpNotFound();
            }
            return View(certificado);
        }

        // GET: Certificadoes/Create
        public ActionResult Create()
        {
            //ViewBag.IdUsuarioEmite = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.IdEstablecimiento = new SelectList(db.CertificadoEstablecimiento.Where(r=>r.TipoCertificadoEstablecimiento.TipoCertificado.Denominacion=="Sanidad"), "ID", "Denominacion");
            //ViewBag.IdCertificadoTipo = new SelectList(db.TipoCertificado, "ID", "Denominacion");
            return PartialView();
        }

        // POST: Certificadoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IdEstablecimiento,FechaEmision,FechaDesde,FechaHasta,NroExpediente,IdCertificadoTipo,IdUsuarioEmite")] Certificado certificado)
        {
            certificado.FechaEmision = DateTime.Now;
            certificado.IdCertificadoTipo = db.TipoCertificado.FirstOrDefault(r => r.Denominacion == "Sanidad").ID;
            certificado.IdUsuarioEmite = User.Identity.GetUserId();


            if (ModelState.IsValid)
            {
                db.Certificado.Add(certificado);
                db.SaveChanges();
                //return RedirectToAction("Index");
                return Json(new { ok = "true" });
            }

            //ViewBag.IdUsuarioEmite = new SelectList(db.AspNetUsers, "Id", "Email", certificado.IdUsuarioEmite);
            ViewBag.IdEstablecimiento = new SelectList(db.CertificadoEstablecimiento, "ID", "Denominacion", certificado.IdEstablecimiento);
            //ViewBag.IdCertificadoTipo = new SelectList(db.TipoCertificado, "ID", "Denominacion", certificado.IdCertificadoTipo);
            return PartialView(certificado);
        }

        // GET: Certificadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Certificado certificado = db.Certificado.Find(id);
            if (certificado == null)
            {
                return HttpNotFound();
            }
            //ViewBag.IdUsuarioEmite = new SelectList(db.AspNetUsers, "Id", "Email", certificado.IdUsuarioEmite);
            ViewBag.IdEstablecimiento = new SelectList(db.CertificadoEstablecimiento, "ID", "Denominacion", certificado.IdEstablecimiento);
            //ViewBag.IdCertificadoTipo = new SelectList(db.TipoCertificado, "ID", "Denominacion", certificado.IdCertificadoTipo);
            return PartialView(certificado);
        }

        // POST: Certificadoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IdEstablecimiento,FechaEmision,FechaDesde,FechaHasta,NroExpediente,IdCertificadoTipo,IdUsuarioEmite")] Certificado certificado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(certificado).State = EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("Index");
                return Json(new { ok = "true" });
            }
            //ViewBag.IdUsuarioEmite = new SelectList(db.AspNetUsers, "Id", "Email", certificado.IdUsuarioEmite);
            ViewBag.IdEstablecimiento = new SelectList(db.CertificadoEstablecimiento, "ID", "Denominacion", certificado.IdEstablecimiento);
            //ViewBag.IdCertificadoTipo = new SelectList(db.TipoCertificado, "ID", "Denominacion", certificado.IdCertificadoTipo);
            return PartialView(certificado);
        }

        // GET: Certificadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Certificado certificado = db.Certificado.Find(id);
            if (certificado == null)
            {
                return HttpNotFound();
            }
            return PartialView(certificado);
        }

        // POST: Certificadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Certificado certificado = db.Certificado.Find(id);
            db.Certificado.Remove(certificado);
            db.SaveChanges();
            //return RedirectToAction("Index");
            return Json(new { ok = "true" });
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
