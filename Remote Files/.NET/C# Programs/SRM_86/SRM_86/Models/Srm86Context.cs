using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;

namespace SRM_86.Models;

public partial class Srm86Context : DbContext
{
    public Srm86Context()
    {
    }

    public Srm86Context(DbContextOptions<Srm86Context> options)
        : base(options)
    {
        
    }


    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<Bond> Bonds { get; set; }

    public virtual DbSet<Equity> Equities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=192.168.0.13\\\\\\\\sqlexpress,49753; Database=SRM_86; User Id=sa; Password=sa@12345678; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__AuditLog__A17F23B834D1D377");

            entity.ToTable("AuditLog");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.ActionType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EndTimestamp).HasColumnType("datetime");
            entity.Property(e => e.StartTimestamp).HasColumnType("datetime");
            entity.Property(e => e.TableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Bond>(entity =>
        {
            entity.HasKey(e => e.SecurityId).HasName("PK__Bonds__9F8B093048EF7AC1");

            entity.Property(e => e.AskPrice).HasColumnName("Ask_Price");
            entity.Property(e => e.AssetType)
                .HasMaxLength(50)
                .HasColumnName("Asset_Type");
            entity.Property(e => e.BbgTicker)
                .HasMaxLength(50)
                .HasColumnName("BBG_Ticker");
            entity.Property(e => e.BbgUniqueId)
                .HasMaxLength(50)
                .HasColumnName("BBG_Unique_ID");
            entity.Property(e => e.BidPrice).HasColumnName("Bid_Price");
            entity.Property(e => e.BloombergIndustryGroup)
                .HasMaxLength(50)
                .HasColumnName("Bloomberg_Industry_Group");
            entity.Property(e => e.BloombergIndustrySector)
                .HasMaxLength(50)
                .HasColumnName("Bloomberg_Industry_Sector");
            entity.Property(e => e.BloombergIndustrySubGroup)
                .HasMaxLength(50)
                .HasColumnName("Bloomberg_Industry_Sub_Group");
            entity.Property(e => e.CallDate).HasColumnName("Call_Date");
            entity.Property(e => e.CallNotificationMaxDays).HasColumnName("Call_Notification_Max_Days");
            entity.Property(e => e.CallPrice).HasColumnName("Call_Price");
            entity.Property(e => e.CallableFlag).HasColumnName("Callable_Flag");
            entity.Property(e => e.Cap).HasMaxLength(1);
            entity.Property(e => e.CountryOfIssuance)
                .HasMaxLength(50)
                .HasColumnName("Country_of_Issuance");
            entity.Property(e => e.CouponFrequency).HasColumnName("Coupon_Frequency");
            entity.Property(e => e.CouponType)
                .HasMaxLength(50)
                .HasColumnName("Coupon_Type");
            entity.Property(e => e.Cusip)
                .HasMaxLength(50)
                .HasColumnName("CUSIP");
            entity.Property(e => e.FirstCouponDate).HasColumnName("First_Coupon_Date");
            entity.Property(e => e.FixToFloatFlag)
                .HasMaxLength(50)
                .HasColumnName("Fix_to_Float_Flag");
            entity.Property(e => e.Floor).HasMaxLength(1);
            entity.Property(e => e.HasPosition)
                .HasMaxLength(50)
                .HasColumnName("Has_Position");
            entity.Property(e => e.HighPrice).HasColumnName("High_Price");
            entity.Property(e => e.InvestmentType)
                .HasMaxLength(50)
                .HasColumnName("Investment_Type");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.IssueCurrency)
                .HasMaxLength(50)
                .HasColumnName("Issue_Currency");
            entity.Property(e => e.IssueDate).HasColumnName("Issue_Date");
            entity.Property(e => e.Issuer).HasMaxLength(50);
            entity.Property(e => e.LastPrice).HasColumnName("Last_Price");
            entity.Property(e => e.LastResetDate)
                .HasMaxLength(1)
                .HasColumnName("Last_Reset_Date");
            entity.Property(e => e.LowPrice).HasColumnName("Low_Price");
            entity.Property(e => e.MacaulayDuration).HasColumnName("Macaulay_Duration");
            entity.Property(e => e.OpenPrice).HasColumnName("Open_Price");
            entity.Property(e => e.PenultimateCouponDate).HasColumnName("Penultimate_Coupon_Date");
            entity.Property(e => e.PfAssetClass)
                .HasMaxLength(50)
                .HasColumnName("PF_Asset_Class");
            entity.Property(e => e.PfCountry)
                .HasMaxLength(50)
                .HasColumnName("PF_Country");
            entity.Property(e => e.PfCreditRating)
                .HasMaxLength(50)
                .HasColumnName("PF_Credit_Rating");
            entity.Property(e => e.PfCurrency)
                .HasMaxLength(50)
                .HasColumnName("PF_Currency");
            entity.Property(e => e.PfInstrument)
                .HasMaxLength(50)
                .HasColumnName("PF_Instrument");
            entity.Property(e => e.PfLiquidityProfile)
                .HasMaxLength(50)
                .HasColumnName("PF_Liquidity_Profile");
            entity.Property(e => e.PfMaturity)
                .HasMaxLength(1)
                .HasColumnName("PF_Maturity");
            entity.Property(e => e.PfNaicsCode)
                .HasMaxLength(1)
                .HasColumnName("PF_NAICS_Code");
            entity.Property(e => e.PfRegion)
                .HasMaxLength(50)
                .HasColumnName("PF_Region");
            entity.Property(e => e.PfSector)
                .HasMaxLength(1)
                .HasColumnName("PF_Sector");
            entity.Property(e => e.PfSubAssetClass)
                .HasMaxLength(100)
                .HasColumnName("PF_Sub_Asset_Class");
            entity.Property(e => e.PricingFactor).HasColumnName("Pricing_Factor");
            entity.Property(e => e.PutDate)
                .HasMaxLength(1)
                .HasColumnName("Put_Date");
            entity.Property(e => e.PutNotificationMaxDays)
                .HasMaxLength(1)
                .HasColumnName("Put_Notification_Max_Days");
            entity.Property(e => e.PutPrice)
                .HasMaxLength(1)
                .HasColumnName("Put_Price");
            entity.Property(e => e.PutableFlag)
                .HasMaxLength(50)
                .HasColumnName("Putable_Flag");
            entity.Property(e => e.ResetFrequency)
                .HasMaxLength(1)
                .HasColumnName("Reset_Frequency");
            entity.Property(e => e.RiskCurrency)
                .HasMaxLength(50)
                .HasColumnName("Risk_Currency");
            entity.Property(e => e.SecurityDescription)
                .HasMaxLength(50)
                .HasColumnName("Security_Description");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(50)
                .HasColumnName("Security_Name");
            entity.Property(e => e.Sedol)
                .HasMaxLength(50)
                .HasColumnName("SEDOL");
            entity.Property(e => e.Spread).HasMaxLength(1);
            entity.Property(e => e.TradingFactor).HasColumnName("Trading_Factor");
            entity.Property(e => e._30dVolatility).HasColumnName("_30D_Volatility");
            entity.Property(e => e._30dayAverageVolume).HasColumnName("_30Day_Average_Volume");
            entity.Property(e => e._90dVolatility).HasColumnName("_90D_Volatility");
        });

        modelBuilder.Entity<Equity>(entity =>
        {
            entity.HasKey(e => e.SecurityId).HasName("PK__Equities__9F8B0930BE1701E8");

            entity.Property(e => e.AdrUnderlyingCurrency)
                .HasMaxLength(1)
                .HasColumnName("ADR_Underlying_Currency");
            entity.Property(e => e.AdrUnderlyingTicker)
                .HasMaxLength(1)
                .HasColumnName("ADR_Underlying_Ticker");
            entity.Property(e => e.AskPrice).HasColumnName("Ask_Price");
            entity.Property(e => e.AverageVolume20d).HasColumnName("Average_Volume_20D");
            entity.Property(e => e.BbgGlobalId)
                .HasMaxLength(50)
                .HasColumnName("BBG_Global_ID");
            entity.Property(e => e.BbgIndustrySubGroup)
                .HasMaxLength(50)
                .HasColumnName("BBG_Industry_Sub_Group");
            entity.Property(e => e.BbgUniqueName)
                .HasMaxLength(50)
                .HasColumnName("BBG_Unique_Name");
            entity.Property(e => e.BidPrice).HasColumnName("Bid_Price");
            entity.Property(e => e.BloombergIndustryGroup)
                .HasMaxLength(50)
                .HasColumnName("Bloomberg_Industry_Group");
            entity.Property(e => e.BloombergSector)
                .HasMaxLength(50)
                .HasColumnName("Bloomberg_Sector");
            entity.Property(e => e.BloombergTicker)
                .HasMaxLength(50)
                .HasColumnName("Bloomberg_Ticker");
            entity.Property(e => e.BloombergUniqueId)
                .HasMaxLength(50)
                .HasColumnName("Bloomberg_Unique_ID");
            entity.Property(e => e.ClosePrice).HasColumnName("Close_Price");
            entity.Property(e => e.CountryOfIncorporation)
                .HasMaxLength(50)
                .HasColumnName("Country_of_Incorporation");
            entity.Property(e => e.CountryOfIssuance)
                .HasMaxLength(50)
                .HasColumnName("Country_of_Issuance");
            entity.Property(e => e.Cusip)
                .HasMaxLength(50)
                .HasColumnName("CUSIP");
            entity.Property(e => e.DividendAmount).HasColumnName("Dividend_Amount");
            entity.Property(e => e.DividendDeclaredDate).HasColumnName("Dividend_Declared_Date");
            entity.Property(e => e.DividendExDate).HasColumnName("Dividend_Ex_Date");
            entity.Property(e => e.DividendPayDate).HasColumnName("Dividend_Pay_Date");
            entity.Property(e => e.DividendRecordDate).HasColumnName("Dividend_Record_Date");
            entity.Property(e => e.DividendType)
                .HasMaxLength(50)
                .HasColumnName("Dividend_Type");
            entity.Property(e => e.Exchange).HasMaxLength(50);
            entity.Property(e => e.Frequency).HasMaxLength(1);
            entity.Property(e => e.HasPosition)
                .HasMaxLength(50)
                .HasColumnName("Has_Position");
            entity.Property(e => e.IpoDate)
                .HasMaxLength(1)
                .HasColumnName("IPO_Date");
            entity.Property(e => e.IsActiveSecurity)
                .HasMaxLength(50)
                .HasColumnName("Is_Active_Security");
            entity.Property(e => e.IsAdrFlag)
                .HasMaxLength(50)
                .HasColumnName("Is_ADR_Flag");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.IssueCurrency)
                .HasMaxLength(50)
                .HasColumnName("Issue_Currency");
            entity.Property(e => e.Issuer).HasMaxLength(50);
            entity.Property(e => e.LastPrice).HasColumnName("Last_Price");
            entity.Property(e => e.LotSize).HasColumnName("Lot_Size");
            entity.Property(e => e.OpenPrice).HasColumnName("Open_Price");
            entity.Property(e => e.PeRatio).HasColumnName("PE_Ratio");
            entity.Property(e => e.PfAssetClass)
                .HasMaxLength(50)
                .HasColumnName("PF_Asset_Class");
            entity.Property(e => e.PfCountry)
                .HasMaxLength(50)
                .HasColumnName("PF_Country");
            entity.Property(e => e.PfCreditRating)
                .HasMaxLength(50)
                .HasColumnName("PF_Credit_Rating");
            entity.Property(e => e.PfCurrency)
                .HasMaxLength(50)
                .HasColumnName("PF_Currency");
            entity.Property(e => e.PfInstrument)
                .HasMaxLength(50)
                .HasColumnName("PF_Instrument");
            entity.Property(e => e.PfLiquidityProfile)
                .HasMaxLength(50)
                .HasColumnName("PF_Liquidity_Profile");
            entity.Property(e => e.PfMaturity)
                .HasMaxLength(1)
                .HasColumnName("PF_Maturity");
            entity.Property(e => e.PfNaicsCode)
                .HasMaxLength(50)
                .HasColumnName("PF_NAICS_Code");
            entity.Property(e => e.PfRegion)
                .HasMaxLength(50)
                .HasColumnName("PF_Region");
            entity.Property(e => e.PfSector)
                .HasMaxLength(1)
                .HasColumnName("PF_Sector");
            entity.Property(e => e.PfSubAssetClass)
                .HasMaxLength(50)
                .HasColumnName("PF_Sub_Asset_Class");
            entity.Property(e => e.PricingCurrency)
                .HasMaxLength(50)
                .HasColumnName("Pricing_Currency");
            entity.Property(e => e.ReturnYtd).HasColumnName("Return_YTD");
            entity.Property(e => e.RiskCurrency)
                .HasMaxLength(50)
                .HasColumnName("Risk_Currency");
            entity.Property(e => e.SecurityDescription)
                .HasMaxLength(50)
                .HasColumnName("Security_Description");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(50)
                .HasColumnName("Security_Name");
            entity.Property(e => e.Sedol)
                .HasMaxLength(50)
                .HasColumnName("SEDOL");
            entity.Property(e => e.SettleDays).HasColumnName("Settle_Days");
            entity.Property(e => e.SharesPerAdr)
                .HasMaxLength(1)
                .HasColumnName("Shares_Per_ADR");
            entity.Property(e => e.ShortInterest).HasColumnName("Short_Interest");
            entity.Property(e => e.TickerAndExchange)
                .HasMaxLength(50)
                .HasColumnName("Ticker_and_Exchange");
            entity.Property(e => e.TotalSharesOutstanding).HasColumnName("Total_Shares_Outstanding");
            entity.Property(e => e.TradingCurrency)
                .HasMaxLength(50)
                .HasColumnName("Trading_Currency");
            entity.Property(e => e.Volatility90d).HasColumnName("Volatility_90D");
            entity.Property(e => e.VotingRightsPerShare).HasColumnName("Voting_Rights_Per_Share");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
