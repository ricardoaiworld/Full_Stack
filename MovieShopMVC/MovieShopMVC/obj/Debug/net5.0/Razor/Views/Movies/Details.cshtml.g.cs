#pragma checksum "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f91821c10f93d72277d3b94423c7aef79269134"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/_ViewImports.cshtml"
using MovieShopMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/_ViewImports.cshtml"
using MovieShopMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f91821c10f93d72277d3b94423c7aef79269134", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d2154f16347fb0df8a919e414827cd460665e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationCore.Models.MovieDetailsResponseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container-fluid\">\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            <img");
            BeginWriteAttribute("src", " src=", 155, "", 176, 1);
#nullable restore
#line 5 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
WriteAttributeValue("", 160, Model.PosterUrl, 160, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\n        </div>\n        <div class=\"col-md-6\">\n            <h1>\n                ");
#nullable restore
#line 9 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h1>\n            <div class=\"pt-3\">\n                <h3>\n                    Casts:\n                </h3>\n                <div>\n");
#nullable restore
#line 16 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
                     foreach (var Cast in Model.Casts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 532, "\"", 556, 1);
#nullable restore
#line 18 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
WriteAttributeValue("", 539, Cast.ProfilePath, 539, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
                                               Write(Cast.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 19 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n            <div class=\"pt-3\">\n                <h3>\n                    Overview\n                </h3>\n                <div>\n                    ");
#nullable restore
#line 27 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
               Write(Model.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"pt-3\">\n                <h3>\n                    Genre:\n                </h3>\n                <div>\n");
#nullable restore
#line 35 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
                     foreach (var genre in Model.Genres)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"pr-2 btn btn-secondary active\">");
#nullable restore
#line 37 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                 Write(genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n");
#nullable restore
#line 38 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n            <div>\n                <h3 class=\"pt-3\">Other Info</h3>\n                <div>Release Date:");
#nullable restore
#line 43 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
                             Write(Model.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            </div>\n        </div>\n        <div class=\"col-md\">\n            <div>\n                Rating:\n                <div>\n                    <button class=\"btn-outline-danger active btn-block\">");
#nullable restore
#line 50 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                   Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                </div>\n            </div>\n            <div>\n                Purchase:\n                <div>\n                    <button class=\"btn-warning active btn-block\">Price:");
#nullable restore
#line 56 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                  Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                </div>\n            </div>\n            <div class=\"mt-5\">\n                <button class=\"btn-outline-info active btn-block\">Favorite<span class=\"badge badge-light\">");
#nullable restore
#line 60 "/Users/ricardo/Downloads/MVCSHOP-main/MovieShopMVC/Views/Movies/Details.cshtml"
                                                                                                     Write(Model.FavoritesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></button>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationCore.Models.MovieDetailsResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
