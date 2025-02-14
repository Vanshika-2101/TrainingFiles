using System;
using System.Collections.Generic;

namespace SRM_86.Models;

public partial class Equity
{
    public string SecurityName { get; set; } = null!;

    public string SecurityDescription { get; set; } = null!;

    public string HasPosition { get; set; } = null!;

    public string IsActiveSecurity { get; set; } = null!;

    public byte LotSize { get; set; }

    public string BbgUniqueName { get; set; } = null!;

    public string? Cusip { get; set; }

    public string? Isin { get; set; }

    public string? Sedol { get; set; }

    public string BloombergTicker { get; set; } = null!;

    public string BloombergUniqueId { get; set; } = null!;

    public string? BbgGlobalId { get; set; }

    public string TickerAndExchange { get; set; } = null!;

    public string IsAdrFlag { get; set; } = null!;

    public string? AdrUnderlyingTicker { get; set; }

    public string? AdrUnderlyingCurrency { get; set; }

    public string? SharesPerAdr { get; set; }

    public string? IpoDate { get; set; }

    public string PricingCurrency { get; set; } = null!;

    public byte SettleDays { get; set; }

    public double? TotalSharesOutstanding { get; set; }

    public double VotingRightsPerShare { get; set; }

    public double AverageVolume20d { get; set; }

    public double Beta { get; set; }

    public double ShortInterest { get; set; }

    public double ReturnYtd { get; set; }

    public double? Volatility90d { get; set; }

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

    public string CountryOfIssuance { get; set; } = null!;

    public string Exchange { get; set; } = null!;

    public string Issuer { get; set; } = null!;

    public string IssueCurrency { get; set; } = null!;

    public string TradingCurrency { get; set; } = null!;

    public string BbgIndustrySubGroup { get; set; } = null!;

    public string BloombergIndustryGroup { get; set; } = null!;

    public string BloombergSector { get; set; } = null!;

    public string CountryOfIncorporation { get; set; } = null!;

    public string RiskCurrency { get; set; } = null!;

    public double OpenPrice { get; set; }

    public double ClosePrice { get; set; }

    public double Volume { get; set; }

    public double LastPrice { get; set; }

    public double AskPrice { get; set; }

    public double BidPrice { get; set; }

    public double PeRatio { get; set; }

    public DateOnly DividendDeclaredDate { get; set; }

    public DateOnly DividendExDate { get; set; }

    public DateOnly DividendRecordDate { get; set; }

    public DateOnly DividendPayDate { get; set; }

    public double DividendAmount { get; set; }

    public string? Frequency { get; set; }

    public string DividendType { get; set; } = null!;

    public int SecurityId { get; set; }
}
