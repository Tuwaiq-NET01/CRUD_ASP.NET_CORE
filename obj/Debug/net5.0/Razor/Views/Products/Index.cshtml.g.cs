#pragma checksum "/Users/sami/Projects/CRUD_with_ASP.NET/CRUD_with_ASP.NET/Views/Products/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf738dc722c0927f762311f5336fe919a1144e83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#nullable restore
#line 1 "/Users/sami/Projects/CRUD_with_ASP.NET/CRUD_with_ASP.NET/Views/_ViewImports.cshtml"
using CRUD_with_ASP.NET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sami/Projects/CRUD_with_ASP.NET/CRUD_with_ASP.NET/Views/_ViewImports.cshtml"
using CRUD_with_ASP.NET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf738dc722c0927f762311f5336fe919a1144e83", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9326bcc71f746651d53f64cdc22277b839bd00a", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/sami/Projects/CRUD_with_ASP.NET/CRUD_with_ASP.NET/Views/Products/Index.cshtml"
  
    var Proudcts = (List<ProductModel>)ViewData["Products"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Details</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "/Users/sami/Projects/CRUD_with_ASP.NET/CRUD_with_ASP.NET/Views/Products/Index.cshtml"
         foreach (var Product in Proudcts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th scope=\"row\">");
#nullable restore
#line 23 "/Users/sami/Projects/CRUD_with_ASP.NET/CRUD_with_ASP.NET/Views/Products/Index.cshtml"
                           Write(Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 24 "/Users/sami/Projects/CRUD_with_ASP.NET/CRUD_with_ASP.NET/Views/Products/Index.cshtml"
               Write(Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "/Users/sami/Projects/CRUD_with_ASP.NET/CRUD_with_ASP.NET/Views/Products/Index.cshtml"
               Write(Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "/Users/sami/Projects/CRUD_with_ASP.NET/CRUD_with_ASP.NET/Views/Products/Index.cshtml"
               Write(Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" SAR</td>\n                <td><button type=\"button\" class=\"btn btn-dark\"><a style=\"color:white\"");
            BeginWriteAttribute("href", "href=\"", 689, "\"", 724, 2);
            WriteAttributeValue("", 695, "/products/details/", 695, 18, true);
#nullable restore
#line 27 "/Users/sami/Projects/CRUD_with_ASP.NET/CRUD_with_ASP.NET/Views/Products/Index.cshtml"
WriteAttributeValue("", 713, Product.Id, 713, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> SHOW </a></button></td>\n            </tr>\n");
#nullable restore
#line 29 "/Users/sami/Projects/CRUD_with_ASP.NET/CRUD_with_ASP.NET/Views/Products/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
