namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Note", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Note", "guid");
            DropColumn("dbo.Note", "dateTimeOffset");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Note", "dateTimeOffset", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Note", "guid", c => c.Guid(nullable: false));
            DropColumn("dbo.Note", "CreatedUtc");
            DropColumn("dbo.Note", "OwnerId");
        }
    }
}
