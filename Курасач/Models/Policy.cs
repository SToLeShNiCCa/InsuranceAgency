using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Курасач.Models;

public partial class Policy
{
    public int PolicyId { get; set; }

    public int ClientId { get; set; }

    public string PolicyType { get; set; } = null!;

    public decimal CoverageAmount { get; set; }

    public decimal Premium { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Stat { get; set; } = null!;

    public virtual CommonUser Client { get; set; } = null!;

    public virtual ICollection<InsuranceClaim> InsuranceClaims { get; set; } = new List<InsuranceClaim>();

}
