#pragma checksum "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "396b78e0974dede4edd971920fd5738386c0b570"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/albumAdd")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/albumAdd/{id:int}")]
    public partial class AlbumAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
 if (album == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                      album

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table");
                __builder2.OpenElement(6, "tr");
                __builder2.AddMarkupContent(7, "<td>Title</td>\r\n                ");
                __builder2.OpenElement(8, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "class", "form-control col-sm-5");
                __builder2.AddAttribute(11, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                                                                           album.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => album.Title = __value, album.Title))));
                __builder2.AddAttribute(13, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => album.Title));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "tr");
                __builder2.AddMarkupContent(16, "<td>Cover</td>\r\n                ");
                __builder2.OpenElement(17, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(18);
                __builder2.AddAttribute(19, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 20 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                                         LoadAlbumCover

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenElement(21, "tr");
                __builder2.AddMarkupContent(22, "<td>Description</td>\r\n                ");
                __builder2.OpenElement(23, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control col-sm-5");
                __builder2.AddAttribute(26, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                                                                           album.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => album.Description = __value, album.Description))));
                __builder2.AddAttribute(28, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => album.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "tr");
                __builder2.AddMarkupContent(31, "<td>Release Date</td>\r\n                ");
                __builder2.OpenElement(32, "td");
                __Blazor.BlazorMusicCatalog.Pages.AlbumAdd.TypeInference.CreateInputDate_0(__builder2, 33, 34, "form-control col-sm-5", 35, 
#nullable restore
#line 28 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                                                                           album.ReleaseDate

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => album.ReleaseDate = __value, album.ReleaseDate)), 37, () => album.ReleaseDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenElement(39, "tr");
                __builder2.AddMarkupContent(40, "<td>Author</td>\r\n                ");
                __builder2.OpenElement(41, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "class", "form-control col-sm-5");
                __builder2.AddAttribute(44, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                                                                           album.Author

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => album.Author = __value, album.Author))));
                __builder2.AddAttribute(46, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => album.Author));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.OpenElement(48, "h3");
                __builder2.AddContent(49, "Songs  ");
                __builder2.OpenElement(50, "button");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                                     AddSong

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(52, "+");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 36 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
         foreach (var song in album.Songs)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<BlazorMusicCatalog.Pages.SongBlock>(53);
                __builder2.AddAttribute(54, "Song", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMusicCatalog.Models.Song>(
#nullable restore
#line 38 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                             song

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "OnSongChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMusicCatalog.Models.Song>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMusicCatalog.Models.Song>(this, 
#nullable restore
#line 38 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                                                  UpdateAddedSong

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(56, "OnSongRemoved", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMusicCatalog.Models.Song>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMusicCatalog.Models.Song>(this, 
#nullable restore
#line 39 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                                      RemoveSong

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 40 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(57, "table");
                __builder2.OpenElement(58, "tr");
                __builder2.OpenElement(59, "td");
                __builder2.AddAttribute(60, "colspan", "2");
                __builder2.AddAttribute(61, "style", "text-align:center");
                __builder2.OpenElement(62, "input");
                __builder2.AddAttribute(63, "type", "submit");
                __builder2.AddAttribute(64, "class", "btn btn-success");
                __builder2.AddAttribute(65, "value", "Save");
                __builder2.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                                                                                        AlbumSave

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.OpenElement(68, "td");
                __builder2.AddAttribute(69, "colspan", "2");
                __builder2.AddAttribute(70, "style", "text-align:center");
                __builder2.OpenElement(71, "input");
                __builder2.AddAttribute(72, "type", "button");
                __builder2.AddAttribute(73, "class", "btn btn-secondary");
                __builder2.AddAttribute(74, "value", "Cancel");
                __builder2.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                                                                                            Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 50 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                 if (id > 0)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(76, "td");
                __builder2.AddAttribute(77, "colspan", "2");
                __builder2.AddAttribute(78, "style", "text-align:center");
                __builder2.OpenElement(79, "input");
                __builder2.AddAttribute(80, "type", "button");
                __builder2.AddAttribute(81, "class", "btn btn-danger");
                __builder2.AddAttribute(82, "value", "Delete");
                __builder2.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                                                                                             DeleteAlbum

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 55 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 59 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Development\Training\Back\BlazorMusicCatalog\BlazorMusicCatalog\Pages\AlbumAdd.razor"
       

    [Parameter]
    public int id { get; set; }

    //public Album album = new Album() { ReleaseDate = DateTime.Now, Songs = new List<Song>() };
    public Album album;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            if (id > 0)
            {
                album = await AlbumService.GetAlbumDetails(id);
            }
            else
            {
                album = new Album() { ReleaseDate = DateTime.Now, Songs = new List<Song>() };
                album.Songs.Add(new Song() { Number = album.Songs.Count + 1 });
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected void AddSong()
    {
        album.Songs.Add(new Song() { Number = album.Songs.Count + 1 });
    }

    protected async Task DeleteAlbum()
    {
        await AlbumService.DeleteAlbum(album);
        NavigateToHome();
    }

    protected async void UpdateAddedSong(Song song)
    {
        var songToUpdate = album.Songs.FirstOrDefault(s => s.Number == song.Number);
        if (songToUpdate != null)
        {
            songToUpdate.Extension = song.Extension;
            songToUpdate.Name = song.Name;
            songToUpdate.Path = song.Path;
        }
    }

    protected void RemoveSong(Song song)
    {
        var songToRemove = album.Songs.FirstOrDefault(s => s.Number == song.Number);
        album.Songs.Remove(songToRemove);
    }

    protected async Task LoadAlbumCover(InputFileChangeEventArgs e)
    {
        var format = "image/png";
        var resizedFile = await e.File.RequestImageFileAsync(format, 200, 200);
        var buffer = new byte[resizedFile.Size];

        await resizedFile.OpenReadStream().ReadAsync(buffer);
        album.CoverImage = buffer;
    }

    protected async Task AlbumSave()
    {
        //var a = album.Songs;
        if(id > 0)
            await AlbumService.UpdateAlbum(album);
        else
            await AlbumService.InsertAlbum(album);
        NavigateToHome();
    }

    protected void Cancel()
    {
        NavigateToHome();
    }

    protected void NavigateToHome()
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlbumService AlbumService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.BlazorMusicCatalog.Pages.AlbumAdd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591