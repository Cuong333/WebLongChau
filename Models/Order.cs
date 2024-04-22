using System;
using System.Collections.Generic;

namespace WebLongChau.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CutomerId { get; set; }

    public decimal? TotalPrice { get; set; }

    public int? PaymentMethodId { get; set; }

    public virtual Customer? Cutomer { get; set; }

    public virtual OrderDetail? OrderDetail { get; set; }

    public virtual PaymentMethod? PaymentMethod { get; set; }
}
