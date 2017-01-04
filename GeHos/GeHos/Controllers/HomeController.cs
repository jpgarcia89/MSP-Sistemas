using GeHos.Model;
using GeHosContract.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeHos.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult SeleccionarCentroDeSalud()
        {
            CentroDeSaludClient csC = new CentroDeSaludClient();
            var lol = new SelectList(csC.buscarTodos().ToList(), "ID", "Nombre");
            ViewBag.ListaCSDeUsuario = lol;
            return PartialView();
        }

        #region Datos Estaticos Menu        
        private List<mnuEntitie> GetMenu(string name)
        {
            List<mnuEntitie> mnus = new List<mnuEntitie> {
                // /GestionHospitalaria/
                new mnuEntitie {
                    mnuId = 1,
                    mnuIdPadre=null,
                    mnuNombre="GestionHospitalaria",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController=""
                },

                // /GestionHospitalaria/Turnos
                new mnuEntitie {
                    mnuId = 2,
                    mnuIdPadre=1,
                    mnuNombre="Turnos",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController=""
                },

                //*/GestionHospitalaria/Turnos/Agenda
                new mnuEntitie {
                    mnuId = 3,
                    mnuIdPadre=2,
                    mnuNombre="Agenda",
                    mnuImagen="",
                    mnuAccion="Index",
                    mnuController="Agenda"
                },
                
                //*/GestionHospitalaria/Turnos/BloqueosMasivos
                new mnuEntitie {
                    mnuId = 4,
                    mnuIdPadre=2,
                    mnuNombre="Bloqueos Masivos",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController="catBloqueosMasivos"
                },
                
                //*/GestionHospitalaria/Turnos/CentroDeSaludPublicidad
                new mnuEntitie {
                    mnuId = 5,
                    mnuIdPadre=2,
                    mnuNombre="Centro de Salud Publicidad",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController="catCentroDeSaludPublicidad"
                },
                
                //* /GestionHospitalaria/Turnos/Turnos
                new mnuEntitie {
                    mnuId = 6,
                    mnuIdPadre=2,
                    mnuNombre="Turnos",
                    mnuImagen="",
                    mnuAccion="Index",
                    mnuController="catTurnos"
                },
                
                //*/GestionHospitalaria/Turnos/VisualizadorDeTurnos
                new mnuEntitie {
                    mnuId = 7,
                    mnuIdPadre=2,
                    mnuNombre="Visualizador de Turnos",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController="catVisualizadorDeTurnos"
                },




       
    }
}