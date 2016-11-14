using System.IO;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.Swagger.Model;

namespace DotNetExampleApi.Configuration
{
    public class SwaggerConfiguration
    {
        public static void AddSwagger(IServiceCollection ServicesCollection)
        {
            // Determine base path for the application.
            var application = PlatformServices.Default.Application;
            var pathToDocumentation = System.IO.Path.Combine(application.ApplicationBasePath, System.IO.Path.ChangeExtension(application.ApplicationName, "xml"));

            ServicesCollection.ConfigureSwaggerGen(Options =>
            {
                Options.SingleApiVersion(new Info
                {
                    Version = "v1",
                    Title = "Authority Group",
                    Description = "ASP Net Core Web API",
                });

                // //Set the comments path for the swagger json and ui.
                // Options.IncludeXmlComments(pathToDocumentation);
                Options.IncludeXmlComments(Path.ChangeExtension(Assembly.GetEntryAssembly().Location, "xml"));
                Options.DescribeAllEnumsAsStrings();
            });
        }
    }
}