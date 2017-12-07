namespace app7
{
    public class BlogSettings
    {
        public string Name { get; set; } = "app7";
        public string Description { get; set; } = "This is a blog template for general use.";
        public string Owner { get; set; } = "The Owner";
        public int PostsPerPage { get; set; } = 2;
        public int CommentsCloseAfterDays { get; set; } = 10;
    }
}
