using System.Web;
using System.Web.Optimization;

namespace Trade.Manage
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                        "~/css/bootstrap.min.css",
                        "~/css/font-awesome.min.css",
                        "~/css/ionicons.min.css",
                        "~/css/morris/morris.css",
                        "~/css/jvectormap/jquery-jvectormap-1.2.2.css",
                        "~/css/fullcalendar/fullcalendar.css",
                        "~/css/daterangepicker/daterangepicker-bs3.css",
                        "~/css/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                        "~/css/AdminLTE.css"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/trade").Include(
                        "~/js/jquery-{version}.min.js",
                        "~/js/jquery-ui-{version}.min.js", 
                        "~/js/bootstrap.min.js", 
                        "~/js/bootstrap.min.js",
                        "~/js/plugins/raphael/raphael-min.js",
                        "~/js/plugins/morris/morris.min.js",
                        "~/js/plugins/sparkline/jquery.sparkline.min.js",
                        "~/js/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                        "~/js/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                        "~/js/plugins/fullcalendar/fullcalendar.min.js",
                        "~/js/plugins/jqueryKnob/jquery.knob.js",
                        "~/js/plugins/daterangepicker/daterangepicker.js",
                        "~/js/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                        "~/js/plugins/iCheck/icheck.min.js",
                        "~/js/plugins/pace/pace.min.js",
                        "~/js/AdminLTE/app.js"
                        ));

#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
