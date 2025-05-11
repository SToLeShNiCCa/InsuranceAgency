using System;
using System.Collections.Generic;

namespace Курасач.Models;

public partial class VersionUpdate
{
    public int NumberOfUpdate { get; set; }

    public DateOnly DateOfUpdate { get; set; }

    public string ContentUpdate { get; set; } = null!;
}
