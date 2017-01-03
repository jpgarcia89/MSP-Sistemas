using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeHos.Controllers;
using System.Web.Mvc;

namespace GeHos.Helpers
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString RenderMenu(this HtmlHelper helper, List<HomeController.mnuEntitie> menus)
        {            
            var menusPadres = menus == null ? null : menus.Where(r => r.mnuIdPadre == null).ToList();
            return MvcHtmlString.Create(createMenu(menusPadres, menus));
        }

        private static string createMenu(List<HomeController.mnuEntitie> menusPadres, List<HomeController.mnuEntitie> menusAll, string output = null)
        {
            if (menusPadres != null && menusAll != null)
            {

                if (menusPadres.Any(r => r.mnuIdPadre != null))//Son opciones de menu q tienen un padre
                {
                    foreach (var item in menusPadres)
                    {

                        if (menusAll.Where(r => r.mnuIdPadre == item.mnuId).Any())
                        {
                            string a = string.Format(@"<li><a href=""#""><i class=""fa fa-circle-o""></i> {0} <span class=""pull-right-container""><i class=""fa fa-angle-left pull-right""></i></span></a><ul class=""treeview-menu"">", item.mnuNombre);
                            output += a;

                            output = createMenu(menusAll.Where(r => r.mnuIdPadre == item.mnuId).ToList(), menusAll, output);

                            string b = @"</ul></li>";
                            output += b;
                        }
                        else
                        {
                            string accion = string.IsNullOrEmpty(item.mnuAccion) ? "" : item.mnuAccion;
                            string url = "/" + item.mnuController + "/" + accion;
                            string c = string.Format(@"<li><a href=""{1}""><i class=""fa fa-circle-o""></i> {0} </a></li>", item.mnuNombre, url);
                            output += c;
                        }
                    }
                    //return output;
                }
                else
                {

                    foreach (var item in menusPadres)
                    {
                        string x = string.Format(@"<li class=""treeview""><a href = ""#"" ><i class=""fa fa-circle-o""></i><span> {0} </span><span class=""pull-right-container""><i class=""fa fa-angle-left pull-right""></i></span></a>", item.mnuNombre);
                        output += x;

                        if (menusAll.Where(r => r.mnuIdPadre == item.mnuId).Any())
                        {
                            string y = @"<ul class=""treeview-menu"">";
                            output += y;

                            output = createMenu(menusAll.Where(r => r.mnuIdPadre == item.mnuId).ToList(), menusAll, output);

                            string z = @"</ul>";
                            output += z;
                        }
                        output += "</li>";

                    }

                }
                return output;
            }
            else
            {
                return @"<li><a href=""#""><i class=""fa fa-circle-o text-red""></i> <span>No hay menus disponibles</span></a></li>";
            }
        }




    }
}