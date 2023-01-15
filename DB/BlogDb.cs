using System.Collections.Generic;
using dotnethomepage.Models;
using System.Data.SQLite;
using System;
//using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace dotnethomepage.DB
{
    public class BlogDb : iBlogDb
    {
        private string _connectionString {get; set;}
        public BlogDb(IConfiguration config) {
            //string connectionString = config.GetConnectionString("Default"); 
            string connectionString = "Data Source=/home/nathan/Desktop/dotnethomepage/DB/blogposts.db;Version=3;"; 
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException(nameof(connectionString));
            _connectionString = connectionString;
        }

        public BlogPost getBlogPost(int id)
        {
            BlogPost blogPost = null;
            using (SQLiteConnection db = new SQLiteConnection(_connectionString))
            {
                using (SQLiteCommand cmd = db.CreateCommand())
                {
                    db.Open();
                    cmd.CommandText = "SELECT id, title, short, body, postDate FROM blogPost WHERE id = @param1 ORDER BY id DESC";
                    cmd.Parameters.Add(new SQLiteParameter("@param1", id));
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            blogPost = new BlogPost() { 
                                id = reader.GetInt32(0),
                                title = reader.GetString(1),
                                shortBody = reader.GetString(2),
                                body = reader.GetString(3),
                                postDate = reader.GetDateTime(4)
                            };
                        }
                    }
                    db.Close();
                }
            }
            return blogPost;
        }

        public List<BlogPost> getBlogPosts()
        {
            List<BlogPost> blogPosts = new List<BlogPost>();
            using (SQLiteConnection db = new SQLiteConnection(_connectionString))
            {
                using (SQLiteCommand cmd = db.CreateCommand())
                {
                    db.Open();
                    cmd.CommandText = "SELECT id, title, short, body, postDate FROM blogPost ORDER BY id DESC";
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            blogPosts.Add(new BlogPost() { 
                                id = reader.GetInt32(0),
                                title = reader.GetString(1),
                                shortBody = reader.GetString(2),
                                body = reader.GetString(3),
                                postDate = reader.GetDateTime(4)
                            });
                        }
                    }
                    db.Close();
                }
            }
            return blogPosts;
        }
    }
}