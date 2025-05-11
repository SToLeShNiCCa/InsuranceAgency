using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Курасач.Models;

public partial class LifeInsurance
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public decimal InsuredAmount { get; set; }

    public DateTime ExpirationDate { get; set; }

    public virtual CommonUser Client { get; set; } = null!;

    [NotMapped]
    public CommonUser UserLifeIns
    {
        get
        {
            return DataWorker.GetAllUsersNameForLife(ClientId);
        }
    }

}
