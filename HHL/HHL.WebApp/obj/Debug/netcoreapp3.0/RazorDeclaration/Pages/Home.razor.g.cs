// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HHL.WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#line 1 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Components.Shared;

#line default
#line hidden
#line 7 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Auth.Core.Services;

#line default
#line hidden
#line 8 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Auth.Core;

#line default
#line hidden
#line 9 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Auth.Core.Models;

#line default
#line hidden
#line 10 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Auth.Core.Handlers;

#line default
#line hidden
#line 11 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Common;

#line default
#line hidden
#line 12 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Models;

#line default
#line hidden
#line 13 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Models.Client;

#line default
#line hidden
#line 14 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp;

#line default
#line hidden
#line 15 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Pages;

#line default
#line hidden
#line 16 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Models;

#line default
#line hidden
#line 17 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Services;

#line default
#line hidden
#line 18 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.DataAccess.Views;

#line default
#line hidden
#line 19 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.DataAccess.Entities;

#line default
#line hidden
#line 20 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using AutoMapper;

#line default
#line hidden
#line 21 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Handlers;

#line default
#line hidden
#line 22 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Services;

#line default
#line hidden
#line 23 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using MoreLinq;

#line default
#line hidden
#line 24 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.FileReader;

#line default
#line hidden
#line 25 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Handlers;

#line default
#line hidden
#line 26 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.DataAccess;

#line default
#line hidden
#line 27 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Shared;

#line default
#line hidden
#line 28 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Shared.Client;

#line default
#line hidden
#line 29 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Shared.Contractor;

#line default
#line hidden
#line 30 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Shared.Wizard;

#line default
#line hidden
#line 31 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.WebApp.Shared.Table;

#line default
#line hidden
#line 32 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Interfaces;

#line default
#line hidden
#line 33 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Models.Address;

#line default
#line hidden
#line 34 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#line 35 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.r