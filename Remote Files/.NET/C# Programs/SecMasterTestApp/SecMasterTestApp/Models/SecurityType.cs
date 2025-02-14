using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class SecurityType
{
    public int SecurityTypeId { get; set; }

    public string SecurityType1 { get; set; } = null!;

    public virtual ICollection<Security> Securities { get; set; } = new List<Security>();
}
