using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MSP_Certificados.Models;

namespace MSP.Controllers.Sanidad
{
    [Authorize]
    public class TipoCertificadoEstablecimientoesController : Controller
    {
        private MSPEntities db = new MSPEntities();

        // GET: TipoCertificadoEstablecimientoes
        public ActionResult Index()
        {
            var tipoCertificadoEstablecimiento = db.TipoCertificadoEstablecimiento.Include(t => t.TipoCertificado);
            return View(tipoCertificadoEstablecimiento.ToList());
        }

        // GET: TipoCertificadoEstablecimientoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCertificadoEstablecimiento tipoCertificadoEstablecimiento = db.TipoCertificadoEstablecimiento.Find(id);
            if (tipoCertificadoEstablecimiento == null)
            {
                return HttpNotFound();
            }
            return PartialView(tipoCertificadoEstablecimiento);
        }

        // GET: TipoCertificadoEstablecimientoes/Create
        public ActionResult Create()
        {
            ViewBag.IdTipoCertificado = new SelectList(db.TipoCertificado, "ID", "Denominacion");
            return PartialView();
        }

        // POST: TipoCertificadoEstablecimientoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Denominacion,IdTipoCertificado")] TipoCertificadoEstablecimiento tipoCertificadoEstablecimiento)
        {
            tipoCertificadoEstablecimiento.IdTipoCertificado = db.TipoCertificado.Where(r => r.Denominacion.Equals("Saneamiento")).FirstOrDefault().ID;

            if (ModelState.IsValid)
            {
                
                db.TipoCertificadoEstablecimiento.Add(tipoCertificadoEstablecimiento);
                db.SaveChanges();
                //return RedirectToAction("Index");
                return  Json(new { ok = "true" });
            }

            ViewBag.IdTipoCertificado = new SelectList(db.TipoCertificado, "ID", "Denominacion", tipoCertificadoEstablecimiento.IdTipoCertificado);
            return PartialView(tipoCertificadoEstablecimiento);
        }

        // GET: TipoCertificadoEstablecimientoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCertificadoEstablecimiento tipoCertificadoEstablecimiento = db.TipoCertificadoEstablecimiento.Find(id);
            if (tipoCertificadoEstablecimiento == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdTipoCertificado = new SelectList(db.TipoCertificado, "ID", "Denominacion", tipoCertificadoEstablecimiento.IdTipoCertificado);
            return PartialView(tipoCertificadoEstablecimiento);
        }

        // POST: TipoCertificadoEstablecimientoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Denominacion,IdTipoCertificado")] TipoCertificadoEstablecimiento tipoCertificadoEstablecimiento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoCertificadoEstablecimiento).State = EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("Index");
                return Json(new { ok = "true" });
            }
            ViewBag.IdTipoCertificado = new SelectList(db.TipoCertificado, "ID", "Denominacion", tipoCertificadoEstablecimiento.IdTipoCertificado);
            return PartialView(tipoCertificadoEstablecimiento);
        }

        // GET: TipoCertificadoEstablecimientoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCertificadoEstablecimiento tipoCertificadoEstablecimiento = db.TipoCertificadoEstablecimiento.Find(id);
            if (tipoCertificadoEstablecimiento == null)
            {
                return HttpNotFound();
            }
            return PartialView(tipoCertificadoEstablecimiento);
        }

        // POST: TipoCertificadoEstablecimientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoCertificadoEstablecimiento tipoCertificadoEstablecimiento = db.TipoCertificadoEstablecimiento.Find(id);
            db.TipoCertificadoEstablecimiento.Remove(tipoCertificadoEstablecimiento);
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
