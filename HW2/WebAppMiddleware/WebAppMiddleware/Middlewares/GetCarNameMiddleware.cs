using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebAppMiddleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class GetCarNameMiddleware
    {
        private readonly RequestDelegate _next;

        public GetCarNameMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {

            var request = httpContext.Request;
            var response = httpContext.Response;

            string? carName = request.Query["name"];

            if (carName != null) {
                IManagementCars managementCars = new ManagementCars();
                var carListResult = managementCars.GetCarName(carName);

                await httpContext.Response.WriteAsync($"<h3>Search results for Name = {carName}:</h3>");

                if (carListResult.Count != 0)
                {
                    foreach (Car car in carListResult)
                    {
                        await httpContext.Response.WriteAsync($"Name={car.Name}, Engine={car.Engine}, Age={car.Age}<p>");
                    }
                }
                else {
                    await httpContext.Response.WriteAsync($"No results found for Name = {carName}<p>");
                }
            }
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class GetCarNameMiddlewareExtensions
    {
        public static IApplicationBuilder UseGetCarNameMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GetCarNameMiddleware>();
        }
    }
}
