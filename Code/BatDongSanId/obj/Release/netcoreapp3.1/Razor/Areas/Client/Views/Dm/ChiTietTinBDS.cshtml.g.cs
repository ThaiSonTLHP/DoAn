#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "824d2a4be0c660bd69f4d4ee6b8375a8f592d982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Dm_ChiTietTinBDS), @"mvc.1.0.view", @"/Areas/Client/Views/Dm/ChiTietTinBDS.cshtml")]
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
#line 5 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"824d2a4be0c660bd69f4d4ee6b8375a8f592d982", @"/Areas/Client/Views/Dm/ChiTietTinBDS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7251536ff652c19e939378bbe977efbd6c44f44", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Dm_ChiTietTinBDS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BatDongSanId.Areas.Client.Models.ListViewModels.ChiTietBDSListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChiTietTinBDS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("aBaoCao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 13pt;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("baoCao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
   ViewData["Title"] = "ChiTietTinBDS";
    Layout = "~/Areas/Client/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .imgStyle {
        height: 100px;
        width: 100px;
        border: 1px solid grey;
    }
    .lienHe{
        font-size: 13pt;
    }
</style>

<div class=""container"">
    <h4>Thông tin chi tiết</h4>
    <hr />
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""row"">
                <div class=""col-lg-5"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 589, "\"", 643, 1);
#nullable restore
#line 24 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
WriteAttributeValue("", 595, Html.Raw(Model.taiKhoanViewModel.AnhDaiDienUrl), 595, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border:1px solid black;width: 100%; max-width: 300px\" />\n                </div>\n                <div class=\"col-lg-7\">\n                    <div>\n                        <p id=\"nguoidang\" style=\"font-size: 14pt;\">Người đăng : ");
#nullable restore
#line 28 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                                           Write(Html.Raw(Model.taiKhoanViewModel.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                    <hr />\n                    <div id=\"lienhe\">\n                        <p style=\"font-size: 12pt;\">SĐT: ");
#nullable restore
#line 32 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                    Write(Html.Raw(Model.taiKhoanViewModel.SoDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                        <p style=\"font-size: 12pt;\">Email: ");
#nullable restore
#line 34 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                      Write(Html.Raw(Model.taiKhoanViewModel.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                        <p style=\"font-size: 12pt;\">ĐC: ");
#nullable restore
#line 36 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                   Write(Html.Raw(Model.taiKhoanViewModel.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-6"" style=""border-left:1px solid #0094ff;"">
            <div class=""row"" style=""padding-left: 20px; "">
                <div class=""room-info"">
                    <div style=""padding-bottom: 10px;"">
                        <b class=""flaticon-timer"">");
#nullable restore
#line 45 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                             Write(Html.Raw(Model.tinBDSViewModel.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                        <b class=\"flaticon-placeholder\">");
#nullable restore
#line 46 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                   Write(Html.Raw(Model.tinBDSViewModel.QuanHuyen));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 46 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                                                                Write(Html.Raw(Model.tinBDSViewModel.TinhThanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                    </div>\n                    <div style=\"padding-bottom: 10px;\">\n                        <b>Diện tích: ");
#nullable restore
#line 49 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                 Write(Html.Raw(Model.tinBDSViewModel.DienTich));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m2 | Hướng: ");
#nullable restore
#line 49 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                                                       Write(Html.Raw(Model.tinBDSViewModel.Huong));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                    </div>\n                    <div style=\"padding-bottom: 10px;\">\n                        <b>Loại bất động sản: ");
#nullable restore
#line 52 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                         Write(Html.Raw(Model.tinBDSViewModel.LoaiBatDongSan));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                    </div>\n                    <div style=\"padding-bottom: 10px;\">\n                        <b>Hình thức giao dịch: ");
#nullable restore
#line 55 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                           Write(Html.Raw(Model.tinBDSViewModel.LoaiTin));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                    </div>\n                    <div style=\"padding-bottom: 10px;\">\n                        <b>Mức giá: ");
#nullable restore
#line 58 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                               Write(Html.Raw(Model.tinBDSViewModel.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                    </div>\n                    <div style=\"padding-bottom: 10px;\">\n");
#nullable restore
#line 61 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                         if (Html.Raw(Model.tinBDSViewModel.XacThuc).ToString() == "Xác thực")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<b>Thông tin đã được xác thực</b>");
#nullable restore
#line 62 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<b>Thông tin chưa được xác thực</b>");
#nullable restore
#line 64 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n        <div class=\"row\" style=\"font-size: 13pt;\">\n            <p>");
#nullable restore
#line 70 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
          Write(Html.Raw(Model.tinBDSViewModel.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n        <div class=\"row\" style=\"padding: 30px;\">\n            <p style=\"font-size: 13pt; text-align:justify;\"> &nbsp &nbsp &nbsp ");
#nullable restore
#line 73 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                                          Write(Html.Raw(Model.tinBDSViewModel.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n\n        <p>Hình ảnh</p>\n        <hr />\n\n        <div class=\"row\" style=\"margin-bottom: 15px;margin-top: 15px;\">\n            <img id=\"mainImage\" height=\"700\" width=\"1150\" style=\"border: 1px solid grey;\"");
            BeginWriteAttribute("src", " src=\"", 3541, "\"", 3570, 1);
#nullable restore
#line 80 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
WriteAttributeValue("", 3547, Model.hinhAnhs.First(), 3547, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        </div>\n        <div class=\"row\">\n");
#nullable restore
#line 83 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
             foreach (var anh in Model.hinhAnhs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"divContainer\" ");
            WriteLiteral(" style=\"margin-right:5px; margin-bottom: 15px;\">\n    <img");
            BeginWriteAttribute("src", " src=\"", 3777, "\"", 3787, 1);
#nullable restore
#line 86 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
WriteAttributeValue("", 3783, anh, 3783, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
            WriteLiteral(" class=\"imgStyle\" />\n</div>");
#nullable restore
#line 87 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        <!-- The Modal -->\n");
            WriteLiteral("    </div>\n</div>\n<div class=\"row container card\" style=\"margin-top: 30px;\">\n    <div class=\"row card-header\" style=\"background-color:#9f0000; color:white;\">Tin liên quan</div>\n    <div class=\"row card-body\" ");
            WriteLiteral(">\n");
#nullable restore
#line 100 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
         foreach (var tin in Model.tinLienQuan)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-12\">\n    <p style=\"font-size: 12pt;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824d2a4be0c660bd69f4d4ee6b8375a8f592d98216546", async() => {
#nullable restore
#line 103 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                                                Write(tin.TieuDe);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 103 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                                                             Write(tin.LuotXem);

#line default
#line hidden
#nullable disable
                WriteLiteral(" lượt xem)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                                WriteLiteral(tin.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\n</div>");
#nullable restore
#line 104 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<div class=""row"" style=""margin-top: 30px;"">
    <div class=""col-lg-6"" style=""padding:0px;"">
        <div id=""fb-root""></div>
        <script async defer crossorigin=""anonymous"" src=""https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v7.0&appId=171275584290364&autoLogAppEvents=1""></script>

        <div class=""fb-comments"" data-href=""https://localhost:44319/Dm/ChiTietTinBDS/");
#nullable restore
#line 112 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                                                                                Write(Model.tinBDSViewModel.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-numposts=\"10\" data-width=\"\"></div>\n    </div>\n    <div class=\"col-lg-6\" style=\"padding-left: 150px;\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824d2a4be0c660bd69f4d4ee6b8375a8f592d98220514", async() => {
                WriteLiteral("Báo cáo tin này");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "data", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 115 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
AddHtmlAttributeValue("", 5169, Context.Session.GetInt32("userID"), 5169, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824d2a4be0c660bd69f4d4ee6b8375a8f592d98222365", async() => {
                WriteLiteral("\n            <div class=\"form-group\">\n                <textarea class=\"form-control\" id=\"lyDo\" rows=\"6\" placeholder=\"Viết lý do\"></textarea>\n            </div>\n            <div class=\"form-group\">\n                <input type=\"submit\" id=\"gui\" value=\"Gửi\"");
                BeginWriteAttribute("data", " data=\"", 5520, "\"", 5552, 1);
#nullable restore
#line 121 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
WriteAttributeValue("", 5527, Model.tinBDSViewModel.ID, 5527, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" />\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#baoCao"").hide();
        //$(""#lienhe"").hide();

        //$(""#nguoidang"").mouseover(function () {
        //    $(""#lienhe"").show('slow');
        //});
        //$(""#nguoidang"").mouseleave(function () {
        //    $(""#lienhe"").hide('slow');
        //});

        $(""#divContainer img"").on({
            mouseover: function () {
                $(this).css({
                    'cursor': 'pointer',
                    'border-Color' : 'red'
                });
            },
            mouseout: function () {
                $(this).css({
                    'cursor': 'default',
                    'border-Color': 'grey'
                });
            },
            click: function () {
                var imageUrl = $(this).attr('src');
                $('#mainImage').fadeOut(300, function () {
                    $(t");
            WriteLiteral(@"his).attr('src', imageUrl);
                }).fadeIn(300);
            }
        });

        $(""#aBaoCao"").click(function () {
            if ($(""#baoCao"").is(':hidden')) {
                $(""#baoCao"").show(""slow"");
                return false;
            }
            else {
                $(""#baoCao"").hide(""slow"");
                return false;
            }
        });

        $(""#gui"").click(function () {
            var user = parseInt($(""#aBaoCao"").attr(""data""));
            if (isNaN(user)) {
                alert(""Bạn chưa đăng nhập!"");
                return false;   
            }
            var tin = $(this).attr(""data"");
            var lyDo = $(""#lyDo"").val();
            if (lyDo == """") {
                alert(""Vui lòng nhập lý do báo cáo!"");
                return false;
            }
            

            //console.log(user, typeof user);
            //console.log(tin);
            //console.log(lyDo);
            //return false;

            $.ajax({
                url: '");
#nullable restore
#line 192 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\Dm\ChiTietTinBDS.cshtml"
                 Write(Url.Action("BaoCaoTin", "Dm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: { 'id': tin, 'user': user, 'lyDo': lyDo },
                type: ""post"",
                async: false,
                success: function (result) {
                    console.log(user, typeof user);
                    alert(""Đã gửi báo cáo!"");
                }
            });
            return false;
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BatDongSanId.Areas.Client.Models.ListViewModels.ChiTietBDSListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
