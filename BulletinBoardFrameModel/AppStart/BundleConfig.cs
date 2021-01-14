using System.Web;
using System.Web.Optimization;

namespace BulletinBoardFrameModel
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Resources/js/lib/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Resources/js/lib/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Resources/css/lib/css").Include(
                      "~/Resources/css/lib/bootstrap.css",
                      "~/Resources/css/common/site.css",
                      "~/Resources/css/post/list.css"));
        }
    }
}
