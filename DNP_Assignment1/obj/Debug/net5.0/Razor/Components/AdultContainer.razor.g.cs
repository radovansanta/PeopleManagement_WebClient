#pragma checksum "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1214599f16da631980c60d54c70fa28b33c1217"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_Assignment1.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 1 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
using DNP_Assignment1.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
using DNP_Assignment1.Data.Services.AdultServices;

#line default
#line hidden
#nullable disable
    public partial class AdultContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin: 10px");
            __builder.AddAttribute(2, "class", "card");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddAttribute(7, "style", "margin-left: 3px; margin-bottom: 10px");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "style", "max-width: 60px; max-height: 60px;border-radius: 50%;");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 9 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                                                                         Adult.ProfileUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "alt", "...");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "h5");
            __builder.AddAttribute(14, "class", "card-title");
            __builder.AddAttribute(15, "style", "margin-left: 10px; margin-top: 20px");
            __builder.AddContent(16, 
#nullable restore
#line 10 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                                                                    Adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.AddContent(18, 
#nullable restore
#line 10 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                                                                                     Adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row");
            __builder.AddAttribute(24, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(25, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/ID.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "class", "card-text");
            __builder.AddContent(28, 
#nullable restore
#line 15 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.AddAttribute(32, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(33, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Sex.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(34, "p");
            __builder.AddAttribute(35, "class", "card-text");
            __builder.AddContent(36, 
#nullable restore
#line 19 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "row");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.AddAttribute(42, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(43, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Job.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(44, "p");
            __builder.AddAttribute(45, "class", "card-text");
            __builder.AddContent(46, 
#nullable restore
#line 25 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.AddAttribute(50, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(51, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Income.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(52, "p");
            __builder.AddAttribute(53, "class", "card-text");
            __builder.AddContent(54, 
#nullable restore
#line 29 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "row");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "row");
            __builder.AddAttribute(60, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(61, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Eye.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(62, "p");
            __builder.AddAttribute(63, "class", "card-text");
            __builder.AddContent(64, 
#nullable restore
#line 35 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n                ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "row");
            __builder.AddAttribute(68, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(69, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Hair.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(70, "p");
            __builder.AddAttribute(71, "class", "card-text");
            __builder.AddContent(72, 
#nullable restore
#line 39 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "row");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "row");
            __builder.AddAttribute(78, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(79, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Age.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(80, "p");
            __builder.AddAttribute(81, "class", "card-text");
            __builder.AddContent(82, 
#nullable restore
#line 46 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\n                ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "row");
            __builder.AddAttribute(86, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(87, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Weight.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(88, "p");
            __builder.AddAttribute(89, "class", "card-text");
            __builder.AddContent(90, 
#nullable restore
#line 50 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n                ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "row");
            __builder.AddAttribute(94, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(95, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Height.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(96, "p");
            __builder.AddAttribute(97, "class", "card-text");
            __builder.AddContent(98, 
#nullable restore
#line 54 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n            ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "row");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "row");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                        () => RemoveAdult(Adult.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "style", "margin-left: 30px; margin-right: 10px; margin-top: 10px");
            __builder.AddAttribute(107, "type", "button");
            __builder.AddAttribute(108, "class", "btn btn-danger btn-sm");
            __builder.AddContent(109, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\n                    ");
            __builder.OpenElement(111, "button");
            __builder.AddAttribute(112, "style", "margin-right: 10px; margin-top: 10px");
            __builder.AddAttribute(113, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
                                                                                                                   HandleEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(115, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultContainer.razor"
       
    [Parameter]  
    public Adult Adult { get; set; }
    
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    
    private void HandleEdit()
    {
        string url = "/editadult/"+Adult.Id;
        NavigationManager.NavigateTo(url);
    }
    
    private async Task RemoveAdult(int adultId)
    {
        try
        {
            await _adultService.RemoveAdultAsync(adultId);
            NavigationManager.NavigateTo("/", forceLoad: false);
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
