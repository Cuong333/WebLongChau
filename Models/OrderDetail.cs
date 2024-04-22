using System;
using System.Collections.Generic;

namespace WebLongChau.Models;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? Quanity { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product? Product { get; set; }
}
