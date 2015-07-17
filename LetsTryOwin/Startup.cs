using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;

namespace LetsTryOwin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                context.Response.ContentType = "application/json";
                return context.Response.WriteAsync("{ \"message\" : \"hello world!\"}");
            });
        }
    }
}