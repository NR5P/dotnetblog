using dotnethomepage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnethomepage.DB;

namespace dotnethomepage.Pages
{
    public class PostModel : PageModel
    {
        private iBlogDb _blogDB {get; set;}
        public BlogPost blogPost {get; set;}
        public PostModel(iBlogDb blogDB) {
            _blogDB = blogDB;     
        }
        public void OnGet([FromRoute] int id = 0)
        {
            this.blogPost = _blogDB.getBlogPost(id);
            ViewData["Title"] = $"Post - {this.blogPost.title}";
        }
    }
}
