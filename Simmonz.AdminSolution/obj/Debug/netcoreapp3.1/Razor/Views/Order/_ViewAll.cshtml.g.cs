#pragma checksum "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f9ac7c99231eadaf587f6703d74183c61682008"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order__ViewAll), @"mvc.1.0.view", @"/Views/Order/_ViewAll.cshtml")]
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
#line 1 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
using Simmonz.ViewModel.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f9ac7c99231eadaf587f6703d74183c61682008", @"/Views/Order/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f307b8ea9f019453acdc8b8cf07a0006f1aed61a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<Simmonz.ViewModel.Order.OrderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryConfirmOrder(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
  
    ViewData["Title"] = "_ViewAll";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh sách đơn hàng </h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách đơn hàng</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            <div class=""row"">
               
                <div class=""col-md-6 col-xs-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f9ac7c99231eadaf587f6703d74183c616820085854", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-9\">\r\n                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 786, "\"", 810, 1);
#nullable restore
#line 22 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
WriteAttributeValue("", 794, ViewBag.Keyword, 794, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""keyword"" class=""form-control"" />
                            </div>
                            <div class=""cold-md-3"">
                                <button type=""submit"" class=""btn btn-outline-primary"">Tìm</button>
                                <button type=""button"" onclick=""window.location.href='/Order/Index'"" class=""btn btn-outline-secondary"">Reset</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 35 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                 if (ViewBag.SuccessMsg != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                        ");
#nullable restore
#line 38 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                   Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 40 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""table-responsive"">

                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>
                                Mã đơn hàng
                            </th>
                            <th>
                                Tổng tiền
                            </th>

                            <th>
                                Giam giá
                            </th>
                            <th>
                                Tình trạng
                            </th>

                            <th>
                                Mã hóa đơn
                            </th>
                            <th>
                                Thời gian đặt
                            </th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 71 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                         foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 75 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 78 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 81 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 84 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                     if (item.Status == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"btn-outline-danger\">Chưa xác nhận</span>\r\n");
#nullable restore
#line 87 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                    }
                                    else if (item.Status == 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"btn-outline-primary\">Đã xác nhận</span>\r\n");
#nullable restore
#line 91 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                    }
                                    else if (item.Status == 2)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"btn-outline-info\">Đang giao</span>\r\n");
#nullable restore
#line 95 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"btn-outline-success\">Hoàn thành</span>\r\n");
#nullable restore
#line 99 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 103 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TransactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 106 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                               Write(Html.DisplayFor(modelItem=>item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n\r\n");
#nullable restore
#line 110 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                     if (item.Status == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f9ac7c99231eadaf587f6703d74183c6168200815353", async() => {
                WriteLiteral("\r\n                                            <input type=\"submit\" value=\"Xác nhận \" class=\"btn btn-outline-info\" />\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 115 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                    }
                                    else if (item.Status == 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f9ac7c99231eadaf587f6703d74183c6168200818581", async() => {
                WriteLiteral("\r\n                                            <input type=\"submit\" value=\"Giao hàng \" class=\"btn btn-outline-info\" />\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 121 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                    }
                                    else if (item.Status == 2)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f9ac7c99231eadaf587f6703d74183c6168200821810", async() => {
                WriteLiteral("\r\n                                            <input type=\"submit\" value=\"Hoàn thành\" class=\"btn btn-outline-info\" />\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 127 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 6041, "\"", 6162, 6);
            WriteAttributeValue("", 6051, "showInPopUp(\'", 6051, 13, true);
#nullable restore
#line 128 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
WriteAttributeValue("", 6064, Url.Action("Details","Order",new { orderId=item.Id},Context.Request.Scheme), 6064, 76, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6140, "\',\'Chi", 6140, 6, true);
            WriteAttributeValue(" ", 6146, "tiết", 6147, 5, true);
            WriteAttributeValue(" ", 6151, "đơn", 6152, 4, true);
            WriteAttributeValue(" ", 6155, "hàng\')", 6156, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">\r\n                                        Chi tiết\r\n                                    </a>\r\n                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 6325, "\"", 6463, 6);
            WriteAttributeValue("", 6335, "showInPopUp(\'", 6335, 13, true);
#nullable restore
#line 131 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
WriteAttributeValue("", 6348, Url.Action("GetTransaction","Order",new { transId=item.TransactionId},Context.Request.Scheme), 6348, 94, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6442, "\',\'Chi", 6442, 6, true);
            WriteAttributeValue(" ", 6448, "tiết", 6449, 5, true);
            WriteAttributeValue(" ", 6453, "hóa", 6454, 4, true);
            WriteAttributeValue(" ", 6457, "đơn\')", 6458, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">\r\n                                        Hóa đơn\r\n                                    </a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 136 "C:\Hoc ky 2\Đồ án C#\Backup\SimmonzWebsite\Simmonz.AdminSolution\Views\Order\_ViewAll.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<Simmonz.ViewModel.Order.OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
