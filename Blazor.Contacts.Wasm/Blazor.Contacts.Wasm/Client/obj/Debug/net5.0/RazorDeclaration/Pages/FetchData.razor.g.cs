// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Contacts.Wasm.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\FetchData.razor"
using Blazor.Contacts.Wasm.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Development\Training\Back\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
