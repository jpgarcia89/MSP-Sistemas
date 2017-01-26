using System;
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

namespace GeHosWebApi.Controllers
{
    public class EmpleadoController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/Empleado/GetEspecialistasPorCentroDeSalud
        public List<EspecialistaVM> GetEspecialistasPorCentroDeSalud(int id)
        {
            var x = db.GetEspecialistasPorCentroDeSalud(id).Select(r => new EspecialistaVM()
            {
                EmpleadoID = r.ID,
                NombreCompleto = r.Apellido + ", " + r.Nombre
            }).OrderBy(r=>r.NombreCompleto).ToList();

            return x;
        }

        [Route("api/Empleado/GetEspecialistasPorGetEspecialidadesPorEspecialista/{espId}/{csId}")]
        public List<EspecialistaVM> GetEspecialistasPorGetEspecialidadesPorEspecialista(int espId, int csId)
        {
            var x = db.GetEspecialistasPorEspecialidadPorCentroDeSalud(espId, csId).Select(r => new EspecialistaVM()
            {
                EmpleadoID = r.ID,
                NombreCompleto = r.Apellido + ", " + r.Nombre
            }).OrderBy(r => r.NombreCompleto).ToList();

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

       
    }
}