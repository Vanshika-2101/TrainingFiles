using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class Security
{
    public int SecurityId { get; set; }

    public int SecurityType { get; set; }

    public string SecurityName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<BondRisk> BondRisks { get; set; } = new List<BondRisk>();

    public virtual ICollection<BondSchedule> BondSchedules { get; set; } = new List<BondSchedule>();

    public virtual ICollection<BondSecurityDetail> BondSecurityDetails { get; set; } = new List<BondSecurityDetail>();

    public virtual ICollection<BondsSecuritySummary> BondsSecuritySummaries { get; set; } = new List<BondsSecuritySummary>();

    public virtual ICollection<EquitiesSecuritySummary> EquitiesSecuritySummaries { get; set; } = new List<EquitiesSecuritySummary>();

    public virtual ICollection<EquityDividendHistory> EquityDividendHistories { get; set; } = new List<EquityDividendHistory>();

    public virtual ICollection<EquityRisk> EquityRisks { get; set; } = new List<EquityRisk>();

    public virtual ICollection<EquitySecurityDetail> EquitySecurityDetails { get; set; } = new List<EquitySecurityDetail>();

    public virtual ICollection<Identifier> Identifiers { get; set; } = new List<Identifier>();

    public virtual ICollection<PricingDetail> PricingDetails { get; set; } = new List<PricingDetail>();

    public virtual ICollection<ReferenceDatum> ReferenceData { get; set; } = new List<ReferenceDatum>();

    public virtual ICollection<RegulatoryDetail> RegulatoryDetails { get; set; } = new List<RegulatoryDetail>();

    public virtual SecurityType SecurityTypeNavigation { get; set; } = null!;
}
