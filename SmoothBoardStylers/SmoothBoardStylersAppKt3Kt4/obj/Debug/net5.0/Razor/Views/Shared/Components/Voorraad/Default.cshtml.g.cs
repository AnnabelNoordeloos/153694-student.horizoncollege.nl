#pragma checksum "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f3f0bc09cdc6c32be09067e1b633785ac4a791d"
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
#line 1 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\_ViewImports.cshtml"
using SmoothBoardStylersApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\_ViewImports.cshtml"
using SmoothBoardStylersApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3f0bc09cdc6c32be09067e1b633785ac4a791d", @"/Views/Shared/Components/Voorraad/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30156aaa0e062d675dad04ee97023764061c56a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Voorraad_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmoothBoardStylersApp.Models.Voorraad>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Voorraad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Voorraad van ");
#nullable restore
#line 7 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
            Write(ViewData["Filiaal"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f3f0bc09cdc6c32be09067e1b633785ac4a791d5176", async() => {
                WriteLiteral("Voeg Surfboard toe aan voorraad");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
                                                       WriteLiteral(ViewBag.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Surfboard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Surfboard.Materiaal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Surfboard.Prijs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Surfboard.FotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Filiaal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Aantal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 37 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 40 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surfboard.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 43 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surfboard.Materiaal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 46 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surfboard.Prijs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f3f0bc09cdc6c32be09067e1b633785ac4a791d11778", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1383, "~/img/thumbnail.", 1383, 16, true);
#nullable restore
#line 49 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
AddHtmlAttributeValue("", 1399, item.Surfboard.FotoUrl, 1399, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
AddHtmlAttributeValue("", 1429, item.Surfboard.Naam, 1429, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 52 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Filiaal.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 55 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Aantal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f3f0bc09cdc6c32be09067e1b633785ac4a791d14768", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-filiaalId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
                                                                         WriteLiteral(item.FiliaalId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filiaalId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filiaalId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filiaalId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
                                                                                                                 WriteLiteral(item.SurfboardId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["surfboardId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-surfboardId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["surfboardId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 61 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Shared\Components\Voorraad\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmoothBoardStylersApp.Models.Voorraad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
