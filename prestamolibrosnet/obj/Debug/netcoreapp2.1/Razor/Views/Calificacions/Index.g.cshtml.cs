#pragma checksum "C:\Users\mnpar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Calificacions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9baac6fc49d7b1142fad576d8797f959b7c3eae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calificacions_Index), @"mvc.1.0.view", @"/Views/Calificacions/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calificacions/Index.cshtml", typeof(AspNetCore.Views_Calificacions_Index))]
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
#line 1 "C:\Users\mnpar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\_ViewImports.cshtml"
using prestamolibrosnet;

#line default
#line hidden
#line 2 "C:\Users\mnpar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\_ViewImports.cshtml"
using prestamolibrosnet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9baac6fc49d7b1142fad576d8797f959b7c3eae", @"/Views/Calificacions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae08e554bde8d9a60e1c2b3eae5354c012647a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Calificacions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prestamolibrosnet.Models.Calificacion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mnpar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Calificacions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 311, true);
            WriteLiteral(@"
<h2>Mis Calificaciones</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>
                <label>Evaluación</label>
            </th>
            <th>
                <label>Observaciones</label>
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 22 "C:\Users\mnpar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Calificacions\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(445, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(494, 45, false);
#line 25 "C:\Users\mnpar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Calificacions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.evaluacion));

#line default
#line hidden
            EndContext();
            BeginContext(539, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(595, 46, false);
#line 28 "C:\Users\mnpar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Calificacions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.observacion));

#line default
#line hidden
            EndContext();
            BeginContext(641, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(696, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20a93aecd2e412fb45a286959540095", async() => {
                BeginContext(744, 8, true);
                WriteLiteral("Detalles");
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
#line 31 "C:\Users\mnpar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Calificacions\Index.cshtml"
                                          WriteLiteral(item.id);

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
            BeginContext(756, 37, true);
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 34 "C:\Users\mnpar\source\repos\prestamolibrosnet2\prestamolibrosnet\Views\Calificacions\Index.cshtml"
}

#line default
#line hidden
            BeginContext(796, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prestamolibrosnet.Models.Calificacion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
