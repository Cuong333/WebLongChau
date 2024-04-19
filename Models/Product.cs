using System;
using System.Collections.Generic;

namespace WebLongChau.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? SupplierId { get; set; }

    public int? CategoryId { get; set; }

    public byte[]? ProductImage { get; set; }

    public virtual Category Category { get; set; }

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Supplier? Supplier { get; set; }
}
