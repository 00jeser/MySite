#pragma checksum "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "263f56aff9aa7cc57ec37592cd54f8c8ba228ab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f56aff9aa7cc57ec37592cd54f8c8ba228ab9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Home\Index.cshtml"
 if (ViewBag.Br == "Mobile")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"content\">\r\n        <center>\r\n            <div>\r\n                <img width=\"100%\"");
            BeginWriteAttribute("src", " src=", 134, "", 157, 1);
#nullable restore
#line 6 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Home\Index.cshtml"
WriteAttributeValue("", 139, ViewBag.ImagePath, 139, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""about-text"">
                <p><br /></p>
                <p class=""about-text-work"" style=""font-size: 4vmin;"">Программист</p>
                <p class=""about-text-surname"">Гавриленко</p>
                <p class=""about-text-firstname"">Сергей</p>
                <center>
                    <div class=""MetroButton MetroButtonA moreButton"">
                        <a href=""../Social"">Подробнее обо мне лично</a>
                    </div>
                    <div class=""MetroButton MetroButtonA moreButton"">
                        <a href=""../Qualification"">Подробнее про мои навыки</a>
                    </div>
                </center>
            </div>
            <br />
        </center>
    </section>
");
#nullable restore
#line 25 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"content\">\r\n        <div class=\"site-container\">\r\n            <div class=\"sidebar\">\r\n            </div>\r\n            <div class=\"site-container-content\">\r\n                <center>\r\n                    <img");
            BeginWriteAttribute("src", " src=", 1173, "", 1196, 1);
#nullable restore
#line 34 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Home\Index.cshtml"
WriteAttributeValue("", 1178, ViewBag.ImagePath, 1178, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                </center>
                <div class=""about-text"">
                    <p class=""about-text-work"" style=""font-size: 2vmin; margin-bottom: -3vw;"">Программист</p>
                    <p class=""about-text-surname"">Гавриленко</p>
                    <p class=""about-text-firstname"">Сергей</p>
                </div>
                <div class=""more"">
                    <center style=""width:100%; align-content:center;"">
                        <a href=""../Social"">
                            <div class=""MetroButton MetroButtonA moreButton"">
                                <p>Подробнее обо мне лично</p>
                            </div>
                        </a>
                    </center>
                    <center style=""width:100%; align-content:center;"">
                        <a href=""../Qualification"">
                            <div class=""MetroButton MetroButtonA moreButton"">
                                <p>Подробнее про мои навыки</p>
                        ");
            WriteLiteral("    </div>\r\n                        </a>\r\n                    </center>\r\n                </div>\r\n            </div>\r\n            <div class=\"sidebar\">\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 62 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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