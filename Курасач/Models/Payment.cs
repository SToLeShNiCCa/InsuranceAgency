using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Курасач.Models;

public partial class Payment
{
    public int IdPayment { get; set; }

    public int IdClients { get; set; }

    public int IdPolices { get; set; }

    public decimal Summa { get; set; }

    public DateTime DateOfPay { get; set; }

    public string TypeOfPay { get; set; } = null!;

    public virtual CommonUser IdClientsNavigation { get; set; } = null!;

    [NotMapped]
    public CommonUser ClientPayment
    {
        get
        {
            return DataWorker.GetAllClientNameForPayment(IdClients);
        }
    }
}
