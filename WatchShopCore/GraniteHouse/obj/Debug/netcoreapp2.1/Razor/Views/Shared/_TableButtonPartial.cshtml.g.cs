#pragma checksum "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f9e6d91306f2fc7582ea3566ca2aef5980e9b9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableButtonPartial.cshtml", typeof(AspNetCore.Views_Shared__TableButtonPartial))]
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
#line 1 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Views\_ViewImports.cshtml"
using GraniteHouse;

#line default
#line hidden
#line 2 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Views\_ViewImports.cshtml"
using GraniteHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9e6d91306f2fc7582ea3566ca2aef5980e9b9f", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d53bf185f1e092ca3f9d10ed71965193003c0de5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(129, 116, true);
            WriteLiteral("\n\n<td style=\"width:150px\">\n    <div class=\"btn-group\" role=\"group\">\n        <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 245, "\"", 278, 1);
#line 8 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 252, Url.Action("Edit/"+Model), 252, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(279, 103, true);
            WriteLiteral(">\n            <i class=\"fas fa-edit\"></i>\n        </a>\n        <a type=\"button\" class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 382, "\"", 418, 1);
#line 11 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 389, Url.Action("Details/"+Model), 389, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(419, 106, true);
            WriteLiteral(">\n            <i class=\"far fa-list-alt\"></i>\n        </a>\n        <a type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 525, "\"", 560, 1);
#line 14 "C:\Users\galax\Desktop\WatchShopCore\GraniteHouse\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 532, Url.Action("Delete/"+Model), 532, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(561, 77, true);
            WriteLiteral(">\n            <i class=\"fas fa-trash-alt\"></i>\n        </a>\n    </div>\n</td>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591