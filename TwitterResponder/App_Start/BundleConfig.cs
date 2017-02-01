using System.Web;
using System.Web.Optimization;

namespace TwitterResponder
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //scripts
            bundles.Add(new ScriptBundle("~/Content/Scripts/jquery").Include("~/Content/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/Content/Scripts/jqueryval").Include("~/Content/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/Content/Scripts/bootstrap").Include("~/Content/Scripts/bootstrap.js", "~/Content/Scripts/respond.js"));
            //styles
            bundles.Add(new StyleBundle("~/Content/Styles/css").Include("~/Content/Styles/bootstrap.css", "~/Content/Styles/site.css"));
            //optimize
            BundleTable.EnableOptimizations = true;
        }
    }
}
