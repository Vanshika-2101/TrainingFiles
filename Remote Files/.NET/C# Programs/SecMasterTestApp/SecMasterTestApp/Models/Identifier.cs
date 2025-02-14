using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class Identifier
{
    public int IdentifierId { get; set; }

    public int SecurityId { get; set; }

    public int IdenitiferType { get; set; }

    public string? IdentifierValue { get; set; }

    public virtual IdentifierType IdenitiferTypeNavigation { get; set; } = null!;

    public virtual Security Security { get; set; } = null!;
}
