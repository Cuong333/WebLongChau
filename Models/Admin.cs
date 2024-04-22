using System;
using System.Collections.Generic;

namespace WebLongChau.Models;

public partial class Admin
{
    public int AdminId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? BirthDay { get; set; }

    public byte? Gender { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public int? PhoneNumber { get; set; }
}
