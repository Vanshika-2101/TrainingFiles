using System;
using System.Collections.Generic;

namespace SecMasterTestApp.Models;

public partial class IdentifierType
{
    public int IdentifierTypeId { get; set; }

    public string? IdentifierType1 { get; set; }

    public virtual ICollection<Identifier> Identifiers { get; set; } = new List<Identifier>();
}
