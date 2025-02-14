using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class EquityPricingDetail
{
    public int EquityPricingDetailsId { get; set; }

    public int PricingDetailsId { get; set; }

    public decimal? ClosePrice { get; set; }

    public decimal? PeRation { get; set; }

    public virtual PricingDetail PricingDetails { get; set; } = null!;
}
