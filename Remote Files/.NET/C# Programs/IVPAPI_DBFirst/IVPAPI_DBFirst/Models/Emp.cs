using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Emp
{
    public int Eid { get; set; }

    public string Ename { get; set; } = null!;

    public double? Salary { get; set; }

    public string? Email { get; set; }

    public string? Aadharcard { get; set; }

    public string? Country { get; set; }

    public string? Gender { get; set; }

    public int? Did { get; set; }

    public int? Mid { get; set; }

    public virtual Dept? DidNavigation { get; set; }

    public virtual ICollection<Emp> InverseMidNavigation { get; set; } = new List<Emp>();

    public virtual Emp? MidNavigation { get; set; }
}
