#pragma checksum "C:\Users\Marce\Source\Repos\prestamolibrosnet2\prestamolibrosnet\Views\Calificacions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3940776007ef443a80722bc365aef4f46c094ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calificacions_Details), @"mvc.1.0.view", @"/Views/Calificacions/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calificacions/Details.cshtml", typeof(AspNetCore.Views_Calificacions_Details))]
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
#line 1 "C:\Users\Marce\Source\Repos\prestamolibrosnet2\prestamolibrosnet\Views\_ViewImports.cshtml"
using prestamolibrosnet;

#line default
#line hidden
#line 2 "C:\Users\Marce\Source\Repos\prestamolibrosnet2\prestamolibrosnet\Views\_ViewImports.cshtml"
using prestamolibrosnet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3940776007ef443a80722bc365aef4f46c094ce", @"/Views/Calificacions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae08e554bde8d9a60e1c2b3eae5354c012647a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Calificacions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<prestamolibrosnet.Models.Calificacion>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Marce\Source\Repos\prestamolibrosnet2\prestamolibrosnet\Views\Calificacions\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 213, true);
            WriteLiteral("\r\n<h2>Detalles de la Calificación</h2>\r\n\r\n<div>\r\n    <h4>Calificacion</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n           <label>Evaluación</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(305, 42, false);
#line 17 "C:\Users\Marce\Source\Repos\prestamolibrosnet2\prestamolibrosnet\Views\Calificacions\Details.cshtml"
       Write(Html.DisplayFor(model => model.evaluacion));

#line default
#line hidden
            EndContext();
            BeginContext(347, 114, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Observaciones</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(462, 43, false);
#line 23 "C:\Users\Marce\Source\Repos\prestamolibrosnet2\prestamolibrosnet\Views\Calificacions\Details.cshtml"
       Write(Html.DisplayFor(model => model.observacion));

#line default
#line hidden
            EndContext();
            BeginContext(505, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(552, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b6c10e4f1cf40da95086101f29e0cdc", async() => {
                BeginContext(574, 6, true);
                WriteLiteral("Volver");
                EndContext();
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
            EndContext();
            BeginContext(584, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<prestamolibrosnet.Models.Calificacion> Html { get; private set; }
    }
}
#pragma warning restore 1591
