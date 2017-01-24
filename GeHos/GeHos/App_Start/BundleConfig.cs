using System.Web;
using System.Web.Optimization;

namespace GeHos
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.1.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            //appStyles
            bundles.Add(new StyleBundle("~/bundles/appStyles").Include(
                      "~/Content/bootstrap.css",        //Bootstrap 3.3.6  .min
                      "~/Content/font-awesome.css",     //Font Awesome
                      "~/Content/ionicons.min.css",         //Ionicons
                      "~/Content/AdminLTE.min.css",         //Theme style
                      "~/Scripts/plugins/select2/select2.min.css",         //Select2
                      "~/Content/skin-blue.css",//AdminLTE Skins
                      "~/Content/jquery.alerts.css",//jQuery Alerts css 
                      "~/Content/jquery-ui.min.css"));     

            //appScripts
            bundles.Add(new ScriptBundle("~/bundles/appScripts").Include(
                      "~/Scripts/jquery.validate*",                     //jQuery Validations
                      "~/Scripts/Scripts/plugins/jQueryUI/jquery-ui.min.js",    //jQuery UI
                      "~/Scripts/bootstrap.min.js",                     //Bootstrap
                      "~/Scripts/plugins/select2/select2.min.js",                     //Bootstrap
                      "~/Scripts/app.min.js",
                      "~/Scripts/jquery.alerts.js",
                      "~/Scripts/jquery-ui.min.js",
                      "~/Scripts/jquery-ui-datepicker-locale-es.js"));
                      //"~/Scripts/AccountScript.js"                         //AdminLTE App

            //BundleTable.EnableOptimizations = true;
        }   
    }
}
