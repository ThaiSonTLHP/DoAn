#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbc71f507e8c45efe15c005aa22ef951a85163b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_QuanLyTaiKhoan_TinDaLuu), @"mvc.1.0.view", @"/Areas/Client/Views/QuanLyTaiKhoan/TinDaLuu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc71f507e8c45efe15c005aa22ef951a85163b0", @"/Areas/Client/Views/QuanLyTaiKhoan/TinDaLuu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7251536ff652c19e939378bbe977efbd6c44f44", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_QuanLyTaiKhoan_TinDaLuu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BatDongSanId.Areas.Client.Models.ViewModels.TinBDSViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChiTietTinBDS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:14px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
  
    ViewData["Title"] = "TinDaLuu";
    Layout = "~/Areas/Client/Views/Shared/_TaiKhoanLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container card @*col-lg-10 h-75*@ @*justify-content-center*@ align-items-center\" style=\"padding:0px;\">\r\n    <div class=\"row card-header col-lg-12\">Tin đã lưu</div>\r\n    <div class=\"row card-body\">\r\n");
#nullable restore
#line 10 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
         foreach (var tin in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-12 col-xl-12\">\r\n                <div class=\"room-items\">\r\n                    <div class=\"row\" style=\"margin:5px\">\r\n                        <div class=\"room-img set-bg col-md-3\" data-setbg=\"");
#nullable restore
#line 14 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                                                     Write(Html.Raw(tin.HinhAnh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc71f507e8c45efe15c005aa22ef951a85163b05976", async() => {
                WriteLiteral("\r\n                                <button");
                BeginWriteAttribute("id", " id=\"", 761, "\"", 788, 1);
#nullable restore
#line 16 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
WriteAttributeValue("", 766, Html.Raw(tin.HinhAnh), 766, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"room-content border-0\" style=\"background-color: transparent\"");
                BeginWriteAttribute("data", " data=\"", 857, "\"", 871, 1);
#nullable restore
#line 16 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
WriteAttributeValue("", 864, tin.ID, 864, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <i class=\"flaticon-heart\"></i>\r\n                                </button>\r\n                            ");
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
                                <div class=""room-title"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbc71f507e8c45efe15c005aa22ef951a85163b08605", async() => {
#nullable restore
#line 24 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                                                                                                                         Write(Html.Raw(tin.MoTa));

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
#line 24 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
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
            WriteLiteral("\r\n                                    <br />\r\n                                    <a href=\"#\">\r\n                                        <i class=\"flaticon-placeholder\"></i> <span>");
#nullable restore
#line 27 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                                                              Write(Html.Raw(tin.QuanHuyen));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 27 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                                                                                         Write(Html.Raw(tin.TinhThanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </a>\r\n                                    <a href=\"#\" class=\"large-width\">\r\n                                        <i class=\"flaticon-timer\"></i><span>");
#nullable restore
#line 30 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                                                       Write(Html.Raw(tin.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </a>
                                </div>
                            </div>
                            <div class=""room-features"" style=""padding-bottom:0px;margin-bottom:0px;"">
                                <div class=""room-info"">
                                    <div class=""size"">
                                        <p>Diện tích: ");
#nullable restore
#line 37 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                                 Write(Html.Raw(tin.DienTich));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m2 | Hướng:");
#nullable restore
#line 37 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                                                                    Write(Html.Raw(tin.Huong));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |</p>\r\n                                    </div>\r\n                                    <div class=\"beds\">\r\n\r\n                                    </div>\r\n                                    <div class=\"garage\">\r\n");
#nullable restore
#line 43 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                         if (Html.Raw(tin.XacThuc).ToString() == "Xác thực")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Xác thực: Xác thực</p>");
#nullable restore
#line 44 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                                                  }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Xác thực: Chưa</p>");
#nullable restore
#line 46 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <br />\r\n                                    <div class=\"size\">\r\n                                        <p>");
#nullable restore
#line 50 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                      Write(Html.Raw(tin.LoaiTin));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 50 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                                               Write(Html.Raw(tin.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"beds\">\r\n                                        <p>Liên hệ: ");
#nullable restore
#line 53 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                                               Write(Html.Raw(tin.LienHe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>");
#nullable restore
#line 60 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\TinDaLuu.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BatDongSanId.Areas.Client.Models.ViewModels.TinBDSViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591