#pragma checksum "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcf8dfbf57d40963e355778d312777cb3a8edc6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dm_Index), @"mvc.1.0.view", @"/Views/Dm/Index.cshtml")]
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
#line 1 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\_ViewImports.cshtml"
using BatDongSan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\_ViewImports.cshtml"
using BatDongSan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcf8dfbf57d40963e355778d312777cb3a8edc6b", @"/Views/Dm/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2bd68a3dd13a8193983ed8e5e0a6eee4bb04f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Dm_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BatDongSan.Models.ViewModels.TinBanViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml"
  
    ViewData["Title"] = "Trang chủ";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml"
  
    ViewData["Title"] = "Tin bán";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mystyle-maintin\">\r\n    <div class=\"mystyle-tin\">\r\n");
#nullable restore
#line 13 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml"
         foreach (var tin in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mystyle-goitin\">\r\n                <div></div>\r\n                <div class=\"mystyle-ngaydangtin\">");
#nullable restore
#line 17 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => tin.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"mystyle-tieudetin\">");
#nullable restore
#line 18 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => tin.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"mystyle-diadiemtin\">");
#nullable restore
#line 19 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => tin.QuanHuyen));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> - </span>");
#nullable restore
#line 19 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml"
                                                                                                       Write(Html.DisplayFor(modelItem => tin.TinhThanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"mystyle-giatin\">Giá: <span>");
#nullable restore
#line 20 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => tin.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>VNĐ | Diện tích: <span>");
#nullable restore
#line 20 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml"
                                                                                                                      Write(Html.DisplayFor(modelItem => tin.DienTich));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>m2 | <span>Hướng: </span>");
#nullable restore
#line 20 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml"
                                                                                                                                                                                                 Write(Html.Raw(tin.Huong));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\Users\ThaiSon\Desktop\DoAn_BatDongSanWeb\DoAn\Code\BatDongSan\Views\Dm\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div id=""fb-root""></div>
<script async defer crossorigin=""anonymous"" src=""https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v7.0&appId=171275584290364&autoLogAppEvents=1""></script>

<div class=""fb-comments"" data-href=""https://localhost:44319"" data-numposts=""5"" data-width=""""></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BatDongSan.Models.ViewModels.TinBanViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
