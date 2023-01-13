using System.Collections.Generic;
using dotnethomepage.Models;

namespace dotnethomepage.DB
{
    public interface iBlogDb
    {
        List<BlogPost> getBlogPosts();
        BlogPost getBlogPost(int id);
    }
}