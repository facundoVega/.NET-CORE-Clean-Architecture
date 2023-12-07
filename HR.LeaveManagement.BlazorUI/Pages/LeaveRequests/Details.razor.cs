using HR.LeaveManagement.BlazorUI.Contracts;
using HR.LeaveManagement.BlazorUI.Models.LeaveRequests;
using Microsoft.AspNetCore.Components;

namespace HR.LeaveManagement.BlazorUI.Pages.LeaveRequests;

public partial class Details
{
    [Inject]
    ILeaveRequestService leaveRequestService { get; set; }

    [Inject]
    NavigationManager NavigationManager { get; set; }

    [Parameter]
    public int id { get; set; }

    string ClassName;
    string headingText;

    public LeaveRequestVM Model { get; private set; } = new LeaveRequestVM();

    protected override async Task OnParametersSetAsync()
    {
        Model = await leaveRequestService.GetLeaveRequest(id);
    }
    protected override async Task OnInitializedAsync()
    {
        if (Model.Approved == null)
        {
            ClassName = "warning";
            headingText = "Pending Approval";
        }
        else if (Model.Approved == true)
        {
            ClassName = "success";
            headingText = "Approved";
        }
        else
        {
            ClassName = "danger";
            headingText = "Rejected";
        }
    }

    async Task ChangeApproval(bool approvalStatus)
    {
        await leaveRequestService.ApproveLeaveRequest(id, approvalStatus);
        NavigationManager.NavigateTo("/leaverequests/");
    }

}