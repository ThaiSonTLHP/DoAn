#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\DoiMatKhau.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb109b38a1205f48555a1cd380506540e2b80708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_QuanLyTaiKhoan_DoiMatKhau), @"mvc.1.0.view", @"/Areas/Client/Views/QuanLyTaiKhoan/DoiMatKhau.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb109b38a1205f48555a1cd380506540e2b80708", @"/Areas/Client/Views/QuanLyTaiKhoan/DoiMatKhau.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7251536ff652c19e939378bbe977efbd6c44f44", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_QuanLyTaiKhoan_DoiMatKhau : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\DoiMatKhau.cshtml"
  
    ViewData["Title"] = "Đổi mật khẩu";
    Layout = "~/Areas/Client/Views/Shared/_TaiKhoanLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row h-75 justify-content-center align-items-center"">
    <div class=""col-md-8"">
        <div class=""card"">
            <div class=""card-header"">
                Đổi mật khẩu
            </div>
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb109b38a1205f48555a1cd380506540e2b807084641", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <input type=""password"" name=""password"" placeholder=""Mật khẩu cũ"" class=""form-control"" id=""oldpass"">
                    </div>
                    <div class=""form-group"">
                        <input type=""password"" name=""password"" placeholder=""Mật khẩu mới"" class=""form-control"" id=""newpass1"">
                    </div>
                    <div class=""form-group"">
                        <input type=""password"" name=""password"" placeholder=""Nhập lại mật khẩu mới"" class=""form-control"" id=""newpass2"">
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Xác nhận"" class=""btn btn-primary"" id=""change"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
    </div>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#change"").prop(""disabled"", true);
        $(""#oldpass"").keyup(function () {
            if ($(""#oldpass"").val() != """" && $(""#newpass1"").val() != """" && $(""#newpass2"").val() != """" && $(""#newpass1"").val() == $(""#newpass2"").val()) {
                $(""#change"").prop(""disabled"", false);
            } else {
                $(""#change"").prop(""disabled"", true);
            }
        });
        $(""#newpass1"").keyup(function () {
            if ($(""#oldpass"").val() != """" && $(""#newpass1"").val() != """" && $(""#newpass2"").val() != """" && $(""#newpass1"").val() == $(""#newpass2"").val()) {
                $(""#change"").prop(""disabled"", false);
            } else {
                $(""#change"").prop(""disabled"", true);
            }
        });
        $(""#newpass2"").keyup(function () {
 ");
            WriteLiteral(@"           if ($(""#oldpass"").val() != """" && $(""#newpass1"").val() != """" && $(""#newpass2"").val() != """" && $(""#newpass1"").val() == $(""#newpass2"").val()) {
                $(""#change"").prop(""disabled"", false);
            } else {
                $(""#change"").prop(""disabled"", true);
            }
        });
        $(""#change"").click(function () {
            var oldpass = $(""#oldpass"").val();
            var newpass = $(""#newpass1"").val();
            $.ajax({
                url: '");
#nullable restore
#line 61 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSanId\Areas\Client\Views\QuanLyTaiKhoan\DoiMatKhau.cshtml"
                 Write(Url.Action("ChangePass", "QuanLyTaiKhoan"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: { 'pass': oldpass, 'newPass': newpass },
                type: ""post"",
                async: false,
                success: function (result) {
                    alert(result);
                }
            });
            return false;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591