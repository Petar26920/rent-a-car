#pragma checksum "C:\Users\sladj\source\repos\pokusajNecega3\pokusajNecega3\Views\Vozilo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08045ebecb9a1c88873236424ca41d3acf241568"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vozilo_Index), @"mvc.1.0.view", @"/Views/Vozilo/Index.cshtml")]
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
#line 1 "C:\Users\sladj\source\repos\pokusajNecega3\pokusajNecega3\Views\_ViewImports.cshtml"
using pokusajNecega3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sladj\source\repos\pokusajNecega3\pokusajNecega3\Views\_ViewImports.cshtml"
using pokusajNecega3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08045ebecb9a1c88873236424ca41d3acf241568", @"/Views/Vozilo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da83ffba8ce06b0cf97f0f6acc1044e9934cbe76", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Vozilo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<pokusajNecega3.Models.BusinesObject.VoziloBO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <label>Pretraga vozila</label>\r\n        <div>\r\n            ");
#nullable restore
#line 7 "C:\Users\sladj\source\repos\pokusajNecega3\pokusajNecega3\Views\Vozilo\Index.cshtml"
       Write(Html.DropDownList(
            "VozilaPregled",
            new SelectList(@ViewBag.SvaVozila, "Tip", "Tip"),
            "Izaberi tip",
            new
                 {
                     @class = "form-control",
                @onchange = "OnSelectedVozilo(this.value)"
                 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div><br /><br />\r\n<div id=\"Vozila\">\r\n\r\n");
#nullable restore
#line 22 "C:\Users\sladj\source\repos\pokusajNecega3\pokusajNecega3\Views\Vozilo\Index.cshtml"
      Html.ActionLink("NadjiSvaVozilaTogTipa", "Vozilo", new { tip = "karavan" });

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<section>

</section>


<script type=""text/javascript"">

    function OnSelectedVozilo(vozilo) {
        console.log(typeof vozilo);
        var idVozila = vozilo;
        if(!idVozila)
        {
            idVozila = ""prazno"";
        }
        console.log(idVozila);
        $.ajax({
            url: '");
#nullable restore
#line 41 "C:\Users\sladj\source\repos\pokusajNecega3\pokusajNecega3\Views\Vozilo\Index.cshtml"
             Write(Url.Action("NadjiSvaVozilaTogTipa", "Vozilo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            data: { tip: idVozila },\r\n          success:   function(result) {\r\n              $(\'#Vozila\').html(result);\r\n              document.getElementById(\'Vozila\').value = result;\r\n            }\r\n        });\r\n    }\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<pokusajNecega3.Models.BusinesObject.VoziloBO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
