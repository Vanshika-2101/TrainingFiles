using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Administrator
{
    public string AdminId { get; set; } = null!;

    public string AdminName { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string AdminContact { get; set; } = null!;

    public string AdminEmail { get; set; } = null!;
}
