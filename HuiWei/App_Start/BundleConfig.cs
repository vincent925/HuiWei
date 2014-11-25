using System.Web;
using System.Web.Optimization;

namespace HuiWei
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/layout").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/docs.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/ie").Include(
                      "~/Scripts/ie-emulation-modes-warning.js",
                      "~/Scripts/ie10-viewport-bug-workaround.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/css/blog.css"));
        }
    }
}
