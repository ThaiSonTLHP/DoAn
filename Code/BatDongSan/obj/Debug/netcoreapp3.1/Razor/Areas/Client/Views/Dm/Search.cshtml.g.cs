#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cd4827a8c00f61d59ed7000596de2a77cde29e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Dm_Search), @"mvc.1.0.view", @"/Areas/Client/Views/Dm/Search.cshtml")]
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
#line 1 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\_ViewImports.cshtml"
using BatDongSan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\_ViewImports.cshtml"
using BatDongSan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cd4827a8c00f61d59ed7000596de2a77cde29e7", @"/Areas/Client/Views/Dm/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7251536ff652c19e939378bbe977efbd6c44f44", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Dm_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BatDongSan.Models.ViewModels.TinBDSViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChiTietTinBDS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
  
    ViewData["Title"] = "Trang chủ";
    Layout = "~/Areas/Client/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
  
    ViewData["Title"] = "Tin bán";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mystyle-maintin\">\n    <div class=\"mystyle-tin\">\n");
#nullable restore
#line 13 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
         if (Model.Count() > 0)
        {
            foreach (var tin in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"mystyle-goitin\">\n                    <div></div>\n                    <div class=\"mystyle-ngaydangtin\">");
#nullable restore
#line 19 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
                                                Write(Html.DisplayFor(modelItem => tin.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    <div class=\"mystyle-tieudetin\">");
#nullable restore
#line 20 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
                                              Write(Html.DisplayFor(modelItem => tin.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    <div class=\"mystyle-diadiemtin\">");
#nullable restore
#line 21 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
                                               Write(Html.DisplayFor(modelItem => tin.QuanHuyen));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> - </span>");
#nullable restore
#line 21 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
                                                                                                           Write(Html.DisplayFor(modelItem => tin.TinhThanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    <div class=\"mystyle-giatin\">Giá: <span>");
#nullable restore
#line 22 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
                                                      Write(Html.DisplayFor(modelItem => tin.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>VNĐ | Diện tích: <span>");
#nullable restore
#line 22 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
                                                                                                                          Write(Html.DisplayFor(modelItem => tin.DienTich));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>m2 | <span>Hướng: </span>");
#nullable restore
#line 22 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
                                                                                                                                                                                                     Write(Html.Raw(tin.Huong));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cd4827a8c00f61d59ed7000596de2a77cde29e77366", async() => {
                WriteLiteral("Xem chi tiết");
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
#line 23 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
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
            WriteLiteral("\n                </div>\n");
#nullable restore
#line 25 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
            }
        }
        else
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>Không tìm thấy kết quả phù hợp</div>\n");
#nullable restore
#line 30 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Areas\Client\Views\Dm\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BatDongSan.Models.ViewModels.TinBDSViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
