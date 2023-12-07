﻿using Microsoft.AspNetCore.Mvc;

namespace HR.LeaveManagament.Api.Models;

public class CustomProblemDetails : ProblemDetails
{
    public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
}
