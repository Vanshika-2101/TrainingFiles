using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class BondPricingDetail
{
    public int BondPricingDetailsId { get; set; }

    public int PricingDetailsId { get; set; }

    public decimal? HighPrice { get; set; }

    public decimal? LowPrice { get; set; }

    public virtual PricingDetail PricingDetails { get; set; } = null!;
}
