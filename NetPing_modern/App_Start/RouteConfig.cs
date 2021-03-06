﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NetPing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute("about", "about", new { controller = "InnerPages", action = "About" });
            routes.MapRoute("contacts", "contacts", new { controller = "InnerPages", action = "Contacts" });
            routes.MapRoute("vacancy", "vacancy", new { controller = "InnerPages", action = "Vacancy" });
            routes.MapRoute("support", "support", new { controller = "InnerPages", action = "Support" });
            routes.MapRoute("dev", "development", new { controller = "Products", action = "Development" });
            routes.MapRoute("archive", "archive", new { controller = "Products", action = "Archive" });

            //routes.MapRoute("buy", "buy", new { controller = "InnerPages", action = "Buy" });

            routes.MapRoute("cache_updated", "cache_updated", new { controller = "InnerPages", action = "UCache" });
            routes.MapRoute("cache_update_async", "cache_update_async", new { controller = "InnerPages", action = "UCacheAsync" });
            routes.MapRoute("stock_update", "stock_update", new { controller = "InnerPages", action = "UCacheStock" });

            routes.MapRoute("product_item_aspx", "product_item.aspx", new { controller = "Product_item", action = "Index" });
            /*
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute("about_aspx", "about.aspx", new { controller = "InnerPages", action = "About" });

            routes.MapRoute("contacts_aspx", "contacts.aspx", new { controller = "InnerPages", action = "Contacts" });

            routes.MapRoute("dealers_aspx", "dealer.aspx", new { controller = "InnerPages", action = "Dealers" });

            routes.MapRoute("zakaz_aspx", "zakaz.aspx", new { controller = "InnerPages", action = "Question" });

            

            routes.MapRoute("default_aspx", "default.aspx", new { controller = "MainPage", action = "Index" });

            
            */
            /*
            routes.MapRoute(
               name: "ASPX",
               url: "{controller}.aspx/{id}",
               defaults: new { action = "Index", id = UrlParameter.Optional },
               constraints: new {controller = "!Products"}
           );
            */

            routes.MapRoute(
                name: "Buy",
                url: "buy/{id}",
                defaults: new { controller = "InnerPages", action = "Buy",id=UrlParameter.Optional}
            );

            routes.MapRoute(
                name: "CatalogCompare",
                url: "Catalog/Compare",
                defaults: new { controller = "Products", action = "Compare" }
            );

            routes.MapRoute(
                name: "BlogCategory",
                url: "Blog/Category/{path}",
                defaults: new { controller = "Blog", action = "Category" }
            );

            routes.MapRoute(
                name: "BlogSearch",
                url: "Blog/Search",
                defaults: new { controller = "Blog", action = "Search" }
            );

            routes.MapRoute(
                name: "Blog",
                url: "Blog/{action}",
                defaults: new { controller = "Blog", action = "Main" },
                constraints: new {action = @"Main"}
            );

            routes.MapRoute(
                name: "BlogArticle",
                url: "Blog/{postname}",
                defaults: new { controller = "Blog", action = "Record" }
            );

            routes.MapRoute(
                name: "UserGuides",
                url: "UserGuide/{id}/{page}",
                defaults: new { controller = "Products", action = "UserGuide", id = UrlParameter.Optional, page = UrlParameter.Optional },
                constraints: new { controller = "Products" }
            );

            routes.MapRoute(
                name: "UserGuideSubPage",
                url: "GetSubPage/{id}/{page}/{subPage}",
                defaults: new { controller = "Products", action = "GetSubPage" },
                constraints: new { controller = "Products" }
            );

            routes.MapRoute(
                name: "UserGuidePage",
                url: "page/{page}/{subPage}",
                defaults: new { controller = "Products", action = "UserGuideSubPage", page = UrlParameter.Optional, subPage = UrlParameter.Optional },
                constraints: new { controller = "Products" }
            );

            routes.MapRoute(
                name: "Products",
                url: "products/{group}/{id}",
                defaults: new { controller = "Products", action = "Index", id = UrlParameter.Optional },
                constraints: new {controller = "Products"}
            );

            routes.MapRoute(
               name: "Solutions",
               url: "solutions",
               defaults: new { controller = "Products", action = "Solutions", id = UrlParameter.Optional },
               constraints: new { controller = "Products" }
           );

            routes.MapRoute(
               name: "SolutionsList",
               url: "solutions/{group}/{id}",
               defaults: new { controller = "Products", action = "Index", id = UrlParameter.Optional  },
               constraints: new { controller = "Products" }
           );

            routes.MapRoute(
               name: "view.aspx",
               url: "view.aspx/{id}",
               defaults: new { controller = "View", action = "Index", id = UrlParameter.Optional },
               constraints: new { controller = "View" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MainPage", action = "Index", id = UrlParameter.Optional }
            );
           
            
        }
    }
}