#pragma checksum "C:\Users\Susan\source\repos\FinalProject\FinalProject\Views\Restaurant\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be846087d658e2fd327a94d9e1edc46c2f73367"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_About), @"mvc.1.0.view", @"/Views/Restaurant/About.cshtml")]
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
#line 1 "C:\Users\Susan\source\repos\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Susan\source\repos\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be846087d658e2fd327a94d9e1edc46c2f73367", @"/Views/Restaurant/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cd403b176af46e85ea812cbc8b3a7a1a86d4d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurant_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProject.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Restaurant: ");
#nullable restore
#line 2 "C:\Users\Susan\source\repos\FinalProject\FinalProject\Views\Restaurant\About.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <p>Name: ");
#nullable restore
#line 5 "C:\Users\Susan\source\repos\FinalProject\FinalProject\Views\Restaurant\About.cshtml"
        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Location: ");
#nullable restore
#line 6 "C:\Users\Susan\source\repos\FinalProject\FinalProject\Views\Restaurant\About.cshtml"
            Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Cuisine type ");
#nullable restore
#line 7 "C:\Users\Susan\source\repos\FinalProject\FinalProject\Views\Restaurant\About.cshtml"
               Write(Model.CuisineType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
