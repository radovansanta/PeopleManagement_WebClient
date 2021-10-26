// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using DNP_Assignment1.Persistence;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adults")]
    public partial class AdultsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Pages/AdultsPage.razor"
      
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext _fileContext { get; set; }
    }
}
#pragma warning restore 1591
