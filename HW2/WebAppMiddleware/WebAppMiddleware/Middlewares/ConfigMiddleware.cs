using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebAppMiddleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ConfigMiddleware
    {
        private readonly RequestDelegate _next;

        public ConfigMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            
            var request  = httpContext.Request;
            var response = httpContext.Response;
            IManagementCars managementCars = new ManagementCars();

            response.ContentType = "text/html";
            string? carAge = request.Query["age"];
            string? carName = request.Query["name"];
            string? carEngine = request.Query["engine"];

            if ((carAge == null && carName == null && carEngine == null) || request.QueryString.ToString() == "")
            {
                response.StatusCode = 500;

                var vendors = managementCars.getVendors();
                var engines = managementCars.getEngines();
                
                var sampleVendor = vendors[Random.Shared.Next(vendors.Length)];
                var sampleEngine = engines[Random.Shared.Next(engines.Length)];
                int sampleMaxAge = managementCars.getMaxAge();
                var sampleAge = Random.Shared.Next(0, sampleMaxAge);

                await response.WriteAsync("<h3>No params found!</h3><p> " +
                                            "Try to find one of: <p>" +
                                            $"<b>name</b> = <i>{string.Join(", ", vendors)}</i><p>" +
                                            $"<b>engine</b> = <i>{string.Join(", ", engines)}</i><p>" +
                                            $"<b>age</b> = <i>numbers from 1 to {sampleMaxAge}</i><p>" +
                                            "Note: application will ignore any other parameters " +
                                            $"<p> <h3>Samples:</h3>" +
                                            $"<ol>" +
                                                $"<li>?name={sampleVendor}" +
                                                $"<li>?age={sampleAge}" +
                                                $"<li>?engine={sampleEngine}" +
                                                $"<li>?name={sampleVendor}&age={sampleAge}" +
                                                $"<li>?name={sampleVendor}&age=1&engine={sampleEngine}" +
                                                $"<li>any other combinataion like above" +
                                            $"</ol>"
                                            );
            }
            else
            {
                await _next(httpContext);
            }
            
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ConfigMiddlewareExtensions
    {
        public static IApplicationBuilder UseConfigMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ConfigMiddleware>();
        }
    }
}
