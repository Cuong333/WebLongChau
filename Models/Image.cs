using System;
using System.Collections.Generic;

namespace WebLongChau.Models;

public partial class Image
{
    public int ImagesId { get; set; }

    public int? ProductId { get; set; }

    public string? ImageName { get; set; }

    public byte[]? ProductImage { get; set; }

    public virtual Product? Product { get; set; }
}
