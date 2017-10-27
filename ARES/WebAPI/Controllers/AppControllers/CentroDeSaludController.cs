using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.Models;
using WebAPI.Models.Entity_Model;

namespace WebAPI.Controllers.AppControllers
{
    [RoutePrefix("api/CentroDeSalud")]
    public class CentroDeSaludController : ApiController
    {
        private Entidades db = new Entidades();


        private decimal DmsToDD(string degrees)
        {

            double d=0;
            double m = 0;
            double s = 0;

            try
            {
                if (!string.IsNullOrEmpty(degrees))
                {
                    degrees = degrees.Trim();

                    d = Double.Parse(degrees.Split('°')[0]);
                    string aux = degrees.Split('°')[1];


                    m = Double.Parse(aux.Split('\'')[0]);
                    aux = aux.Split('\'')[1];

                    s = Double.Parse(aux.Split('\"')[0].Replace('.', ','));
                    aux = aux.Split('\"')[1];
                }

                return Convert.ToDecimal(-1 * (d + (m / 60) + (s / 3600)) * (d < 0 ?
                    -1 : 1));
            }
            catch (Exception e)
            {

                throw e;
            }

            
        }

        // GET: api/CentroDeSalud
        public IHttpActionResult GetCentroDeSalud()
        {
            var data = db.CentroDeSalud.ToList();

            try
            {
                var cs = data.Select(r => new {
                    ID = r.ID,
                    Nombre = r.Nombre.Trim(),
                    Latitud = r.Latitud,//DmsToDD(r.Latitud),//-31.405809929952255,
                    Longitud = r.Longitud,//DmsToDD(r.Longitud),//-68.49254608154297,
                    Telefono = r.Telefono.Trim(),//"*sin dato*",
                    Direccion = r.Direccion.Trim(),//"La Laja 3850. Las Lomitas.",
                    DepartamentoID = r.Localidad.DepartamentoID,//442,
                    LocalidadID = r.LocalidadID,
                    URLImagenDelCentroDeSalud = r.URLImagenDelCentroDeSalud.Trim()//"http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
                }).ToList();

                return Json(cs);
            }
            catch (Exception e)
            {

                throw e;
            }

            
        }

        // GET: api/CentroDeSalud/5
        [ResponseType(typeof(CentroDeSalud))]
        public IHttpActionResult GetCentroDeSalud(short id)
        {
            CentroDeSalud centroDeSalud = db.CentroDeSalud.Find(id);
            if (centroDeSalud == null)
            {
                return NotFound();
            }

            var data = new {
                ID = centroDeSalud.ID,
                Nombre = centroDeSalud.Nombre.Trim(),
                Latitud = centroDeSalud.Latitud,//DmsToDD(centroDeSalud.Latitud),//-31.405809929952255,
                Longitud = centroDeSalud.Longitud,//DmsToDD(centroDeSalud.Longitud),//-68.49254608154297,
                Telefono = centroDeSalud.Telefono.Trim(),//"*sin dato*",
                Direccion = centroDeSalud.Direccion.Trim(),//"La Laja 3850. Las Lomitas.",
                DepartamentoID = centroDeSalud.Localidad.DepartamentoID,//442,
                LocalidadID = centroDeSalud.LocalidadID,
                URLImagenDelCentroDeSalud = centroDeSalud.URLImagenDelCentroDeSalud.Trim()//"http//cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            };

            return Json(data);
            
            //return Ok(centroDeSalud);
        }

        // GET: api/CentroDeSalud/5/EspecialidadesYHorarios
        [Route("{id}/EspecialidadesYHorarios")]
        [ResponseType(typeof(CentroDeSalud))]
        public IHttpActionResult GetHorarios(short id)
        {
            CentroDeSalud centroDeSalud = db.CentroDeSalud.Find(id);
            if (centroDeSalud == null)
            {
                return NotFound();
            }
                        
            List<EspecialidadHorariosVM> especialidades = new List<EspecialidadHorariosVM>();

            foreach (var esp in centroDeSalud.EspecialidadPorCentroDeSalud.Where(r=>r.Activo).ToList())
            {
                var itemEsp = new EspecialidadHorariosVM()
                {
                    ID=esp.Especialidad.ID,
                    Nombre=esp.Especialidad.Nombre,
                    Horarios = new List<HorariosVM>()
                };

                foreach (var hr in esp.HorariosPorEspecialidadPorCentroDeSalud.Where(r => r.Activo))
                {
                    string dia = "";

                    switch (hr.Dia)
                    {
                        case 1:
                            dia = "Lunes";
                            break;
                        case 2:
                            dia = "Martes";
                            break;
                        case 3:
                            dia = "Miércoles";
                            break;
                        case 4:
                            dia = "Jueves";
                            break;
                        case 5:
                            dia = "Viernes";
                            break;
                        case 6:
                            dia = "Sábado";
                            break;
                        case 7:
                            dia = "Domingo";
                            break;

                    }

                    var itemHr = new HorariosVM() {
                        Dia = dia,
                        HorarioEntrada = hr.Horarios.Hora,
                        HorarioSalida = hr.Horarios1.Hora

                    };

                    itemEsp.Horarios.Add(itemHr);
                }

                especialidades.Add(itemEsp);

            }

            return Json(especialidades);
        }

        // GET: api/CentroDeSalud/5/EspecialidadesYHorarios
        [Route("{id}/LineasDeColectivos")]
        [ResponseType(typeof(CentroDeSalud))]
        public IHttpActionResult GetLineasColectivos(short id)
        {
            CentroDeSalud centroDeSalud = db.CentroDeSalud.Find(id);
            if (centroDeSalud == null)
            {
                return NotFound();
            }
            
            List<LineaColectivoVM> LineasColectivos = new List<LineaColectivoVM>();

            foreach (var linea in centroDeSalud.LineaColectivoPorCentroDeSalud.Where(r => r.Activo).ToList())
            {
                var item = new LineaColectivoVM()
                {
                    ID = linea.LineaColectivo.ID,
                    Numero = linea.LineaColectivo.Numero
                };

                LineasColectivos.Add(item);
            }

            return Json(LineasColectivos);
        }


        // GET: api/CentroDeSalud/5/EspecialidadesYHorarios
        [Route("Departamento/{id}")]
        [ResponseType(typeof(CentroDeSalud))]
        public IHttpActionResult GetCentroDeSaludPorDepartamento(short id)
        {
            var data = db.CentroDeSalud.Where(r=>r.Localidad.DepartamentoID == id).ToList();
                        
            var cs = data.Select(r => new {
                ID = r.ID,
                Nombre = r.Nombre.Trim(),
                Latitud = DmsToDD(r.Latitud),//-31.405809929952255,
                Longitud = DmsToDD(r.Longitud),//-68.49254608154297,
                Telefono = r.Telefono.Trim(),//"*sin dato*",
                Direccion = r.Direccion.Trim(),//"La Laja 3850. Las Lomitas.",
                DepartamentoID = r.Localidad.DepartamentoID,//442,
                LocalidadID = r.LocalidadID,
                URLImagenDelCentroDeSalud = r.URLImagenDelCentroDeSalud.Trim()//"http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            }).ToList();

            return Json(cs);
        }




        //// PUT: api/CentroDeSalud/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutCentroDeSalud(short id, CentroDeSalud centroDeSalud)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != centroDeSalud.ID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(centroDeSalud).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CentroDeSaludExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/CentroDeSalud
        //[ResponseType(typeof(CentroDeSalud))]
        //public IHttpActionResult PostCentroDeSalud(CentroDeSalud centroDeSalud)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.CentroDeSalud.Add(centroDeSalud);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = centroDeSalud.ID }, centroDeSalud);
        //}

        //// DELETE: api/CentroDeSalud/5
        //[ResponseType(typeof(CentroDeSalud))]
        //public IHttpActionResult DeleteCentroDeSalud(short id)
        //{
        //    CentroDeSalud centroDeSalud = db.CentroDeSalud.Find(id);
        //    if (centroDeSalud == null)
        //    {
        //        return NotFound();
        //    }

        //    db.CentroDeSalud.Remove(centroDeSalud);
        //    db.SaveChanges();

        //    return Ok(centroDeSalud);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CentroDeSaludExists(short id)
        {
            return db.CentroDeSalud.Count(e => e.ID == id) > 0;
        }
    }
}