#pragma checksum "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/NewsletterMVC/NewsletterMVC/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4bf65c4d43aecb547702bcce681f41bbecd0fd5"
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
#nullable restore
#line 1 "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/NewsletterMVC/NewsletterMVC/Views/_ViewImports.cshtml"
using NewsletterMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/NewsletterMVC/NewsletterMVC/Views/_ViewImports.cshtml"
using NewsletterMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4bf65c4d43aecb547702bcce681f41bbecd0fd5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abca2513534b7cf7f79e0e9664bd5c3d6e45c912", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row no-gutters m-3\">\n    <div class=\"card col-sm-12 col-md-10 col-lg-6 mx-auto shadow\">\n        <div class=\"card-header text-center\">\n            <h5 class=\"m-0\">Sign up to our newsletter</h5>\n        </div>\n        <div class=\"card-body\">\n");
#nullable restore
#line 7 "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/NewsletterMVC/NewsletterMVC/Views/Home/Index.cshtml"
             using (Html.BeginForm("SignUp", "Home", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row no-gutters"">
                <div class=""form-group col-med-12"">
                    <input name=""FirstName"" type=""text"" class=""form-control"" placeholder=""First Name"" /> <br />
                </div>
                <div class=""form-group col-med-12"">
                    <input name=""LastName"" type=""text"" class=""form-control"" placeholder=""Last Name"" />
                </div>
                <div class=""form-group col-med-12"">
                    <input name=""EmailAddress"" type=""email"" class=""form-control"" placeholder=""Email Address"" />
                </div>
                <button type=""submit"" class=""btn btn-block btn-primary"">Submit</button>
            </div>
");
#nullable restore
#line 21 "/Users/joshcummings/Documents/Github/TechAcademy/C-Sharp Coding Projects/NewsletterMVC/NewsletterMVC/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>");
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
