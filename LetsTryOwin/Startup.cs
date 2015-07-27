using Owin;

namespace LetsTryOwin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWebApi(new WebApiConfig());    //added support for webapi

            app.Run(context =>
            {
                context.Response.ContentType = "application/json";
                return context.Response.WriteAsync("{ \"message\" : \"hello world!\"}");
            });
        }
    }
}