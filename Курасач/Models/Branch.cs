using System;
using System.Collections.Generic;

namespace Курасач.Models;

public partial class Branch
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int EmployeeCount { get; set; }
}
