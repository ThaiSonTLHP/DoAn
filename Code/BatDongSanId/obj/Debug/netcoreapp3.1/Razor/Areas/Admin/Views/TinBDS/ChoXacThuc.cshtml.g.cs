#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ce721f2fba0ef85e87e286a25620576d059d31c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TinBDS_ChoXacThuc), @"mvc.1.0.view", @"/Areas/Admin/Views/TinBDS/ChoXacThuc.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce721f2fba0ef85e87e286a25620576d059d31c", @"/Areas/Admin/Views/TinBDS/ChoXacThuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b1e8e2d45f807bd9b81a0c4611e4ea48ab007c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TinBDS_ChoXacThuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BatDongSanId.Areas.Client.Models.ViewModels.TinBDSViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
  
    ViewData["Title"] = "ChoXacThuc";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <thead style=\"background-color:#000257;color:white;\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
           Write(Html.DisplayNameFor(model => model.LoaiTin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
           Write(Html.DisplayNameFor(model => model.GoiTin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
           Write(Html.DisplayNameFor(model => model.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
           Write(Html.DisplayNameFor(model => model.NguoiDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
           Write(Html.DisplayNameFor(model => model.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
           Write(Html.DisplayNameFor(model => model.PheDuyet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 59 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
               Write(Html.DisplayFor(modelItem => item.LoaiTin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
               Write(Html.DisplayFor(modelItem => item.GoiTin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
               Write(Html.DisplayFor(modelItem => item.NguoiDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
               Write(Html.DisplayFor(modelItem => item.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
               Write(Html.DisplayFor(modelItem => item.PheDuyet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"xacThuc\"");
            BeginWriteAttribute("data", " data=\"", 2957, "\"", 2972, 1);
#nullable restore
#line 84 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
WriteAttributeValue("", 2964, item.ID, 2964, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xác thực</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 87 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>



<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""a.xacThuc"").click(function (event) {
            event.preventDefault();
            event.stopPropagation();
            //var btn = $(""button.room-content"");
            var tin = $(this).attr(""data"");
            $.ajax({
                url: '");
#nullable restore
#line 102 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Admin\Views\TinBDS\ChoXacThuc.cshtml"
                 Write(Url.Action("DuyetTin", "TinBDS"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: { 'idTin': tin },
                type: ""post"",
                async: false,
                success: function (result) {
                    alert(""Đã xác thực tin!"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BatDongSanId.Areas.Client.Models.ViewModels.TinBDSViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
