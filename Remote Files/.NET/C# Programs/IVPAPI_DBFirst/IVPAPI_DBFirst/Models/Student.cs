using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Student
{
    public int Sid { get; set; }

    public string Sname { get; set; } = null!;

    public string? Branch { get; set; }

    public double? Marks { get; set; }
}
