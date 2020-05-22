namespace ProgramTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PresetSettings", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PresetSettings", "Description", c => c.String());
        }
    }
}
