using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeHosData;
using System.Collections.ObjectModel;

namespace GeHos.Controllers
{
    public class HomeController : Controller
    {
        private NcatAgenta cAgenda;

        public HomeController()
        {
            this.cAgenda = new NcatAgenta();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}