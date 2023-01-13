using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnethomepage.DB;
using dotnethomepage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace dotnethomepage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private iBlogDb _blogDb;
        public List<BlogPost> blogPosts {get;set;}

        public IndexModel(ILogger<IndexModel> logger, iBlogDb blogDB)
        {
            _logger = logger;
            _blogDb = blogDB;
        }

        public void OnGet()
        {
            this.blogPosts = _blogDb.getBlogPosts();
        }
    }
}
