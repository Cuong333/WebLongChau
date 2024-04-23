using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebLongChau.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    [Required(ErrorMessage = "UserName is Required")]
    public string? UserName { get; set; }

    [Required(ErrorMessage = "PassWord is Required")]
    [DataType(DataType.Password)]
    public string? PassWord { get; set; }

    public string? FisrtName { get; set; }

    public string? LastName { get; set; }

    public DateTime? BirthDay { get; set; }

    public string? Gender { get; set; }

    public string? Email { get; set; }

    public int? PhoneNumber { get; set; }

    [DataType(DataType.MultilineText)]
    public string? Address { get; set; }

    public string? Photo { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
