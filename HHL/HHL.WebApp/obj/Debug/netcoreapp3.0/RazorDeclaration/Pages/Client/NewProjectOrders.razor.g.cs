// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HHL.WebApp.Pages.Client
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/client/new-project-orders/{projectid}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/client/new-project-orders")]
    public partial class NewProjectOrders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 187 "c:\Users\mikek\source\repos\health_home_live_blazorapp\HHL\HHL.WebApp\Pages\Client\NewProjectOrders.razor"
            


    string BuldingType;

    ModalSeetings ModalSeetings { get; set; }

    IEnumerable<PrioritySelectModel> PrioritySelectModels { get; set; } = Enumerable.Empty<PrioritySelectModel>();
    AddUpdateProjectFormModel AddUpdateProjectFormModel { get; set; } = new AddUpdateProjectFormModel();

    [Parameter] string Projectid { get; set; }

    v_VmHomeProject ClientProjectModel = new v_VmHomeProject();


    IEnumerable<v_VmHomeTask> ClientTasksModels = Enumerable.Empty<v_VmHomeTask>();

    decimal ProjectTotalPrice { get; set; } = 0;

    protected override async Task OnInitializedAsync()
    {

        var r = await LoadData();

    }

    public async Task<bool> LoadData()
    {
        ModalSeetings = new ModalSeetings() { ShowModal = false };
        var projectId = new Guid(Projectid);
        ClientProjectModel = await ProjectSvc.SELECTByProjectId(projectId);


        ClientTasksModels = (await TaskSvc.SELECTActiveByProjectId(projectId)).Results.OrderBy(q => q.TaskName);
        BuldingType = ClientProjectModel.ProjectHomeBuldingTypeId == 1 ? "residential" : "commercial";

        PrioritySelectModels = _mapper.Map<IEnumerable<e_Priority>, IEnumerable<PrioritySelectModel>>(InstantDatahandler.All_Priorities);

        ProjectTotalPrice = ClientTasksModels.Sum(q => q.TaskPriceTotal);






        return true;
    }


    async void EditProject(UIMouseEventArgs __e, Guid projectId)
    {
        AddUpdateProjectFormModel = new AddUpdateProjectFormModel();
        AddUpdateProjectFormModel.Id = projectId;
        AddUpdateProjectFormModel.Name = ClientProjectModel.ProjectName;
        AddUpdateProjectFormModel.PriorityId = ClientProjectModel.ProjectPriorityId;
        ModalSeetings.ShowModal = true;
    }


    async void HandleAddUpdateProjectFormModelSubmit()
    {

        using (var ls = await new LoadingScreen(UiJsHandler).Load())
        {

            if (await ProjectSvc.Update(AddUpdateProjectFormModel))
            {
                ClientProjectModel.ProjectName = AddUpdateProjectFormModel.Name;
                ClientProjectModel.ProjectPriorityId = AddUpdateProjectFormModel.PriorityId;

                ModalSeetings.ShowModal = false;
                StateHasChanged();
            }


        }

    }


    async void HandleCheckoutSubmit()
    {
        using (var ls = await new LoadingScreen(UiJsHandler).Load())
        {
            var result = await ProjectSvc.CheckOutProjectTask(ClientProjectModel.ProjectId);
            if (result)
            {
                UriHelper.NavigateTo(UrlNameHdr.ClientPaymentCompletion, forceLoad: true);
            }
        }


    }


    public async void DeleteTaskHandler(UIMouseEventArgs e, Guid taskId)
    {

        using (var ls = await new LoadingScreen(UiJsHandler).Load())
        {
            var isDeleted = await TaskSvc.DeleteTask(taskId);
            if (isDeleted)
            {
                var r = await LoadData();
                StateHasChanged();
            }
        }

    }

    public async void EditTaskHandler(UIMouseEventArgs e, Guid taskId)
    {
        using (var ls = await new LoadingScreen(UiJsHandler).Load())
        {
            var task = (await _HHLQueryExecutionSvc.SELECTbyIdAsync<e_HomeTask>(taskId)).FirstOrDefault;
            var taskCategory = (await _HHLQueryExecutionSvc.SELECTbyIdAsync<v_VmHomeTaskCategory>(task.HomeTaskCategoryId)).FirstOrDefault;
            UriHelper.NavigateTo($"/home/{BuldingType.ToUrl()}/task/{taskCategory.HomeTaskTypeName.ToUrl()}/{taskCategory.HomeTaskServiceTypeName.ToUrl()}/{taskId}", forceLoad: true);
        }
    }




#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InstantDatahandler InstantDatahandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UiJsHandler UiJsHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHHLQueryExecutionSvc _HHLQueryExecutionSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaskSvc TaskSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProjectSvc ProjectSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AutoMapper.IMapper _mapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HHLAuthSessionSvc AuthSessionSvc { get; set; }
    }
}
#pragma warning restore 1591
