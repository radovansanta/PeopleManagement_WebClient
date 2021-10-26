// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNP_Assignment1.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 1 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultForm.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultForm.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultForm.razor"
using DNP_Assignment1.Data.Services;

#line default
#line hidden
#nullable disable
    public partial class AdultForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "/Users/radovansanta/RiderProjects/PeopleManagement_WebClient/DNP_Assignment1/Components/AdultForm.razor"
       
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    

    string error = "";
    
    string _profileDefault = "profileDefault";
    string _profileMale = "profileMale";
    string _profileFemale = "profileFemale";
    string _profileUrl = "ownUrl";

    private string ProfilePicture { get; set; } = "profileDefault";
    string _ownUrl = "";


    private Adult _adult = new()
    {
        Id = 0,
        Age = 0,
        Height = 0,
        Sex = null,
        Weight = 0,
        EyeColor = null,
        FirstName = null,
        HairColor = null,
        LastName = null, JobTitle = new Job()
        {
            JobTitle = null,
            Salary = 0
        }
    };

    private void HandleValidSubmit()
    {
        if (_adult.Id==0 ||
            _adult.FirstName==null ||
            _adult.LastName==null ||
            _adult.HairColor==null ||
            _adult.EyeColor==null ||
            _adult.Age ==0 ||
            _adult.Weight ==0 ||
            _adult.Height==0 ||
            _adult.Sex==null ||
            _adult.JobTitle.Salary==0 ||
            _adult.JobTitle.JobTitle==null)
        {
            error = "Missing inputs";
            
        }
        else
        {
            if (ProfilePicture.Equals("profileDefault"))
                {
                    _adult.ProfileUrl = "https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/ProfileDefault.png";
                }
                else if (ProfilePicture.Equals("profileMale"))
                {
                    _adult.ProfileUrl = "https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/ProfileMale.png";
                }
                else if (ProfilePicture.Equals("profileFemale"))
                {
                    _adult.ProfileUrl = "https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/ProfileFemale.png";
                }
                else if (ProfilePicture.Equals("ownUrl"))
                {
                    if (_ownUrl == "")
                    {
                        _adult.ProfileUrl = "https://raw.githubusercontent.com/radovansanta/DNP_Assignment1/master/DNP_Assignment1/Images/ProfileDefault.png";
                    }
                    else _adult.ProfileUrl = _ownUrl;

                }

                
                _adultService.AddAdultAsync(_adult);
                NavigationManager.NavigateTo("adults", forceLoad: false);
            }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService _adultService { get; set; }
    }
}
#pragma warning restore 1591
