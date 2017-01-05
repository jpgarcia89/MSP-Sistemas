using GeHos.Model;
using GeHosContract.Contrato;
using Microsoft.AspNet.Identity;
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
            int id = Convert.ToInt32(User.Identity.GetUserId());
            CentroDeSaludClient csC = new CentroDeSaludClient();
            var listaCS = new SelectList(csC.buscarTodosPorUsuario(id).ToList(), "ID", "Nombre");
            ViewBag.ListaCSDeUsuario = listaCS;
            return PartialView();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult setCentroDeSalud(int csSeleccionado)
        {
            Session["CSSeleccionado"] = csSeleccionado;
            return Json(new { msg = "ok" });
        }
    }
}