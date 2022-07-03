#pragma checksum "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\SongBlock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d7b6c10057d6078161a1fc5d95555251c2fb0e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMusicCatalog.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using BlazorMusicCatalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using BlazorMusicCatalog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\_Imports.razor"
using BlazorMusicCatalog.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\SongBlock.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class SongBlock : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.OpenElement(2, "tr");
            __builder.AddMarkupContent(3, "<td>Name</td>\r\n        ");
            __builder.OpenElement(4, "td");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\SongBlock.razor"
                                      Song.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Song.Name = __value, Song.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "<td>Upload</td>\r\n        ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "p");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(14);
            __builder.AddAttribute(15, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\SongBlock.razor"
                                     LoadSong

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\SongBlock.razor"
                                  RemovedSong

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Remove");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\SongBlock.razor"
       
    [Parameter]
    public Song Song { get; set; }

    [Parameter]
    public EventCallback<Song> OnSongChanged { get; set; }

    [Parameter]
    public EventCallback<Song> OnSongRemoved { get; set; }

    //async Task UpdateValueSong()
    //{
    //    await OnSongChanged.InvokeAsync(Song);
    //}

    async Task LoadSong(InputFileChangeEventArgs e)
    {
        var folderName = Path.Combine("wwwroot","songs");
        var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
        var fullPath = Path.Combine(pathToSave, e.File.Name.Replace(" ","-"));
        Song.Extension = e.File.Name.Substring(e.File.Name.Count() - 3, 3);
        Song.Path = e.File.Name.Replace(" ", "-");

        using(var ms = new MemoryStream())
        {
            await e.File.OpenReadStream(Int32.MaxValue).CopyToAsync(ms);
            await File.WriteAllBytesAsync(fullPath, ms.ToArray());
        }

        await OnSongChanged.InvokeAsync(Song);
    }

    async Task RemovedSong()
    {
        await OnSongRemoved.InvokeAsync(Song);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591