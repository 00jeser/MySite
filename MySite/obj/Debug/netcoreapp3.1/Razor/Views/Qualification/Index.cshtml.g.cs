#pragma checksum "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e375669fe3a8112c35e820621c2f91b3c47e8e8f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e375669fe3a8112c35e820621c2f91b3c47e8e8f", @"/Views/Qualification/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Qualification_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
 if (ViewBag.Br == "Mobile")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"content\">\r\n    </section>\r\n");
#nullable restore
#line 5 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""content schr1"" id=""schr1"">
        <script>
            if (schr1.addEventListener) {
                if ('onwheel' in document) {
                    // IE9+, FF17+, Ch31+
                    schr1.addEventListener(""wheel"", onWheel1);
                } else if ('onmousewheel' in document) {
                    // устаревший вариант события
                    schr1.addEventListener(""mousewheel"", onWheel1);
                } else {
                    // Firefox < 17
                    schr1.addEventListener(""MozMousePixelScroll"", onWheel1);
                }
            } else { // IE8-
                schr1.attachEvent(""onmousewheel"", onWheel1);
            }
        </script>
        <h1 style=""margin-top:0;"">Здесь информация о моих знаниях и умениях</h1>
        <div class=""container"">

            <div>
                <h3>Языки которые я знаю</h3>
");
#nullable restore
#line 30 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
                 foreach (var i in ViewBag.Langs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"knowledge-l-p\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
                   Write(i.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <progress class=\"knowledge\" max=\"100\"");
            BeginWriteAttribute("value", " value=\"", 1212, "\"", 1230, 1);
#nullable restore
#line 34 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
WriteAttributeValue("", 1220, i.percent, 1220, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></progress>\r\n                        ");
#nullable restore
#line 35 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
                   Write(i.level);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 37 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

            <div>
                <h3>Технологии которые я знаю</h3>
                <p class=""knowledge-t-p"">
                    ASP.NET Core
                    <progress class=""knowledge"" max=""100"" value=""25""></progress>
                </p>
            </div>

        </div>
    </section>
    <section class=""schr2 content"" id=""schr2"">
        <script>
            if (schr2.addEventListener) {
                if ('onwheel' in document) {
                    // IE9+, FF17+, Ch31+
                    schr2.addEventListener(""wheel"", onWheel2);
                } else if ('onmousewheel' in document) {
                    // устаревший вариант события
                    schr2.addEventListener(""mousewheel"", onWheel2);
                } else {
                    // Firefox < 17
                    schr2.addEventListener(""MozMousePixelScroll"", onWheel2);
                }
            } else { // IE8-
                schr2.attachEvent(""onmousewheel"", onWheel2);
    ");
            WriteLiteral("        }\r\n        </script>\r\n");
#nullable restore
#line 67 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
         foreach (var i in ViewBag.works)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 2446, "\"", 2459, 1);
#nullable restore
#line 69 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
WriteAttributeValue("", 2453, i.URL, 2453, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div style=\"margin: 3px; margin-left: 10vw; margin-right: 10vw;\" class=\"MetroButton MetroButtonA Work\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2608, "\"", 2622, 1);
#nullable restore
#line 71 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
WriteAttributeValue("", 2614, i.Image, 2614, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 10vh;\" />\r\n                    <div style=\"width:100%; height:100%; text-align:left; float:right;\">\r\n                        <p class=\"title\">\r\n                            ");
#nullable restore
#line 74 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
                       Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p class=\"discr\">\r\n                            ");
#nullable restore
#line 77 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
                       Write(i.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 82 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\r\n");
#nullable restore
#line 84 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Qualification\Index.cshtml"
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
