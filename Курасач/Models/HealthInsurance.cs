using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Курасач.Models;

public partial class HealthInsurance
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public string? MedicalConditions { get; set; }

    public decimal? CoverageLimit { get; set; }

    public virtual CommonUser Client { get; set; } = null!;

    [NotMapped]
    public List<CommonUser> UserHealthIns
    {
        get
        {
            return DataWorker.GetAllUsersForHealth(ClientId);
        }
    }
}
