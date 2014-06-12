using System;

namespace Web.Api.Posts
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Published { get; set; }
        public DateTime Updated { get; set; }
        public string Slug { get; set; }
        
    }
}