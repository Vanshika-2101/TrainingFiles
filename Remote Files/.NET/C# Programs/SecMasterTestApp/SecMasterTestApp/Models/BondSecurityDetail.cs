using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class BondSecurityDetail
{
    public int BondSecurityDetailId { get; set; }

    public int SecurityId { get; set; }

    public DateTime? FirstCouponDate { get; set; }

    public string? CouponCap { get; set; }

    public string? CouponFloor { get; set; }

    public string? CouponFrequency { get; set; }

    public decimal? CouponRate { get; set; }

    public string? CouponType { get; set; }

    public bool? IsCallable { get; set; }

    public bool? IsFixToFloat { get; set; }

    public bool? IsPutable { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? LastResetDate { get; set; }

    public DateTime MaturityDate { get; set; }

    public int? MaxCallNoticeDays { get; set; }

    public int? MaxPutNoticeDays { get; set; }

    public DateTime? PenCouponDate { get; set; }

    public int? ResetFrequency { get; set; }

    public bool? HasPosition { get; set; }

    public virtual Security Security { get; set; } = null!;
}
