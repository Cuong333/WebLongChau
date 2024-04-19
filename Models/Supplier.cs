using System;
using System.Collections.Generic;

namespace WebLongChau.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? Address { get; set; }

    public int? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
