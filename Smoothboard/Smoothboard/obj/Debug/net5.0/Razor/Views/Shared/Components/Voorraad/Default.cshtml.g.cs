#pragma checksum "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Shared\Components\Voorraad\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3e5b6b3d79a978fb8ff8504dc81f2979abf082e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Voorraad_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Voorraad/Default.cshtml")]
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
#line 1 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\_ViewImports.cshtml"
using Smoothboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\_ViewImports.cshtml"
using Smoothboard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e5b6b3d79a978fb8ff8504dc81f2979abf082e", @"/Views/Shared/Components/Voorraad/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"773ba32c7269e86786b02045e7756a09e434818f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Voorraad_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Smoothboard.Models.Voorraad>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Shared\Components\Voorraad\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3e5b6b3d79a978fb8ff8504dc81f2979abf082e3734", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Default</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3e5b6b3d79a978fb8ff8504dc81f2979abf082e4795", async() => {
                WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Surfboard));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Filiaal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Aantal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Shared\Components\Voorraad\Default.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surfboard.Naam));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Filiaal.Naam));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Aantal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Shared\Components\Voorraad\Default.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Smoothboard.Models.Voorraad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
