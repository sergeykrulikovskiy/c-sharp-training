using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebAppRazor
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class GetCarEngineMiddleware
    {
        private readonly RequestDelegate _next;

        public GetCarEngineMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var request = httpContext.Request;
            var response = httpContext.Response;

            string? carEngine = request.Query["engine"];

            if (carEngine != null) {
                IManagementCars managementCars = new ManagementCars();
                var carListResult = managementCars.GetCarEngine(carEngine);
                
                await httpContext.Response.WriteAsync($"<h3>Search results for engine={carEngine}:</h3>");

                if (carListResult.Count != 0)
                {
                    foreach (Car car in carListResult)
                    {
                        await httpContext.Response.WriteAsync($"Name={car.Name}, Engine={car.Engine}, Age={car.Age}<p>");
                    }
                }
                else
                {
                    await httpContext.Response.WriteAsync($"No results found for Engine = {carEngine}<p>");
                }
            }

            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class GetCarEngineMiddlewareExtensions
    {
        public static IApplicationBuilder UseGetCarEngineMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GetCarEngineMiddleware>();
        }
    }
}
