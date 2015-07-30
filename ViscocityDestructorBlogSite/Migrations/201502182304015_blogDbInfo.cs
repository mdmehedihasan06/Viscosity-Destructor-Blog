namespace ViscocityDestructorBlogSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogDbInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CommentDate = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                        PostID = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 500),
                        Description = c.String(nullable: false),
                        PostDate = c.DateTime(nullable: false),
                        IsPublished = c.Boolean(nullable: false),
                        NoOfView = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "UserID", "dbo.Users");
            DropForeignKey("dbo.Comments", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "UserID", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "UserID" });
            DropIndex("dbo.Comments", new[] { "PostID" });
            DropIndex("dbo.Comments", new[] { "UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
        }
    }
}
