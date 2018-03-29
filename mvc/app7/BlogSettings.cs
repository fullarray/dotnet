namespace app7
{
    public class BlogSettings
    {
        public string Name { get; set; } = "app7";
        public string Description { get; set; } = "A short description of the blog";
        public string Owner { get; set; } = "The Owner";
        public int PostsPerPage { get; set; } = 2;
        public int CommentsCloseAfterDays { get; set; } = 10;
    }
}
