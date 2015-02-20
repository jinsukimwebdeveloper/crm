using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace crm
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void Application_BeginRequest(Object source, EventArgs e)
        {
            string culture;
            if (Request.Cookies["lang"] != null)
            {
                culture = Request.Cookies["lang"].Value;
                culture = string.IsNullOrEmpty(culture) ? "en-US" : culture;
            }
            else
            {
                // Browser's default language setting value
                culture = Request.UserLanguages[0];
            }

            HttpApplication application = (HttpApplication)source;
            HttpContext context = application.Context;

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
        }
    }
}
