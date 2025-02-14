using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Vujointaccount
{
    public int Cid { get; set; }

    public string Cname { get; set; } = null!;

    public string? Acctype { get; set; }

    public double? Balance { get; set; }
}
