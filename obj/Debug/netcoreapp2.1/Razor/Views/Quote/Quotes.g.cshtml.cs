#pragma checksum "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/QuotingDojo/Views/Quote/Quotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a748d4e2ec69934fa3218011fe7c956c35706140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quote_Quotes), @"mvc.1.0.view", @"/Views/Quote/Quotes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Quote/Quotes.cshtml", typeof(AspNetCore.Views_Quote_Quotes))]
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
#line 1 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/QuotingDojo/Views/_ViewImports.cshtml"
using QuotingDojo;

#line default
#line hidden
#line 2 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/QuotingDojo/Views/_ViewImports.cshtml"
using QuotingDojo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a748d4e2ec69934fa3218011fe7c956c35706140", @"/Views/Quote/Quotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1590bf4c09dff90063a94a6cfc81488d471e1d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Quote_Quotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dictionary<string, object>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 78, true);
            WriteLiteral("<div class=\"container-fluid\">\n  <div class=\"row\">\n    <div class=\"col-md-12\">\n");
            EndContext();
#line 5 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/QuotingDojo/Views/Quote/Quotes.cshtml"
        
        foreach(var quote in Model)
        {

#line default
#line hidden
            BeginContext(173, 35, true);
            WriteLiteral("          <p class=\"text-primary\">\"");
            EndContext();
            BeginContext(209, 14, false);
#line 8 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/QuotingDojo/Views/Quote/Quotes.cshtml"
                              Write(quote["quote"]);

#line default
#line hidden
            EndContext();
            BeginContext(223, 40, true);
            WriteLiteral("\"</p>\n          <p class=\"text-primary\">");
            EndContext();
            BeginContext(264, 15, false);
#line 9 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/QuotingDojo/Views/Quote/Quotes.cshtml"
                             Write(quote["author"]);

#line default
#line hidden
            EndContext();
            BeginContext(279, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(281, 19, false);
#line 9 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/QuotingDojo/Views/Quote/Quotes.cshtml"
                                              Write(quote["created_at"]);

#line default
#line hidden
            EndContext();
            BeginContext(300, 20, true);
            WriteLiteral("</p>\n          <hr>\n");
            EndContext();
#line 11 "/Users/rx/Documents/CodingDojo/csharp_stack/aspNet_core/aspMVC/QuotingDojo/Views/Quote/Quotes.cshtml"
        }
      

#line default
#line hidden
            BeginContext(338, 26, true);
            WriteLiteral("    </div>\n  </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dictionary<string, object>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
