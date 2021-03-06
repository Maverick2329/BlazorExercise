#pragma checksum "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8299950e89463175a3f7cc067779910a20351b1"
// <auto-generated/>
#pragma warning disable 1591
namespace BalzorPokedex.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\_Imports.razor"
using BalzorPokedex.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\_Imports.razor"
using BalzorPokedex.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pokeDetails/{name}")]
    public partial class PokemonDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
 if(Pokemon == null)
 {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
 }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row row-align");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-6");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mt-2");
            __builder.OpenElement(7, "h1");
#nullable restore
#line 15 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
__builder.AddContent(8, Pokemon.Name.Substring(0,1).ToUpper());

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
__builder.AddContent(9, Pokemon.Name.Substring(1,Pokemon.Name.Length - 1));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
                 foreach (var poke in Pokemon.Types)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "class", "badge" + " border" + " rounded-pill" + " bg-" + (
#nullable restore
#line 18 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
                                                               poke.PokemonType.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "style", "font-size:medium; text-align:center");
#nullable restore
#line 19 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
__builder.AddContent(13, poke.PokemonType.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "list-group-item mt-4");
            __builder.AddAttribute(17, "style", "width:20 rem");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "list-group list-group-flush bg-transparent");
            __builder.AddMarkupContent(20, "\r\n                    ID #");
            __builder.OpenElement(21, "b");
            __builder.AddAttribute(22, "class", "float-end");
#nullable restore
#line 25 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
__builder.AddContent(23, Pokemon.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "list-group-item bg-transparent");
            __builder.AddMarkupContent(27, "\r\n                    Experience ");
            __builder.OpenElement(28, "b");
            __builder.AddAttribute(29, "class", "float-end");
#nullable restore
#line 28 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
__builder.AddContent(30, Pokemon.Experience);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "list-group-item bg-transparent");
            __builder.AddMarkupContent(34, "\r\n                    Weight ");
            __builder.OpenElement(35, "b");
            __builder.AddAttribute(36, "class", "float-end");
#nullable restore
#line 31 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
__builder.AddContent(37, Pokemon.Weight);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "list-group-item bg-transparent");
            __builder.AddMarkupContent(41, "\r\n                    Height ");
            __builder.OpenElement(42, "b");
            __builder.AddAttribute(43, "class", "float-end");
#nullable restore
#line 34 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
__builder.AddContent(44, Pokemon.Height);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-ms-6");
            __builder.OpenElement(48, "img");
            __builder.AddAttribute(49, "src", "https://img.pokemondb.net/artwork/large/" + (
#nullable restore
#line 40 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
                                                                Pokemon.Name

#line default
#line hidden
#nullable disable
            ) + ".jpg");
            __builder.AddAttribute(50, "alt", 
#nullable restore
#line 40 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
                                                                                         Pokemon.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "class", "img-fluid d-block mx-auto");
            __builder.AddAttribute(52, "style", "width:300px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Development\Training\Back\BalzorPokedex\BalzorPokedex.Client\Pages\PokemonDetails.razor"
       
    [Parameter]
    public string name { get; set; }

    public Pokemon Pokemon { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Pokemon = await PokeApiClient.GetPokemon(name);
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPokeApiClient PokeApiClient { get; set; }
    }
}
#pragma warning restore 1591
