#pragma checksum "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad1273d1f11cd5d0b4141fa0f0f5c76d2f2ef9f3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Movies
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/create")]
    public partial class CreateMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateMovie</h3>\n\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 6 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
                                          SaveMovie

#line default
#line hidden
            ));
            __builder.AddContent(4, "Save Movie");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 8 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
       
    private void SaveMovie()
    {
        // Saving movie...
        Console.WriteLine(navigationManager.Uri);
        navigationManager.NavigateTo("movie");

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
