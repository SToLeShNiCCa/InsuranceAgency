using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Курасач.Models;

public partial class CommonUser
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int PassportId { get; set; }

    public string PassportNumber { get; set; } = null!;

    public int CardsNumber { get; set; }

    public string UsersLogin { get; set; } = null!;

    public string UsersPassword { get; set; } = null!;

    public string UsersMail { get; set; } = null!;

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<HealthInsurance> HealthInsurances { get; set; } = new List<HealthInsurance>();

    public virtual ICollection<LifeInsurance> LifeInsurances { get; set; } = new List<LifeInsurance>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Policy> Policies { get; set; } = new List<Policy>();

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

}

