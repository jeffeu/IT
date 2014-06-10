using System.Web;
using System.Web.Optimization;

namespace it
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

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
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/coral.css").Include(
                    "~/Content/coral/css/coral.css"
               ));
            bundles.Add(new ScriptBundle("~/mask.js").Include(
                    "~/Content/coral/jquery/mask.js"
                ));
            bundles.Add(new ScriptBundle("~/coral.js").Include(
                    "~/Content/coral/jquery/jquery.js",
                    "~/Content/coral/jquery/jquery-m.js",
                    "~/Content/coral/ie/ie.js",
                    "~/Content/coral/modernizr/modernizr.js",
                    "~/Content/coral/less/less.js"
               ));
        }
    }
}
