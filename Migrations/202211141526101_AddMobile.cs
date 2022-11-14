namespace MigrationsPOC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMobile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Mobile", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Mobile");
        }
    }
}
