#pragma checksum "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5750e482f72a15b3dccb32d21166874ef67edb22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veiculo_Novo), @"mvc.1.0.razor-page", @"/Views/Veiculo/Novo.cshtml")]
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
#line 1 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\_ViewImports.cshtml"
using RevendaVeiculos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\_ViewImports.cshtml"
using RevendaVeiculos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5750e482f72a15b3dccb32d21166874ef67edb22", @"/Views/Veiculo/Novo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca3033aeeb19f151e6098ea7065bbeb5895b97db", @"/Views/_ViewImports.cshtml")]
    public class Views_Veiculo_Novo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
 if (ViewBag.Mensagem != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 10 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
   Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Cadastrar Veiculo</h1>\r\n    <p>Formulário de veículos</p>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5750e482f72a15b3dccb32d21166874ef67edb224978", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""form-group col-6"">
            <label for=""nomeInput"">Renavam</label>
            <input type=""text""
                   class=""form-control""
                   id=""renavamInput""
                   aria-describedby=""renavamHelp""
                   placeholder=""Digite um valor""
                   name=""Renavam"">
            <small id=""renavamHelp"" class=""form-text text-muted"">Digite um valor.</small>
        </div>
        <div class=""form-group col-6"">
            <label for=""nomeInput"">Modelo</label>
            <input type=""text""
                   class=""form-control""
                   id=""modeloInput""
                   aria-describedby=""modeloHelp""
                   placeholder=""Digite um modelo""
                   name=""Modelo"">
            <small id=""modeloHelp"" class=""form-text text-muted"">Digite um modelo.</small>
        </div>
    </div>
    <div class=""row"">
        <div class=""form-group col-6"">
            <label for=""anoInput""");
                WriteLiteral(@">Ano</label>
            <input type=""number""
                   class=""form-control""
                   id=""anoInput""
                   aria-describedby=""anoHelp""
                   placeholder=""Digite um ano""
                   name=""AnoModelo"">
            <small id=""anoHelp"" class=""form-text text-muted"">Digite um ano.</small>
        </div>
        <div class=""form-group col-6"">
            <label for=""quilometragemInput"">Quilometragem</label>
            <input type=""number""
                   class=""form-control""
                   id=""quilometragemInput""
                   aria-describedby=""quilometragemHelp""
                   placeholder=""Digite um valor""
                   name=""Quilometragem"">
            <small id=""quilometragemHelp"" class=""form-text text-muted"">Digite um valor.</small>
        </div>
    </div>
    <div class=""row"">
        <div class=""form-group col-6"">
            <label for=""valorInput"">Valor</label>
            <input type=""number""
                   ");
                WriteLiteral(@"class=""form-control""
                   id=""valorInput""
                   aria-describedby=""valorHelp""
                   placeholder=""Digite um valor""
                   name=""Valor"">
            <small id=""valorHelp"" class=""form-text text-muted"">Digite um valor.</small>
        </div>


        <div class=""form-group form-check col-6"">
            <label for=""valorInput"">Proprietario</label>
            <select class=""form-control"" name=""proprietario"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5750e482f72a15b3dccb32d21166874ef67edb227955", async() => {
                    WriteLiteral("Selecione um item");
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
                WriteLiteral("\r\n");
#nullable restore
#line 81 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                 if (ViewBag.Proprietario != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                     foreach (var item in ViewBag.Proprietario)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5750e482f72a15b3dccb32d21166874ef67edb229807", async() => {
#nullable restore
#line 85 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                                            Write(item.Nome);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"form-group form-check col-6\">\r\n            <label for=\"valorInput\">Marca</label>\r\n            <select class=\"form-control\" name=\"marca\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5750e482f72a15b3dccb32d21166874ef67edb2212435", async() => {
                    WriteLiteral("Selecione um item");
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
                WriteLiteral("\r\n");
#nullable restore
#line 94 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                 if (ViewBag.Marca!=null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                     foreach (var item in ViewBag.Marca)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5750e482f72a15b3dccb32d21166874ef67edb2214272", async() => {
#nullable restore
#line 98 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                                            Write(item.Nome);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 99 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n    ");
#nullable restore
#line 106 "C:\Users\Rafael\Desktop\TesteJunho22\TesteJunho22\RevendaVeiculos\RevendaVeiculos\Views\Veiculo\Novo.cshtml"
Write(Html.ActionLink("Voltar", "Index", "Proprietario", null, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RevendaVeiculos.Dominio.Entidades.Veiculo> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RevendaVeiculos.Dominio.Entidades.Veiculo> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RevendaVeiculos.Dominio.Entidades.Veiculo>)PageContext?.ViewData;
        public RevendaVeiculos.Dominio.Entidades.Veiculo Model => ViewData.Model;
    }
}
#pragma warning restore 1591