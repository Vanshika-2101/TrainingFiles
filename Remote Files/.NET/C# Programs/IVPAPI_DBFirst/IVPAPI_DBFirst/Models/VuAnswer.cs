using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class VuAnswer
{
    public string DepartmentName { get; set; } = null!;

    public int? Count { get; set; }

    public double? Totalsal { get; set; }

    public double Avgsal { get; set; }
}
