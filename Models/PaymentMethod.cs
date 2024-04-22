using System;
using System.Collections.Generic;

namespace WebLongChau.Models;

public partial class PaymentMethod
{
    public int PaymentMethodId { get; set; }

    public string? PaymentMethodType { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
