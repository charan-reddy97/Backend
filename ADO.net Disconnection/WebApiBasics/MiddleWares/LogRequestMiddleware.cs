using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBasics.MiddleWares
{
    public class LogRequestMiddleware
    {
        private readonly RequestDelegate _next;

        public LogRequestMiddleware(RequestDelegate requestDelegate)
        {
            _next = requestDelegate;
        }
        public Task Invoke(HttpContext context)
        {
            File.AppendAllText("Log.txt",$"Request=>"+$"{context.Request.Path},Date Time:{DateTime.Now}\n");
            return _next(context);
        }
    }
}
