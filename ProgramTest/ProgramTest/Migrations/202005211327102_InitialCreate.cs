namespace ProgramTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Presets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PresetSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        PresetSettingType = c.String(),
                        Value = c.String(),
                        PresetId = c.Int(nullable: false),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Presets", t => t.PresetId, cascadeDelete: true)
                .Index(t => t.PresetId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PresetSettings", "PresetId", "dbo.Presets");
            DropIndex("dbo.PresetSettings", new[] { "PresetId" });
            DropTable("dbo.PresetSettings");
            DropTable("dbo.Presets");
        }
    }
}
