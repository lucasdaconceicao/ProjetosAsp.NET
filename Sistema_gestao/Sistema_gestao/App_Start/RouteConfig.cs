using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sistema_gestao
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Criar produtos",
                url: "criar/",
                defaults: new { controller = "Produtos", action = "Criar" }
            );
            routes.MapRoute(
                name: "Detalhes produtos",
                url: "detalhes-{id}/",
                defaults: new { controller = "Produtos", action = "Detalhes" }
            );
            routes.MapRoute(
                name: "Excluir produtos",
                url: "excluir-{id}/",
                defaults: new { controller = "Produtos", action = "Delete" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Produtos", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
