#pragma checksum "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework3\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_OrderDetailsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b34a848ca47c3afcd4453072bf712b65eaf5a93d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__OrderDetailsPartial), @"mvc.1.0.view", @"/Views/Shared/Partials/_OrderDetailsPartial.cshtml")]
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
#line 1 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework3\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework3\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework3\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_OrderDetailsPartial.cshtml"
using SEDC.PizzaApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34a848ca47c3afcd4453072bf712b65eaf5a93d", @"/Views/Shared/Partials/_OrderDetailsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf335bc6052e5e3fa1cc836b3840e9eb30e1fb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__OrderDetailsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>DETAILS FOR YOUR ORDER:</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 7 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework3\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_OrderDetailsPartial.cshtml"
Write(Model.PizzaName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework3\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_OrderDetailsPartial.cshtml"
                  Write(Model.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework3\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_OrderDetailsPartial.cshtml"
                                        Write(Model.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework3\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_OrderDetailsPartial.cshtml"
                                                               Write(Model.PizzaPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" DEN -\r\n    ");
#nullable restore
#line 8 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework3\SEDC.PizzaApp\SEDC.PizzaApp\Views\Shared\Partials\_OrderDetailsPartial.cshtml"
Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
