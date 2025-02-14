using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class EquitySecurityDetail
{
    public int EquitySecurityDetailId { get; set; }

    public int SecurityId { get; set; }

    public string? AdrUnderlyingTicker { get; set; }

    public string? AdrUnderlyingCurrency { get; set; }

    public int? SharesPerAdr { get; set; }

    public DateOnly? IpoDate { get; set; }

    public string? PriceCurrency { get; set; }

    public int? SettleDays { get; set; }

    public decimal? OutstandingShares { get; set; }

    public decimal? VoteRightPerShare { get; set; }

    public virtual Security Security { get; set; } = null!;
}
