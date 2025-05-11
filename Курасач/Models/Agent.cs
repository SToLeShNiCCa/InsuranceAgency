using System;
using System.Collections.Generic;

namespace Курасач.Models;

public partial class Agent
{
    public int AgentId { get; set; }

    public string FullAgentsName { get; set; } = null!;

    public string ContactNumber { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime HireDate { get; set; }

    public string Stat { get; set; } = null!;

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
