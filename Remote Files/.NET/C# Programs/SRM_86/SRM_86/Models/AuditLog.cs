using System;
using System.Collections.Generic;

namespace SRM_86.Models;

public partial class AuditLog
{
    public int AuditId { get; set; }

    public string TableName { get; set; } = null!;

    public DateTime StartTimestamp { get; set; }

    public DateTime? EndTimestamp { get; set; }

    public int? UserId { get; set; }

    public string? Username { get; set; }

    public string ActionType { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? Comments { get; set; }

    
}
