using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Vuempdept
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public double? Salary { get; set; }

    public string JobId { get; set; } = null!;

    public DateTime HireDate { get; set; }

    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;
}
