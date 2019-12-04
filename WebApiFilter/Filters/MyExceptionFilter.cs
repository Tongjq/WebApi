using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace WebApiFilter.Filters
{
    public class MyExceptionFilter : IExceptionFilter
    {
        public bool AllowMultiple => true;

        public async Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            Exception ex = actionExecutedContext.Exception;
        }
    }
}