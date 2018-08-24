using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Common.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        //should be logger with proper logger or into the db
        private readonly ILogger<ExceptionFilter> _logger;

        public ExceptionFilter(ILogger<ExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            _logger.Log(LogLevel.Error, $"Exception Message:{context.Exception.Message}");
            _logger.Log(LogLevel.Error, $"Exception Source:{context.Exception.Source}");
            _logger.Log(LogLevel.Error, $"Exception CallStack:{context.Exception.StackTrace}");

        }

    }
}
