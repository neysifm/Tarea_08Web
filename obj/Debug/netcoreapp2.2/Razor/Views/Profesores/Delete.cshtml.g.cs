#pragma checksum "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa181e162c297d765e81adcc250333e35b388146"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profesores_Delete), @"mvc.1.0.view", @"/Views/Profesores/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profesores/Delete.cshtml", typeof(AspNetCore.Views_Profesores_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa181e162c297d765e81adcc250333e35b388146", @"/Views/Profesores/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e474c171bf9b453425107ead8a0b415bc585e9c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Profesores_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tarea_07Web.Models.Profesor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary fas fa-arrow-alt-circle-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
  
    ViewData["Title"] = "Eliminar";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(134, 471, true);
            WriteLiteral(@"
<div class=""col-md-12"">

    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <br />
            <h1 class=""col-lg-offset-4"" style=""font-family:Cambria""><strong>Esta accion no se podra deshacer</strong></h1>
        </div>

        <div class=""box-body"">

            <hr />
            <div class=""row"">
                <dl class=""row"">
                    <dt class=""col-lg-3 col-lg-offset-4"">
                        ");
            EndContext();
            BeginContext(606, 38, false);
#line 22 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(644, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(724, 34, false);
#line 25 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(758, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(871, 42, false);
#line 28 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(913, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(993, 38, false);
#line 31 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(1144, 42, false);
#line 34 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1266, 38, false);
#line 37 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Cedula));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(1417, 51, false);
#line 40 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1548, 47, false);
#line 43 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(1708, 48, false);
#line 46 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.FechaIngreso));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1836, 44, false);
#line 49 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.FechaIngreso));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(1993, 42, false);
#line 52 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(2035, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2115, 38, false);
#line 55 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(2153, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(2266, 44, false);
#line 58 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(2310, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2390, 40, false);
#line 61 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(2430, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(2543, 40, false);
#line 64 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
            EndContext();
            BeginContext(2583, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2663, 36, false);
#line 67 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Sexo));

#line default
#line hidden
            EndContext();
            BeginContext(2699, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(2812, 47, false);
#line 70 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.EstadoCivil));

#line default
#line hidden
            EndContext();
            BeginContext(2859, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2939, 43, false);
#line 73 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.EstadoCivil));

#line default
#line hidden
            EndContext();
            BeginContext(2982, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(3095, 45, false);
#line 76 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Ocupacion));

#line default
#line hidden
            EndContext();
            BeginContext(3140, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3220, 41, false);
#line 79 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Ocupacion));

#line default
#line hidden
            EndContext();
            BeginContext(3261, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(3374, 46, false);
#line 82 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.TipoSangre));

#line default
#line hidden
            EndContext();
            BeginContext(3420, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3500, 42, false);
#line 85 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.TipoSangre));

#line default
#line hidden
            EndContext();
            BeginContext(3542, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(3655, 48, false);
#line 88 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nacionalidad));

#line default
#line hidden
            EndContext();
            BeginContext(3703, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3783, 44, false);
#line 91 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Nacionalidad));

#line default
#line hidden
            EndContext();
            BeginContext(3827, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(3940, 44, false);
#line 94 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Religion));

#line default
#line hidden
            EndContext();
            BeginContext(3984, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4064, 40, false);
#line 97 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Religion));

#line default
#line hidden
            EndContext();
            BeginContext(4104, 114, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(4219, 44, false);
#line 101 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(4263, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4343, 40, false);
#line 104 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(4383, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(4496, 41, false);
#line 107 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4537, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4617, 37, false);
#line 110 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4654, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(4767, 45, false);
#line 113 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(4812, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(4892, 41, false);
#line 116 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(4933, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(5046, 43, false);
#line 119 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Carrera));

#line default
#line hidden
            EndContext();
            BeginContext(5089, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(5169, 39, false);
#line 122 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Carrera));

#line default
#line hidden
            EndContext();
            BeginContext(5208, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(5321, 55, false);
#line 125 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mayorgradoacademico));

#line default
#line hidden
            EndContext();
            BeginContext(5376, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(5456, 51, false);
#line 128 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Mayorgradoacademico));

#line default
#line hidden
            EndContext();
            BeginContext(5507, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(5620, 56, false);
#line 131 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Categoriaprofesional));

#line default
#line hidden
            EndContext();
            BeginContext(5676, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(5756, 52, false);
#line 134 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Categoriaprofesional));

#line default
#line hidden
            EndContext();
            BeginContext(5808, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(5921, 44, false);
#line 137 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Facultad));

#line default
#line hidden
            EndContext();
            BeginContext(5965, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(6045, 40, false);
#line 140 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Facultad));

#line default
#line hidden
            EndContext();
            BeginContext(6085, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(6198, 47, false);
#line 143 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Asignaturas));

#line default
#line hidden
            EndContext();
            BeginContext(6245, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(6325, 43, false);
#line 146 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Asignaturas));

#line default
#line hidden
            EndContext();
            BeginContext(6368, 112, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-lg-3 col-lg-offset-4\">\r\n                        ");
            EndContext();
            BeginContext(6481, 49, false);
#line 149 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(6530, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(6610, 45, false);
#line 152 "C:\Users\Neysi FM\Desktop\Tarea_07Web\Tarea_07Web\Views\Profesores\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(6655, 110, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(6765, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa181e162c297d765e81adcc250333e35b38814626374", async() => {
                BeginContext(6791, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6797, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa181e162c297d765e81adcc250333e35b38814626762", async() => {
                    BeginContext(6872, 8, true);
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
                BeginContext(6884, 89, true);
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger col-lg-offset-4\" /> |\r\n");
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
            BeginContext(6980, 2, true);
            WriteLiteral("\r\n");
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
