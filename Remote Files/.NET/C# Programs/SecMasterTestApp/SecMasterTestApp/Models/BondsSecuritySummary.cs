using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class BondsSecuritySummary
{
    public int BondSecuritySummaryId { get; set; }

    public int? SecurityId { get; set; }

    public string? InvestmentType { get; set; }

    public decimal? TradingFactor { get; set; }

    public decimal? PricingFactor { get; set; }

    public string? AssetType { get; set; }

    public virtual Security? Security { get; set; }
}
