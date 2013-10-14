using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace KinetikV1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.Routes.MapHttpRoute(
                name: "LogoUrl",
                routeTemplate: "api/account/{id}/logo",
                defaults: new { controller = "Account", action = "GetLogoUrl"}
            );

            config.Routes.MapHttpRoute(
                name: "CompanyLogoApi",
                routeTemplate: "api/logos/logo-{id}",
                defaults: new { controller = "Account", action = "GetLogo" }
            );

            config.Routes.MapHttpRoute(
                name: "Account",
                routeTemplate: "api/account/{id}",
                defaults: new { controller = "Account", action = "Get" }
            );

            //config.Routes.MapHttpRoute(
            //    name: "Receipt",
            //    routeTemplate: "api/receipt/{id}",
            //    defaults: new {controller = "Receipt", action = "GetReceipt"}
            //);

            config.Routes.MapHttpRoute(
                name: "Receipts",
                routeTemplate: "api/receipt/",
                defaults: new { controller = "Receipt", action = "Get" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
