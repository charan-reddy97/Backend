using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBasics.Filters
{
    public class CheckIdParamAttribute : Attribute, IResourceFilter
    {
        void IResourceFilter.OnResourceExecuted(ResourceExecutedContext context)
        {
            
        }

        void IResourceFilter.OnResourceExecuting(ResourceExecutingContext context)
        {
            var queryData = context.RouteData;
            if (queryData.Values.Keys.Contains("id"))
            {
                var idValue = queryData.Values["id"].ToString();
                if (int.TryParse(idValue, out var id))
                {
                    if (id <= 0)
                    {
                        context.HttpContext.Response.StatusCode = 400;
                        context.Result = new ObjectResult(new
                        {
                            Error = "Id must be Greater than or equal to 0"

                        });
                        
                    }
                }
            }
        }
    }
}
