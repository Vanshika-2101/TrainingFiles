using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Auditbank
{
    public string? Username { get; set; }

    public DateTime? Xndate { get; set; }

    public string? Newacctype { get; set; }

    public string? Oldacctype { get; set; }

    public double? Newbal { get; set; }

    public double? Oldbal { get; set; }

    public string? Xntype { get; set; }

    public int? Cid { get; set; }
}
