#pragma checksum "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Treats/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a3c57ed27619f14bc26819678346c170b1338db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Edit), @"mvc.1.0.view", @"/Views/Treats/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Edit.cshtml", typeof(AspNetCore.Views_Treats_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a3c57ed27619f14bc26819678346c170b1338db", @"/Views/Treats/Edit.cshtml")]
    public class Views_Treats_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bakery.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Treats/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 36, true);
            WriteLiteral("\n<h2>EDIT TREAT DETAILS</h2>\n<hr />\n");
            EndContext();
#line 9 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Treats/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(124, 38, false);
#line 11 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Treats/Edit.cshtml"
Write(Html.HiddenFor(model => model.TreatId));

#line default
#line hidden
            EndContext();
            BeginContext(163, 26, true);
            WriteLiteral("    <label>Name: </label>\n");
            EndContext();
            BeginContext(194, 104, false);
#line 13 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Treats/Edit.cshtml"
Write(Html.TextBoxFor(model => model.TreatName, new {type="text", required="required", @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(299, 42, true);
            WriteLiteral("    <br>\n    <label>Description: </label>\n");
            EndContext();
            BeginContext(346, 104, false);
#line 16 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Treats/Edit.cshtml"
Write(Html.TextBoxFor(model => model.TreatDesc, new {type="text", required="required", @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(451, 39, true);
            WriteLiteral("    <br>\n    <label>Quantity: </label>\n");
            EndContext();
            BeginContext(495, 105, false);
#line 19 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Treats/Edit.cshtml"
Write(Html.TextBoxFor(model => model.TreatQty, new {type="number", required="required", @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(601, 48, true);
            WriteLiteral("    <br>\n    <input type=\"submit\" value=\"Save\">\n");
            EndContext();
#line 22 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Treats/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(651, 10, true);
            WriteLiteral("<hr />\n<p>");
            EndContext();
            BeginContext(662, 48, false);
#line 24 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Treats/Edit.cshtml"
Write(Html.ActionLink("Return to all treats", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(710, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(719, 47, false);
#line 25 "/Users/thekidnamedkd/Desktop/PierresLogin.Solution/Bakery/Views/Treats/Edit.cshtml"
Write(Html.ActionLink("Return home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(766, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bakery.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
