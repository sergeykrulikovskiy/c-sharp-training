using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebAppMiddleware.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class GetCarAgeMiddleware
    {
        private readonly RequestDelegate _next;

        public GetCarAgeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var request = httpContext.Request;
            var response = httpContext.Response;

            string? carAge = request.Query["age"];

            if (carAge != null)
            {
                await httpContext.Response.WriteAsync($"<h3>Search results for Age = {carAge}:</h3>");

                if (int.TryParse(carAge, out _))
                {
                    IManagementCars managementCars = new ManagementCars();
                    var carListResult = managementCars.GetCarAge(Convert.ToInt32(carAge));

                    if (carListResult.Count != 0)
                    {
                        foreach (Car car in carListResult)
                        {
                            await httpContext.Response.WriteAsync($"Name={car.Name}, Engine={car.Engine}, Age={car.Age}<p>");
                        }
                    }
                    else
                    {
                        await httpContext.Response.WriteAsync($"No results found for Age = {carAge}<p>");
                    }
                }
                else
                {
                    await httpContext.Response.WriteAsync($"No results found for Age = {carAge}.<p> <b>Incorrect format for AGE parameter: use NUMBERS only<b>");                    
                }
            }

            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class GetCarAgeMiddlewareExtensions
    {
        public static IApplicationBuilder UseGetCarAgeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GetCarAgeMiddleware>();
        }
    }
}
