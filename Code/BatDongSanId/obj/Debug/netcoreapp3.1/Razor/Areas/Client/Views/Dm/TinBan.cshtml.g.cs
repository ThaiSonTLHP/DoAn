#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9f1ae633358c1c885186819eb6a26567a34292e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Dm_TinBan), @"mvc.1.0.view", @"/Areas/Client/Views/Dm/TinBan.cshtml")]
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
#line 7 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9f1ae633358c1c885186819eb6a26567a34292e", @"/Areas/Client/Views/Dm/TinBan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7251536ff652c19e939378bbe977efbd6c44f44", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Dm_TinBan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<BatDongSanId.Areas.Client.Models.ViewModels.TinBDSViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QuanLyTaiKhoan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LuuTin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("room-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
   ViewData["Title"] = "Trang chủ";
    Layout = "~/Areas/Client/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
   ViewData["Title"] = "Tin bán"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container\">\n    <div class=\"row\">\n");
#nullable restore
#line 13 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
         foreach (var tin in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 col-md-6\">\n                <div class=\"room-items\">\n                    <div class=\"room-img set-bg\" data-setbg=\"");
#nullable restore
#line 17 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
                                                        Write(Html.Raw(tin.HinhAnh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9f1ae633358c1c885186819eb6a26567a34292e6036", async() => {
                WriteLiteral("\n                            <i class=\"flaticon-heart\"></i>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                    <div class=\"room-text\">\n                        <div class=\"room-details\">\n                            <div class=\"room-title\">\n                                <h5>");
#nullable restore
#line 25 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
                               Write(Html.Raw(tin.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                <a href=\"#\">\n                                    <i class=\"flaticon-placeholder\"></i> <span>");
#nullable restore
#line 27 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
                                                                          Write(Html.Raw(tin.QuanHuyen));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 27 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
                                                                                                     Write(Html.Raw(tin.TinhThanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                </a>\n                                <br />\n                                <a href=\"#\" class=\"large-width\">\n                                    <i class=\"flaticon-timer\"></i><span>");
#nullable restore
#line 31 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
                                                                   Write(Html.Raw(tin.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </a>
                            </div>
                        </div>
                        <div class=""room-features"">
                            <div class=""room-info"">
                                <div class=""baths"">
                                    <p>Người đăng</p>
");
            WriteLiteral("                                    <span>");
#nullable restore
#line 40 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
                                     Write(Html.Raw(tin.NguoiDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                </div>\n                                <div class=\"size\">\n                                    <p>Diện tích</p>\n");
            WriteLiteral("                                    <i class=\"flaticon-bath\"></i>\n                                    <span>");
#nullable restore
#line 46 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
                                     Write(Html.Raw(tin.DienTich));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m2</span>\n                                </div>\n                                <div class=\"beds\">\n                                    <p>Hướng</p>\n");
            WriteLiteral("                                    <span>");
#nullable restore
#line 51 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
                                     Write(Html.Raw(tin.Huong));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                </div>\n                                <div class=\"garage\">\n                                    <p>Xác thực</p>\n");
            WriteLiteral("                                    <span>1</span>\n                                </div>\n                            </div>\n                        </div>\n                        <div class=\"room-price\">\n                            <p>");
#nullable restore
#line 61 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
                          Write(Html.Raw(tin.LoaiTin));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <span>");
#nullable restore
#line 62 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
                             Write(Html.Raw(tin.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> VNĐ\n                        </div>\n                        <a href=\"#\" class=\"site-btn btn-line\">Xem chi tiết</a>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 68 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n<!-- Thêm mã phân trang -->\n<br />\nTrang ");
#nullable restore
#line 74 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
  Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 74 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
                                                                Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 76 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinBan.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("TinBan", new { page, @class = "page-item" }),
    new PagedListRenderOptions
    {
        LiElementClasses = new string[] { "page-item" },
        PageClasses = new string[] { "page-link" }
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Kết thúc -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<BatDongSanId.Areas.Client.Models.ViewModels.TinBDSViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
