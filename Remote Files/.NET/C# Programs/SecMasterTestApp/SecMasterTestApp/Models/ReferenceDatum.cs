using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class ReferenceDatum
{
    public int ReferenceId { get; set; }

    public int SecurityId { get; set; }

    public string Issuer { get; set; } = null!;

    public string IssuerCountry { get; set; } = null!;

    public string IssueCurrency { get; set; } = null!;

    public string BloombergSector { get; set; } = null!;

    public string BloombergGroup { get; set; } = null!;

    public string BloomberSubGroup { get; set; } = null!;

    public virtual ICollection<EquityReferenceDatum> EquityReferenceData { get; set; } = new List<EquityReferenceDatum>();

    public virtual Security Security { get; set; } = null!;
}
