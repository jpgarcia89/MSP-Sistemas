using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
 using System.Web.Mvc;
using MSP_RegProf.Models;
using System.Text;
using System.IO;

namespace MSP_RegProf.Controllers.RegProf.Matriculas
{
    [Authorize]
    public class MatriculasController : Controller
    {
        private MSPEntities db = new MSPEntities();

        // GET: Matriculas
        public ActionResult Index(int? profId)
        {

            List<Matricula> matriculas = new List<Matricula>();
            Persona profesional = new Persona();

            if (profId != null)
            {
                profesional = db.Persona.FirstOrDefault(r=>r.ID == profId);
                matriculas = db.Matricula.Where(r=>r.PersonaID == profId).Include(m => m.Organismo).Include(m => m.Persona).Include(m => m.TipoEstadoMatricula).Include(m => m.Titulo).ToList();
            }

            var tuplaModelos = new Tuple<Persona, List<Matricula>>(profesional, matriculas);
            return View(tuplaModelos);
        }

        // GET: Matriculas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matricula matricula = db.Matricula.Find(id);
            if (matricula == null)
            {
                return HttpNotFound();
            }
            return View(matricula);
        }

        // GET: Matriculas/Create/5
        [Route("Matriculas/Create/{profId}")]
        [HttpGet]
        public ActionResult Create(int profId)
        {
            ViewBag.OrganismoID = new SelectList(db.Organismo, "ID", "Descripcion");
            ViewBag.PersonaID = new SelectList(db.Persona, "ID", "Apellido");
            ViewBag.TipoEstadoMatriculaID = new SelectList(db.TipoEstadoMatricula, "ID", "Descripcion");
            ViewBag.TituloID = new SelectList(db.Titulo, "ID", "Descripcion");

            Matricula model = new Matricula {PersonaID = profId };
            return View(model);
        }

        // POST: Matriculas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Matriculas/Create")]//int profId,
        public ActionResult Create( Matricula matricula)//[Bind(Include = "ID,PersonaID,TituloID,OrganismoID,Revalido,FechaDiploma,ObservacionDiploma,FechaInscripcion,NroMatricula,Folio,libro,FechaActualizacion,Habilitada,TipoEstadoMatriculaID,Retirado,FechaRetiro,ObservacionMatricula,TieneAnalitico,TieneTitulo")]
        {

            matricula.FechaInscripcion = DateTime.Today;
            matricula.FechaActualizacion = DateTime.Today;
            //UpdateModel(matricula);
            ModelState["FechaInscripcion"].Errors.Clear();
            ModelState["FechaActualizacion"].Errors.Clear();

            if (ModelState.IsValid)
            {
                db.Matricula.Add(matricula);
                db.SaveChanges();

                return Json(new
                {
                    ok = 1,
                    mensaje = ""
                });


                //return RedirectToAction("Index",new { profId=matricula.PersonaID });
            }

            ViewBag.OrganismoID = new SelectList(db.Organismo, "ID", "Descripcion", matricula.OrganismoID);
            ViewBag.PersonaID = new SelectList(db.Persona, "ID", "Apellido", matricula.PersonaID);
            ViewBag.TipoEstadoMatriculaID = new SelectList(db.TipoEstadoMatricula, "ID", "Descripcion", matricula.TipoEstadoMatriculaID);
            ViewBag.TituloID = new SelectList(db.Titulo, "ID", "Descripcion", matricula.TituloID);
            return View(matricula);
        }

        // GET: Matriculas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matricula matricula = db.Matricula.Find(id);
            if (matricula == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrganismoID = new SelectList(db.Organismo, "ID", "Descripcion", matricula.OrganismoID);
            ViewBag.PersonaID = new SelectList(db.Persona, "ID", "Apellido", matricula.PersonaID);
            ViewBag.TipoEstadoMatriculaID = new SelectList(db.TipoEstadoMatricula, "ID", "Descripcion", matricula.TipoEstadoMatriculaID);
            ViewBag.TituloID = new SelectList(db.Titulo, "ID", "Descripcion", matricula.TituloID);
            return View(matricula);
        }

        // POST: Matriculas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PersonaID,TituloID,OrganismoID,Revalido,FechaDiploma,ObservacionDiploma,FechaInscripcion,NroMatricula,Folio,libro,FechaActualizacion,Habilitada,TipoEstadoMatriculaID,Retirado,FechaRetiro,ObservacionMatricula,TieneAnalitico,TieneTitulo")] Matricula matricula)
        {

            matricula.FechaActualizacion = DateTime.Today;

            if (ModelState.IsValid)
            {
                db.Entry(matricula).State = EntityState.Modified;
                db.SaveChanges();

                return Json(new
                {
                    ok = 1,
                    mensaje = ""
                });
            }
            ViewBag.OrganismoID = new SelectList(db.Organismo, "ID", "Descripcion", matricula.OrganismoID);
            ViewBag.PersonaID = new SelectList(db.Persona, "ID", "Apellido", matricula.PersonaID);
            ViewBag.TipoEstadoMatriculaID = new SelectList(db.TipoEstadoMatricula, "ID", "Descripcion", matricula.TipoEstadoMatriculaID);
            ViewBag.TituloID = new SelectList(db.Titulo, "ID", "Descripcion", matricula.TituloID);
            return View(matricula);
        }

        // GET: Matriculas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matricula matricula = db.Matricula.Find(id);
            if (matricula == null)
            {
                return HttpNotFound();
            }
            return View(matricula);
        }

        // POST: Matriculas/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Matricula matricula = db.Matricula.Find(id);
            db.Matricula.Remove(matricula);
            db.SaveChanges();
            return Json(new
            {
                ok = 1,
                mensaje = ""
            });
        }


        // GET: Matriculas/Delete/5
        public ActionResult ExportarSISA(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matricula matricula = db.Matricula.Find(id);
            if (matricula == null)
            {
                return HttpNotFound();
            }
            return View(matricula);
        }

        [HttpPost, ActionName("ExportarSISA")]
        //[ValidateAntiForgeryToken]
        public ActionResult ExportarSISAConfirmed(int id)
        {
            Matricula matricula = db.Matricula.Find(id);

            string sFileName = id + ".txt";

            //YOu could omit these lines here as you may
            //not want to save the textfile to the server
            //I have just left them here to demonstrate that you could create the text file 
            DirectoryInfo directory = new DirectoryInfo(Server.MapPath("~/ExportaSISA"));

            if (System.IO.File.Exists(directory + "/" + sFileName))
            {
                System.IO.File.Delete(directory + "/" + sFileName);
            }

            using (var tw = new StreamWriter(directory + "/" + sFileName, true))
            {
                
                tw.WriteLine("The next line!");
                tw.Close();
            }

            string host = System.Web.HttpContext.Current.Request.Url.Authority;
            // localhost

            return Json(new
            {
                url= "http://" +host + "/ExportaSISA/" + sFileName, 
                ok = 1,
                mensaje = ""
            });
            
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        protected void csv()
        {
            TextWriter sw = new StreamWriter(@"C:\\temp.txt");

            sw.WriteLine("hola");
            sw.Close();     //Don't Forget Close the TextWriter Object(sw)
          

            //MessageBox.Show("Data Successfully Exported");
        }
    }
}
