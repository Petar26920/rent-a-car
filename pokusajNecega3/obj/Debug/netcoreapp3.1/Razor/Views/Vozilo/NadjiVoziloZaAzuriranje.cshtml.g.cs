#pragma checksum "D:\Projekat za ppp\PPP\pokusajNecega3\Views\Vozilo\NadjiVoziloZaAzuriranje.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2365a67df3243bcc4b81b6976609dab428d9980b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vozilo_NadjiVoziloZaAzuriranje), @"mvc.1.0.view", @"/Views/Vozilo/NadjiVoziloZaAzuriranje.cshtml")]
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
#line 1 "D:\Projekat za ppp\PPP\pokusajNecega3\Views\_ViewImports.cshtml"
using pokusajNecega3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projekat za ppp\PPP\pokusajNecega3\Views\_ViewImports.cshtml"
using pokusajNecega3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2365a67df3243bcc4b81b6976609dab428d9980b", @"/Views/Vozilo/NadjiVoziloZaAzuriranje.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec3ee268f3c0cd7cfa2ea28c12ca64da35c5979", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Vozilo_NadjiVoziloZaAzuriranje : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<pokusajNecega3.Models.BusinesObject.VoziloBO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n");
#nullable restore
#line 5 "D:\Projekat za ppp\PPP\pokusajNecega3\Views\Vozilo\NadjiVoziloZaAzuriranje.cshtml"
 foreach (var voz in Model)
{
        string boja = voz.Boja;
  

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>Tip vozila:</label>\n    <br />\n");
#nullable restore
#line 12 "D:\Projekat za ppp\PPP\pokusajNecega3\Views\Vozilo\NadjiVoziloZaAzuriranje.cshtml"
Write(Html.DropDownList("TipVozila", new SelectList(@ViewBag.Tip, voz.Tip),
                "Izaberi",
                new
                {
                    @class = "form-control",
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <label>Model:</label>\n    <br />\n    <input type=\"text\" class=\"form-control\" name=\"nMod\" id=\"iMod\"");
            BeginWriteAttribute("value", " value=\"", 582, "\"", 600, 1);
#nullable restore
#line 21 "D:\Projekat za ppp\PPP\pokusajNecega3\Views\Vozilo\NadjiVoziloZaAzuriranje.cshtml"
WriteAttributeValue("", 590, voz.Model, 590, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    <br />
    <label>Boja:</label>
    <br />
    <input type=""text"" class=""form-control"" name=""nBoj"" id=""iBoj"" value=""Crvena"" />
    <br />
    <label>Tezina:</label>
    <br />
    <input type=""number"" min=""0"" max=""10000"" class=""form-control"" name=""nTez"" id=""iTez""");
            BeginWriteAttribute("value", " value=\"", 872, "\"", 891, 1);
#nullable restore
#line 29 "D:\Projekat za ppp\PPP\pokusajNecega3\Views\Vozilo\NadjiVoziloZaAzuriranje.cshtml"
WriteAttributeValue("", 880, voz.Tezina, 880, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    <br />\n    <label>Vozni park:</label>\n    <br />\n    <input type=\"number\" min=\"1\" max=\"2\" class=\"form-control\" name=\"nVozPar\" id=\"iVozPar\"");
            BeginWriteAttribute("value", " value=\"", 1038, "\"", 1060, 1);
#nullable restore
#line 33 "D:\Projekat za ppp\PPP\pokusajNecega3\Views\Vozilo\NadjiVoziloZaAzuriranje.cshtml"
WriteAttributeValue("", 1046, voz.vozniPark, 1046, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    <br />\n    <label>Zauzeto:</label>\n    <br />\n");
#nullable restore
#line 37 "D:\Projekat za ppp\PPP\pokusajNecega3\Views\Vozilo\NadjiVoziloZaAzuriranje.cshtml"
     if (voz.Zauzeto)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"checkbox\" id=\"iZauz\" onchange=\"zauzeto()\" name=\"nZauz\" class=\"form-control\" checked value=\"true\"/>\n");
#nullable restore
#line 41 "D:\Projekat za ppp\PPP\pokusajNecega3\Views\Vozilo\NadjiVoziloZaAzuriranje.cshtml"

    }
    else
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"checkbox\" id=\"iZauz\" name=\"nZauz\" onchange=\"zauzeto()\" class=\"form-control\" value=\"false\"/>\n");
#nullable restore
#line 47 "D:\Projekat za ppp\PPP\pokusajNecega3\Views\Vozilo\NadjiVoziloZaAzuriranje.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
#nullable restore
#line 50 "D:\Projekat za ppp\PPP\pokusajNecega3\Views\Vozilo\NadjiVoziloZaAzuriranje.cshtml"

}

#line default
#line hidden
#nullable disable
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
