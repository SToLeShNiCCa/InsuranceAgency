using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Курасач.Models;

public partial class Vehicle
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public string Mark { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int YearOfMade { get; set; }

    public string RegistrationNumber { get; set; } = null!;

    public decimal InsuredValue { get; set; }

    public virtual CommonUser Client { get; set; } = null!;

    [NotMapped]
    public CommonUser UserVehicle
    {
        get
        {
            return DataWorker.GetAllUsersNameForVehicle(ClientId);
        }
    }
}
