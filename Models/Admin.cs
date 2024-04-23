using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebLongChau.Models;

public partial class Admin
{
    public int AdminId { get; set; }

    [Required(ErrorMessage ="UserName is Required")]
    public string? UserName { get; set; }

    [Required(ErrorMessage = "Password is Required")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? BirthDay { get; set; }

    public byte? Gender { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public int? PhoneNumber { get; set; }
}
