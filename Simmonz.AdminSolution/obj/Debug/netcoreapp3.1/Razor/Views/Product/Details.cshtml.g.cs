#pragma checksum "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48ba9c1a71825cfbd97ddb51baeb12f82c43288c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\_ViewImports.cshtml"
using Simmonz.AdminSolution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\_ViewImports.cshtml"
using Simmonz.AdminSolution.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48ba9c1a71825cfbd97ddb51baeb12f82c43288c", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f307b8ea9f019453acdc8b8cf07a0006f1aed61a", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Simmonz.ViewModel.Product.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null ;
    var imagePath = "/img/"+ Model.Image;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        <dl class=\"row\">\r\n            <dt class=\"col-md-3\">\r\n                ");
#nullable restore
#line 12 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd  class=\"col-md-9\">\r\n                ");
#nullable restore
#line 15 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt  class=\"col-md-4\">\r\n                ");
#nullable restore
#line 18 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-md-8\">\r\n                ");
#nullable restore
#line 21 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt  class=\"col-md-3\">\r\n                ");
#nullable restore
#line 24 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd  class=\"col-md-9\">\r\n                ");
#nullable restore
#line 27 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt  class=\"col-md-3\">\r\n                ");
#nullable restore
#line 30 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd  class=\"col-md-9\">\r\n                <img style=\"width:200px\" id=\"img\"");
            BeginWriteAttribute("src", " src=\"", 1095, "\"", 1111, 1);
#nullable restore
#line 33 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
WriteAttributeValue("", 1101, imagePath, 1101, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </dd>\r\n            <dt  class=\"col-md-3\">\r\n                ");
#nullable restore
#line 36 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd  class=\"col-md-9\">\r\n                ");
#nullable restore
#line 39 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt  class=\"col-md-3\">\r\n                ");
#nullable restore
#line 42 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd  class=\"col-md-9\">\r\n                ");
#nullable restore
#line 45 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt  class=\"col-md-3\">\r\n                ");
#nullable restore
#line 48 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd  class=\"col-md-6\">\r\n                ");
#nullable restore
#line 51 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Details.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Simmonz.ViewModel.Product.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
