using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViscocityDestructorBlogSite.Models
{
    public class Comment
    {
        public int CommentID { set; get; }
        public string Description { set; get; }
        public DateTime CommentDate { set; get; }
        public int UserID { set; get; }
        public int PostID { set; get; }
        public bool IsDeleted { set; get; }
        public virtual User User { get; set; }

        public virtual Post Post { set; get; }
    }
}