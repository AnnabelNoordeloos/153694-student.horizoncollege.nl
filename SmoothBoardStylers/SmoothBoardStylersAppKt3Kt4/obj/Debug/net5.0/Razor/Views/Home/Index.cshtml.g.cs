#pragma checksum "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d75d98c20187f6f2c254caf13e1ca237044fa1c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d75d98c20187f6f2c254caf13e1ca237044fa1c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30156aaa0e062d675dad04ee97023764061c56a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Spicin up your Board</h1>\r\n    <!--Home pagina foto toegevoegd o.1-->\r\n    <img src=\"./img/2021-04-07 (2).png\" width=\"1000\" height=\"500\" class=\"HomeImage\"/>\r\n    <p>Smoothboard Stylers</p>\r\n</div>\r\n ");
#nullable restore
#line 11 "C:\Users\HP\OneDrive\Documenten\GitHub\153694-student.horizoncollege.nl\SmoothBoardStylers\SmoothBoardStylersAppKt3Kt4\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Filialen"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--style toegevoegd voor de Spicin up your board tekst w.3-->
<style>
    .display-4 {
        position: absolute;
        transform: rotate( 30deg );
        margin-top: 300px;
        margin-left: 300px;
        font-weight: 400;
    }

    .HomeImage{
        z-index: -1;
    }
</style>");
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
