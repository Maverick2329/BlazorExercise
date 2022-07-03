#pragma checksum "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b422eb12ddad8772fcb0e4f3593fb6e6d443924"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.FurnitureStore.Client.Pages
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
#line 3 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 15 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

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
#line 9 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderDetails")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderDetails/{id:int}")]
    public partial class OrderDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
#nullable restore
#line 13 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
__builder.AddContent(1, Message);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
 if(clients != null && Order != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                  Order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                        SaveOrder

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "card");
                __builder2.AddMarkupContent(8, "<h5 class=\"card-header\">Order Details</h5>\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "card-body");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "container");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row");
                __builder2.AddMarkupContent(15, "<div class=\"col-md-4 mb-3\"></div>\r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-md-4 mb-3");
                __builder2.AddMarkupContent(18, "<input type=\"submit\" class=\"btn btn-success\" value=\"Save\">\r\n                        ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "type", "button");
                __builder2.AddAttribute(21, "class", "btn btn-secondary");
                __builder2.AddAttribute(22, "value", "Cancel");
                __builder2.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                                                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                    <div class=\"col-md-4 mb-3\"></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "row");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(30, "<label for>Number</label>\r\n                        ");
                __Blazor.Blazor.FurnitureStore.Client.Pages.OrderDetails.TypeInference.CreateInputNumber_0(__builder2, 31, 32, "form-control", 33, 
#nullable restore
#line 36 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                                                        Order.OrderNumber

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Order.OrderNumber = __value, Order.OrderNumber)), 35, () => Order.OrderNumber);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(39, "<label for>Order Date</label>\r\n                        ");
                __Blazor.Blazor.FurnitureStore.Client.Pages.OrderDetails.TypeInference.CreateInputDate_1(__builder2, 40, 41, "form-control", 42, 
#nullable restore
#line 40 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                                                      Order.OrderDate

#line default
#line hidden
#nullable disable
                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Order.OrderDate = __value, Order.OrderDate)), 44, () => Order.OrderDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "row");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-md-12 mb-3");
                __builder2.AddMarkupContent(50, "<label for>Client</label>\r\n                        ");
                __Blazor.Blazor.FurnitureStore.Client.Pages.OrderDetails.TypeInference.CreateInputSelect_2(__builder2, 51, 52, "form-control", 53, 
#nullable restore
#line 46 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                                                        Order.ClientId

#line default
#line hidden
#nullable disable
                , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Order.ClientId = __value, Order.ClientId)), 55, () => Order.ClientId, 56, (__builder3) => {
#nullable restore
#line 47 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                             foreach (var item in clients)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(57, "option");
                    __builder3.AddAttribute(58, "value", 
#nullable restore
#line 49 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                                item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 49 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
__builder3.AddContent(59, item.LastName + ", " + item.FirstName );

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 50 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "row");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(65, "<label for>Delivery Date</label>\r\n                        ");
                __Blazor.Blazor.FurnitureStore.Client.Pages.OrderDetails.TypeInference.CreateInputDate_3(__builder2, 66, 67, "form-control", 68, 
#nullable restore
#line 57 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                                                      Order.DeliveryDate

#line default
#line hidden
#nullable disable
                , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Order.DeliveryDate = __value, Order.DeliveryDate)), 70, () => Order.DeliveryDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(74, "<label for>Total</label>\r\n                        ");
                __builder2.OpenElement(75, "input");
                __builder2.AddAttribute(76, "type", "text");
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "readonly", "readonly");
                __builder2.AddAttribute(79, "value", 
#nullable restore
#line 62 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                                                                            Order.Total.ToString("C")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "row");
                __builder2.AddMarkupContent(83, "<div class=\"col-md-4 mb-3\"></div>\r\n                    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "col-md-4 mb-3");
                __builder2.OpenElement(86, "input");
                __builder2.AddAttribute(87, "type", "button");
                __builder2.AddAttribute(88, "class", "btn btn-secondary");
                __builder2.AddAttribute(89, "value", "Add Product");
                __builder2.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                                                                                     AddProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                    <div class=\"col-md-4 mb-3\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 80 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
     if(Order.Products != null && Order.Products.Any())
    {

#line default
#line hidden
#nullable disable
                __Blazor.Blazor.FurnitureStore.Client.Pages.OrderDetails.TypeInference.CreateMudTable_4(__builder2, 92, 93, 
#nullable restore
#line 82 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                          Order.Products

#line default
#line hidden
#nullable disable
                , 94, 
#nullable restore
#line 82 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                                 true

#line default
#line hidden
#nullable disable
                , 95, 
#nullable restore
#line 82 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                                                   Breakpoint.Sm

#line default
#line hidden
#nullable disable
                , 96, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(97);
                    __builder3.AddAttribute(98, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 84 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(100, "Products");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 101, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTh>(102);
                    __builder3.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(104, "Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(106);
                    __builder3.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(108, "Price");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(109, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(110);
                    __builder3.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(112, "Quantity");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(113, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(114);
                    __builder3.CloseComponent();
                }
                , 115, (ProductContext) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTd>(116);
                    __builder3.AddAttribute(117, "DataLabel", "Name");
                    __builder3.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 93 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
__builder4.AddContent(119, ProductContext.Name);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(121);
                    __builder3.AddAttribute(122, "DataLabel", "Price");
                    __builder3.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 94 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
__builder4.AddContent(124, ProductContext.Price);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(125, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(126);
                    __builder3.AddAttribute(127, "DataLabel", "Quantity");
                    __builder3.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 95 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
__builder4.AddContent(129, ProductContext.Quantity);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(130, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(131);
                    __builder3.AddAttribute(132, "DataLabel", "");
                    __builder3.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudFab>(134);
                        __builder4.AddAttribute(135, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                       () => RemoveProduct(ProductContext.Id)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(136, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 98 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                   Color.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(137, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 99 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                   Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(138, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 100 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                  Size.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(139, "IconSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 101 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
                                      Size.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                );
#nullable restore
#line 105 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 108 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(140, "<p>Loading...</p>");
#nullable restore
#line 112 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Development\Training\Back\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\OrderDetails.razor"
       

    public Order Order;
    public IEnumerable<Client> clients;
    public string Message { get; set; }

    [Parameter] public int id { get; set; }

    protected async override Task OnInitializedAsync()
    {
        try
        {

            if(id > 0)
            {
                Order = await OrderService.GetDetails(id);
            }
            else
            {
                Order = new Order()
                {
                    OrderNumber = await OrderService.GetNextNumber(),
                    ProductCategoryId = 1,
                    OrderDate = DateTime.Today,
                    DeliveryDate = DateTime.Today.AddDays(7)
                };
            }
            clients = await ClientService.GetAll();
        }
        catch (Exception e)
        {

            Message = "There was a error..." + e.Message;
        }
    }



    protected async Task SaveOrder()
    {
        await OrderService.SaveOrder(Order);
        NavigationHome();
    }

    private void NavigationHome()
    {
        NavigationManager.NavigateTo("/");
    }

    protected void Cancel()
    {
        NavigationHome();
    }

    protected async Task AddProduct()
    {
        var dialog = DialogService.Show<ProductDetails>("Product Details");
        var result = await dialog.Result;
        if (!result.Cancelled)
        {
            var product = (Product)result.Data;
            if (Order.Products == null)
                Order.Products = new List<Product>();

            Order.Products.Add(product);
        }
    }

    protected async Task RemoveProduct(int productId)
    {
        Order.Products.RemoveAll(p => p.Id == productId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService OrderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientService ClientService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductCategoryService ProductCategoryService { get; set; }
    }
}
namespace __Blazor.Blazor.FurnitureStore.Client.Pages.OrderDetails
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTable_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "ToolBarContent", __arg3);
        __builder.AddAttribute(__seq4, "HeaderContent", __arg4);
        __builder.AddAttribute(__seq5, "RowTemplate", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591