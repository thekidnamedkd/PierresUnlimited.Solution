#pragma checksum "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "120efb78fd01d88b6eb875879026d9c1c7722e89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 5 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Register.cshtml"
using Bakery.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"120efb78fd01d88b6eb875879026d9c1c7722e89", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Register.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(78, 38, true);
            WriteLiteral("\n<h1>Register as a new user</h1>\n<hr>\n");
            EndContext();
#line 10 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(182, 31, true);
            WriteLiteral("  <div class=\"form-group\">\n    ");
            EndContext();
            BeginContext(214, 33, false);
#line 13 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Register.cshtml"
Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(247, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(253, 64, false);
#line 14 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Register.cshtml"
Write(Html.TextBoxFor(user => user.Email, new {@class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(317, 6, true);
            WriteLiteral("\n\n    ");
            EndContext();
            BeginContext(324, 36, false);
#line 16 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Register.cshtml"
Write(Html.LabelFor(user => user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(360, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(366, 68, false);
#line 17 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Register.cshtml"
Write(Html.PasswordFor(user => user.Password, new {@class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(434, 6, true);
            WriteLiteral("\n\n    ");
            EndContext();
            BeginContext(441, 43, false);
#line 19 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Register.cshtml"
Write(Html.LabelFor(user => user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(484, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(490, 75, false);
#line 20 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Register.cshtml"
Write(Html.PasswordFor(user => user.ConfirmPassword, new {@class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(565, 51, true);
            WriteLiteral("\n  </div>\n  <input type=\"submit\" value=\"Register\">\n");
            EndContext();
#line 23 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Account/Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591