using System;
using System.Collections.Generic;

namespace IVPAPI_DBFirst.Models;

public partial class Dept
{
    public int Did { get; set; }

    public string Dname { get; set; } = null!;

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();
}
