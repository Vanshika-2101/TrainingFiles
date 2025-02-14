using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class EquityReferenceDatum
{
    public int EquityReferenceId { get; set; }

    public int ReferenceId { get; set; }

    public string? Exchange { get; set; }

    public string? TradingCurrency { get; set; }

    public virtual ReferenceDatum Reference { get; set; } = null!;
}
