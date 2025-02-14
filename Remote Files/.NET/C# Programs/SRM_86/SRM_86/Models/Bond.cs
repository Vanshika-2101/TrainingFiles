using System;
using System.Collections.Generic;

namespace SRM_86.Models;

public partial class Bond
{
    public string SecurityDescription { get; set; } = null!;

    public string SecurityName { get; set; } = null!;

    public string AssetType { get; set; } = null!;

    public string InvestmentType { get; set; } = null!;

    public double TradingFactor { get; set; }

    public double PricingFactor { get; set; }

    public string Isin { get; set; } = null!;

    public string BbgTicker { get; set; } = null!;

    public string BbgUniqueId { get; set; } = null!;

    public string Cusip { get; set; } = null!;

    public string Sedol { get; set; } = null!;

    public DateOnly FirstCouponDate { get; set; }

    public string? Cap { get; set; }

    public string? Floor { get; set; }

    public byte CouponFrequency { get; set; }

    public double Coupon { get; set; }

    public string CouponType { get; set; } = null!;

    public string? Spread { get; set; }

    public bool CallableFlag { get; set; }

    public string FixToFloatFlag { get; set; } = null!;

    public string PutableFlag { get; set; } = null!;

    public DateOnly IssueDate { get; set; }

    public string? LastResetDate { get; set; }

    public DateOnly Maturity { get; set; }

    public double? CallNotificationMaxDays { get; set; }

    public string? PutNotificationMaxDays { get; set; }

    public DateOnly PenultimateCouponDate { get; set; }

    public string? ResetFrequency { get; set; }

    public string HasPosition { get; set; } = null!;

    public double MacaulayDuration { get; set; }

    public double? _30dVolatility { get; set; }

    public double? _90dVolatility { get; set; }

    public double Convexity { get; set; }

    public double? _30dayAverageVolume { get; set; }

    public string PfAssetClass { get; set; } = null!;

    public string PfCountry { get; set; } = null!;

    public string PfCreditRating { get; set; } = null!;

    public string PfCurrency { get; set; } = null!;

    public string PfInstrument { get; set; } = null!;

    public string PfLiquidityProfile { get; set; } = null!;

    public string? PfMaturity { get; set; }

    public string? PfNaicsCode { get; set; }

    public string PfRegion { get; set; } = null!;

    public string? PfSector { get; set; }

    public string PfSubAssetClass { get; set; } = null!;

    public string BloombergIndustryGroup { get; set; } = null!;

    public string BloombergIndustrySubGroup { get; set; } = null!;

    public string BloombergIndustrySector { get; set; } = null!;

    public string CountryOfIssuance { get; set; } = null!;

    public string IssueCurrency { get; set; } = null!;

    public string Issuer { get; set; } = null!;

    public string RiskCurrency { get; set; } = null!;

    public string? PutDate { get; set; }

    public string? PutPrice { get; set; }

    public double AskPrice { get; set; }

    public double HighPrice { get; set; }

    public double LowPrice { get; set; }

    public double OpenPrice { get; set; }

    public double Volume { get; set; }

    public double BidPrice { get; set; }

    public double LastPrice { get; set; }

    public DateOnly? CallDate { get; set; }

    public double? CallPrice { get; set; }

    public int SecurityId { get; set; }
}
