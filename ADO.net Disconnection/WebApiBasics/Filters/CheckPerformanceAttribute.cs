using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBasics.Filters
{
    public class CheckPerformanceAttribute :ActionFilterAttribute
    {
        Stopwatch stopwatch = new Stopwatch();
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            stopwatch.Stop();
            File.WriteAllText("Performance.txt", $"Took=>{stopwatch.ElapsedMilliseconds}");
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            stopwatch.Start();
        }
    }
}
