using System;
using System.Collections.Generic;

namespace Курасач.Models;

public partial class PolicyType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal BasePrice { get; set; }
}
