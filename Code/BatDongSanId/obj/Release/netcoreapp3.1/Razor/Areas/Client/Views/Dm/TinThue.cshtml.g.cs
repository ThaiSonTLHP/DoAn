#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "213b016c97e04be90468e332932114d75f1e0fa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Dm_TinThue), @"mvc.1.0.view", @"/Areas/Client/Views/Dm/TinThue.cshtml")]
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
#line 1 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\_ViewImports.cshtml"
using BatDongSan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\_ViewImports.cshtml"
using BatDongSan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213b016c97e04be90468e332932114d75f1e0fa6", @"/Areas/Client/Views/Dm/TinThue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7251536ff652c19e939378bbe977efbd6c44f44", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Dm_TinThue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BatDongSanId.Areas.Client.Models.ListViewModels.TrangChuListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChiTietTinBDS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:13pt;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:11pt;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TinVIP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
   ViewData["Title"] = "Tin thuê";
    Layout = "~/Areas/Client/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""row hotel-rooms spad"" style=""padding-top:0px;"">
    <div class=""col-md-8"" style=""padding-right: 0px;"">
        <div class=""container card"">
            <div class=""row card-header"" style=""background-color:#002d63; color:white;"">Tin tin thuê</div>
            <div class=""row card-body"">
");
#nullable restore
#line 13 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                 foreach (var tin in Model.TinPagedList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-12\" style=\"padding:5px;\">\n                        <div class=\" room-items mystyle-tin-border\">\n                            <div style=\"margin: 5px;\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213b016c97e04be90468e332932114d75f1e0fa67514", async() => {
#nullable restore
#line 17 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                                                      Write(Html.Raw(tin.TieuDe));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                    WriteLiteral(Html.Raw(tin.ID));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n\n                            <div class=\"row\" style=\"margin:5px\">\n                                <div class=\"room-img set-bg col-md-3\" data-setbg=\"");
#nullable restore
#line 21 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                             Write(Html.Raw(tin.HinhAnh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213b016c97e04be90468e332932114d75f1e0fa610894", async() => {
                WriteLiteral("\n                                        <button");
                BeginWriteAttribute("id", " id=\"", 1282, "\"", 1309, 1);
#nullable restore
#line 23 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
WriteAttributeValue("", 1287, Html.Raw(tin.HinhAnh), 1287, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"room-content border-0\" style=\"background-color: transparent\"");
                BeginWriteAttribute("data", " data=\"", 1378, "\"", 1392, 1);
#nullable restore
#line 23 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
WriteAttributeValue("", 1385, tin.ID, 1385, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                            <i class=\"flaticon-heart\"></i>\n                                        </button>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""room-text col-md-9"" style=""padding-top:0px;padding-bottom:0px;"">
                                    <div class=""room-details"" style=""padding-bottom:0px;"">
                                        <div class=""room-title"" style=""padding-right: 0px;"">
                                            <a href=""#"">
                                                <i class=""flaticon-placeholder""></i> <span style=""font-size:11pt;"">");
#nullable restore
#line 32 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                              Write(Html.Raw(tin.QuanHuyen));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 32 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                                                         Write(Html.Raw(tin.TinhThanh));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            </a>
                                            <br />
                                            <a href=""#"" class=""large-width"">
                                                <i class=""flaticon-timer""></i><span style=""font-size:11pt;"">");
#nullable restore
#line 36 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                       Write(Html.Raw(tin.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            </a>
                                        </div>
                                    </div>
                                    <div class=""room-features"" style=""padding-bottom:0px;margin-bottom:0px;"">
                                        <div class=""room-info"" style=""padding-right: 0px;"">
                                            <div class=""size"" style=""margin-right: 0px;"">
                                                <p style=""font-size:11pt;"">DT: ");
#nullable restore
#line 43 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                          Write(Html.Raw(tin.DienTich));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m2 | Hướng:");
#nullable restore
#line 43 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                             Write(Html.Raw(tin.Huong));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 44 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                 if (Html.Raw(tin.XacThuc).ToString() == "Xác thực")
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p style=\"font-size:11pt;\">Thông tin: Đã xác minh</p>");
#nullable restore
#line 45 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                      }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p style=\"font-size:11pt;\">Thông tin: Chưa xác minh</p>");
#nullable restore
#line 47 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p style=\"font-size:11pt;\">");
#nullable restore
#line 48 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                      Write(tin.LoaiTin);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 48 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                     Write(tin.Gia);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Liên hệ: ");
#nullable restore
#line 48 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                         Write(tin.LienHe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>");
#nullable restore
#line 55 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""col-md-4"" style=""margin-left:0px;"">
        <div class=""container card"" style=""margin-bottom: 30px;"">
            <div class=""row card-header"" style=""background-color:#9f0000; color:white;"">Tin VIP</div>
            <div class=""row card-body"" style=""padding:0px;"">
");
#nullable restore
#line 63 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                 foreach (var tin in Model.TinVIPViewModels)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-12\">\n                <div class=\" room-items mystyle-tin-border\" style=\"margin-top: 5px;\">\n                    <div style=\"margin: 5px;\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213b016c97e04be90468e332932114d75f1e0fa620005", async() => {
#nullable restore
#line 68 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                                              Write(Html.Raw(tin.TieuDe));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                            WriteLiteral(Html.Raw(tin.ID));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n\n                    <div class=\"row\" style=\"margin:5px\">\n                        <div class=\"room-img set-bg col-md-12\" data-setbg=\"");
#nullable restore
#line 72 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                      Write(Html.Raw(tin.HinhAnh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213b016c97e04be90468e332932114d75f1e0fa623332", async() => {
                WriteLiteral("\n                                <button");
                BeginWriteAttribute("id", " id=\"", 4767, "\"", 4794, 1);
#nullable restore
#line 74 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
WriteAttributeValue("", 4772, Html.Raw(tin.HinhAnh), 4772, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"room-content border-0\" style=\"background-color: transparent\"");
                BeginWriteAttribute("data", " data=\"", 4863, "\"", 4877, 1);
#nullable restore
#line 74 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
WriteAttributeValue("", 4870, tin.ID, 4870, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                    <i class=\"flaticon-heart\"></i>\n                                </button>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""room-text col-md-12"" style=""padding:0px;"">
                            <div class=""room-details"" style=""padding-bottom:0px;"">
                                <div class=""room-title"">
                                    <a href=""#"">
                                        <i class=""flaticon-placeholder""></i> <span style=""font-size:11pt;"">");
#nullable restore
#line 83 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                      Write(Html.Raw(tin.TinhThanh));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </a>
                                </div>
                            </div>
                            <div class=""room-features"" style=""padding-bottom:0px;padding-top:0px;margin-bottom:0px;"">
                                <div class=""room-info"" style=""padding-right: 0px;"">
                                    <div class=""size"">
                                        <p style=""font-size:11pt;"">");
#nullable restore
#line 90 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                              Write(tin.LoaiTin);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 90 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                             Write(tin.Gia);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 90 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                        Write(tin.LienHe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                    </div>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>");
#nullable restore
#line 97 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-12\">\n                    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213b016c97e04be90468e332932114d75f1e0fa628315", async() => {
                WriteLiteral("Xem thêm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
        <div class=""container card"" style=""margin-bottom: 30px;"">
            <div class=""row card-header"" style=""background-color:#9f0000; color:white;"">Theo tỉnh thành</div>
            <div class=""row card-body"" ");
            WriteLiteral(">\n");
#nullable restore
#line 106 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                 foreach (var tt in Model.TinBDSTinhThanhViewModels)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-12\">\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213b016c97e04be90468e332932114d75f1e0fa630137", async() => {
#nullable restore
#line 109 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                         Write(tt.Ten);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 109 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                  Write(tt.Tong);

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n    </div>");
#nullable restore
#line 110 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</section>\n\n<!-- Thêm mã phân trang -->\n<br />\nTrang ");
#nullable restore
#line 118 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
  Write(Model.TinPagedList.PageCount < Model.TinPagedList.PageNumber ? 0 : Model.TinPagedList.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 118 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                       Write(Model.TinPagedList.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 120 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
Write(Html.PagedListPager(Model.TinPagedList, page => Url.Action("TinBan", new { page, @class = "page-item" }),
    new PagedListRenderOptions
    {
        LiElementClasses = new string[] { "page-item" },
        PageClasses = new string[] { "page-link" }
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Kết thúc -->

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""button.room-content"").click(function (event) {
            event.preventDefault();
            event.stopPropagation();
            //var btn = $(""button.room-content"");
            var tin = $(this).attr(""data"");
            var user = ");
#nullable restore
#line 136 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                  Write(Context.Session.GetInt32("userID"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n            if (user == null) {\n                alert(\"Bạn chưa đăng nhập!\");\n                return false;\n            }\n            $.ajax({\n                url: \'");
#nullable restore
#line 142 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                 Write(Url.Action("LuuTin", "QuanLyTaiKhoan"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: { 'idUser': user, 'idTin': tin },
                type: ""post"",
                async: false,
                success: function (result) {
                    alert(""Đã lưu tin!"");
                }
            });
            return;
        });
    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BatDongSanId.Areas.Client.Models.ListViewModels.TrangChuListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
