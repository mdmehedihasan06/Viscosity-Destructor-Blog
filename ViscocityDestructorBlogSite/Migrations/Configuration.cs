namespace ViscocityDestructorBlogSite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ViscocityDestructorBlogSite.Models.ProjectDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ViscocityDestructorBlogSite.Models.ProjectDB context)
        {
          
        }
    }
}
