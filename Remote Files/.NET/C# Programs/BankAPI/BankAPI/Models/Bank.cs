using System;
using System.Collections.Generic;

namespace BankAPI.Models;

public partial class Bank
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Account { get; set; }

    public double? Balance { get; set; }
}
