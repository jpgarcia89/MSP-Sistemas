using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSP.Models;

namespace MSP.Controllers
{
    
    public class MenuController : Controller
    {
        MSPEntities Context = new MSPEntities();

        // GET: Menu
        public List<MenuVM> GetMenu()
        {
            var datos = Context.Menu.Where(r=>r.Activo).Select(r=> new MenuVM() {
                ID = r.ID,
                //mnuId=r.mnuId,
                PadreID = r.PadreID,
                Nombre=r.Nombre,
                Accion=r.Accion,
                Controlador=r.Controlador,
                Icono = r.Icono
            }).ToList();

            return datos;
        }

        
    }
}
