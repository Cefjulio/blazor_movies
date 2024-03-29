#pragma checksum "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5a7b6e81a7a07b34c3aa3cf70ee052e84beed19"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
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
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
 if (List == null)
{
    

#line default
#line hidden
#line 5 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
     if (NullTemplate != null)
    {
        

#line default
#line hidden
            __builder.AddContent(0, 
#line 7 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
         NullTemplate

#line default
#line hidden
            );
#line 7 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
                     
    }
    else
    {
        // Default Content

#line default
#line hidden
            __builder.AddMarkupContent(1, "        <img src=\"https://media.giphy.com/media/3oEjI6SIIHBdRxXI40/giphy.gif\">\n");
#line 13 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
    }

#line default
#line hidden
#line 13 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
     
}
else if (List.Count == 0)
{
    

#line default
#line hidden
#line 17 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
     if (EmptyTemplate != null)
    {
        

#line default
#line hidden
            __builder.AddContent(2, 
#line 19 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
         EmptyTemplate

#line default
#line hidden
            );
#line 19 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
                      
    }
    else
    {
        // Default Content
        

#line default
#line hidden
            __builder.AddContent(3, "There are no records to show");
#line 24 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
                                                 
    }

#line default
#line hidden
#line 25 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
     
}
else
{
    

#line default
#line hidden
#line 29 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
     foreach (var element in List)
    {

        

#line default
#line hidden
            __builder.AddContent(4, 
#line 32 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
         ElementTemplate(element)

#line default
#line hidden
            );
#line 32 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
                                 
    }

#line default
#line hidden
#line 33 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
     
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 36 "C:\Users\auyon.j6356\source\repos\Blazor_Movies\BlazorMovies\Client\Shared\GenericList.razor"
       
    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }
    [Parameter] public RenderFragment<TItem> ElementTemplate { get; set; }
    [Parameter] public List<TItem> List { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
