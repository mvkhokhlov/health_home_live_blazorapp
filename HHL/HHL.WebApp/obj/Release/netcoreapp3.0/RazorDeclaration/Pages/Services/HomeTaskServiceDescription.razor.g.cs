// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HHL.WebApp.Pages.Services
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/home/{BuldingType}/task/{TaskType}/{TaskService}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/home/{BuldingType}/task/{TaskType}/{TaskService}/{HomeTaskId}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/home/{BuldingType}/task/{TaskType}/{TaskService}/project/{ProjectId}")]
    public partial class HomeTaskServiceDescription : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 380 "C:\Users\mikek\Source\Repos\HHL\HHL\HHL.WebApp\Pages\Services\HomeTaskServiceDescription.razor"
            

    [Parameter]
    private string BuldingType { get; set; }

    [Parameter]
    private string TaskType { get; set; }

    [Parameter]
    private string TaskService { get; set; }

    [Parameter]
    private string HomeTaskId { get; set; }

    [Parameter]
    private string ProjectId { get; set; }

    List<FormSettingModel> FormSettings = new List<FormSettingModel>();

    IEnumerable<ErrorMdl> Errors;

    [Parameter]
    private bool isLoading { get; set; } = false;

    [Parameter]
    Guid? AddressId { get; set; }

    e_Client ClientAccount { get; set; }

    e_HomeTaskCategory TaskCategory { get; set; }

    v_VmHomeTaskCategory TaskCategoryView { get; set; }

    AddNewHomeTaskModel AddNewHomeTaskModel = new AddNewHomeTaskModel();

    List<v_Address> ClientAddresses { get; set; } = new List<v_Address>();

    List<AddImageFileElementModel> TaskImages { get; set; } = new List<AddImageFileElementModel>();

    AddImageFileElementModel AddImageFileElementModel = new AddImageFileElementModel("newImage");

    IEnumerable<CountryCodeSelectModel> CountryCodeSelectModels { get; set; } = Enumerable.Empty<CountryCodeSelectModel>();

    IEnumerable<PrioritySelectModel> PrioritySelectModels { get; set; } = Enumerable.Empty<PrioritySelectModel>();


    TimeSpan HoursAndMin;

    e_Address ClientAddress;
    e_Phone ClientPrimaryPhoneNumber;
    e_Email ClientEmail;
    e_HomeTask SavedTask;
    e_Address SavedAddress;

    //FormSettings

    FormSettingModel BrandFS;
    FormSettingModel ModelFS;



    protected override async Task OnInitializedAsync()
    {

        if (!_HHLQueryExecutionSvc._AuthSessionSvc.IsAuthenticated)
        {

            UriHelper.NavigateTo("/signin", true);
        }




        var taskType = TaskType.FromUrl();
        var taskService = TaskService.FromUrl();
        var buldingType = String.Equals(BuldingType, "residential", StringComparison.OrdinalIgnoreCase) ? 1 : 2;


        var category = InstantDatahandler.All_VmHomeTaskCategories.First(
        q => q.HomeBuldingTypeId == buldingType &&
        q.IsActive &&
        string.Equals(q.HomeTaskTypeName, taskType, StringComparison.OrdinalIgnoreCase) &&
        string.Equals(q.HomeTaskServiceTypeName, taskService, StringComparison.OrdinalIgnoreCase));

        TaskCategory = InstantDatahandler.All_HomeTaskCategories.First(q => q.Id == category.Id);
        TaskCategoryView = InstantDatahandler.All_VmHomeTaskCategories.First(q => q.Id == category.Id);

        if (!string.IsNullOrEmpty(TaskCategory.FormSettings))
        {
            FormSettings = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FormSettingModel>>(TaskCategory.FormSettings);
        }

        var dtln = DateTime.Now;
        var tTaskDateStart = new DateTime(dtln.Year, dtln.Month, dtln.Day, dtln.Hour, 0, 0).AddHours(24);

        AddNewHomeTaskModel.PriceBase = HHLConfigHdr.PricePerHourSell;
        AddNewHomeTaskModel.PriceMultiplier = TaskCategory.PriceMultiplier;
        AddNewHomeTaskModel.PriceBaseFinal = AddNewHomeTaskModel.PriceBase * AddNewHomeTaskModel.PriceMultiplier;


        CountryCodeSelectModels = _mapper.Map<IEnumerable<e_Country>, IEnumerable<CountryCodeSelectModel>>(InstantDatahandler.All_Countries);
        PrioritySelectModels = _mapper.Map<IEnumerable<e_Priority>, IEnumerable<PrioritySelectModel>>(InstantDatahandler.All_Priorities);
        var ClientAccount = await ClientSvc.SelectCurrent();

        if (HomeTaskId != null)
        {

            SavedTask = _HHLQueryExecutionSvc.SELECTbyId<e_HomeTask>(new Guid(HomeTaskId)).FirstOrDefault;
            AddNewHomeTaskModel.Name = SavedTask.Name;
            AddNewHomeTaskModel.ClientId = SavedTask.ClientId;
            AddNewHomeTaskModel.HomeTaskCategoryId = SavedTask.HomeTaskCategoryId;
            AddNewHomeTaskModel.UseClientPrimaryContactInfo = SavedTask.UseClientPrimaryContactInfo;


            if (SavedTask.DateStart != null || SavedTask.DateStart < tTaskDateStart)
            {
                AddNewHomeTaskModel.DateStart = SavedTask.DateStart.Value;
            }
            else
            {
                AddNewHomeTaskModel.DateStart = tTaskDateStart;
            }

            AddNewHomeTaskModel.EstimatedHours = SavedTask.EstimatedHours;
            AddNewHomeTaskModel.AddressId = SavedTask.AddressId;
            AddNewHomeTaskModel.ContactEmail = SavedTask.ContactEmail;
            AddNewHomeTaskModel.ContactPhoneNumber = SavedTask.ContactPhoneNumber;
            AddNewHomeTaskModel.ContactCountryCodeId = SavedTask.ContactCountryCodeId;

            AddNewHomeTaskModel.Brand = SavedTask.Brand;
            AddNewHomeTaskModel.Model = SavedTask.Model;
            AddNewHomeTaskModel.ProjectId = SavedTask.HomeProjectId;
            AddNewHomeTaskModel.Description = SavedTask.Description;
            AddNewHomeTaskModel.TaskId = SavedTask.Id;


        }
        else
        {
            AddNewHomeTaskModel.Name = TaskCategory.Name;
            AddNewHomeTaskModel.ClientId = ClientAccount.Id;
            AddNewHomeTaskModel.HomeTaskCategoryId = TaskCategory.Id;
            AddNewHomeTaskModel.DateStart = tTaskDateStart;
            AddNewHomeTaskModel.EstimatedHours = TaskCategory.MinHours;
            AddNewHomeTaskModel.UseClientPrimaryAddress = true;
            AddNewHomeTaskModel.UseClientPrimaryContactInfo = true;
            AddNewHomeTaskModel.PriorityId = 3;

            if (!string.IsNullOrWhiteSpace(ProjectId))
            {
                AddNewHomeTaskModel.ProjectId = new Guid(ProjectId);
            }
        }

        HandleTotalPriceCalc();

        ClientAddresses = (await ClientSvc.SelectClientAddresses()).OrderByDescending(q => q.TypeId == 1).ToList();
        if (!ClientAddresses.IsNullOrEmpty())
        {
            AddNewHomeTaskModel.AddressId = ClientAddresses.First().Id;
        }

        //Address


        //HandlePrimaryAddress();


        //FormSetting

        BrandFS = FormSettings.FirstOrDefault(q => string.Equals(q.Type, "Brand", StringComparison.OrdinalIgnoreCase));
        ModelFS = FormSettings.FirstOrDefault(q => string.Equals(q.Type, "Model", StringComparison.OrdinalIgnoreCase));
    }

    async void HandleAddNewHomeTaskModelSubmit()
    {
        using (var ls = await new LoadingScreen(UiJsHandler).Load())
        {
            var r = await TaskSvc.AddOrUpdateNewTask(AddNewHomeTaskModel);
            if (r.HasValue)
            {
                UriHelper.NavigateTo($"{UrlNameHdr.ClientNewProjectOrders}/{r.Value}", forceLoad: true);
            }
        }

    }



    protected override async Task OnParametersSetAsync()
    {

    }

    void HandleTotalPriceCalc()
    {
        if (AddNewHomeTaskModel.EstimatedHours < TaskCategory.MinHours)
        {
            AddNewHomeTaskModel.EstimatedHours = TaskCategory.MinHours;
        }

        AddNewHomeTaskModel.PriceTotal = AddNewHomeTaskModel.PriceBaseFinal * AddNewHomeTaskModel.EstimatedHours;
        HoursAndMin = TimeSpan.FromHours(Convert.ToDouble(AddNewHomeTaskModel.EstimatedHours));
    }

    async void HandleEstimatePriceChangeChange(UIChangeEventArgs __e)
    {

        AddNewHomeTaskModel.EstimatedHours = !string.IsNullOrWhiteSpace(__e.Value.ToString()) ? Convert.ToDecimal(__e.Value.ToString()) : (decimal)0;

        HandleTotalPriceCalc();
        StateHasChanged();

    }

    async void HandleUseClientPrimaryContactInfoChange(UIChangeEventArgs __e)
    {
        AddNewHomeTaskModel.UseClientPrimaryContactInfo = !string.IsNullOrWhiteSpace(__e.Value.ToString()) ? Convert.ToBoolean(__e.Value.ToString()) : false;
        StateHasChanged();
    }

    async Task UploadImageFile(UIChangeEventArgs __e, AddImageFileElementModel model)
    {
        using (var ls = await new LoadingScreen(UiJsHandler).Load())
        {
            var files = await fileReaderService.CreateReference(model.Element).EnumerateFilesAsync();
            var file = files.First();
            await model.SetFile(file);
            TaskImages.Add(model);
            StateHasChanged();

            AddImageFileElementModel = new AddImageFileElementModel("newImage");
        }


    }

    async void UploadButtonClick(UIMouseEventArgs e, AddImageFileElementModel model)
    {
        await UiJsHandler.TriggerClientClick(model.ElementId);
        StateHasChanged();
    }






#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AddressSvc AddressSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientSvc ClientSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InstantDatahandler InstantDatahandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHHLQueryExecutionSvc _HHLQueryExecutionSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaskSvc TaskSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UiJsHandler UiJsHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AutoMapper.IMapper _mapper { get; set; }
    }
}
#pragma warning restore 1591
