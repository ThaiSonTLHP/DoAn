#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dbaedb6e9870c5872fcdf90ace2e467a7c0617f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NguoiDung_Index), @"mvc.1.0.view", @"/Views/NguoiDung/Index.cshtml")]
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
#line 1 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\_ViewImports.cshtml"
using AdminBatDongSan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\_ViewImports.cshtml"
using AdminBatDongSan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dbaedb6e9870c5872fcdf90ace2e467a7c0617f", @"/Views/NguoiDung/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259f52d24b7b6401cd7c54d0c5642aa6f77e941b", @"/Views/_ViewImports.cshtml")]
    public class Views_NguoiDung_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminBatDongSan.Models.ViewModel.NguoiDungViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <table class=\"table table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 13 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.SoDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ChucVu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.SoBaiDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ChucVu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoBaiDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"edit-link\"");
            BeginWriteAttribute("href", " href=\"", 2013, "\"", 2061, 1);
#nullable restore
#line 62 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
WriteAttributeValue("", 2020, Url.Action("Edit", new { id = item.ID }), 2020, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span ");
            WriteLiteral(">Sửa</span></a>\r\n                    ");
#nullable restore
#line 63 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 64 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\NguoiDung\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminBatDongSan.Models.ViewModel.NguoiDungViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591