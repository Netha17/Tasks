using System.Web.Http;
using WebActivatorEx;
using SameOrigin;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace SameOrigin
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {

                        c.SingleApiVersion("v1", "SameOrigin");

                        c.IncludeXmlComments(string.Format(@"{0}bin\SameOrigin.xml", System.AppDomain.CurrentDomain.BaseDirectory));






                    })

                .EnableSwaggerUi(c =>
                {
                    c.InjectStylesheet(thisAssembly, "SameOrigin.Content.Swaggercss.css");
                });
                 
        }
    }
}