#pragma checksum "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c4cdde6403557c7aeeb48fcfcc33c34af9b2b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pelicula_Crear), @"mvc.1.0.view", @"/Views/Pelicula/Crear.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pelicula/Crear.cshtml", typeof(AspNetCore.Views_Pelicula_Crear))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c4cdde6403557c7aeeb48fcfcc33c34af9b2b16", @"/Views/Pelicula/Crear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d0af1dea6613a0eb51f940570a223bcd2444a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pelicula_Crear : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "--Seleccione--", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Martin Scorsese", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Quentin Tarantino", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "David Lynch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Pelicula/Crear"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml"
  
    ViewData["Title"] = "Crear";

#line default
#line hidden
            BeginContext(43, 185, true);
            WriteLiteral("\r\n<h2>Crear</h2>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-2\"></div>\r\n        <div class=\"col-sm-8\">\r\n            <div class=\"row\">\r\n                ");
            EndContext();
            BeginContext(228, 2955, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4318bb5aa8c745f8bfd9843af97bd527", async() => {
                BeginContext(303, 526, true);
                WriteLiteral(@"

                    <div class=""panel panel-primary"">
                        <div class=""panel-heading text-center""><h3>Crear pelicula</h3></div>
                        <div class=""panel-body"">
                            <div class=""col-sm-4""></div>
                            <div class=""col-sm-4"">

                                <div>
                                    <label class=""control-label"">Codigo :</label>
                                    <input class=""form-control"" type=""text"" name=""Codigo""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 829, "\"", 850, 1);
#line 23 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml"
WriteAttributeValue("", 837, Model.Codigo, 837, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(851, 41, true);
                WriteLiteral(" />\r\n                                    ");
                EndContext();
                BeginContext(893, 32, false);
#line 24 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml"
                               Write(Html.ValidationMessage("Codigo"));

#line default
#line hidden
                EndContext();
                BeginContext(925, 253, true);
                WriteLiteral("\r\n                                </div>\r\n                                <div>\r\n                                    <label class=\"control-label\">Nombre :</label>\r\n                                    <input class=\"form-control\" type=\"text\" name=\"Nombre\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1178, "\"", 1199, 1);
#line 28 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml"
WriteAttributeValue("", 1186, Model.Nombre, 1186, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1200, 41, true);
                WriteLiteral(" />\r\n                                    ");
                EndContext();
                BeginContext(1242, 32, false);
#line 29 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml"
                               Write(Html.ValidationMessage("Nombre"));

#line default
#line hidden
                EndContext();
                BeginContext(1274, 289, true);
                WriteLiteral(@"
                                </div>
                                <div>
                                    <label class=""control-label"">Director :</label>
                                    <select name=""Director"" class=""form-control"">
                                        ");
                EndContext();
                BeginContext(1563, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "189c935e8ec9408cb442b2ae3d6088f3", async() => {
                    BeginContext(1594, 14, true);
                    WriteLiteral("--Seleccione--");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1617, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(1659, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c914c5f15c444c1587f4b0975524259a", async() => {
                    BeginContext(1691, 15, true);
                    WriteLiteral("Martin Scorsese");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1715, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(1757, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cb70f88db9640eb9cd3587e00ad33a3", async() => {
                    BeginContext(1791, 17, true);
                    WriteLiteral("Quentin Tarantino");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1817, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(1859, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8026d29170874b0d8ef1cc5d3ad64e06", async() => {
                    BeginContext(1887, 11, true);
                    WriteLiteral("David Lynch");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1907, 85, true);
                WriteLiteral("\r\n                                    </select>\r\n                                    ");
                EndContext();
                BeginContext(1993, 34, false);
#line 39 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml"
                               Write(Html.ValidationMessage("Director"));

#line default
#line hidden
                EndContext();
                BeginContext(2027, 282, true);
                WriteLiteral(@"
                                </div>

                                <div>
                                    <label class=""control-label"">Año :</label>
                                    <select name=""Anio"" class=""form-control"">
                                        ");
                EndContext();
                BeginContext(2309, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e55e773831a40c89e197afcb544df5f", async() => {
                    BeginContext(2340, 14, true);
                    WriteLiteral("--Seleccione--");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2363, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 46 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml"
                                         for (var i = 2020; i >= 1990; i--)
                                        {

#line default
#line hidden
                BeginContext(2485, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(2529, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a16167e86f614b998525e4772109f52d", async() => {
                    BeginContext(2549, 1, false);
#line 48 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml"
                                                          Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 48 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml"
                                               WriteLiteral(i);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2559, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 49 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2604, 83, true);
                WriteLiteral("                                    </select>\r\n                                    ");
                EndContext();
                BeginContext(2688, 30, false);
#line 51 "C:\Users\USER\source\repos\T2\T2\Views\Pelicula\Crear.cshtml"
                               Write(Html.ValidationMessage("Anio"));

#line default
#line hidden
                EndContext();
                BeginContext(2718, 458, true);
                WriteLiteral(@"
                                </div>

                                <br />
                                <div class=""panel-body"">
                                    <button class=""btn btn-primary pull-right""> Guardar</button>
                                </div>

                            </div>
                            <div class=""col-sm-4""></div>

                        </div>

                    </div>

                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3183, 170, true);
            WriteLiteral("\r\n                    </div>\r\n            </div>\r\n\r\n              \r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"col-sm-2\"></div>\r\n    </div>\r\n</div>\r\n</div>");
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