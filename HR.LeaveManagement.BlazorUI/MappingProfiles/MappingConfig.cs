﻿using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetails;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using HR.LeaveManagement.BlazorUI.Models.LeaveRequests;
using HR.LeaveManagement.BlazorUI.Models.LeaveTypes;
using HR.LeaveManagement.BlazorUI.Services.Base;
using HR.LeaveManagement.BlazorUI.Models.LeaveAllocations;
using HR.LeaveManagement.BlazorUI.Models;

namespace HR.LeaveManagement.BlazorUI.MappingProfiles;

public class MappingConfig :Profile
{
    public MappingConfig()
    {
        CreateMap<LeaveTypeDto, LeaveTypeVM>().ReverseMap();
        CreateMap<LeaveTypeDetailsDto, LeaveTypeVM>().ReverseMap();
        CreateMap<CreateLeaveTypeCommand, LeaveTypeVM>().ReverseMap();
        CreateMap<UpdateLeaveTypeCommand, LeaveTypeVM>().ReverseMap();

        CreateMap<LeaveRequestListDto, LeaveRequestVM>()
           .ForMember(q => q.DateRequested, opt => opt.MapFrom(x => x.DateRequested.DateTime))
           .ForMember(q => q.StartDate, opt => opt.MapFrom(x => x.StartDate.DateTime))
           .ForMember(q => q.EndDate, opt => opt.MapFrom(x => x.EndDate.DateTime))
           .ReverseMap();

        CreateMap<LeaveRequestDetailsDto, LeaveRequestVM>()
            .ForMember(q => q.DateRequested, opt => opt.MapFrom(x => x.DateRequested.DateTime))
            .ForMember(q => q.StartDate, opt => opt.MapFrom(x => x.StartDate.DateTime))
            .ForMember(q => q.EndDate, opt => opt.MapFrom(x => x.EndDate.DateTime))
            .ForMember(q => q.DateActioned, opt => opt.MapFrom(x => x.DateActioned.DateTime))
            .ReverseMap();

        CreateMap<CreateLeaveRequestCommand, LeaveRequestVM>().ReverseMap();
        CreateMap<UpdateLeaveRequestCommand, LeaveRequestVM>().ReverseMap();

        CreateMap<LeaveAllocationDto, LeaveAllocationVM>().ReverseMap();    
        CreateMap<LeaveAllocationDetailsDto, LeaveAllocationVM>().ReverseMap();

        CreateMap<EmployeeVM, Employee>().ReverseMap();
    }
}
