#pragma checksum "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c64453c041ca882925d330946d6a21aecf989f82"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#line 7 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#line 9 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Current count: ");
            __builder.AddContent(2, 
#line 3 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 5 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
            ));
            __builder.AddContent(7, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "number");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 7 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Counter.razor"
                            currentCount

#line default
#line hidden
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentCount = __value, currentCount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
