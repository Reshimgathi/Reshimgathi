using System.Web;
using System.Web.Optimization;

namespace Reshimgathi
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new StyleBundle("~/Base/js").Include(
                      "~/js/bootstrap.js",
                      "~/js/config.js",
                      "~/js/jquery-1.11.1.min.js",
                      "~/js/jquery.swipebox.min.js",
                      "~/js/jquery.flexslider.js"));

            bundles.Add(new StyleBundle("~/Facebook/JS").Include(
                      "~/js/Facebook.js"));

            bundles.Add(new StyleBundle("~/Twitter/JS").Include(
                      "~/js/Twitter.js",
                      "~/js/oauth.js"));

            bundles.Add(new StyleBundle("~/Gmail/JS").Include(
                "~/js/Gmail.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Base/css").Include(
                      "~/css/bootstrap.css",
                      "~/css/style.css",
                      "~/css/swipebox.css"));

            bundles.Add(new StyleBundle("~/Twitter/CSS").Include(
                      "~/css/bootstrap-social.min.css",
                      "~/css/font-awesome.min.css"));

        }
    }
}
