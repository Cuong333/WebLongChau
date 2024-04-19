using System;
using System.Collections.Generic;

namespace WebLongChau.Models;

public partial class Admin
{
    public int AdminId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public int? Phone { get; set; }

    public string? Address { get; set; }
}
