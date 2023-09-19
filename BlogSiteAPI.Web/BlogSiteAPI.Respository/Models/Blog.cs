namespace BlogSiteAPI.Repository.Models
{
    public class Blog
    {
        public Guid Id { get; set; }
        public string BlogName { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Article { get; set; } = string.Empty;
        public string AuthorName { get; set; } = string.Empty;
        public byte[]? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}