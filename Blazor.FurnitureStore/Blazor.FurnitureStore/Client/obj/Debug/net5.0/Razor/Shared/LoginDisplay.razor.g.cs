#pragma checksum "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bb6517351ef7b70b820ebd396b8802923c95390"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.FurnitureStore.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Blazor.FurnitureStore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Blazor.FurnitureStore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Blazor.FurnitureStore.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Blazor.FurnitureStore.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "a");
                __builder2.AddAttribute(3, "href", "authentication/profile");
                __builder2.AddContent(4, "Hello, ");
#nullable restore
#line 9 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Shared\LoginDisplay.razor"
__builder2.AddContent(5, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(6, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "button");
                __builder2.AddAttribute(9, "class", "nav-link btn btn-link");
                __builder2.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Shared\LoginDisplay.razor"
                                                        BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(11, "Log out");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(12, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "<a href=\"authentication/register\">Register</a>\r\n        ");
                __builder2.AddMarkupContent(14, "<a href=\"authentication/login\">Log in</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Shared\LoginDisplay.razor"
      
    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
