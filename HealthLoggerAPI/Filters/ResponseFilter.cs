using HealthLoggerAPI.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HealthLoggerAPI.Filters
{
    public class ResponseFilter : ResultFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            base.OnResultExecuted(context);
        }
    }
}
