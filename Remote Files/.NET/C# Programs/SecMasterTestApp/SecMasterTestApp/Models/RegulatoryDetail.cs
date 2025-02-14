using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class RegulatoryDetail
{
    public int RegulatoryId { get; set; }

    public int SecurityId { get; set; }

    public string? PfAssetClass { get; set; }

    public string? PfCountry { get; set; }

    public string? PfCreditRating { get; set; }

    public string? PfCurrency { get; set; }

    public string? PfInstrument { get; set; }

    public string? PfLiquidity { get; set; }

    public string? PfMaturity { get; set; }

    public string? PfNaicsCode { get; set; }

    public string? PfRegion { get; set; }

    public string? PfSector { get; set; }

    public string? PfSubAssetClass { get; set; }

    public virtual Security Security { get; set; } = null!;
}
