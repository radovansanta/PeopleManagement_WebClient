#pragma checksum "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "556b1dec15b2c200480e3f5f516806a1cf02efca"
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
#line 1 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
using DNP_Assignment1.Persistence;

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
            __builder.OpenElement(5, "h5");
            __builder.AddAttribute(6, "class", "card-title");
            __builder.AddContent(7, 
#nullable restore
#line 7 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                    Adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, " ");
            __builder.AddContent(9, 
#nullable restore
#line 7 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                                     Adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddAttribute(15, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(16, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/ID.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "card-text");
            __builder.AddContent(19, 
#nullable restore
#line 11 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row");
            __builder.AddAttribute(23, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(24, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Sex.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(25, "p");
            __builder.AddAttribute(26, "class", "card-text");
            __builder.AddContent(27, 
#nullable restore
#line 15 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.AddAttribute(33, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(34, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Job.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(35, "p");
            __builder.AddAttribute(36, "class", "card-text");
            __builder.AddContent(37, 
#nullable restore
#line 21 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "row");
            __builder.AddAttribute(41, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(42, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Income.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(43, "p");
            __builder.AddAttribute(44, "class", "card-text");
            __builder.AddContent(45, 
#nullable restore
#line 25 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row");
            __builder.AddAttribute(51, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(52, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Eye.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(53, "p");
            __builder.AddAttribute(54, "class", "card-text");
            __builder.AddContent(55, 
#nullable restore
#line 31 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "row");
            __builder.AddAttribute(59, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(60, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Hair.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(61, "p");
            __builder.AddAttribute(62, "class", "card-text");
            __builder.AddContent(63, 
#nullable restore
#line 35 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n            ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "row");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "row");
            __builder.AddAttribute(69, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(70, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Age.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(71, "p");
            __builder.AddAttribute(72, "class", "card-text");
            __builder.AddContent(73, 
#nullable restore
#line 42 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n                ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "row");
            __builder.AddAttribute(77, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(78, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Weight.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(79, "p");
            __builder.AddAttribute(80, "class", "card-text");
            __builder.AddContent(81, 
#nullable restore
#line 46 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n                ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "row");
            __builder.AddAttribute(85, "style", "margin-left: 20px; margin-right: 20px");
            __builder.AddMarkupContent(86, "<img style=\"max-width: 20px; max-height: 20px; margin-right: 10px\" src=\"https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/Height.png\" alt=\"...\">\n                    ");
            __builder.OpenElement(87, "p");
            __builder.AddAttribute(88, "class", "card-text");
            __builder.AddContent(89, 
#nullable restore
#line 50 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                          Adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n            ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "row");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "row");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
                                      HandleDelete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "style", "margin-left: 30px; margin-right: 10px; margin-top: 10px");
            __builder.AddAttribute(98, "type", "button");
            __builder.AddAttribute(99, "class", "btn btn-danger btn-sm");
            __builder.AddContent(100, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\n                    ");
            __builder.AddMarkupContent(102, "<button style=\"margin-top: 10px\" type=\"button\" class=\"btn btn-warning btn-sm\">Edit</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/Users/radovansanta/RiderProjects/DNP_Assignment1/DNP_Assignment1/Components/AdultContainer.razor"
       
    [Parameter]  
    public Adult Adult { get; set; }
    
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    
    private void HandleDelete()
    {
        _fileContext.DeleteAdult(Adult);
        NavigationManager.NavigateTo("/");

    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext _fileContext { get; set; }
    }
}
#pragma warning restore 1591
