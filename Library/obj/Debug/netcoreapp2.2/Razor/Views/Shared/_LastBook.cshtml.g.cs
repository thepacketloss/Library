#pragma checksum "C:\Users\Ghost\RiderProjects\Library\Library\Views\Shared\_LastBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fdb605a844ff65350fb6ab65a3e0287e881a86f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LastBook), @"mvc.1.0.view", @"/Views/Shared/_LastBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LastBook.cshtml", typeof(AspNetCore.Views_Shared__LastBook))]
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
#line 1 "C:\Users\Ghost\RiderProjects\Library\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#line 2 "C:\Users\Ghost\RiderProjects\Library\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fdb605a844ff65350fb6ab65a3e0287e881a86f", @"/Views/Shared/_LastBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LastBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 175, true);
            WriteLiteral("<div id=\"mainLastBook\">\r\n\r\n    <div class=\"div-header\">آخرین کتاب های چاپ شده</div>\r\n    <div class=\"hr\"></div>\r\n    <div class=\"owl-carousel owl-theme\" id=\"owl_lastbook\">\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Ghost\RiderProjects\Library\Library\Views\Shared\_LastBook.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(250, 95, true);
            WriteLiteral("            <div class=\"img-thumbnail\">\r\n                <a href=\"#\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 345, "\"", 384, 2);
#line 12 "C:\Users\Ghost\RiderProjects\Library\Library\Views\Shared\_LastBook.cshtml"
WriteAttributeValue("", 351, ViewBag.imagePath, 351, 18, false);

#line default
#line hidden
#line 12 "C:\Users\Ghost\RiderProjects\Library\Library\Views\Shared\_LastBook.cshtml"
WriteAttributeValue("", 369, item.BookImage, 369, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(385, 93, true);
            WriteLiteral("/>\r\n                    <div class=\"hrunderimage\"></div>\r\n                    <span class=\"\">");
            EndContext();
            BeginContext(479, 13, false);
#line 14 "C:\Users\Ghost\RiderProjects\Library\Library\Views\Shared\_LastBook.cshtml"
                              Write(item.BookName);

#line default
#line hidden
            EndContext();
            BeginContext(492, 51, true);
            WriteLiteral("</span>\r\n                </a>\r\n            </div>\r\n");
            EndContext();
#line 17 "C:\Users\Ghost\RiderProjects\Library\Library\Views\Shared\_LastBook.cshtml"
        }

#line default
#line hidden
            BeginContext(554, 18, true);
            WriteLiteral("    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
