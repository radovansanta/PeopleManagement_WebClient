#pragma checksum "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa8ae99c133b9d4de8e2980db786e020b5d8c1c4"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_Assignment1.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using DNP_Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/_Imports.razor"
using DNP_Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
using DNP_Assignment1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
using DNP_Assignment1.Persistence;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add_people")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(1, "\n\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "content px-4");
            __builder.AddMarkupContent(4, "<h1>All Adults</h1>\n    ");
            __builder.AddMarkupContent(5, "<h5><span style=\"color: white\" class=\"badge bg-secondary\">Search by:</span></h5>\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-sm");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "placeholder", "First name");
            __builder.AddAttribute(15, "value", 
#nullable restore
#line 16 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
                                                                              ValueFirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
                                                                                                        OnInputChangeFisrtName

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-sm");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "placeholder", "Last name");
            __builder.AddAttribute(23, "value", 
#nullable restore
#line 19 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
                                                                             ValueLastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
                                                                                                      OnInputChangeLastName

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-sm");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "placeholder", "ID");
            __builder.AddAttribute(31, "value", 
#nullable restore
#line 22 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
                                                                      ValueId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
                                                                                         OnInputChangeId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card-columns");
#nullable restore
#line 29 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
         foreach (var adult in _fileContext.SearchAdult(searchOption))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<DNP_Assignment1.Components.AdultContainer>(36);
            __builder.AddAttribute(37, "adult", 
#nullable restore
#line 31 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
                                   adult

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
#nullable restore
#line 32 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
      
    public string ValueFirstName { get; set; }

    public string ValueLastName { get; set; }

    public string ValueId { get; set; }

    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }
    
    string[] searchOption = {"",""};
    
    private async Task OnInputChangeFisrtName(ChangeEventArgs args )
    {
        ValueFirstName = (string)args.Value;
        searchOption[0] = "firstName";
        searchOption[1] = ValueFirstName;
        await ValueChanged.InvokeAsync(ValueFirstName);
    }
    private async Task OnInputChangeLastName(ChangeEventArgs args )
    {
        ValueLastName = (string)args.Value;
        searchOption[0] = "lastName";
        searchOption[1] = ValueLastName;
        await ValueChanged.InvokeAsync(ValueLastName);
    }
    private async Task OnInputChangeId(ChangeEventArgs args )
    {
        ValueId = (string)args.Value;
        searchOption[0] = "id";
        searchOption[1] = ValueId;
        await ValueChanged.InvokeAsync(ValueId);
    }
    
    private void Reload()
    {
        searchOption[0] = "";
        searchOption[1] = "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext _fileContext { get; set; }
    }
}
#pragma warning restore 1591
