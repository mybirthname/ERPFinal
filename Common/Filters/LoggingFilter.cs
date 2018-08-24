using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Common.Filters
{
    public class LoggingFilter: IAsyncActionFilter
    {
        private readonly ILogger<LoggingFilter> _logger;
        public LoggingFilter(ILogger<LoggingFilter> logger)
        {
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _logger.LogInformation($"Executing {context.ActionDescriptor.DisplayName} with method {context.HttpContext.Request.Method}");

            await next();

            _logger.LogInformation($"Executed {context.ActionDescriptor.DisplayName} with method {context.HttpContext.Request.Method}");

        }
    }
}
