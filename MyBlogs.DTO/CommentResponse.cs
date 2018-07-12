using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace MyBlogs.DTO
{
    public class CommentResponse
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string AuthorEmail { get; set; }
        public string IP { get; set; }
        public DateTime CommentDate { get; set; }
        public string Content { get; set; }
    }
}
