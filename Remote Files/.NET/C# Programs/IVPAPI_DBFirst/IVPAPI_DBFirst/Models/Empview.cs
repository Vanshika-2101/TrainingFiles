using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Empview
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateTime HireDate { get; set; }

    public string JobId { get; set; } = null!;

    public double? Salary { get; set; }

    public double? CommissionPct { get; set; }

    public int? ManagerId { get; set; }

    public int? DepartmentId { get; set; }
}
