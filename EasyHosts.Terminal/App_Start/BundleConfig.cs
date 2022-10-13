﻿using System.Web;
using System.Web.Optimization;

namespace EasyHosts.Terminal
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/bootstrap-css").Include(
                     "~/Content/bootstrap-css/bootstrap.css",
                     "~/Content/bootstrap-css/bootstrap-grid.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-icons").Include(
                     "~/Content/bootstrap-icons/bootstrap-icons.css",
                     "~/Content/bootstrap-icons/bootstrap-icons.json",
                     "~/Content/bootstrap-icons/bootstrap-icons.scss",
                     "~/Content/bootstrap-icons/fonts/bootstrap-icons.woff",
                     "~/Content/bootstrap-icons/fonts/bootstrap-icons.woff2"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootstrap.bundle.js",
                      "~/Scripts/bootstrap.esm.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Scripts/jquery-3.4.1.js"));

           
        }
    }
}
