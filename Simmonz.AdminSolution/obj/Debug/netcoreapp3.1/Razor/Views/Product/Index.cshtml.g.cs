#pragma checksum "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8affba112a6a599d5dd19a0be57212173fea61e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Index.cshtml"
using Simmonz.ViewModel.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8affba112a6a599d5dd19a0be57212173fea61e", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f307b8ea9f019453acdc8b8cf07a0006f1aed61a", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<Simmonz.ViewModel.Product.ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"view-all\">\r\n    ");
#nullable restore
#line 9 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Product\Index.cshtml"
Write(await Html.PartialAsync("_ViewAll", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<Simmonz.ViewModel.Product.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
