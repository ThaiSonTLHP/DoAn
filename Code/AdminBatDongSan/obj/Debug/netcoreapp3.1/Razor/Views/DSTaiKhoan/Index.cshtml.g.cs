#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4efb92fb8e78bb2c47c8b028d4352e6ccf1f3a44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DSTaiKhoan_Index), @"mvc.1.0.view", @"/Views/DSTaiKhoan/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4efb92fb8e78bb2c47c8b028d4352e6ccf1f3a44", @"/Views/DSTaiKhoan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"259f52d24b7b6401cd7c54d0c5642aa6f77e941b", @"/Views/_ViewImports.cshtml")]
    public class Views_DSTaiKhoan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminBatDongSan.Models.ViewModel.TaiKhoanViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4efb92fb8e78bb2c47c8b028d4352e6ccf1f3a443839", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SoDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SoDuVi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LoaiTaiKhoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MatKhau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoDuVi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoaiTaiKhoan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 78 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 79 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 82 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\AdminBatDongSan\Views\DSTaiKhoan\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminBatDongSan.Models.ViewModel.TaiKhoanViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
