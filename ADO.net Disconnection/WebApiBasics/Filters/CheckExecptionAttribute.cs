using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBasics.Filters
{
    public class CheckExceptionAttribute:ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            File.AppendAllText("Error.txt", $"Error:{context.Exception.Message}\npath:{context.HttpContext.Request.Path}\n");
            context.Result = new ObjectResult(new { Error = context.Exception.Message, Message="Got a problem!!! please try again\n" } );
            context.HttpContext.Response.StatusCode = 500;
        }
    }
}
