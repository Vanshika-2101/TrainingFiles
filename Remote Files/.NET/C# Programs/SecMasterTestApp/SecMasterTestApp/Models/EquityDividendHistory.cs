using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class EquityDividendHistory
{
    public int DividendId { get; set; }

    public int SecurityId { get; set; }

    public DateTime? DeclaredDate { get; set; }

    public DateTime? ExDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? PayDate { get; set; }

    public decimal? Amount { get; set; }

    public string? Frequency { get; set; }

    public string? DividendType { get; set; }

    public virtual Security Security { get; set; } = null!;
}
