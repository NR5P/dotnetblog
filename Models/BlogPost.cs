using System;

namespace dotnethomepage.Models
{
    public class BlogPost
    {
        public int id {get; set;}
        public string title {get; set;}
        public string shortBody {get; set;}
        public string body {get; set;}
        public DateTime postDate {get; set;}
    }
}