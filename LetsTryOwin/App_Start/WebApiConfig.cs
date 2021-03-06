﻿using System.Web.Http;
using LightInject;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace LetsTryOwin
{
    public class WebApiConfig : HttpConfiguration
    {
        public WebApiConfig()
        {
            RegisterContainer();
            ConfigureRoutes();
            ConfigureSerializer();
        }

        private void ConfigureRoutes()
        {
            Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional}
                );
        }

        private void ConfigureSerializer()
        {
            var jsonSettings = Formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        private void RegisterContainer()
        {
            var container = new ServiceContainer();
            container.RegisterApiControllers();
            container.RegisterFrom<CompositionRoot>();
            container.EnableWebApi(this);
        }
    }
}