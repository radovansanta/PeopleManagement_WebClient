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
using DNP_Assignment1.Persistence;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Pages/Index.razor"
      
    public Adult _adult = new()
    {
        Id = 293346,
        Age = 21,
        Height = 180,
        Sex = "M",
        Weight = 73,
        EyeColor = "brown",
        FirstName = "Radovan",
        HairColor = "brown",
        LastName = "Santa", JobTitle = new Job()
        {
            JobTitle = "Student",
            Salary = 15000
        }
    };

    protected override void OnInitialized()
    {

    }


    private void AddButton()
    {
        _fileContext.Adults.Insert(_fileContext.Adults.Count,_adult);
        _fileContext.SaveChanges();
        Console.Out.WriteLine(_fileContext.Adults.Count);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext _fileContext { get; set; }
    }
}
#pragma warning restore 1591
