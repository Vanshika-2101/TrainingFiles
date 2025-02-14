using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class PricingDetail
{
    public int PricingId { get; set; }

    public int SecurityId { get; set; }

    public decimal? OpenPrice { get; set; }

    public decimal? LastPrice { get; set; }

    public decimal? AskPrice { get; set; }

    public decimal? BidPrice { get; set; }

    public decimal? Volume { get; set; }

    public virtual ICollection<BondPricingDetail> BondPricingDetails { get; set; } = new List<BondPricingDetail>();

    public virtual ICollection<EquityPricingDetail> EquityPricingDetails { get; set; } = new List<EquityPricingDetail>();

    public virtual Security Security { get; set; } = null!;
}
