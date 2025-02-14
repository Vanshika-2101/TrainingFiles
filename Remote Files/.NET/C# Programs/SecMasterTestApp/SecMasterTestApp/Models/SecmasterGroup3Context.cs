using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SecMasterTestApp.Models;

public partial class SecmasterGroup3Context : DbContext
{
    public SecmasterGroup3Context()
    {
    }

    public SecmasterGroup3Context(DbContextOptions<SecmasterGroup3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<BondPricingDetail> BondPricingDetails { get; set; }

    public virtual DbSet<BondRisk> BondRisks { get; set; }

    public virtual DbSet<BondSchedule> BondSchedules { get; set; }

    public virtual DbSet<BondScheduleType> BondScheduleTypes { get; set; }

    public virtual DbSet<BondSecurityDetail> BondSecurityDetails { get; set; }

    public virtual DbSet<BondsSecuritySummary> BondsSecuritySummaries { get; set; }

    public virtual DbSet<EquitiesSecuritySummary> EquitiesSecuritySummaries { get; set; }

    public virtual DbSet<EquityDividendHistory> EquityDividendHistories { get; set; }

    public virtual DbSet<EquityPricingDetail> EquityPricingDetails { get; set; }

    public virtual DbSet<EquityReferenceDatum> EquityReferenceData { get; set; }

    public virtual DbSet<EquityRisk> EquityRisks { get; set; }

    public virtual DbSet<EquitySecurityDetail> EquitySecurityDetails { get; set; }

    public virtual DbSet<Identifier> Identifiers { get; set; }

    public virtual DbSet<IdentifierType> IdentifierTypes { get; set; }

    public virtual DbSet<PricingDetail> PricingDetails { get; set; }

    public virtual DbSet<ReferenceDatum> ReferenceData { get; set; }

    public virtual DbSet<RegulatoryDetail> RegulatoryDetails { get; set; }

    public virtual DbSet<Security> Securities { get; set; }

    public virtual DbSet<SecurityType> SecurityTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.0.13\\\\\\\\sqlexpress,49753; Database=secmaster_group3; User Id=sa; Password=sa@12345678; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BondPricingDetail>(entity =>
        {
            entity.HasKey(e => e.BondPricingDetailsId).HasName("PK__Bond_Pri__FF889DA12D0FBC2E");

            entity.ToTable("Bond_Pricing_Details");

            entity.Property(e => e.BondPricingDetailsId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Bond_Pricing_Sequence])")
                .HasColumnName("bond_pricing_details_id");
            entity.Property(e => e.HighPrice)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("high_price");
            entity.Property(e => e.LowPrice)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("low_price");
            entity.Property(e => e.PricingDetailsId).HasColumnName("pricing_details_id");

            entity.HasOne(d => d.PricingDetails).WithMany(p => p.BondPricingDetails)
                .HasForeignKey(d => d.PricingDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bond_Pric__prici__04E4BC85");
        });

        modelBuilder.Entity<BondRisk>(entity =>
        {
            entity.HasKey(e => e.BondRiskId).HasName("PK__Bond_Ris__0C9B4377C6A75968");

            entity.ToTable("Bond_Risk");

            entity.Property(e => e.BondRiskId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Bond_risk_Sequence])")
                .HasColumnName("bond_risk_id");
            entity.Property(e => e.AverageVol30d)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("average_vol_30d");
            entity.Property(e => e.Convexity)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("convexity");
            entity.Property(e => e.Duration)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("duration");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");
            entity.Property(e => e.Volatility30d)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("volatility_30d");
            entity.Property(e => e.Volatility90d)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("volatility_90d");

            entity.HasOne(d => d.Security).WithMany(p => p.BondRisks)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bond_Risk__secur__5DCAEF64");
        });

        modelBuilder.Entity<BondSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK__Bond_Sch__C46A8A6FA49BCBD0");

            entity.ToTable("Bond_Schedules");

            entity.Property(e => e.ScheduleId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Bond_Schedule_type_Sequence])")
                .HasColumnName("schedule_id");
            entity.Property(e => e.ScheduleDate)
                .HasColumnType("datetime")
                .HasColumnName("schedule_date");
            entity.Property(e => e.SchedulePrice)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("schedule_price");
            entity.Property(e => e.ScheduleType).HasColumnName("schedule_type");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");

            entity.HasOne(d => d.ScheduleTypeNavigation).WithMany(p => p.BondSchedules)
                .HasForeignKey(d => d.ScheduleType)
                .HasConstraintName("FK__Bond_Sche__sched__10566F31");

            entity.HasOne(d => d.Security).WithMany(p => p.BondSchedules)
                .HasForeignKey(d => d.SecurityId)
                .HasConstraintName("FK__Bond_Sche__secur__0F624AF8");
        });

        modelBuilder.Entity<BondScheduleType>(entity =>
        {
            entity.HasKey(e => e.ScheduleTypeId).HasName("PK__Bond_Sch__C4D44B8B038A7F60");

            entity.ToTable("Bond_Schedule_type");

            entity.Property(e => e.ScheduleTypeId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Schedule_type_Sequence])")
                .HasColumnName("schedule_type_id");
            entity.Property(e => e.ScheduleType)
                .HasMaxLength(255)
                .HasColumnName("schedule_type");
        });

        modelBuilder.Entity<BondSecurityDetail>(entity =>
        {
            entity.HasKey(e => e.BondSecurityDetailId).HasName("PK__Bond_Sec__5AA954FAE7B2CDEB");

            entity.ToTable("Bond_Security_Details");

            entity.Property(e => e.BondSecurityDetailId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Bond_security_Sequence])")
                .HasColumnName("bond_security_detail_id");
            entity.Property(e => e.CouponCap)
                .HasMaxLength(255)
                .HasColumnName("coupon_cap");
            entity.Property(e => e.CouponFloor)
                .HasMaxLength(255)
                .HasColumnName("coupon_floor");
            entity.Property(e => e.CouponFrequency)
                .HasMaxLength(255)
                .HasColumnName("coupon_frequency");
            entity.Property(e => e.CouponRate)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("coupon_rate");
            entity.Property(e => e.CouponType)
                .HasMaxLength(255)
                .HasColumnName("coupon_type");
            entity.Property(e => e.FirstCouponDate)
                .HasColumnType("datetime")
                .HasColumnName("first_coupon_date");
            entity.Property(e => e.HasPosition).HasColumnName("has_position");
            entity.Property(e => e.IsCallable).HasColumnName("is_callable");
            entity.Property(e => e.IsFixToFloat).HasColumnName("is_fix_to_float");
            entity.Property(e => e.IsPutable).HasColumnName("is_putable");
            entity.Property(e => e.IssueDate)
                .HasColumnType("datetime")
                .HasColumnName("issue_date");
            entity.Property(e => e.LastResetDate)
                .HasColumnType("datetime")
                .HasColumnName("last_reset_date");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("maturity_date");
            entity.Property(e => e.MaxCallNoticeDays).HasColumnName("max_call_notice_days");
            entity.Property(e => e.MaxPutNoticeDays).HasColumnName("max_put_notice_days");
            entity.Property(e => e.PenCouponDate)
                .HasColumnType("datetime")
                .HasColumnName("pen_coupon_date");
            entity.Property(e => e.ResetFrequency).HasColumnName("reset_frequency");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");

            entity.HasOne(d => d.Security).WithMany(p => p.BondSecurityDetails)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bond_Secu__secur__6E01572D");
        });

        modelBuilder.Entity<BondsSecuritySummary>(entity =>
        {
            entity.HasKey(e => e.BondSecuritySummaryId).HasName("PK__Bonds_Se__2932B7603E13A3D3");

            entity.ToTable("Bonds_Security_Summary");

            entity.Property(e => e.BondSecuritySummaryId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Bond_Summary_Sequence])")
                .HasColumnName("bond_security_summary_id");
            entity.Property(e => e.AssetType)
                .HasMaxLength(255)
                .HasColumnName("asset_type");
            entity.Property(e => e.InvestmentType)
                .HasMaxLength(255)
                .HasColumnName("investment_type");
            entity.Property(e => e.PricingFactor)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("pricing_factor");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");
            entity.Property(e => e.TradingFactor)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("trading_factor");

            entity.HasOne(d => d.Security).WithMany(p => p.BondsSecuritySummaries)
                .HasForeignKey(d => d.SecurityId)
                .HasConstraintName("FK__Bonds_Sec__secur__5629CD9C");
        });

        modelBuilder.Entity<EquitiesSecuritySummary>(entity =>
        {
            entity.HasKey(e => e.EquitySecuritySummaryId).HasName("PK__Equities__A94CF7D5668EC77B");

            entity.ToTable("Equities_Security_Summary");

            entity.Property(e => e.EquitySecuritySummaryId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Entity_Summary_Sequence])")
                .HasColumnName("equity_security_summary_id");
            entity.Property(e => e.BloombergUniqueName)
                .HasMaxLength(255)
                .HasColumnName("bloomberg_unique_name");
            entity.Property(e => e.HasPosition)
                .HasDefaultValue(true)
                .HasColumnName("has_position");
            entity.Property(e => e.RoundLotSize).HasColumnName("round_lot_size");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");

            entity.HasOne(d => d.Security).WithMany(p => p.EquitiesSecuritySummaries)
                .HasForeignKey(d => d.SecurityId)
                .HasConstraintName("FK__Equities___secur__5165187F");
        });

        modelBuilder.Entity<EquityDividendHistory>(entity =>
        {
            entity.HasKey(e => e.DividendId).HasName("PK__Equity_D__7635F10C4475E724");

            entity.ToTable("Equity_Dividend_History");

            entity.Property(e => e.DividendId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Equity_Dividend_Sequence])")
                .HasColumnName("dividend_id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("amount");
            entity.Property(e => e.DeclaredDate)
                .HasColumnType("datetime")
                .HasColumnName("declared_date");
            entity.Property(e => e.DividendType)
                .HasMaxLength(255)
                .HasColumnName("dividend_type");
            entity.Property(e => e.ExDate)
                .HasColumnType("datetime")
                .HasColumnName("ex_date");
            entity.Property(e => e.Frequency)
                .HasMaxLength(255)
                .HasColumnName("frequency");
            entity.Property(e => e.PayDate)
                .HasColumnType("datetime")
                .HasColumnName("pay_date");
            entity.Property(e => e.RecordDate)
                .HasColumnType("datetime")
                .HasColumnName("record_date");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");

            entity.HasOne(d => d.Security).WithMany(p => p.EquityDividendHistories)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Equity_Di__secur__08B54D69");
        });

        modelBuilder.Entity<EquityPricingDetail>(entity =>
        {
            entity.HasKey(e => e.EquityPricingDetailsId).HasName("PK__Equity_P__0E56F0FB01FD87C3");

            entity.ToTable("Equity_Pricing_Details");

            entity.Property(e => e.EquityPricingDetailsId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Equity_Pricing_Sequence])")
                .HasColumnName("equity_pricing_details_id");
            entity.Property(e => e.ClosePrice)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("close_price");
            entity.Property(e => e.PeRation)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("pe_ration");
            entity.Property(e => e.PricingDetailsId).HasColumnName("pricing_details_id");

            entity.HasOne(d => d.PricingDetails).WithMany(p => p.EquityPricingDetails)
                .HasForeignKey(d => d.PricingDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Equity_Pr__prici__01142BA1");
        });

        modelBuilder.Entity<EquityReferenceDatum>(entity =>
        {
            entity.HasKey(e => e.EquityReferenceId).HasName("PK__Equity_r__E294D24573C29034");

            entity.ToTable("Equity_reference_data");

            entity.Property(e => e.EquityReferenceId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Equity_Reference_data_Sequence])")
                .HasColumnName("equity_reference_id");
            entity.Property(e => e.Exchange)
                .HasMaxLength(255)
                .HasColumnName("exchange");
            entity.Property(e => e.ReferenceId).HasColumnName("reference_id");
            entity.Property(e => e.TradingCurrency)
                .HasMaxLength(255)
                .HasColumnName("trading_currency");

            entity.HasOne(d => d.Reference).WithMany(p => p.EquityReferenceData)
                .HasForeignKey(d => d.ReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Equity_re__refer__797309D9");
        });

        modelBuilder.Entity<EquityRisk>(entity =>
        {
            entity.HasKey(e => e.EquityRiskId).HasName("PK__Equity_R__9121C4491F12451E");

            entity.ToTable("Equity_Risk");

            entity.Property(e => e.EquityRiskId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Equity_risk_Sequence])")
                .HasColumnName("equity_risk_id");
            entity.Property(e => e.AverageVolume20d)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("average_volume_20d");
            entity.Property(e => e.Beta)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("beta");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");
            entity.Property(e => e.ShortInterest)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("short_interest");
            entity.Property(e => e.Volatility90d)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("volatility_90d");
            entity.Property(e => e.YtdReturn)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("ytd_return");

            entity.HasOne(d => d.Security).WithMany(p => p.EquityRisks)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Equity_Ri__secur__59FA5E80");
        });

        modelBuilder.Entity<EquitySecurityDetail>(entity =>
        {
            entity.HasKey(e => e.EquitySecurityDetailId).HasName("PK__Equity_S__983EF8452F191EF2");

            entity.ToTable("Equity_Security_Details");

            entity.Property(e => e.EquitySecurityDetailId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Equity_security_Sequence])")
                .HasColumnName("equity_security_detail_id");
            entity.Property(e => e.AdrUnderlyingCurrency)
                .HasMaxLength(255)
                .HasColumnName("adr_underlying_currency");
            entity.Property(e => e.AdrUnderlyingTicker)
                .HasMaxLength(255)
                .HasColumnName("adr_underlying_ticker");
            entity.Property(e => e.IpoDate).HasColumnName("ipo_date");
            entity.Property(e => e.OutstandingShares)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("outstanding_shares");
            entity.Property(e => e.PriceCurrency)
                .HasMaxLength(255)
                .HasColumnName("price_currency");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");
            entity.Property(e => e.SettleDays).HasColumnName("settle_days");
            entity.Property(e => e.SharesPerAdr).HasColumnName("shares_per_adr");
            entity.Property(e => e.VoteRightPerShare)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("vote_right_per_share");

            entity.HasOne(d => d.Security).WithMany(p => p.EquitySecurityDetails)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Equity_Se__secur__6A30C649");
        });

        modelBuilder.Entity<Identifier>(entity =>
        {
            entity.HasKey(e => e.IdentifierId).HasName("PK__Identifi__57C4F6DC63CBAF16");

            entity.Property(e => e.IdentifierId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Identifier_Sequence])")
                .HasColumnName("identifier_id");
            entity.Property(e => e.IdenitiferType).HasColumnName("idenitifer_type");
            entity.Property(e => e.IdentifierValue)
                .HasMaxLength(255)
                .HasColumnName("identifier_value");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");

            entity.HasOne(d => d.IdenitiferTypeNavigation).WithMany(p => p.Identifiers)
                .HasForeignKey(d => d.IdenitiferType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Identifie__ideni__66603565");

            entity.HasOne(d => d.Security).WithMany(p => p.Identifiers)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Identifie__secur__656C112C");
        });

        modelBuilder.Entity<IdentifierType>(entity =>
        {
            entity.HasKey(e => e.IdentifierTypeId).HasName("PK__Identifi__0CA15AA27DF812D5");

            entity.ToTable("Identifier_Types");

            entity.Property(e => e.IdentifierTypeId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Identifier_type_Sequence])")
                .HasColumnName("identifier_type_id");
            entity.Property(e => e.IdentifierType1)
                .HasMaxLength(255)
                .HasColumnName("identifier_type");
        });

        modelBuilder.Entity<PricingDetail>(entity =>
        {
            entity.HasKey(e => e.PricingId).HasName("PK__Pricing___A25A9FB70BB56EF8");

            entity.ToTable("Pricing_Details");

            entity.Property(e => e.PricingId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Pricing_Sequence])")
                .HasColumnName("pricing_id");
            entity.Property(e => e.AskPrice)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("ask_price");
            entity.Property(e => e.BidPrice)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("bid_price");
            entity.Property(e => e.LastPrice)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("last_price");
            entity.Property(e => e.OpenPrice)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("open_price");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");
            entity.Property(e => e.Volume)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("volume");

            entity.HasOne(d => d.Security).WithMany(p => p.PricingDetails)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pricing_D__secur__7D439ABD");
        });

        modelBuilder.Entity<ReferenceDatum>(entity =>
        {
            entity.HasKey(e => e.ReferenceId).HasName("PK__Referenc__8E860B28AA867DB0");

            entity.ToTable("Reference_Data");

            entity.Property(e => e.ReferenceId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Reference_data_Sequence])")
                .HasColumnName("reference_id");
            entity.Property(e => e.BloomberSubGroup)
                .HasMaxLength(255)
                .HasColumnName("bloomber_subGroup");
            entity.Property(e => e.BloombergGroup)
                .HasMaxLength(255)
                .HasColumnName("bloomberg_group");
            entity.Property(e => e.BloombergSector)
                .HasMaxLength(255)
                .HasColumnName("bloomberg_sector");
            entity.Property(e => e.IssueCurrency)
                .HasMaxLength(255)
                .HasColumnName("issue_currency");
            entity.Property(e => e.Issuer)
                .HasMaxLength(255)
                .HasColumnName("issuer");
            entity.Property(e => e.IssuerCountry)
                .HasMaxLength(255)
                .HasColumnName("issuer_country");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");

            entity.HasOne(d => d.Security).WithMany(p => p.ReferenceData)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reference__secur__75A278F5");
        });

        modelBuilder.Entity<RegulatoryDetail>(entity =>
        {
            entity.HasKey(e => e.RegulatoryId).HasName("PK__Regulato__CE5849C94D9A2623");

            entity.ToTable("Regulatory_Details");

            entity.Property(e => e.RegulatoryId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Regulatory_details_Sequence])")
                .HasColumnName("regulatory_id");
            entity.Property(e => e.PfAssetClass)
                .HasMaxLength(255)
                .HasColumnName("pf_asset_class");
            entity.Property(e => e.PfCountry)
                .HasMaxLength(255)
                .HasColumnName("pf_country");
            entity.Property(e => e.PfCreditRating)
                .HasMaxLength(255)
                .HasColumnName("pf_credit_rating");
            entity.Property(e => e.PfCurrency)
                .HasMaxLength(255)
                .HasColumnName("pf_currency");
            entity.Property(e => e.PfInstrument)
                .HasMaxLength(255)
                .HasColumnName("pf_instrument");
            entity.Property(e => e.PfLiquidity)
                .HasMaxLength(255)
                .HasColumnName("pf_liquidity");
            entity.Property(e => e.PfMaturity)
                .HasMaxLength(255)
                .HasColumnName("pf_maturity");
            entity.Property(e => e.PfNaicsCode)
                .HasMaxLength(255)
                .HasColumnName("pf_NAICS_code");
            entity.Property(e => e.PfRegion)
                .HasMaxLength(255)
                .HasColumnName("pf_region");
            entity.Property(e => e.PfSector)
                .HasMaxLength(255)
                .HasColumnName("pf_sector");
            entity.Property(e => e.PfSubAssetClass)
                .HasMaxLength(255)
                .HasColumnName("pf_sub_asset_class");
            entity.Property(e => e.SecurityId).HasColumnName("security_id");

            entity.HasOne(d => d.Security).WithMany(p => p.RegulatoryDetails)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Regulator__secur__71D1E811");
        });

        modelBuilder.Entity<Security>(entity =>
        {
            entity.HasKey(e => e.SecurityId).HasName("PK__Securiti__46647BD1C6BC2815");

            entity.Property(e => e.SecurityId)
                .HasDefaultValueSql("(NEXT VALUE FOR [SecurityID_Sequence])")
                .HasColumnName("security_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(255)
                .HasColumnName("security_name");
            entity.Property(e => e.SecurityType).HasColumnName("security_type");

            entity.HasOne(d => d.SecurityTypeNavigation).WithMany(p => p.Securities)
                .HasForeignKey(d => d.SecurityType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Securitie__secur__4CA06362");
        });

        modelBuilder.Entity<SecurityType>(entity =>
        {
            entity.HasKey(e => e.SecurityTypeId).HasName("PK__Security__4EE38F369F7DC877");

            entity.ToTable("Security_types");

            entity.Property(e => e.SecurityTypeId)
                .HasDefaultValueSql("(NEXT VALUE FOR [Security_type_id_Sequence])")
                .HasColumnName("security_type_id");
            entity.Property(e => e.SecurityType1)
                .HasMaxLength(255)
                .HasColumnName("security_type");
        });
        modelBuilder.HasSequence<int>("Bond_Pricing_Sequence");
        modelBuilder.HasSequence<int>("Bond_risk_Sequence");
        modelBuilder.HasSequence<int>("Bond_Schedule_type_Sequence");
        modelBuilder.HasSequence<int>("Bond_security_Sequence");
        modelBuilder.HasSequence<int>("Bond_Summary_Sequence");
        modelBuilder.HasSequence<int>("Entity_Summary_Sequence");
        modelBuilder.HasSequence<int>("Equity_Dividend_Sequence");
        modelBuilder.HasSequence<int>("Equity_Pricing_Sequence");
        modelBuilder.HasSequence<int>("Equity_Reference_data_Sequence");
        modelBuilder.HasSequence<int>("Equity_risk_Sequence");
        modelBuilder.HasSequence<int>("Equity_security_Sequence");
        modelBuilder.HasSequence<int>("Identifier_Sequence");
        modelBuilder.HasSequence<int>("Identifier_type_Sequence");
        modelBuilder.HasSequence<int>("Pricing_Sequence");
        modelBuilder.HasSequence<int>("Reference_data_Sequence");
        modelBuilder.HasSequence<int>("Regulatory_details_Sequence");
        modelBuilder.HasSequence<int>("Schedule_type_Sequence");
        modelBuilder.HasSequence<int>("Security_type_id_Sequence");
        modelBuilder.HasSequence<int>("SecurityID_Sequence");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
