using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Tweetinvi;

namespace TwitterResponder
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Setup your credentials
            TwitterCredentials.SetCredentials("463985895-BhF4q7U06jGvIpvRx0XhpFwlWzKsM59nsHcmumIb", "x03IC553XSGApqtbhWPjFkTl5yoYd9RmgjcrFudJRWtQE", "LDimM12P2rHghdDaN0lwZb4ti", "3V6PbMd1gyRCFyAcREH4un7PfBLc73vyIvJFJCTDtirNPDzm2D");
        }
    }
}
