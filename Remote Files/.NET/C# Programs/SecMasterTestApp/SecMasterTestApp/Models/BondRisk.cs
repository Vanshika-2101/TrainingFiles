using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class BondRisk
{
    public int BondRiskId { get; set; }

    public int SecurityId { get; set; }

    public decimal Duration { get; set; }

    public decimal? Volatility30d { get; set; }

    public decimal? Volatility90d { get; set; }

    public decimal Convexity { get; set; }

    public decimal? AverageVol30d { get; set; }

    public virtual Security Security { get; set; } = null!;
}
