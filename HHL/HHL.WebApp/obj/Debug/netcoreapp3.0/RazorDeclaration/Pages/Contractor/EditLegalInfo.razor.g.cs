// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HHL.WebApp.Pages.Contractor
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
#line 35 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Models.Contractor;

#line default
#line hidden
#line 36 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using Stripe;

#line default
#line hidden
#line 37 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\_Imports.razor"
using HHL.Core.Helpers;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/contractor/edit-legal-info")]
    public partial class EditLegalInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 225 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\Pages\Contractor\EditLegalInfo.razor"
            

    EditContractorLegalInfoFormModel EditContractorLegalInfoFormModel { get; set; } = new EditContractorLegalInfoFormModel();
    IEnumerable<CountryCodeSelectModel> CountryCodeSelectModels = Enumerable.Empty<CountryCodeSelectModel>();
    IEnumerable<CountrySelectModel> CountrySelectModels { get; set; } = Enumerable.Empty<CountrySelectModel>();
    IEnumerable<RegionSelectModel> RegionSelectModels { get; set; } = Enumerable.Empty<RegionSelectModel>();
    IEnumerable<CitySelectModel> CitySelectModels { get; set; } = Enumerable.Empty<CitySelectModel>();



    protected override async Task OnInitializedAsync()
    {

        CountryCodeSelectModels = _mapper.Map<IEnumerable<e_Country>, IEnumerable<CountryCodeSelectModel>>(InstantDatahandler.All_Countries).OrderBy(q => q.Name != "United States");
        CountrySelectModels = _mapper.Map<IEnumerable<e_Country>, IEnumerable<CountrySelectModel>>(InstantDatahandler.All_Countries).OrderBy(q => q.Name != "United States");
        var r = await ContractorSvc.SelectCurrent_EditView();
        EditContractorLegalInfoFormModel = _mapper.Map<EditContractorLegalInfoFormModel>(r);
        CountrySelectModels = _mapper.Map<IEnumerable<e_Country>, IEnumerable<CountrySelectModel>>(InstantDatahandler.All_Countries).OrderBy(q => q.Name != "United States");
        if (EditContractorLegalInfoFormModel.PrimaryAddressCountryId != null)
        {
            RegionSelectModels = _mapper.Map<IEnumerable<e_Region>, IEnumerable<RegionSelectModel>>(InstantDatahandler.All_Regions.Where(q => q.CountryId == EditContractorLegalInfoFormModel.PrimaryAddressCountryId)).OrderBy(q => q.Name);
            if (EditContractorLegalInfoFormModel.PrimaryAddressRegionId != null)
            {
                CitySelectModels = _mapper.Map<IEnumerable<e_City>, IEnumerable<CitySelectModel>>(InstantDatahandler.All_Cities.Where(q => q.RegionId == EditContractorLegalInfoFormModel.PrimaryAddressRegionId)).OrderBy(q => q.Name);
            }
        }

    }

    async void HandleEditContractorLegalInfoFormModelSubmit()
    {

    }


    async void HandleCustomCountryChange(UIChangeEventArgs __e)
    {
        EditContractorLegalInfoFormModel.PrimaryAddressCountryId = !string.IsNullOrWhiteSpace(__e.Value.ToString()) ? new Guid(__e.Value.ToString()) : (Guid?)default;

        if (EditContractorLegalInfoFormModel?.PrimaryAddressCountryId != null)
        {
            RegionSelectModels = _mapper.Map<IEnumerable<e_Region>, IEnumerable<RegionSelectModel>>(InstantDatahandler.All_Regions.Where(q => q.CountryId == EditContractorLegalInfoFormModel.PrimaryAddressCountryId)).OrderBy(q => q.Name);
            EditContractorLegalInfoFormModel.PrimaryAddressCityId = null;
        }
        else
        {
            EditContractorLegalInfoFormModel.PrimaryAddressRegionId = null;
            EditContractorLegalInfoFormModel.PrimaryAddressCityId = null;
        }

        StateHasChanged();
    }

    async void HandleCustomRegionChange(UIChangeEventArgs __e)
    {
        EditContractorLegalInfoFormModel.PrimaryAddressRegionId = !string.IsNullOrWhiteSpace(__e.Value.ToString()) ? new Guid(__e.Value.ToString()) : (Guid?)default;

        if (EditContractorLegalInfoFormModel?.PrimaryAddressRegionId != null)
        {
            CitySelectModels = _mapper.Map<IEnumerable<e_City>, IEnumerable<CitySelectModel>>(InstantDatahandler.All_Cities.Where(q => q.RegionId == EditContractorLegalInfoFormModel.PrimaryAddressRegionId)).OrderBy(q => q.Name);
        }
        else
        {
            EditContractorLegalInfoFormModel.PrimaryAddressCityId = null;
        }

        StateHasChanged();
    }

    //IEnumerable<ErrorMdl> Errors;

    //[Parameter]
    //private bool isLoading { get; set; } = false;


    //void HandleEditContractorLegalInfoFormModelSubmit()
    //{
    //    isLoading = true;
    //}


    //protected override async Task OnAfterRenderAsync()
    //{
    //    if (isLoading)
    //    {

    //        //await UpdateContractorInfo();
    //    }
    //}




    //async Task UpdateContractorInfo()
    //{

    //    var r = e_Contractor;

    //    r.Id = (Guid)EditContractorLegalInfoFormModel.Id;
    //    await r.UPDATEAsync(
    //        new string[] { nameof(e_Contractor.FirstName), nameof(e_Contractor.LastName), nameof(e_Contractor.OrganizationName), nameof(e_Contractor.OrganizationIdentity), nameof(e_Contractor.PrimaryLanguageId), nameof(e_Contractor.SecondaryLanguageId), nameof(e_Contractor.DateOfBirth), nameof(e_Contractor.SIN) },
    //        new object[] { EditContractorLegalInfoFormModel.FirstName, EditContractorLegalInfoFormModel.LastName, EditContractorLegalInfoFormModel.OrganizationName, EditContractorLegalInfoFormModel.OrganizationIdentity, EditContractorLegalInfoFormModel.PrimaryLanguageId, EditContractorLegalInfoFormModel.SecondaryLanguageId, EditContractorLegalInfoFormModel.DateOfBirth, EditContractorLegalInfoFormModel.SIN });



    //    var e1 = new e_Email();

    //    if (EditContractorLegalInfoFormModel.PrimaryEmailId != null)
    //    {
    //        e1.Id = (Guid)EditContractorLegalInfoFormModel.PrimaryEmailId;
    //        await e1.UPDATEAsync(new string[] { nameof(e_Email.Name) }, new object[] { EditContractorLegalInfoFormModel.PrimaryEmailName });
    //    }
    //    else
    //    {

    //        e1.Name = EditContractorLegalInfoFormModel.PrimaryEmailName;

    //        var response = await e1.INSERTAsync();
    //        if (response.Success)
    //        {
    //            var EmailId = response.Results.First().Id;
    //            var d = await e_Contractor.UPDATEAsync(nameof(e_Contractor.PrimaryEmailId), EmailId, QuerySvc.SetAccountIdQueryFilter(AuthSessionSvc.AccountSession.AccountId));
    //            EditContractorLegalInfoFormModel.PrimaryEmailId = EmailId;
    //        }
    //    }



    //    var e2 = new e_Email();

    //    if (EditContractorLegalInfoFormModel.SecondaryEmailId != null)
    //    {
    //        e2.Id = (Guid)EditContractorLegalInfoFormModel.SecondaryEmailId;
    //        await e2.UPDATEAsync(new string[] { nameof(e_Email.Name) }, new object[] { EditContractorLegalInfoFormModel.SecondaryEmailName });
    //    }
    //    else
    //    {

    //        e2.Name = EditContractorLegalInfoFormModel.SecondaryEmailName;

    //        var response = await e2.INSERTAsync();
    //        if (response.Success)
    //        {
    //            var EmailId = response.Results.First().Id;
    //            var d = await e_Contractor.UPDATEAsync(nameof(e_Contractor.SecondaryEmailId), EmailId, QuerySvc.SetAccountIdQueryFilter(AuthSessionSvc.AccountSession.Account