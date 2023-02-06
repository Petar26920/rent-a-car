#pragma checksum "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\Vozilo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a7f5b656b82faa3bb15dff49b6d26b832c6bf94"
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
#line 1 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\_ViewImports.cshtml"
using pokusajNecega3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\_ViewImports.cshtml"
using pokusajNecega3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a7f5b656b82faa3bb15dff49b6d26b832c6bf94", @"/Views/Vozilo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da83ffba8ce06b0cf97f0f6acc1044e9934cbe76", @"/Views/_ViewImports.cshtml")]
    public class Views_Vozilo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<pokusajNecega3.Models.BusinesObject.VoziloBO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\"/>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <label>Pretraga vozila</label>\r\n        <div>\r\n            ");
#nullable restore
#line 7 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\Vozilo\Index.cshtml"
       Write(Html.DropDownList(
            "VozilaPregled",
            (new SelectList(@ViewBag.Tipovi)),
            "Izaberi tip",
            new
                 {
                     @class = "form-control",
                @onchange = "OnSelectedVozilo(this.value)"
                 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div><br /><br />\r\n<div id=\"Vozila\">\r\n\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Registracioni broj</th>\r\n            <th>Tip</th>\r\n            <th>Boja</th>\r\n            <th>Zauzeto</th>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\Vozilo\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\Vozilo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RegistracioniBroj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\Vozilo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\Vozilo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Boja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 43 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\Vozilo\Index.cshtml"
                     if (item.Zauzeto == false)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Nije zauzeto</p>\r\n");
#nullable restore
#line 46 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\Vozilo\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Zauzeto je</p>\r\n");
#nullable restore
#line 50 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\Vozilo\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\Vozilo\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>

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
#line 73 "C:\Users\Petar\source\repos\PPP\uptodate\pokusajNecega3\Views\Vozilo\Index.cshtml"
             Write(Url.Action("NadjiSvaVozilaTogTipa", "Vozilo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            data: { tip: idVozila },\r\n          success:   function(result) {\r\n              $(\'#Vozila\').html(result);\r\n              document.getElementById(\'Vozila\').value = result;\r\n            }\r\n        });\r\n    }\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<pokusajNecega3.Models.BusinesObject.VoziloBO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
