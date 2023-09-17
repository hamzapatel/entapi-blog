using System;
using System.Collections.Generic;

namespace BlogSiteAPI.Respository.Models;

public partial class Blog
{
    public Guid Id { get; set; }

    public string Blogname { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Article { get; set; } = null!;

    public string Authorname { get; set; } = null!;

    public byte[]? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }
}
