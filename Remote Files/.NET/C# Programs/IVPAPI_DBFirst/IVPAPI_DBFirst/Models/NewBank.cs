using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class NewBank
{
    public int Cid { get; set; }

    public string Cname { get; set; } = null!;

    public string? Acctype { get; set; }

    public double? Balance { get; set; }

    public string Country { get; set; } = null!;
}
