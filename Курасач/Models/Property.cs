using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Курасач.Models;

public partial class Property
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public string PropertyType { get; set; } = null!;

    public string Address { get; set; } = null!;

    public decimal InsuredValue { get; set; }

    public virtual CommonUser Client { get; set; } = null!;

    [NotMapped]
    public CommonUser UserProperty
    {
        get
        {
            return DataWorker.GetAllUsersNameForProperty(ClientId);
        }
    }
}
