#pragma checksum "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "162044d35ef1974e82de43070fe8cd668e72a87e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paquetes_Detalle), @"mvc.1.0.view", @"/Views/Paquetes/Detalle.cshtml")]
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
#line 1 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\_ViewImports.cshtml"
using NETCORE_CRUD_991;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\_ViewImports.cshtml"
using NETCORE_CRUD_991.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"162044d35ef1974e82de43070fe8cd668e72a87e", @"/Views/Paquetes/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2eb51bb85f4e8d15c7fa631530cd70a042a0e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Paquetes_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NETCORE_CRUD_991.Clases.PaqueteDetalle>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearEditar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
  
    ViewData["Title"] = "Detallar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detallar</h1>\r\n\r\n<div>\r\n    <h4>Paquete</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayNameFor(model => model.CodigoPaquete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayFor(model => model.CodigoPaquete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayNameFor(model => model.PesoLibra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayFor(model => model.PesoLibra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayNameFor(model => model.Casillero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayFor(model => model.NombreCasillero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayNameFor(model => model.USA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayFor(model => model.USA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayNameFor(model => model.Transportadora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayFor(model => model.Transportadora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoMercancia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayFor(model => model.TipoMercancia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayNameFor(model => model.COL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayFor(model => model.COL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorPagar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
       Write(Html.DisplayFor(model => model.ValorPagar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162044d35ef1974e82de43070fe8cd668e72a87e10523", async() => {
                WriteLiteral("Editar");
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
#nullable restore
#line 70 "C:\Users\Moncho\Desktop\NETCORE CRUD 991MIA\NETCORE CRUD 991\NETCORE CRUD 991\Views\Paquetes\Detalle.cshtml"
                                  WriteLiteral(Model.IdPaquete);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162044d35ef1974e82de43070fe8cd668e72a87e12710", async() => {
                WriteLiteral("Volver a la Lista");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NETCORE_CRUD_991.Clases.PaqueteDetalle> Html { get; private set; }
    }
}
#pragma warning restore 1591
