using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Student1
{
    public int Sid { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public int? StreamId { get; set; }

    public string Grade { get; set; } = null!;

    public double? Marks { get; set; }

    public DateTime AdmissionDate { get; set; }

    public virtual Stream? Stream { get; set; }
}
