using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Razor.Generator;

namespace MyFirstAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            // Remove XML Formatter
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Add(config.Formatters.JsonFormatter); //Add Json Formatters

            // Configure JSON Formatter
            //var jsonFormatter = config.Formatters.JsonFormatter;
            //jsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented; // For pretty print
            //jsonFormatter.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(); // CamelCase
        }
    }
    }
