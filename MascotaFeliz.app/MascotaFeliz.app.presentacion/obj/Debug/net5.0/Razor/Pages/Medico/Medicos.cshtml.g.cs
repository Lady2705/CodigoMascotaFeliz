#pragma checksum "C:\Users\ladyr\Documents\mistic2021\ciclo 3\ds\MascotaFeliz\MascotaFeliz.app\MascotaFeliz.app.presentacion\Pages\Medico\Medicos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc44c9e38497daf7c79c678a28337da04ecddda7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.ap.presentacion.Pages.Medico.Pages_Medico_Medicos), @"mvc.1.0.razor-page", @"/Pages/Medico/Medicos.cshtml")]
namespace MascotaFeliz.ap.presentacion.Pages.Medico
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
#line 1 "C:\Users\ladyr\Documents\mistic2021\ciclo 3\ds\MascotaFeliz\MascotaFeliz.app\MascotaFeliz.app.presentacion\Pages\_ViewImports.cshtml"
using MascotaFeliz.ap.presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc44c9e38497daf7c79c678a28337da04ecddda7", @"/Pages/Medico/Medicos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc5afcd7aa0074acc3084c8fb3fc23ef9197c3a4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medico_Medicos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <div class=""white-text-container background-image-container"" style=""background-image: url('img/img-home.png')"" >
    
    
    <div class=""container"">
        <div class=""rowsd"">
           
            <div class=""col-md-6"">
                <h1>Contacta a nuestros Veterinarios</h1>
                <p>contamos con un excelente equipo de médicos veterinarios las 24 horas
                   para prestar un servicio oportuno. </p>
                 <a href=""/Medico/ListaMedicos""");
            BeginWriteAttribute("title", " title=\"", 560, "\"", 568, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-lg btn-primary"">Aqui</a>
                 
            </div>

          </div>
        </div>
      </div>
    <br>
    <br>
    <br>
    <br>
    
    
    <div class=""contenedor-formularios"">
      <div class=""caja-contenedor"">
      <li class=""tab1""><a href=""#iniciar-sesion"">Datos</a></li>
      
      </div>

    
  <div class=""contenido-tab"">
    
    
      <h1>Medicos</h1>
      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc44c9e38497daf7c79c678a28337da04ecddda74947", async() => {
                WriteLiteral(@"
        <div class=""contenedor-input"">
          <label>
            Nombre del Medico <span class=""req"">*</span>
          </label>
          <input id=""Nombre"" type=""text"" required placeholder=""Digite el Nombre Medico"" class=""form control"">
        </div>

        <div class=""contenedor-input"">
            <label>
              Tarjeta Profecional <span class=""req"">*</span>
            </label>
            <input id=""Tarjeta""type=""text"" required placeholder=""Digite el Nombre Medico"" class=""form control"">
          </div> 
          <br>
          <br>
        <div>
        <button id=""btnIngresar"" type=""submit"" class=""btn btn-primary"" style=""display: block;""> Ingresar</button>
        <button id=""btnActualizar"" type=""submit"" class=""btn btn-primary"" style=""display: none;"">Actualizar</button>
        <button id=""btnEliminar"" type=""submit"" class=""btn btn-primary"" onclick=""LimpiarDatos"">Eliminar</button>
        </div>

      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
  
        <br>
      <br>
      <br>
      <br>
      <br>
       <br>
      <br>
      <br>
      <br>
      </div>
</div>
      <br>
       <br>
      <br>
      <br>
      <br>
      <h1>lista de medicos</h1>
      <br>
      <br>
    <table class=""tabla-med"">
        <tr>
          <th>Id</th>
          <th>Nombre</th>
          <th>T.Profesional</th>
          <th>Especialidad</th>
          <th>Id.animal</th>
        </tr> 
        <tr>
          <td></td>
          <td></td>
          <td></td>
          <td></td>
          <td></td>
          
        </tr>
        <tr>
          <td></td>
          <td></td>
          <td></td>
          <td></td>
          <td></td>
          
        </tr>
        <tr>
          <td></td>
          <td></td>
          <td></td>
          <td></td>
          <td></td>
          
        </tr>
        <tr>
          <td></td>
          <td></td>
          <td></td>
          <td></td>
          <td></td>
  ");
            WriteLiteral("        \r\n        </tr>\r\n        \r\n      </table>\r\n\r\n      <script>\r\n        function LimpiarDatos(){\r\n          $(\"#Nombre\").val_(\'\');\r\n          $(\"#Tarjeta\").val_(\'\');\r\n        }\r\n      </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.app.presentacion.page.MedicosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.app.presentacion.page.MedicosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.app.presentacion.page.MedicosModel>)PageContext?.ViewData;
        public MascotaFeliz.app.presentacion.page.MedicosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591