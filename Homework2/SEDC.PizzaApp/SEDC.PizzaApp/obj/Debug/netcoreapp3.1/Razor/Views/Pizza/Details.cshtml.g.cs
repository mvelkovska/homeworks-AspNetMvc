#pragma checksum "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\ChasoviAspNetMvc\Class03\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8c9da864fbabb49454b23044b62276a3f61b007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Details), @"mvc.1.0.view", @"/Views/Pizza/Details.cshtml")]
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
#line 1 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\ChasoviAspNetMvc\Class03\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\ChasoviAspNetMvc\Class03\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\ChasoviAspNetMvc\Class03\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
using SEDC.PizzaApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c9da864fbabb49454b23044b62276a3f61b007", @"/Views/Pizza/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9da3483405b0ddc092d1e77dd5d8a02d663a044", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h2> Details for your pizza:</h2>\r\n\r\n");
            WriteLiteral("\r\n<p>Pizza name: ");
#nullable restore
#line 13 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\ChasoviAspNetMvc\Class03\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
          Write(Model.PizzaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Pizza price: ");
#nullable restore
#line 14 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\ChasoviAspNetMvc\Class03\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
           Write(Model.PizzaPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" DEN</p>\r\n<p>Pizza size: ");
#nullable restore
#line 15 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\ChasoviAspNetMvc\Class03\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
          Write(Model.PizzaSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\ChasoviAspNetMvc\Class03\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
 if (Model.HasExtras)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Has extras:YES.</p>\r\n");
#nullable restore
#line 20 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\ChasoviAspNetMvc\Class03\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Has extras:NO.</p>\r\n");
#nullable restore
#line 24 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\ChasoviAspNetMvc\Class03\SEDC.PizzaApp\SEDC.PizzaApp\Views\Pizza\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
