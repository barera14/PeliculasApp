#pragma checksum "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\Home\ListMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c3e491ec52e6a19a16a8e9ff3c753aa959e7b42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListMovies), @"mvc.1.0.view", @"/Views/Home/ListMovies.cshtml")]
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
#line 1 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\_ViewImports.cshtml"
using IuPeliculas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\_ViewImports.cshtml"
using IuPeliculas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c3e491ec52e6a19a16a8e9ff3c753aa959e7b42", @"/Views/Home/ListMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77cd61a10ce8bb0f683a7e2f2d1ac0bb624504c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IuPeliculas.Models.searchResult>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\Home\ListMovies.cshtml"
 if (Model.Response)
{    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"box\">\r\n");
#nullable restore
#line 5 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\Home\ListMovies.cshtml"
         foreach (Movies item in Model.Search)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"margin:5px;\">\r\n                <div class=\"card\" style=\"width: 16rem;\">\r\n                    <img");
            BeginWriteAttribute("alt", " alt=\"", 269, "\"", 332, 3);
            WriteAttributeValue("", 275, "Poster", 275, 6, true);
            WriteAttributeValue(" ", 281, "pelicula", 282, 9, true);
#nullable restore
#line 9 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\Home\ListMovies.cshtml"
WriteAttributeValue(" ", 290, Html.DisplayFor(modelItem => item.Title), 291, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 333, "\"", 381, 1);
#nullable restore
#line 9 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\Home\ListMovies.cshtml"
WriteAttributeValue("", 339, Html.DisplayFor(modelItem => item.Poster), 339, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" align=\"left\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-11\" style=\"margin:5px;\">\r\n                            <h5 class=\"card-title\"> ");
#nullable restore
#line 12 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\Home\ListMovies.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-7\" style=\"margin:5px;\">\r\n                            Año: ");
#nullable restore
#line 17 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\Home\ListMovies.cshtml"
                            Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-3\" style=\"margin:5px;\">      \r\n                            ");
#nullable restore
#line 20 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\Home\ListMovies.cshtml"
                       Write(Html.ActionLink("Ver", "Detalle", "Home", new { id = item.imdbID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\Home\ListMovies.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 27 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\Home\ListMovies.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"alert alert-danger\" role=\"alert\">\r\n                No se encontro ningún resultado.\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\ALEJANDRO BERNAL\source\repos\slnPeliculas\IuPeliculas\Views\Home\ListMovies.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IuPeliculas.Models.searchResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
