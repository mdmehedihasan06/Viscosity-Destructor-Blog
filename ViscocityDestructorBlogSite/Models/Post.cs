using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Services.Description;

namespace ViscocityDestructorBlogSite.Models
{
    public class Post
    {
        public int PostID { set; get; }
        [Required(ErrorMessage = "Please provide a Title for your article")]
        [StringLength(500)]
        public string Title { set; get; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { set; get; }

        [Required]
        public DateTime PostDate { set; get; }
        public bool IsPublished { set; get; }
        public int NoOfView { set; get; }
        public int UserID { set; get; }
        public virtual User User { get; set; }
    }
}