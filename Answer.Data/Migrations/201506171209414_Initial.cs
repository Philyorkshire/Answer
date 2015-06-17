namespace Answer.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IsValid = c.Boolean(nullable: false),
                        IsAuthorised = c.Boolean(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonColours",
                c => new
                    {
                        Person_Id = c.Int(nullable: false),
                        Colour_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Person_Id, t.Colour_Id })
                .ForeignKey("dbo.People", t => t.Person_Id, cascadeDelete: true)
                .ForeignKey("dbo.Colours", t => t.Colour_Id, cascadeDelete: true)
                .Index(t => t.Person_Id)
                .Index(t => t.Colour_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonColours", "Colour_Id", "dbo.Colours");
            DropForeignKey("dbo.PersonColours", "Person_Id", "dbo.People");
            DropIndex("dbo.PersonColours", new[] { "Colour_Id" });
            DropIndex("dbo.PersonColours", new[] { "Person_Id" });
            DropTable("dbo.PersonColours");
            DropTable("dbo.People");
            DropTable("dbo.Colours");
        }
    }
}
