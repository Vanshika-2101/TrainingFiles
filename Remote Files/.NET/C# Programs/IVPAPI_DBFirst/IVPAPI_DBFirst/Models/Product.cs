using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Product
{
    public int Pid { get; set; }

    public string Pname { get; set; } = null!;

    public double? Price { get; set; }

    public string? Pcategory { get; set; }
}
