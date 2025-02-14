using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SimpleRazerWebApp.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class TestMiddleware
    {
        // _next represents the request delegate of the next middleware in the middleware pipeline
        private readonly RequestDelegate _next;

        public TestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        // here we will process our http request and call request delegate which takes HttpContext object as argument
        public async Task Invoke(HttpContext httpContext)
        {
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class TestMiddlewareExtensions
    {
        public static IApplicationBuilder UseTestMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TestMiddleware>();
        }
    }
}
