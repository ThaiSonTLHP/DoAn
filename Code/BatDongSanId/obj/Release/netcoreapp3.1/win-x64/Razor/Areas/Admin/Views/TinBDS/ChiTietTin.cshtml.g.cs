#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20dd0bbbc69982f1c84c7b38fff692353d7e5879"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TinBDS_ChiTietTin), @"mvc.1.0.view", @"/Areas/Admin/Views/TinBDS/ChiTietTin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20dd0bbbc69982f1c84c7b38fff692353d7e5879", @"/Areas/Admin/Views/TinBDS/ChiTietTin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b1e8e2d45f807bd9b81a0c4611e4ea48ab007c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TinBDS_ChiTietTin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BatDongSanId.Areas.Client.Models.ListViewModels.ChiTietBDSListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
  
    ViewData["Title"] = "ChiTietTin";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .imgStyle {
        height: 100px;
        width: 100px;
        border: 1px solid grey;
    }
</style>

<div class=""container"">
    <h4>TinBDSViewModel</h4>
    <hr />
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""row"">
                <div class=""col-lg-5"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 529, "\"", 583, 1);
#nullable restore
#line 22 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
WriteAttributeValue("", 535, Html.Raw(Model.taiKhoanViewModel.AnhDaiDienUrl), 535, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border:1px solid black;width: 100%; max-width: 300px\" />\r\n                </div>\r\n                <div class=\"col-lg-7\">\r\n                    <div>\r\n                        <p style=\"font-size: 13pt;\">Người đăng : ");
#nullable restore
#line 26 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                                                            Write(Html.Raw(Model.taiKhoanViewModel.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <hr />\r\n                    <div>\r\n                        <p>SĐT: ");
#nullable restore
#line 30 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                           Write(Html.Raw(Model.taiKhoanViewModel.SoDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div>\r\n                        <p>Email: ");
#nullable restore
#line 33 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                             Write(Html.Raw(Model.taiKhoanViewModel.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div>\r\n                        <p>ĐC: ");
#nullable restore
#line 36 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
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
#line 45 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                                             Write(Html.Raw(Model.tinBDSViewModel.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                        <b class=\"flaticon-placeholder\">");
#nullable restore
#line 46 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                                                   Write(Html.Raw(Model.tinBDSViewModel.QuanHuyen));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 46 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                                                                                                Write(Html.Raw(Model.tinBDSViewModel.TinhThanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div style=\"padding-bottom: 10px;\">\r\n                        <b>Diện tích: ");
#nullable restore
#line 49 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                                 Write(Html.Raw(Model.tinBDSViewModel.DienTich));

#line default
#line hidden
#nullable disable
            WriteLiteral(" m2 | Hướng:");
#nullable restore
#line 49 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                                                                                      Write(Html.Raw(Model.tinBDSViewModel.Huong));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div style=\"padding-bottom: 10px;\">\r\n                        <b>Hình thức giao dịch: ");
#nullable restore
#line 52 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                                           Write(Html.Raw(Model.tinBDSViewModel.LoaiTin));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div style=\"padding-bottom: 10px;\">\r\n                        <b>Mức giá: ");
#nullable restore
#line 55 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                               Write(Html.Raw(Model.tinBDSViewModel.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div style=\"padding-bottom: 10px;\">\r\n");
#nullable restore
#line 58 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                         if (Html.Raw(Model.tinBDSViewModel.XacThuc).ToString() == "Xác thực")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<b>Thông tin đã được xác thực</b>");
#nullable restore
#line 59 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<b>Thông tin chưa được xác thực</b>");
#nullable restore
#line 61 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" style=\"font-size: 13pt;\">\r\n            <p>");
#nullable restore
#line 67 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
          Write(Html.Raw(Model.tinBDSViewModel.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"row\" style=\"padding: 30px;\">\r\n            <p style=\"font-size: 13pt; text-align:justify;\"> &nbsp &nbsp &nbsp ");
#nullable restore
#line 70 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                                                                          Write(Html.Raw(Model.tinBDSViewModel.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <p>Hình ảnh</p>\r\n        <hr />\r\n\r\n        <div class=\"row\" style=\"margin-bottom: 15px;margin-top: 15px;\">\r\n            <img id=\"mainImage\" height=\"700\" width=\"1150\" style=\"border: 1px solid grey;\"");
            BeginWriteAttribute("src", " src=\"", 3356, "\"", 3385, 1);
#nullable restore
#line 77 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
WriteAttributeValue("", 3362, Model.hinhAnhs.First(), 3362, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 80 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
             foreach (var anh in Model.hinhAnhs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"divContainer\" ");
            WriteLiteral(" style=\"margin-right:5px; margin-bottom: 15px;\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3630, "\"", 3640, 1);
#nullable restore
#line 83 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
WriteAttributeValue("", 3636, anh, 3636, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
            WriteLiteral(" class=\"imgStyle\" />\r\n                </div>");
#nullable restore
#line 84 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChiTietTin.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <!-- The Modal -->\r\n");
            WriteLiteral(@"    </div>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#baoCao"").hide();

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
                    $(this).attr('src', imageUrl);
                }).fadeIn(300);
            }
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
