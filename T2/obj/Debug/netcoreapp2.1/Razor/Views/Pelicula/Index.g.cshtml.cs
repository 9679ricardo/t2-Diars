#pragma checksum "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b23d9513e58fd93027348ba98ca984e6d7b13852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pelicula_Index), @"mvc.1.0.view", @"/Views/Pelicula/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pelicula/Index.cshtml", typeof(AspNetCore.Views_Pelicula_Index))]
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
#line 1 "C:\Users\USER\source\repos\T2\T2\Views\_ViewImports.cshtml"
using T2;

#line default
#line hidden
#line 2 "C:\Users\USER\source\repos\T2\T2\Views\_ViewImports.cshtml"
using T2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b23d9513e58fd93027348ba98ca984e6d7b13852", @"/Views/Pelicula/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d0af1dea6613a0eb51f940570a223bcd2444a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pelicula_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 425, true);
            WriteLiteral(@"
<h2>Index</h2>

<div class=""row"">
    <div class=""col-md-3"">
        <label class=""control-label"">Buscar por nombre : </label>
        <input type=""text"" id=""query"" class=""form-control"" />
    </div>
    <div class=""col-md-2"">
        <br />
        <button id=""btnBuscar"" class=""btn btn-success"">Buscar</button>
    </div>
    <div class=""col-md-2"">
        <br />
        <select id=""favorita"">
            ");
            EndContext();
            BeginContext(468, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73ffe8638d9e4cb9b0feac25c5f944a3", async() => {
                BeginContext(476, 14, true);
                WriteLiteral("--Seleccione--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(499, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(513, 22, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bc082111bc94157858e0b0cce6067d0", async() => {
                BeginContext(521, 5, true);
                WriteLiteral("Todas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(535, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(549, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4561e8590174c64b03def007149e849", async() => {
                BeginContext(557, 9, true);
                WriteLiteral("Favoritas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(575, 282, true);
            WriteLiteral(@"
        </select>
    </div>
    <div class=""col-md-2"">
        <br />
        <a href=""/Pelicula/Crear"" class=""btn btn-info"">Crear pelicula</a>
    </div>
</div>


<br />
<hr />
<div class=""row"">
    <div class=""col-md-12"">
        <div id=""peliculas"" class=""row"">
");
            EndContext();
#line 37 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
            BeginContext(916, 254, true);
            WriteLiteral("                <div class=\"col-sm-6 col-md-4\">\r\n                    <div class=\"thumbnail\">\r\n                        <img src=\"\" alt=\"...\" style=\"width:200px;height:300px\">\r\n                        <div class=\"caption\">\r\n                            <h3>");
            EndContext();
            BeginContext(1171, 11, false);
#line 44 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Index.cshtml"
                           Write(item.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1182, 38, true);
            WriteLiteral("</h3>\r\n                            <p>");
            EndContext();
            BeginContext(1221, 13, false);
#line 45 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Index.cshtml"
                          Write(item.Director);

#line default
#line hidden
            EndContext();
            BeginContext(1234, 39, true);
            WriteLiteral("</p>\r\n                            <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1273, "\"", 1318, 2);
            WriteAttributeValue("", 1280, "/Pelicula/Detalle?id=", 1280, 21, true);
#line 46 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Index.cshtml"
WriteAttributeValue("", 1301, item.Id_Pelicula, 1301, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1319, 137, true);
            WriteLiteral(" class=\"btnLibroAdd btn btn-danger\">Detalle</a></p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 50 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1471, 388, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<script>
    //alert($this.attr(""id""));//obtener el atributo id
    $(""#btnBuscar"").click(function (e) {
        e.preventDefault();
        var valor = $(""#query"").val();
        $.ajax({ url: ""/Pelicula/BuscarPorNombre?query="" + valor })
      .success(function (resp) {
          $(""#peliculas"").html(resp);
      });
    });
    </script>");
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
