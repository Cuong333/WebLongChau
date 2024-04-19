using System;
using System.Collections.Generic;

namespace WebLongChau.Models;

public partial class ProductSupplier
{
    public int ProductId { get; set; }

    public int? SupplierId { get; set; }
}
