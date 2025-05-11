using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Курасач.Models;

public partial class InsuranceClaim
{
    public int Id { get; set; }

    public int PolicyId { get; set; }

    public DateTime IncidentDate { get; set; }

    public string Description { get; set; } = null!;

    public string ClaimStatus { get; set; } = null!;

    public virtual Policy Policy { get; set; } = null!;

    [NotMapped]
    public Policy ClaimPolicy
    {
        get
        {
            return DataWorker.GetAllPolicyNameForClaim(PolicyId);
        }
    }
}
