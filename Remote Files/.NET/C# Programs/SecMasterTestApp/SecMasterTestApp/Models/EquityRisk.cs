using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class EquityRisk
{
    public int EquityRiskId { get; set; }

    public int SecurityId { get; set; }

    public decimal AverageVolume20d { get; set; }

    public decimal Beta { get; set; }

    public decimal ShortInterest { get; set; }

    public decimal YtdReturn { get; set; }

    public decimal? Volatility90d { get; set; }

    public virtual Security Security { get; set; } = null!;
}
