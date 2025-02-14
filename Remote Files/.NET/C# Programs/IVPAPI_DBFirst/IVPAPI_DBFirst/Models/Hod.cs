using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Hod
{
    public string Hodid { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public int? StreamId { get; set; }

    public DateTime HireDate { get; set; }

    public virtual Stream? Stream { get; set; }
}
