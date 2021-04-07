#pragma checksum "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Genres\CreateGenre.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad8d218250eb0983f9b152bef97dc7f713d4115"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Genres
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/genre/create")]
    public partial class CreateGenre : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateGenre</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 5 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Genres\CreateGenre.razor"
                  genre

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 5 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Genres\CreateGenre.razor"
                                   Create

#line default
#line hidden
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "\n        ");
                __builder2.AddMarkupContent(9, "<label>Name:</label>\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddMarkupContent(11, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 10 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Genres\CreateGenre.razor"
                                                             genre.Name

#line default
#line hidden
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => genre.Name = __value, genre.Name))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => genre.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n    ");
                __builder2.AddMarkupContent(20, "<button class=\"btn btn-success\" type=\"submit\">Save Changes</button>\n\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 18 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Pages\Genres\CreateGenre.razor"
       

    private Genre genre = new Genre();

    private void Create()
    {
        Console.WriteLine(genre.Name);
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
