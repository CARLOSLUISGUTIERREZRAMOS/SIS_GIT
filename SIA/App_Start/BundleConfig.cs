using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SIA
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/admin-lte/app").Include(
             "~/Scripts/AdminLTE/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/fastclick").Include(
                        "~/Scripts/AdminLTE/plugins/fastclick/fastclick.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/sparkline").Include(
                        "~/Scripts/AdminLTE/plugins/sparkline/jquery.sparkline.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jvectormap").Include(
                        "~/Scripts/AdminLTE/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                        "~/Scripts/AdminLTE/plugins/jvectormap/jquery-jvectormap-world-mill-en.js"));

            bundles.Add(new ScriptBundle("~/bundles/daterangepicker").Include(
                        "~/Scripts/AdminLTE/plugins/daterangepicker/daterangepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/datepicker").Include(
                        "~/Scripts/AdminLTE/plugins/datepicker/bootstrap-datepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/icheck").Include(
                        "~/Scripts/AdminLTE/plugins/iCheck/icheck.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/slimscroll").Include(
                        "~/Scripts/AdminLTE/plugins/slimScroll/jquery.slimscroll.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/chartjs").Include(
                        "~/Scripts/AdminLTE/plugins/chartjs/Chart.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/fontawesome").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/vuelo").Include(
                        "~/css/Vuelos/vuelo.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                      "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/sialogic").Include(
                     "~/Scripts/ReporteVentas/ReporteVentas.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/AdminLTE/AdminLTE.css"));

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                "~/Content/fontawesome/font-awesome.css"));
            
            bundles.Add(new StyleBundle("~/Content/skinblue").Include(
                "~/Content/AdminLTE/skins/skin-blue.css"));

            bundles.Add(new StyleBundle("~/Content/allskins").Include(
                "~/Content/AdminLTE/skins/_all-skins.min.css"));

            bundles.Add(new StyleBundle("~/Content/morrischart").Include(
                "~/Scripts/AdminLTE/plugins/morris/morris.css"));

            bundles.Add(new StyleBundle("~/Content/jvectormap").Include(
                "~/Scripts/AdminLTE/plugins/jvectormap/jquery-jvectormap-1.2.2.css"));

            bundles.Add(new StyleBundle("~/Content/daterangepicker").Include(
                "~/Scripts/AdminLTE/plugins/daterangepicker/daterangepicker-bs3.css"));

        }

    }
}