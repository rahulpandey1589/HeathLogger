using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace HealthLoggerAPI.Filters
{
    public class LogException : ExceptionFilterAttribute
    {
        public override Task OnExceptionAsync(ExceptionContext context)
        {
            return base.OnExceptionAsync(context);
        }
    }
}
