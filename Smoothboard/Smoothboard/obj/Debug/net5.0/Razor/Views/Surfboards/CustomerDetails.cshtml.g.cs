#pragma checksum "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95f1b2518b3cdcc00d3b7834668cd548e0275895"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Surfboards_CustomerDetails), @"mvc.1.0.view", @"/Views/Surfboards/CustomerDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95f1b2518b3cdcc00d3b7834668cd548e0275895", @"/Views/Surfboards/CustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"773ba32c7269e86786b02045e7756a09e434818f", @"/Views/_ViewImports.cshtml")]
    public class Views_Surfboards_CustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Smoothboard.Models.Surfboards>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateFromDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Interesses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Surfboards</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Beschrijving));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Beschrijving));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Prijs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Prijs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.FotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.FotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Materiaal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Materiaal.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<!-- Interesse formulier -->\r\n<div class=\"col-8 p-0\">\r\n    <p>Geinteresseerd in dit board? Geef uw e-mail adres door en wij nemen zo spoedig mogelijk contact met u op.</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f1b2518b3cdcc00d3b7834668cd548e02758958595", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"SurfboardId\"");
                BeginWriteAttribute("value", " value=\"", 1515, "\"", 1532, 1);
#nullable restore
#line 49 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
WriteAttributeValue("", 1523, Model.Id, 1523, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

        <div class=""input-group"">
            <input type=""email"" class=""form-control"" name=""Email"" placeholder=""e-mail adres"">
            <div class=""input-group-append"">
                <button class=""btn btn-outline-secondary"" type=""submit"">Versturen</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
     if (TempData["InteresseCreated"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Bedankt! Uw aanvraag is doorgegeven en we nemen snel contact met u op</p>\r\n");
#nullable restore
#line 61 "C:\apache24\Apache24\htdocs\Software jaar 2\Portfolio\Smoothboard\Smoothboard\Views\Surfboards\CustomerDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f1b2518b3cdcc00d3b7834668cd548e027589511657", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Smoothboard.Models.Surfboards> Html { get; private set; }
    }
}
#pragma warning restore 1591