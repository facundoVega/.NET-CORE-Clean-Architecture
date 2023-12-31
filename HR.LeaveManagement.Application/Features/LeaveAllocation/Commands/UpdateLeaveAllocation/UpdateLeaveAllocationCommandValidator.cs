﻿
using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;
using System.Security.Cryptography;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Commands.UpdateLeaveAllocation;

public class UpdateLeaveAllocationCommandValidator : AbstractValidator<UpdateLeaveAllocationCommand>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;

    public UpdateLeaveAllocationCommandValidator(ILeaveTypeRepository leaveTypeRepository, ILeaveAllocationRepository leaveAllocationRepository)
	{
        _leaveTypeRepository = leaveTypeRepository;
        _leaveAllocationRepository = leaveAllocationRepository;

        RuleFor(p => p.NumberOfDays)
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than {ComparisonValue}");

        RuleFor(p => p.Period)
            .GreaterThanOrEqualTo(DateTime.Now.Year).WithMessage("{PropertyName} must be after {ComparisonValue}");

        RuleFor(p => p.LeaveTypeId)
            .GreaterThan(0)
            .MustAsync(LeaveTypeMustExist)
            .WithMessage("{PropertyName} does not exist");

        RuleFor(p => p.Id)
            .NotNull()
            .MustAsync(LeaveAllocationMustExist)
            .WithMessage("{PropertyName} must be present");

    }

    private async Task<bool> LeaveAllocationMustExist(int Id, CancellationToken arg2)
    {
        var leaveAllocation = await _leaveAllocationRepository.GetByIdAsync(Id);
        return leaveAllocation != null;
    }

    private async Task<bool> LeaveTypeMustExist(int Id, CancellationToken token)
    {
        var leaveType = await _leaveTypeRepository.GetByIdAsync(Id);
        return leaveType != null;
    }
}
