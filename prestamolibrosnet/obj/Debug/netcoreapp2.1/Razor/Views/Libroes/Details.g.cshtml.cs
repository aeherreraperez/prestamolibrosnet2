#pragma checksum "C:\Users\mnparapar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Libroes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da2994bd272825deac07e5fe884739d017a341b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libroes_Details), @"mvc.1.0.view", @"/Views/Libroes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Libroes/Details.cshtml", typeof(AspNetCore.Views_Libroes_Details))]
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
#line 1 "C:\Users\mnparapar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\_ViewImports.cshtml"
using prestamolibrosnet;

#line default
#line hidden
#line 2 "C:\Users\mnparapar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\_ViewImports.cshtml"
using prestamolibrosnet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da2994bd272825deac07e5fe884739d017a341b", @"/Views/Libroes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae08e554bde8d9a60e1c2b3eae5354c012647a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Libroes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<prestamolibrosnet.Models.Libro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mnparapar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Libroes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 182, true);
            WriteLiteral("\r\n<h2>Detalles</h2>\r\n\r\n<div>\r\n    <h4>Libro</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            <label>ISBN</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(267, 36, false);
#line 17 "C:\Users\mnparapar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Libroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.isbn));

#line default
#line hidden
            EndContext();
            BeginContext(303, 107, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Título</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(411, 38, false);
#line 23 "C:\Users\mnparapar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Libroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.titulo));

#line default
#line hidden
            EndContext();
            BeginContext(449, 106, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Autor</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(556, 37, false);
#line 29 "C:\Users\mnparapar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Libroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.autor));

#line default
#line hidden
            EndContext();
            BeginContext(593, 106, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Fecha</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(700, 37, false);
#line 35 "C:\Users\mnparapar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Libroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.fecha));

#line default
#line hidden
            EndContext();
            BeginContext(737, 110, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Editorial</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(848, 41, false);
#line 41 "C:\Users\mnparapar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Libroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.editorial));

#line default
#line hidden
            EndContext();
            BeginContext(889, 109, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <label>Prestado</label>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(999, 40, false);
#line 47 "C:\Users\mnparapar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Libroes\Details.cshtml"
       Write(Html.DisplayFor(model => model.prestado));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1086, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eef5bcc9e6c41f38a8557a3b606fd45", async() => {
                BeginContext(1132, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\mnparapar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Libroes\Details.cshtml"
                           WriteLiteral(Model.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1142, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1150, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b30032faabc84905a0d6b14f02b391a3", async() => {
                BeginContext(1172, 6, true);
                WriteLiteral("Volver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1182, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<prestamolibrosnet.Models.Libro> Html { get; private set; }
    }
}
#pragma warning restore 1591
