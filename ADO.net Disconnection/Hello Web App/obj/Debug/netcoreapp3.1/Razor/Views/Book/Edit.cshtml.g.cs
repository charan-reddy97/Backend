#pragma checksum "C:\Users\VMUser\source\repos\ADO.net Disconnection\Hello Web App\Views\Book\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a3fd27a8d8ebf3e6f20e246353bd83eae59c8b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Edit), @"mvc.1.0.view", @"/Views/Book/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a3fd27a8d8ebf3e6f20e246353bd83eae59c8b0", @"/Views/Book/Edit.cshtml")]
    public class Views_Book_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloWeb.Model.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\VMUser\source\repos\ADO.net Disconnection\Hello Web App\Views\Book\Edit.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<form action=\"/books/edit\" method=\"post\">\r\n\r\n    <div class=\"card m-5\">\r\n        <div class=\"card-body\">\r\n            ");
#nullable restore
#line 9 "C:\Users\VMUser\source\repos\ADO.net Disconnection\Hello Web App\Views\Book\Edit.cshtml"
       Write(Html.TextBoxFor(d => d.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 10 "C:\Users\VMUser\source\repos\ADO.net Disconnection\Hello Web App\Views\Book\Edit.cshtml"
       Write(Html.ValidationMessageFor(d => d.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 12 "C:\Users\VMUser\source\repos\ADO.net Disconnection\Hello Web App\Views\Book\Edit.cshtml"
       Write(Html.TextBoxFor(d => d.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\VMUser\source\repos\ADO.net Disconnection\Hello Web App\Views\Book\Edit.cshtml"
       Write(Html.ValidationMessageFor(d => d.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 15 "C:\Users\VMUser\source\repos\ADO.net Disconnection\Hello Web App\Views\Book\Edit.cshtml"
       Write(Html.TextBoxFor(d => d.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\VMUser\source\repos\ADO.net Disconnection\Hello Web App\Views\Book\Edit.cshtml"
       Write(Html.ValidationMessageFor(d => d.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save Book</button>\r\n        </div>\r\n    </div>\r\n\r\n</form> ");
#nullable restore
#line 23 "C:\Users\VMUser\source\repos\ADO.net Disconnection\Hello Web App\Views\Book\Edit.cshtml"
        }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger m-5\">Book cannot be found</div>\r\n");
#nullable restore
#line 27 "C:\Users\VMUser\source\repos\ADO.net Disconnection\Hello Web App\Views\Book\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloWeb.Model.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
