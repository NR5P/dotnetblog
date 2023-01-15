using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using dotnethomepage.Models;

namespace dotnethomepage.DB
{
    public class BlogJson : iBlogDb
    {
        public BlogPost getBlogPost(int id)
        {
            return getListFromJson().FirstOrDefault(x => x.id == id);
        }

        public List<BlogPost> getBlogPosts()
        {
            return getListFromJson();
        }

        private List<BlogPost> getListFromJson() {
            string jsonData = "";
            try {
                jsonData = System.IO.File.ReadAllText("DB/blogposts.json"); //read all the content inside the file
            } catch(Exception e){
                System.Console.WriteLine(e.ToString());
            }
            List<BlogPost> blogPosts = new List<BlogPost>();
            blogPosts = JsonSerializer.Deserialize<List<BlogPost>>(jsonData);
            blogPosts.Reverse();
            return blogPosts;
        }
    }
}