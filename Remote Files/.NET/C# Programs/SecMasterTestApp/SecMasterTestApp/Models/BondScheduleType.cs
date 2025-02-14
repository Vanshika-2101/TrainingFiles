using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class BondScheduleType
{
    public int ScheduleTypeId { get; set; }

    public string? ScheduleType { get; set; }

    public virtual ICollection<BondSchedule> BondSchedules { get; set; } = new List<BondSchedule>();
}
