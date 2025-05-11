using System;
using System.Collections.Generic;

namespace Курасач.Models;

public partial class Contact
{
    public int Id { get; set; }

    public string NameOfMessager { get; set; } = null!;

    public string MessageContacts { get; set; } = null!;
}
