#pragma checksum "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ab6540bf42a637ca2712d45e750078fe829a700"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Qualification_Index), @"mvc.1.0.view", @"/Views/Qualification/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ab6540bf42a637ca2712d45e750078fe829a700", @"/Views/Qualification/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Qualification_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
 if (ViewBag.Br == "Mobile")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"content\">\r\n    </section>\r\n");
#nullable restore
#line 6 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"content\">\r\n");
#nullable restore
#line 10 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
         foreach (var i in ViewBag.works)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 193, "\"", 206, 1);
#nullable restore
#line 12 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
WriteAttributeValue("", 200, i.URL, 200, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <div style="" margin: 5px"" class=""MetroButton MetroButtonA"">
                    <img src=""https://sun9-63.userapi.com/vTZ8t8qLa2_JW8tXrG7CT2ho__1qr-yKREV_aA/XwAcSJPSkqc.jpg"" style=""width:10vw;"" />
                    <div style=""width:87vw; height:100%; text-align:left; float:right;"">
                        <p>
                            ");
#nullable restore
#line 17 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
                       Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            ");
#nullable restore
#line 20 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
                       Write(i.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 25 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\r\n");
#nullable restore
#line 27 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
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
