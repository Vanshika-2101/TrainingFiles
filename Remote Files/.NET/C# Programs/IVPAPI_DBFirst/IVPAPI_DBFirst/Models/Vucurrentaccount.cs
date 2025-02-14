using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Vucurrentaccount
{
    public int Cid { get; set; }

    public string? Acctype { get; set; }

    public double? Balance { get; set; }
}
