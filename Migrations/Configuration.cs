namespace MigrationsPOC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MigrationsPOC.Models.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MigrationsPOC.Models.StudentContext";
        }

        protected override void Seed(MigrationsPOC.Models.StudentContext context)
        {
            
        }
    }
}
