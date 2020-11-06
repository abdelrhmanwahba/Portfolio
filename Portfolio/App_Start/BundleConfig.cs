using System.Web.Optimization;

namespace Portfolio
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        // "~/Scripts/jquery-{version}.js"
                        "~/assets/js/jquery.min.js",
                        "~/assets/js/bs-init.js",
                        "~/assets/js/theme.js"

                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      // "~/Scripts/bootstrap.js"
                      "~/assets/bootstrap/js/bootstrap.min.js"
                      ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/assets/css/untitled.css",
                "~/assets/css/Pretty-Footer.css",
                "~/assets/css/Footer-with-social-media-icons.css",
                "~/assets/bootstrap/css/bootstrap.min.css",
                "~/assets/fonts/ionicons.min.css",
                "~/assets/fonts/font-awesome.min.css"
            ));

        }
    }
}
