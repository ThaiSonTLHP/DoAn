#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c64638460c5b565dc34b3cc88352799a62647446"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TaiKhoan_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/TaiKhoan/Details.cshtml")]
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
#line 1 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\_ViewImports.cshtml"
using BatDongSanId.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\_ViewImports.cshtml"
using BatDongSanId.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c64638460c5b565dc34b3cc88352799a62647446", @"/Areas/Admin/Views/TaiKhoan/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b1e8e2d45f807bd9b81a0c4611e4ea48ab007c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TaiKhoan_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BatDongSanId.Areas.Client.Models.ListViewModels.QLTKListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 13pt;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TinDaDang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TinDaLuu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("napTien"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 15pt;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("xoa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("khoa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n            <div>\r\n                <img height=\"235\" style=\"border:1px solid black;\"");
            BeginWriteAttribute("src", " src=\"", 342, "\"", 396, 1);
#nullable restore
#line 11 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
WriteAttributeValue("", 348, Html.Raw(Model.taiKhoanViewModel.AnhDaiDienUrl), 348, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
        </div>
        <div class=""col-sm-8"" style=""border-left: 1px solid #00c1ff;"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <table class=""table table-borderless"">
                        <tbody>
                            <tr>
                                <th scope=""row"">Tên:</th>
                                <td>");
#nullable restore
#line 21 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                               Write(Html.Raw(Model.taiKhoanViewModel.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th scope=\"row\">Email/ Tài khoản:</th>\r\n                                <td>");
#nullable restore
#line 25 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                               Write(Html.Raw(Model.taiKhoanViewModel.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th scope=\"row\">Địa chỉ:</th>\r\n                                <td colspan=\"2\">");
#nullable restore
#line 29 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                                           Write(Html.Raw(Model.taiKhoanViewModel.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th scope=\"row\">Số điện thoại:</th>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                               Write(Html.Raw(Model.taiKhoanViewModel.SoDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th scope=\"row\">Số dư ví:</th>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                               Write(Html.Raw(Model.taiKhoanViewModel.SoDuVi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <th scope=\"row\">Loại tài khoản:</th>\r\n                                <td colspan=\"2\">");
#nullable restore
#line 41 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                                           Write(Html.Raw(Model.taiKhoanViewModel.LoaiTaiKhoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                    <p id=\"userID\" style=\"visibility:hidden;\"");
            BeginWriteAttribute("data", " data=\"", 2146, "\"", 2180, 1);
#nullable restore
#line 45 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
WriteAttributeValue("", 2153, Model.taiKhoanViewModel.ID, 2153, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n");
#nullable restore
#line 51 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
     if (Model.taiKhoanViewModel.LoaiTaiKhoan == "Nhà môi giới" || Model.taiKhoanViewModel.LoaiTaiKhoan == "Khách hàng")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <p style=\"font-size: 13pt;\">Số tin đã đăng: ");
#nullable restore
#line 55 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                                                       Write(Html.Raw(Model.soTinDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c64638460c5b565dc34b3cc88352799a6264744611956", async() => {
                WriteLiteral("Xem chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <p style=\"font-size: 13pt;\">Số tin đã luu: ");
#nullable restore
#line 63 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                                                      Write(Html.Raw(Model.soTinLuu));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-sm-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c64638460c5b565dc34b3cc88352799a6264744613768", async() => {
                WriteLiteral("Xem chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <hr />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c64638460c5b565dc34b3cc88352799a6264744615079", async() => {
                WriteLiteral("Nạp tiền");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""row"" id=""napTienForm"" style=""margin-top: 20px;"">
            <div class=""form-group col-sm-6"">
                <input type=""text"" class=""form-control"" id=""tien"" placeholder=""Nhập số tiền (VNĐ)"" />
            </div>
            <div class=""form-group col-sm-6"">
                <input type=""button"" class=""btn btn-primary"" id=""nap"" value=""Nạp"" style=""margin: 0px;"" />
            </div>
        </div>
        <hr />
");
#nullable restore
#line 80 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\" style=\"margin-top: 50px;\">\r\n        <div class=\"col-md-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c64638460c5b565dc34b3cc88352799a6264744617207", async() => {
                WriteLiteral("Sửa tài khoản");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                                   WriteLiteral(Model.taiKhoanViewModel.ID);

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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c64638460c5b565dc34b3cc88352799a6264744619474", async() => {
                WriteLiteral("Xóa tài khoản");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "data", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 86 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
AddHtmlAttributeValue("", 3867, Model.taiKhoanViewModel.ID, 3867, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c64638460c5b565dc34b3cc88352799a6264744621290", async() => {
                WriteLiteral("Khóa tài khoản");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "data", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 89 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
AddHtmlAttributeValue("", 4010, Model.taiKhoanViewModel.ID, 4010, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 92 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
Write(Html.Hidden("RedirectTo", Url.Action("TaiKhoan", "TaiKhoan")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Xác nhận khóa tài khoản</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Xóa tài khoản này?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""button"" class=""btn btn-primary"">Xác nhận</button>
            </div>
        </div>
    </div>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js");
            WriteLiteral(@"""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#napTienForm"").hide();
        $(""#napTien"").click(function () {
            if ($(""#napTienForm"").is(':hidden')) {
                $(""#napTienForm"").show('slow');
                return false;
            } else {
                $(""#napTienForm"").hide('slow');
                return false;
            }
        });
        $(""#nap"").click(function () {
            if ($(""#tien"").val() == """") {
                alert(""Nhập số tiền!"");
                return false;
            }
            var tien = $(""#tien"").val();
            var id = $(""#userID"").attr('data');
            $.ajax({
                url: '");
#nullable restore
#line 137 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                 Write(Url.Action("NapTien", "TaiKhoan"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: { 'id': id, 'tien': tien },
                type: ""post"",
                success: function (result) {
                    location.reload();
                }
            });
            return false;
        });

        $(""a.xoa"").click(function (event) {
            event.preventDefault();
            event.stopPropagation();
            var id = $(this).attr(""data"");
            //console.log(this);
            //alert(tin);
            if (confirm(""Xóa tài khoản này sẽ xóa toàn bộ thông tin tài khoản và tin đăng/ lưu. Bạn có chắc muốn xóa?"")) {
                $.ajax({
                    url: '");
#nullable restore
#line 155 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                     Write(Url.Action("Xoa", "TaiKhoan"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    data: { 'id': id },
                    type: ""post"",
                    async: false,
                    success: function (result) {
                        if (result == true) {
                            window.location.href = '/Admin/TaiKhoan/TaiKhoan/';
                        } else {
                            alert(""Không thể xóa tài khoản này!"");
                            return false;
                        }
                    }
                });
            }
            else {
                return false;
            }
        });

        $(""a.khoa"").click(function (event) {
            event.preventDefault();
            event.stopPropagation();
            var id = $(this).attr(""data"");
            var text = """";
            if (confirm(""Khóa tài khoản này?"")) {
                $.ajax({
                    url: '");
#nullable restore
#line 181 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TaiKhoan\Details.cshtml"
                     Write(Url.Action("Khoa", "TaiKhoan"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    data: { 'id': id },
                    type: ""post"",
                    async: false,
                    success: function (result) {
                        text = ""Đã khóa"";
                    }
                });
                $(this).hide(""slow"").finish();
                $(this).show(""slow"").text(text);
                return;
            }
            else {
                return;
            }
        });
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BatDongSanId.Areas.Client.Models.ListViewModels.QLTKListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
