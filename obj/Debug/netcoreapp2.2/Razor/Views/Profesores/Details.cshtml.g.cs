#pragma checksum "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40ec756ed35bf17013da86a836802cd529cb87a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profesores_Details), @"mvc.1.0.view", @"/Views/Profesores/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profesores/Details.cshtml", typeof(AspNetCore.Views_Profesores_Details))]
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
#line 1 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\_ViewImports.cshtml"
using Tarea_07Web;

#line default
#line hidden
#line 2 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\_ViewImports.cshtml"
using Tarea_07Web.Models;

#line default
#line hidden
#line 5 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#line 7 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ec756ed35bf17013da86a836802cd529cb87a1", @"/Views/Profesores/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e474c171bf9b453425107ead8a0b415bc585e9c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Profesores_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tarea_07Web.Models.Profesor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger fas fa-arrow-alt-circle-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
  
    ViewData["Title"] = "Detalles";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(134, 457, true);
            WriteLiteral(@"
<div class=""col-md-12"">

    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <br />
            <h1 class=""col-lg-offset-4"" style=""font-family:Cambria""><strong>Detalle Profesores</strong></h1>
        </div>

        <div class=""box-body"">

            <hr />
            <div class=""row"">
                <dl class=""row"">
                    <dt class=""col-lg-3 col-lg-offset-4"">
                        ");
            EndContext();
            BeginContext(592, 38, false);
#line 22 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(630, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(710, 34, false);
#line 25 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(744, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(857, 42, false);
#line 28 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(899, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(979, 38, false);
#line 31 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(1130, 42, false);
#line 34 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1252, 38, false);
#line 37 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Cedula));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(1403, 51, false);
#line 40 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1534, 47, false);
#line 43 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1581, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(1694, 48, false);
#line 46 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.FechaIngreso));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1822, 44, false);
#line 49 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.FechaIngreso));

#line default
#line hidden
            EndContext();
            BeginContext(1866, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(1979, 42, false);
#line 52 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(2021, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2101, 38, false);
#line 55 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(2139, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(2252, 44, false);
#line 58 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(2296, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2376, 40, false);
#line 61 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(2416, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(2529, 40, false);
#line 64 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
            EndContext();
            BeginContext(2569, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2649, 36, false);
#line 67 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Sexo));

#line default
#line hidden
            EndContext();
            BeginContext(2685, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(2798, 47, false);
#line 70 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.EstadoCivil));

#line default
#line hidden
            EndContext();
            BeginContext(2845, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2925, 43, false);
#line 73 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.EstadoCivil));

#line default
#line hidden
            EndContext();
            BeginContext(2968, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(3081, 45, false);
#line 76 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Ocupacion));

#line default
#line hidden
            EndContext();
            BeginContext(3126, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3206, 41, false);
#line 79 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Ocupacion));

#line default
#line hidden
            EndContext();
            BeginContext(3247, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(3360, 46, false);
#line 82 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.TipoSangre));

#line default
#line hidden
            EndContext();
            BeginContext(3406, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3486, 42, false);
#line 85 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.TipoSangre));

#line default
#line hidden
            EndContext();
            BeginContext(3528, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(3641, 48, false);
#line 88 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nacionalidad));

#line default
#line hidden
            EndContext();
            BeginContext(3689, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3769, 44, false);
#line 91 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Nacionalidad));

#line default
#line hidden
            EndContext();
            BeginContext(3813, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(3926, 44, false);
#line 94 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Religion));

#line default
#line hidden
            EndContext();
            BeginContext(3970, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4050, 40, false);
#line 97 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Religion));

#line default
#line hidden
            EndContext();
            BeginContext(4090, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(4203, 44, false);
#line 100 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(4247, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4327, 40, false);
#line 103 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(4367, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(4480, 41, false);
#line 106 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4521, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4601, 37, false);
#line 109 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4638, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(4751, 45, false);
#line 112 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(4796, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4876, 41, false);
#line 115 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(4917, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(5030, 43, false);
#line 118 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Carrera));

#line default
#line hidden
            EndContext();
            BeginContext(5073, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(5153, 39, false);
#line 121 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Carrera));

#line default
#line hidden
            EndContext();
            BeginContext(5192, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(5305, 55, false);
#line 124 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mayorgradoacademico));

#line default
#line hidden
            EndContext();
            BeginContext(5360, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(5440, 51, false);
#line 127 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Mayorgradoacademico));

#line default
#line hidden
            EndContext();
            BeginContext(5491, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(5604, 56, false);
#line 130 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Categoriaprofesional));

#line default
#line hidden
            EndContext();
            BeginContext(5660, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(5740, 52, false);
#line 133 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Categoriaprofesional));

#line default
#line hidden
            EndContext();
            BeginContext(5792, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(5905, 44, false);
#line 136 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Facultad));

#line default
#line hidden
            EndContext();
            BeginContext(5949, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(6029, 40, false);
#line 139 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Facultad));

#line default
#line hidden
            EndContext();
            BeginContext(6069, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(6182, 47, false);
#line 142 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Asignaturas));

#line default
#line hidden
            EndContext();
            BeginContext(6229, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(6309, 43, false);
#line 145 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Asignaturas));

#line default
#line hidden
            EndContext();
            BeginContext(6352, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(6465, 49, false);
#line 148 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(6514, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(6594, 45, false);
#line 151 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(6639, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(6751, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40ec756ed35bf17013da86a836802cd529cb87a126409", async() => {
                BeginContext(6775, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6781, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40ec756ed35bf17013da86a836802cd529cb87a126797", async() => {
                    BeginContext(6855, 8, true);
                    WriteLiteral("Regresar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6867, 88, true);
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Editar\" class=\"btn btn-primary col-lg-offset-4\" /> |\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<NSettings> _personalSettings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<AppSettings> _appSettings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<GlobalSettings> _gSettings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tarea_07Web.Models.Profesor> Html { get; private set; }
    }
}
#pragma warning restore 1591