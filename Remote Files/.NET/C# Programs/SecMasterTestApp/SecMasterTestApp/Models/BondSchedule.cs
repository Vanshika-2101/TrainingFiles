using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class BondSchedule
{
    public int ScheduleId { get; set; }

    public int? SecurityId { get; set; }

    public int? ScheduleType { get; set; }

    public decimal? SchedulePrice { get; set; }

    public DateTime? ScheduleDate { get; set; }

    public virtual BondScheduleType? ScheduleTypeNavigation { get; set; }

    public virtual Security? Security { get; set; }
}
