using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ViscocityDestructorBlogSite.Models
{
    public class ProjectDB : DbContext
    {
        public ProjectDB() : base("BlogSiteDatabase")
        {

        }
        public DbSet<User> Users { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<Comment> Comments { set; get; }
    }
}
