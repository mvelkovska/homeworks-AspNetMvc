#pragma checksum "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework1\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c32c1b2353a153e0402bd357d64415092dae38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
#line 1 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework1\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework1\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c32c1b2353a153e0402bd357d64415092dae38", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9da3483405b0ddc092d1e77dd5d8a02d663a044", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SEDC.PizzaApp.Models.Domain.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2> Details for the order: </h2>\r\n\r\n<p>");
#nullable restore
#line 5 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework1\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
Write(Model.Customer);

#line default
#line hidden
#nullable disable
            WriteLiteral("- <strong> ");
#nullable restore
#line 5 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework1\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
                        Write(Model.typeOfPizza);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong> - ");
#nullable restore
#line 5 "C:\Users\Ivica\Desktop\SEDC\AspNetMvc\homeworks-AspNetMvc\Homework1\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
                                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEDC.PizzaApp.Models.Domain.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
