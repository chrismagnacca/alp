﻿using System.Web;
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
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap-min.css",
                "~/Content/bootstrap-responsive-min.css",
                "~/Content/font-awesome-min.css",
                "~/Content/normalize.css",
                "~/Content/site.css",
                "~/Content/index.css",
                "~/Content/staff-and-faculty.css",
                "~/Content/fullcalendar.css",
                "~/Content/fullcalendar-print.css",
                "~/Content/school-calendar.css",
                "~/Content/contact-us.css",
                "~/Content/media-queries.css",
                "~/Content/jquery-ui-1.10.3.custom.min.css"
                ));

        }
    }
}