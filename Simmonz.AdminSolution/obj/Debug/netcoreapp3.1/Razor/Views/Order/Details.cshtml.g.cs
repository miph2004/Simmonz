#pragma checksum "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69280acfee97ab4d63c48196329f8b4627663092"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69280acfee97ab4d63c48196329f8b4627663092", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f307b8ea9f019453acdc8b8cf07a0006f1aed61a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Simmonz.ViewModel.OrderDetail.OrderDetailViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"card mb-4\">\r\n        <div class=\"card-header\">\r\n            <div class=\"row\">\r\n            </div>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 16 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
                 if (ViewBag.SuccessMsg != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                        ");
#nullable restore
#line 19 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
                   Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 21 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"table-responsive\">\r\n\r\n                <table class=\"table table-bordered\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
#line 29 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 32 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 35 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 41 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 46 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 49 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 52 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 56 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Simmonz.ViewModel.OrderDetail.OrderDetailViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
