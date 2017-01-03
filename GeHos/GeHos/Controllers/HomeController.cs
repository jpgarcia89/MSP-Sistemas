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
            if (Session["Menu"] ==null)
            {
                Session["Menu"] = GetMenu(User.Identity.Name);
            }
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




                // /GestionHospitalaria/Catálogos
                new mnuEntitie {
                    mnuId = 8,
                    mnuIdPadre=null,
                    mnuNombre="Catálogos",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController=""
                },

                // GestionHospitalaria/Catálogos/Consultorios
                new mnuEntitie {
                    mnuId = 9,
                    mnuIdPadre=8,
                    mnuNombre="Consultorios",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController=""
                },

                // /GestionHospitalaria/Catálogos/Motivos para Bloquear Turnos
                new mnuEntitie {
                    mnuId = 10,
                    mnuIdPadre=8,
                    mnuNombre="Motivos para Bloquear Turnos",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController="catAgenda"
                },
                
                // GestionHospitalaria/Catálogos/Pacientes
                new mnuEntitie {
                    mnuId = 11,
                    mnuIdPadre=8,
                    mnuNombre="Pacientes",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController="catBloqueosMasivos"
                },
                
                // GestionHospitalaria/Catálogos/Problemas Crónicos
                new mnuEntitie {
                    mnuId = 12,
                    mnuIdPadre=8,
                    mnuNombre="Problemas Crónicos",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController="catCentroDeSaludPublicidad"
                },
                
                // GestionHospitalaria/Catálogos/Salas
                new mnuEntitie {
                    mnuId = 13,
                    mnuIdPadre=8,
                    mnuNombre="Salas",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController="catTurnos"
                },
                
                // GestionHospitalaria/Catálogos/Vademecum
                new mnuEntitie {
                    mnuId = 14,
                    mnuIdPadre=8,
                    mnuNombre="Vademecum",
                    mnuImagen="",
                    mnuAccion="",
                    mnuController="catVisualizadorDeTurnos"
                },
            };
            return mnus;
        }

        public class mnuEntitie
        {
            public int mnuId { get; set; }
            public int? mnuIdPadre { get; set; }
            public string mnuNombre { get; set; }
            //public int mnuOrden { get; set; }
            //public string mnuTitulo { get; set; }
            public string mnuImagen { get; set; }
            public string mnuAccion { get; set; }
            public string mnuController { get; set; }
        }
        #endregion
    }
}