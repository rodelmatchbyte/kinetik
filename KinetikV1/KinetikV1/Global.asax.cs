using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using KinetikV1.Domain.Interfaces;
using KinetikV1.Repository;

namespace KinetikV1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterApis(GlobalConfiguration.Configuration);
        }

        public static void RegisterApis(HttpConfiguration config)
        {
            // remove default Xml handlers
            // This will make clients to receive only json data, instead of xml. e.g. Firefox
            var xmlMediaTypes = config.Formatters
                .Where(f => f.SupportedMediaTypes.Count(m => m.MediaType == "application/xml" || m.MediaType == "text/xml") > 0);

            xmlMediaTypes.ToList().ForEach(m => config.Formatters.Remove(m));


        }
    }
}