#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ece9121aaa767921cc08d2dad2f1a83fa559e266"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ece9121aaa767921cc08d2dad2f1a83fa559e266", @"/Areas/Client/Views/Dm/TinThue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7251536ff652c19e939378bbe977efbd6c44f44", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Dm_TinThue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<BatDongSanId.Areas.Client.Models.ViewModels.TinBDSViewModel>>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
   ViewData["Title"] = "Tin cho thuê";
    Layout = "~/Areas/Client/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"hotel-rooms spad\" style=\"padding-top:0px;\">\n    <div class=\"container card\">\n        <div class=\"row card-header\">Tin cho thuê</div>\n        <div class=\"row card-body\">\n");
#nullable restore
#line 12 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
             foreach (var tin in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-6 col-xl-6\">\n                    <div class=\"room-items\">\n                        <div style=\"margin: 5px;\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ece9121aaa767921cc08d2dad2f1a83fa559e2666093", async() => {
#nullable restore
#line 16 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
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
#line 16 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
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
            WriteLiteral("\n                        </div>\n\n                        <div class=\"row\" style=\"margin:5px\">\n                            <div class=\"room-img set-bg col-md-3\" data-setbg=\"");
#nullable restore
#line 20 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                         Write(Html.Raw(tin.HinhAnh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ece9121aaa767921cc08d2dad2f1a83fa559e2669444", async() => {
                WriteLiteral("\n                                    <button");
                BeginWriteAttribute("id", " id=\"", 1095, "\"", 1122, 1);
#nullable restore
#line 22 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
WriteAttributeValue("", 1100, Html.Raw(tin.HinhAnh), 1100, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"room-content border-0\" style=\"background-color: transparent\"");
                BeginWriteAttribute("data", " data=\"", 1191, "\"", 1205, 1);
#nullable restore
#line 22 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
WriteAttributeValue("", 1198, tin.ID, 1198, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                        <i class=\"flaticon-heart\"></i>\n                                    </button>\n                                ");
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
                                        <a href=""#"">
                                            <i class=""flaticon-placeholder""></i> <span>");
#nullable restore
#line 31 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                  Write(Html.Raw(tin.QuanHuyen));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 31 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                             Write(Html.Raw(tin.TinhThanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                        </a>\n                                        <br />\n                                        <a href=\"#\" class=\"large-width\">\n                                            <i class=\"flaticon-timer\"></i><span>");
#nullable restore
#line 35 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
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
");
#nullable restore
#line 42 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                             if (Html.Raw(tin.XacThuc).ToString() == "Xác thực")
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Diện tích: ");
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
            WriteLiteral(" | Xác thực</p>");
#nullable restore
#line 43 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                                                 }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Diện tích: ");
#nullable restore
#line 45 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                  Write(Html.Raw(tin.DienTich));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m2 | Hướng:");
#nullable restore
#line 45 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                     Write(Html.Raw(tin.Huong));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Chưa xác thực</p>");
#nullable restore
#line 45 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\n                                        <br />\n                                        <div class=\"size\">\n                                            <p>");
#nullable restore
#line 49 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                          Write(Html.Raw(tin.LoaiTin));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 49 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                   Write(Html.Raw(tin.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                        </div>\n                                        <div class=\"beds\">\n                                            <p>Liên hệ: ");
#nullable restore
#line 52 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                   Write(Html.Raw(tin.LienHe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                        </div>\n                                    </div>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                </div>");
#nullable restore
#line 59 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</section>\n\n<!-- Thêm mã phân trang -->\n<br />\nTrang ");
#nullable restore
#line 66 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
  Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 66 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                                                                Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 68 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("TinBan", new { page, @class = "page-item" }),
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
#line 84 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
                  Write(Context.Session.GetInt32("userID"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n            if (user == null) {\n                alert(\"Bạn chưa đăng nhập!\");\n                return false;\n            }\n            $.ajax({\n                url: \'");
#nullable restore
#line 90 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\TinThue.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<BatDongSanId.Areas.Client.Models.ViewModels.TinBDSViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
