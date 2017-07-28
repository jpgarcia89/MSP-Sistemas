using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MSP_RegProf.Models;
using System.Transactions;

namespace MSP_RegProf.Controllers.Seguridad
{
    public class RolesController : Controller
    {
        private MSPEntities db = new MSPEntities();

        // GET: Roles
        public ActionResult Index()
        {
            return View(db.AspNetRoles.ToList());
        }

        // GET: Roles/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetRoles aspNetRoles = db.AspNetRoles.Find(id);
            if (aspNetRoles == null)
            {
                return HttpNotFound();
            }
            return View(aspNetRoles);
        }

        // GET: Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] AspNetRoles aspNetRoles)
        {
            if (ModelState.IsValid)
            {
                db.AspNetRoles.Add(aspNetRoles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aspNetRoles);
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetRoles aspNetRoles = db.AspNetRoles.Find(id);
            if (aspNetRoles == null)
            {
                return HttpNotFound();
            }
            return View(aspNetRoles);
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] AspNetRoles aspNetRoles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aspNetRoles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aspNetRoles);
        }

        // GET: Roles/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetRoles aspNetRoles = db.AspNetRoles.Find(id);
            if (aspNetRoles == null)
            {
                return HttpNotFound();
            }
            return View(aspNetRoles);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AspNetRoles aspNetRoles = db.AspNetRoles.Find(id);
            db.AspNetRoles.Remove(aspNetRoles);
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







        // GET: Roles/Permisos/5
        public ActionResult Permisos(string id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //AspNetRoles aspNetRoles = db.AspNetRoles.Find(id);
            //if (aspNetRoles == null)
            //{
            //    return HttpNotFound();
            //}
            var menu = db.Menu.Where(r => r.Activo).ToList();

            PermisosVM model = new PermisosVM
            {
                Menu = menu,
                idRol = id
            };



            return View(model);
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Permisos(string idRol, string[] permisos)
        {

            try
            {
                //var idMenus = permisos.Where(r => r.Contains("menu")).Select(r => new { id = r.Split('_')[1] }).Distinct().ToList();
                //var idMenusAccion = permisos.Where(r => r.Contains("accion")).Select(r => new
                //{
                //    idMenu = r.Split('_')[1],
                //    idAccion = r.Split('_')[2]
                //}).Distinct().ToList();


                //using (TransactionScope tran = new TransactionScope())
                //{
                //    #region Alta de registros en "MenuAspNetRoles" y "MenuAspNetRolesAccion"
                //    foreach (var idMenu in idMenus)
                //    {
                //        //Creo el nuevo registro "MenuAspNetRoles"
                //        var itemMenuRol = new MenuAspNetRoles
                //        {
                //            MenuId = int.Parse(idMenu.id),
                //            AspNetRolesId = idRol
                //        };

                //        //Guardo el nuevo registro "MenuAspNetRoles"
                //        db.MenuAspNetRoles.Add(itemMenuRol);
                //        db.SaveChanges();


                //        //Si existe alguna accion asociada al menu registrado, se crean los registros
                //        //correspondientes en "MenuAspNetRolesAccion"
                //        if (idMenusAccion.Any(r => r.idMenu == idMenu.id))
                //        {
                //            foreach (var accion in idMenusAccion.Where(r => r.idMenu == idMenu.id))
                //            {
                //                //Creo el nuevo registro "MenuAspNetRolesAccion"
                //                var itemMenuRolAccion = new MenuAspNetRolesAccion
                //                {
                //                    MenuAspNetRolesId = itemMenuRol.ID,
                //                    AccionId = int.Parse(accion.idAccion)
                //                };

                //                //Guardo el nuevo registro "MenuAspNetRolesAccion"
                //                db.MenuAspNetRolesAccion.Add(itemMenuRolAccion);
                //            }
                //            db.SaveChanges();
                //        }

                //    }

                //    tran.Complete();

                //    #endregion

                //}


                return Json(new
                {
                    ok = 1,
                    mensaje = ""
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    ok = 0,
                    mensaje = ex.InnerException.Message
                });
            }

        }


    }

}