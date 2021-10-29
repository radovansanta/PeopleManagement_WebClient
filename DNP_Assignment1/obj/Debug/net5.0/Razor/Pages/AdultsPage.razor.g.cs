#pragma checksum "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d67304d21585043f25d3cbe9a4a185ad8f7a1cc6"
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
#line 1 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/_Imports.razor"
using DNP_Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/_Imports.razor"
using DNP_Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
using DNP_Assignment1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
using DNP_Assignment1.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
using DNP_Assignment1.Data.Services.AdultServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adults")]
    public partial class AdultsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(1, "\n\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "content px-4");
            __builder.AddMarkupContent(4, "<h1>All Adults</h1>");
#nullable restore
#line 32 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
     if (allAdults == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Loading...</em></p>");
#nullable restore
#line 37 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
    }
    else if (!allAdults.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>No ToDo items exist. Please add some.</em></p>");
#nullable restore
#line 43 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
     if (allAdults != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-columns");
#nullable restore
#line 47 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
             foreach (var adult in allAdults)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<DNP_Assignment1.Components.AdultContainer>(9);
            __builder.AddAttribute(10, "adult", 
#nullable restore
#line 49 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
                                       adult

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
#nullable restore
#line 50 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 52 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
      
    /*
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
    */

    private IList<Adult> allAdults;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            allAdults = await _adultService.GetAdultsAsync();
        }
        catch (Exception e)
        {
    // update some error label here, or show popup..
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService _adultService { get; set; }
    }
}
#pragma warning restore 1591
