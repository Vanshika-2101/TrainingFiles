using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class EquitiesSecuritySummary
{
    public int EquitySecuritySummaryId { get; set; }

    public int? SecurityId { get; set; }

    public bool? HasPosition { get; set; }

    public int? RoundLotSize { get; set; }

    public string? BloombergUniqueName { get; set; }

    public virtual Security? Security { get; set; }
}
