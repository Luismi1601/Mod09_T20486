#pragma checksum "C:\Curso\20486\Luismi\Tareas\Mod09\Democode\01_BootstrapExample_begin\BootstrapExample\Views\Library\GetDramaBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf62ed43d73c7fd55d32fc809cc2572a9b15ffdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Library_GetDramaBooks), @"mvc.1.0.view", @"/Views/Library/GetDramaBooks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Library/GetDramaBooks.cshtml", typeof(AspNetCore.Views_Library_GetDramaBooks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf62ed43d73c7fd55d32fc809cc2572a9b15ffdc", @"/Views/Library/GetDramaBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Library_GetDramaBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Curso\20486\Luismi\Tareas\Mod09\Democode\01_BootstrapExample_begin\BootstrapExample\Views\Library\GetDramaBooks.cshtml"
  
    ViewData["Title"] = "GetDramaBooks";

#line default
#line hidden
            BeginContext(47, 56, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1>Drama Books</h1>\n    ");
            EndContext();
            BeginContext(104, 33, false);
#line 8 "C:\Curso\20486\Luismi\Tareas\Mod09\Democode\01_BootstrapExample_begin\BootstrapExample\Views\Library\GetDramaBooks.cshtml"
Write(await Html.PartialAsync("_Alert"));

#line default
#line hidden
            EndContext();
            BeginContext(137, 13, true);
            WriteLiteral("\n</div>\n\n\n\n\n\n");
            EndContext();
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
