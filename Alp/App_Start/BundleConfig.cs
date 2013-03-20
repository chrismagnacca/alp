using System.Web;
using System.Web.Optimization;

namespace Alp
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*",
                        "~/Scripts/site.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Site.css",
                "~/Content/Navigation.css",
                "~/Content/Body.css",
                "~/Content/Index.css"
                ));

            bundles.Add(new StyleBundle("~/Content/Themes/base/css").Include(
                        "~/Content/Themes/base/jquery.ui.core.css",
                        "~/Content/Themes/base/jquery.ui.resizable.css",
                        "~/Content/Themes/base/jquery.ui.selectable.css",
                        "~/Content/Themes/base/jquery.ui.accordion.css",
                        "~/Content/Themes/base/jquery.ui.autocomplete.css",
                        "~/Content/Themes/base/jquery.ui.button.css",
                        "~/Content/Themes/base/jquery.ui.dialog.css",
                        "~/Content/Themes/base/jquery.ui.slider.css",
                        "~/Content/Themes/base/jquery.ui.tabs.css",
                        "~/Content/Themes/base/jquery.ui.datepicker.css",
                        "~/Content/Themes/base/jquery.ui.progressbar.css",
                        "~/Content/Themes/base/jquery.ui.theme.css"));
        }
    }
}