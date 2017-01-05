using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeHos.Controllers.CentroDeSalud
{
    public class CentroDeSaludController : Controller
    {
        // GET: CentroDeSalud
        public ActionResult Index()
        {
            return View();
        }

        // GET: CentroDeSalud/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CentroDeSalud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CentroDeSalud/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CentroDeSalud/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CentroDeSalud/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CentroDeSalud/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CentroDeSalud/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
