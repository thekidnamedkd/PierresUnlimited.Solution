#pragma checksum "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3645c0fc1f7495ce7d75acea507782ad3f3e291"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3645c0fc1f7495ce7d75acea507782ad3f3e291", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Home/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 70, true);
            WriteLiteral("\n<h1>PIERRE\'S BAKERIES UNLIMITED</h1>\n<hr />\n<h2>ALL FLAVORS</h2>\n<h3>");
            EndContext();
            BeginContext(98, 54, false);
#line 8 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Home/Index.cshtml"
Write(Html.ActionLink("See all Flavors", "Index", "Flavors"));

#line default
#line hidden
            EndContext();
            BeginContext(152, 35, true);
            WriteLiteral("</h3>\n<br>\n<h2>ALL TREATS</h2>\n<h3>");
            EndContext();
            BeginContext(188, 52, false);
#line 11 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Home/Index.cshtml"
Write(Html.ActionLink("See all Treats", "Index", "Treats"));

#line default
#line hidden
            EndContext();
            BeginContext(240, 5, true);
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
