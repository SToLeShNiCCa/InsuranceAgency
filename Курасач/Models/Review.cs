using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Курасач.Models;

public partial class Review
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int? Rating { get; set; }

    public string? Comments { get; set; }

    public DateTime? ReviewDate { get; set; }

    public virtual CommonUser Client { get; set; } = null!;

    [NotMapped]
    public CommonUser ClientReview
    {
        get
        {
            return DataWorker.GetAllUsersLoginForReview(ClientId);
        }
    }
}
