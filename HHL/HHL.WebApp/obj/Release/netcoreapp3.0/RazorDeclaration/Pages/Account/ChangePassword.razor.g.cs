// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HHL.WebApp.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#line 1 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Components.Shared;

#line default
#line hidden
#line 7 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Auth.Core.Services;

#line default
#line hidden
#line 8 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Auth.Core;

#line default
#line hidden
#line 9 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Auth.Core.Models;

#line default
#line hidden
#line 10 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Auth.Core.Handlers;

#line default
#line hidden
#line 11 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Common;

#line default
#line hidden
#line 12 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Models;

#line default
#line hidden
#line 13 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Models.Client;

#line default
#line hidden
#line 14 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp;

#line default
#line hidden
#line 15 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Pages;

#line default
#line hidden
#line 16 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Models;

#line default
#line hidden
#line 17 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Services;

#line default
#line hidden
#line 18 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.DataAccess.Views;

#line default
#line hidden
#line 19 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.DataAccess.Entities;

#line default
#line hidden
#line 20 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using AutoMapper;

#line default
#line hidden
#line 21 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Handlers;

#line default
#line hidden
#line 22 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Services;

#line default
#line hidden
#line 23 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using MoreLinq;

#line default
#line hidden
#line 24 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.FileReader;

#line default
#line hidden
#line 25 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Handlers;

#line default
#line hidden
#line 26 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.DataAccess;

#line default
#line hidden
#line 27 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Shared;

#line default
#line hidden
#line 28 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Shared.Client;

#line default
#line hidden
#line 29 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Shared.Contractor;

#line default
#line hidden
#line 30 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Shared.Wizard;

#line default
#line hidden
#line 31 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Shared.Table;

#line default
#line hidden
#line 32 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Interfaces;

#line default
#line hidden
#line 33 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Models.Address;

#line default
#line hidden
#line 34 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#line 35 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Models.Contractor;

#line default
#line hidden
#line 36 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using Stripe;

#line default
#line hidden
#line 37 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Helpers;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/security/changepassword")]
    public partial class ChangePassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 95 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\Pages\Account\ChangePassword.razor"
            


    ChangePasswordModel ChangePasswordModel = new ChangePasswordModel();

    IEnumerable<ErrorMdl> Errors;

    [Parameter]
    private bool isLoading { get; set; } = false;


    void HandleChangePasswordModelSubmit()
    {

    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
