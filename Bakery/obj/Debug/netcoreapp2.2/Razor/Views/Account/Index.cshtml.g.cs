#pragma checksum "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f5c1a50ff0d1e82b3dd1a059744c482f5221e3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f5c1a50ff0d1e82b3dd1a059744c482f5221e3f", @"/Views/Account/Index.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 6, true);
            WriteLiteral("\n<hr>\n");
            EndContext();
#line 6 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(71, 12, true);
            WriteLiteral("  <h3>Hello ");
            EndContext();
            BeginContext(84, 18, false);
#line 8 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
       Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(102, 7, true);
            WriteLiteral("!</h3>\n");
            EndContext();
#line 9 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
   using (Html.BeginForm("LogOff", "Account"))
  {

#line default
#line hidden
            BeginContext(160, 8, true);
            WriteLiteral("    <h5>");
            EndContext();
            BeginContext(169, 54, false);
#line 11 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
   Write(Html.ActionLink("See all Flavors", "Index", "Flavors"));

#line default
#line hidden
            EndContext();
            BeginContext(223, 14, true);
            WriteLiteral("</h5>\n    <h5>");
            EndContext();
            BeginContext(238, 52, false);
#line 12 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
   Write(Html.ActionLink("See all Treats", "Index", "Treats"));

#line default
#line hidden
            EndContext();
            BeginContext(290, 14, true);
            WriteLiteral("</h5>\n    <h5>");
            EndContext();
            BeginContext(305, 40, false);
#line 13 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
   Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(345, 72, true);
            WriteLiteral("</h5>\n    <input type=\"submit\" value=\"Log out\" class=\"btn btn-warning\">\n");
            EndContext();
#line 15 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
  }

#line default
#line hidden
#line 15 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
   
}
else 
{

#line default
#line hidden
            BeginContext(431, 6, true);
            WriteLiteral("  <h5>");
            EndContext();
            BeginContext(438, 39, false);
#line 19 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
 Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
            EndContext();
            BeginContext(477, 12, true);
            WriteLiteral("</h5>\n  <h5>");
            EndContext();
            BeginContext(490, 34, false);
#line 20 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
 Write(Html.ActionLink("Log in", "Login"));

#line default
#line hidden
            EndContext();
            BeginContext(524, 12, true);
            WriteLiteral("</h5>\n  <h5>");
            EndContext();
            BeginContext(537, 47, false);
#line 21 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
 Write(Html.ActionLink("Return home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(584, 6, true);
            WriteLiteral("</h5>\n");
            EndContext();
#line 22 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Index.cshtml"
}

#line default
#line hidden
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
