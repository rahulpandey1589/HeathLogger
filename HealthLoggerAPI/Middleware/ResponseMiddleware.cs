using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HealthLoggerAPI.Middleware
{
    public class ResponseMiddleware 
    {
        private readonly RequestDelegate _next;

        public ResponseMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            //Move to next delegate/middleware in the pipleline
            await _next.Invoke(httpContext);
        }
    }
}
