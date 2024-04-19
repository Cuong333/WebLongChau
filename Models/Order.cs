using System;
using System.Collections.Generic;

namespace WebLongChau.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public decimal? TotalPrice { get; set; }

    public int? PaymentMethodId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual OrderDetail? OrderDetail { get; set; }

    public virtual PaymentMethod? PaymentMethod { get; set; }
}
