#pragma checksum "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Voorraad\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a1eb1986390fc2a37bcc24c5e40ad916c7e6226"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Voorraad_Details), @"mvc.1.0.view", @"/Views/Voorraad/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a1eb1986390fc2a37bcc24c5e40ad916c7e6226", @"/Views/Voorraad/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30156aaa0e062d675dad04ee97023764061c56a", @"/Views/_ViewImports.cshtml")]
    public class Views_Voorraad_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmoothBoardStylersApp.Models.Voorraad>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Voorraad\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Voorraad</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Voorraad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Surfboard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Voorraad\Details.cshtml"
       Write(Html.DisplayFor(model => model.Surfboard.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Voorraad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Filiaal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Voorraad\Details.cshtml"
       Write(Html.DisplayFor(model => model.Filiaal.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Voorraad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Aantal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Voorraad\Details.cshtml"
       Write(Html.DisplayFor(model => model.Aantal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
#nullable restore
#line 34 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Voorraad\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a1eb1986390fc2a37bcc24c5e40ad916c7e62266708", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmoothBoardStylersApp.Models.Voorraad> Html { get; private set; }
    }
}
#pragma warning restore 1591
