#pragma checksum "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ac974d7d7ffd451dbe3273fbbc14ed0b8a7e152"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon_Details), @"mvc.1.0.view", @"/Views/Pokemon/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pokemon/Details.cshtml", typeof(AspNetCore.Views_Pokemon_Details))]
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
#line 5 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
using PokedexClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac974d7d7ffd451dbe3273fbbc14ed0b8a7e152", @"/Views/Pokemon/Details.cshtml")]
    public class Views_Pokemon_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PokedexClient.Models.Pokemon>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(93, 6, true);
            WriteLiteral("\n<h1>#");
            EndContext();
            BeginContext(100, 41, false);
#line 8 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayFor(model => model.PokemonId));

#line default
#line hidden
            EndContext();
            BeginContext(141, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(143, 39, false);
#line 8 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                           Write(Html.DisplayFor(model => model.Species));

#line default
#line hidden
            EndContext();
            BeginContext(182, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
#line 10 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
 if(@Model.PokemonId >= 2 && @Model.PokemonId != 151)
{

#line default
#line hidden
            BeginContext(245, 32, true);
            WriteLiteral("  <div class=\"next-button\">\n    ");
            EndContext();
            BeginContext(278, 66, false);
#line 13 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.ActionLink("◀︎", "Details", new { id = @Model.PokemonId - 1}));

#line default
#line hidden
            EndContext();
            BeginContext(344, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(347, 66, false);
#line 13 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                                                    Write(Html.ActionLink("▶︎", "Details", new { id = @Model.PokemonId + 1}));

#line default
#line hidden
            EndContext();
            BeginContext(413, 10, true);
            WriteLiteral("\n  </div>\n");
            EndContext();
#line 15 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
} 
else if (@Model.PokemonId == 151)
{

#line default
#line hidden
            BeginContext(462, 32, true);
            WriteLiteral("  <div class=\"next-button\">\n    ");
            EndContext();
            BeginContext(495, 66, false);
#line 19 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.ActionLink("◀︎", "Details", new { id = @Model.PokemonId - 1}));

#line default
#line hidden
            EndContext();
            BeginContext(561, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(564, 67, false);
#line 19 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                                                    Write(Html.ActionLink("▶︎", "Details", new { id = @Model.PokemonId -150}));

#line default
#line hidden
            EndContext();
            BeginContext(631, 10, true);
            WriteLiteral("\n  </div>\n");
            EndContext();
#line 21 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
} 
else if (@Model.PokemonId == 1)
{

#line default
#line hidden
            BeginContext(678, 32, true);
            WriteLiteral("  <div class=\"next-button\">\n    ");
            EndContext();
            BeginContext(711, 67, false);
#line 25 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.ActionLink("◀︎", "Details", new { id = @Model.PokemonId +150}));

#line default
#line hidden
            EndContext();
            BeginContext(778, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(781, 65, false);
#line 25 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                                                     Write(Html.ActionLink("▶︎", "Details", new { id = @Model.PokemonId +1}));

#line default
#line hidden
            EndContext();
            BeginContext(846, 10, true);
            WriteLiteral("\n  </div>\n");
            EndContext();
#line 27 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
} 

#line default
#line hidden
            BeginContext(859, 12, true);
            WriteLiteral("\n\n<hr/>\n<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 871, "\"", 893, 1);
#line 31 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
WriteAttributeValue("", 877, Model.ImageMain, 877, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 894, "\"", 914, 1);
#line 31 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
WriteAttributeValue("", 900, Model.Species, 900, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(915, 122, true);
            WriteLiteral(">\n<p><br></p>\n<div class=\"container\">\n  <div class=\"row\">\n    <div class=\"col-sm-12\">\n      <h1>Description</h1>\n      <p>");
            EndContext();
            BeginContext(1038, 43, false);
#line 37 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
    Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 90, true);
            WriteLiteral("</p>\n    </div>\n<div class=\"col-sm-1\">\n</div>\n<div class=\"col-sm-5\">\n  <h1>Info</h1>\n  <p>");
            EndContext();
            BeginContext(1172, 43, false);
#line 43 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Species));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1218, 39, false);
#line 43 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Species));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(1268, 48, false);
#line 44 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayNameFor(model => model.PokeTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1319, 44, false);
#line 44 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.PokeTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(1374, 42, false);
#line 45 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1419, 38, false);
#line 45 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                             Write(Html.DisplayFor(model => model.Height));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 17, true);
            WriteLiteral(" Meters</p>\n  <p>");
            EndContext();
            BeginContext(1475, 42, false);
#line 46 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1520, 38, false);
#line 46 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                             Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 13, true);
            WriteLiteral(" Kg</p>\n  <p>");
            EndContext();
            BeginContext(1572, 43, false);
#line 47 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Ability));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1618, 39, false);
#line 47 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Ability));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 55, true);
            WriteLiteral("</p>\n</div>\n\n<div class=\"col-sm-6\">\n<h1>Stats</h1>\n\n<p>");
            EndContext();
            BeginContext(1713, 41, false);
#line 53 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Speed));

#line default
#line hidden
            EndContext();
            BeginContext(1754, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1757, 37, false);
#line 53 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Speed));

#line default
#line hidden
            EndContext();
            BeginContext(1794, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(1804, 41, false);
#line 55 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayNameFor(model => model.SpDef));

#line default
#line hidden
            EndContext();
            BeginContext(1845, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1848, 37, false);
#line 55 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.SpDef));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(1895, 41, false);
#line 57 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayNameFor(model => model.SpAtk));

#line default
#line hidden
            EndContext();
            BeginContext(1936, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1939, 37, false);
#line 57 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.SpAtk));

#line default
#line hidden
            EndContext();
            BeginContext(1976, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(1986, 43, false);
#line 59 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Defense));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(2032, 39, false);
#line 59 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                            Write(Html.DisplayFor(model => model.Defense));

#line default
#line hidden
            EndContext();
            BeginContext(2071, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(2081, 38, false);
#line 61 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Hp));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(2122, 34, false);
#line 61 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Hp));

#line default
#line hidden
            EndContext();
            BeginContext(2156, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(2166, 42, false);
#line 63 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Attack));

#line default
#line hidden
            EndContext();
            BeginContext(2208, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(2211, 38, false);
#line 63 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/Pokemon/Details.cshtml"
                                           Write(Html.DisplayFor(model => model.Attack));

#line default
#line hidden
            EndContext();
            BeginContext(2249, 31, true);
            WriteLiteral("</p>\n\n\n\n</div>\n</div>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PokedexClient.Models.Pokemon> Html { get; private set; }
    }
}
#pragma warning restore 1591
